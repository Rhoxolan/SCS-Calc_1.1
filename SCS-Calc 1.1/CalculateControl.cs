using System.ComponentModel;
using System.Text.Json;
using SCSCalc.WindowsForms;
using SCSCalc.Settings;
using SCSCalc;

namespace SKS_Calc_1._1
{
    public partial class CalculateControl : SCSCalcControl
    {
        public CalculateControl(SettingsPresent settingsPresent, BindingList<Configuration> configurations, string docPath, string settingsDocPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settingsPresent = settingsPresent;
            this.configurations = configurations;
            this.docPath = docPath;
            this.settingsDocPath = settingsDocPath;
            this.Load += OutputBlockCleaner; //Устанавливаем начальное отображение блока вывода
            buttonCalculate.Click += Saver; //Добавляем обработчик для сохранения данных списка конфигураций
            numericUpDownMinPermanentLink.ValueChanged += OutputBlockCleaner; //Очищаем блок вывода при любых изменениях
            numericUpDownMaxPermanentLink.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfWorkplaces.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfPorts.ValueChanged += OutputBlockCleaner;
            checkBoxCableHankMeterage.CheckedChanged += OutputBlockCleaner;
            numericUpDownCableHankMeterage.ValueChanged += OutputBlockCleaner;
            this.VisibleChanged += OutputBlockCleaner; //Очищаем блок вывода при выходе из режима расчёта
            this.VisibleChanged += DiapasonEqualizer; //Меняем диапазон значений параметров конфигурации в соответствии настройкам
        }

        private void CalculateControl_Load(object sender, EventArgs e)
        {
            checkBoxCableHankMeterage.Checked = false;
        }

        private void checkBoxCableHankMeterage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCableHankMeterage.Checked)
            {
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if (!checkBoxCableHankMeterage.Checked)
            {
                numericUpDownCableHankMeterage.Enabled = false;
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e) => TransitionInto(typeof(HistoryControl)); //Переход в режим "История"

        private void buttonInfo_Click(object sender, EventArgs e) => TransitionInto(typeof(InformationControl)); //Переход в режим "Информация"

        private void buttonSettings_Click(object sender, EventArgs e) => TransitionInto(typeof(SettingsControl)); //Переход в режим "Настройки"

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxCableHankMeterage.Checked)
                {
                    Configuration configuration = Configuration.Calculate(settingsPresent, (double)numericUpDownMinPermanentLink.Value, (double)numericUpDownMaxPermanentLink.Value,
                        (int)numericUpDownNumberOfWorkplaces.Value, (int)numericUpDownNumberOfPorts.Value, (double)numericUpDownCableHankMeterage.Value);
                    configurations.Add(configuration);
                    textBoxOutputMinPermanentLink.Text = configuration.MinPermanentLink.ToString("F" + 2);
                    textBoxOutputMaxPermanentLink.Text = configuration.MaxPermanentLink.ToString("F" + 2);
                    textBoxOutputAveragePermanentLink.Text = configuration.AveragePermanentLink.ToString("F" + 2);
                    textBoxOutputNumberOfWorkplaces.Text = configuration.NumberOfWorkplaces.ToString();
                    textBoxOutputNumberOfPorts.Text = configuration.NumberOfPorts.ToString();
                    textBoxOutputСableQuantity.Text = configuration.СableQuantity?.ToString("F" + 2);
                    textBoxOutputCableHankMeterage.Text = configuration.CableHankMeterage?.ToString("F" + 2);
                    textBoxOutputHankQuantity.Text = configuration.HankQuantity.ToString();
                    textBoxOutputTotalСableQuantity.Text = configuration.TotalСableQuantity.ToString("F" + 2);
                }
                else
                {
                    Configuration? configuration = Configuration.Calculate(settingsPresent, (double)numericUpDownMinPermanentLink.Value, (double)numericUpDownMaxPermanentLink.Value,
                        (int)numericUpDownNumberOfWorkplaces.Value, (int)numericUpDownNumberOfPorts.Value, null);
                    configurations.Add(configuration);
                    textBoxOutputMinPermanentLink.Text = configuration.MinPermanentLink.ToString("F" + 2);
                    textBoxOutputMaxPermanentLink.Text = configuration.MaxPermanentLink.ToString("F" + 2);
                    textBoxOutputAveragePermanentLink.Text = configuration.AveragePermanentLink.ToString("F" + 2);
                    textBoxOutputNumberOfWorkplaces.Text = configuration.NumberOfWorkplaces.ToString();
                    textBoxOutputNumberOfPorts.Text = configuration.NumberOfPorts.ToString();
                    textBoxOutputTotalСableQuantity.Text = configuration.TotalСableQuantity.ToString("F" + 2);
                }
                buttonOutputSaveToTxt.Enabled = true;
            }
            catch (SCSCalcException SCSCalcEx)
            {
                MessageBox.Show(SCSCalcEx.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonOutputSaveToTxt_Click(object sender, EventArgs e)
        {
            configurations[^1].SaveToTXT();
        }

        private void OutputBlockCleaner(object sender, EventArgs e) //Обработчик для очистки блока вывода
        {
            textBoxOutputMinPermanentLink.Text = string.Empty;
            textBoxOutputMaxPermanentLink.Text = string.Empty;
            textBoxOutputAveragePermanentLink.Text = string.Empty;
            textBoxOutputNumberOfWorkplaces.Text = string.Empty;
            textBoxOutputNumberOfPorts.Text = string.Empty;
            textBoxOutputСableQuantity.Text = string.Empty;
            textBoxOutputHankQuantity.Text = string.Empty;
            textBoxOutputCableHankMeterage.Text = string.Empty;
            textBoxOutputTotalСableQuantity.Text = string.Empty;
            numericUpDownCableHankMeterage.Enabled = false;
            if (checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = true;
                textBoxOutputСableQuantity.Enabled = true;
                labelMeters7.Enabled = true;
                labelOutputCableHankMeterage.Enabled = true;
                textBoxOutputCableHankMeterage.Enabled = true;
                labelMeters8.Enabled = true;
                labelOutputHankQuantity.Enabled = true;
                textBoxOutputHankQuantity.Enabled = true;
                numericUpDownCableHankMeterage.Enabled = true;
            }
            if (!checkBoxCableHankMeterage.Checked)
            {
                labelOutputСableQuantity.Enabled = false;
                textBoxOutputСableQuantity.Enabled = false;
                labelMeters7.Enabled = false;
                labelOutputCableHankMeterage.Enabled = false;
                textBoxOutputCableHankMeterage.Enabled = false;
                labelMeters8.Enabled = false;
                labelOutputHankQuantity.Enabled = false;
                textBoxOutputHankQuantity.Enabled = false;
                numericUpDownCableHankMeterage.Enabled = false;
            }
            buttonOutputSaveToTxt.Enabled = false;
        }

        private void DiapasonEqualizer(object sender, EventArgs e)
        {
            numericUpDownMinPermanentLink.Minimum = settingsPresent.Diapasons.MinPermanentLinkDiapason.Min;
            numericUpDownMinPermanentLink.Maximum = settingsPresent.Diapasons.MinPermanentLinkDiapason.Max;
            numericUpDownMaxPermanentLink.Minimum = settingsPresent.Diapasons.MaxPermanentLinkDiapason.Min;
            numericUpDownMaxPermanentLink.Maximum = settingsPresent.Diapasons.MaxPermanentLinkDiapason.Max;
            numericUpDownNumberOfWorkplaces.Minimum = settingsPresent.Diapasons.NumberOfWorkplacesDiapason.Min;
            numericUpDownNumberOfWorkplaces.Maximum = settingsPresent.Diapasons.NumberOfWorkplacesDiapason.Max;
            numericUpDownNumberOfPorts.Minimum = settingsPresent.Diapasons.NumberOfPortsDiapason.Min;
            numericUpDownNumberOfPorts.Maximum = settingsPresent.Diapasons.NumberOfPortsDiapason.Max;
            numericUpDownCableHankMeterage.Minimum = settingsPresent.Diapasons.CableHankMeterageDiapason.Min;
            numericUpDownCableHankMeterage.Maximum = settingsPresent.Diapasons.CableHankMeterageDiapason.Max;
        }

        private void Saver(object sender, EventArgs e) //Обработчик для сохранения данных списка конфигураций
        {
            using (FileStream fs = new(docPath, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, configurations);
            }
        }
    }
}
