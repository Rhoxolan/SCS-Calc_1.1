using System.ComponentModel;
using System.Text.Json;

namespace SKS_Calc_1._1
{
    public partial class CalculateControl : SCSCalcControl
    {
        public CalculateControl(SettingsLocator settings, BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settings = settings;
            this.configurations = configurations;
            this.docPath = docPath;
            this.Load += OutputBlockCleaner; //Устанавливаем начальное отображение блока вывода
            buttonCalculate.Click += Saver; //Добавляем обработчик для сохранения данных списка конфигураций
            numericUpDownMinPermanentLink.ValueChanged += OutputBlockCleaner; //Очищаем блок вывода при любых изменениях
            numericUpDownMaxPermanentLink.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfWorkplaces.ValueChanged += OutputBlockCleaner;
            numericUpDownNumberOfPorts.ValueChanged += OutputBlockCleaner;
            checkBoxCableHankMeterage.CheckedChanged += OutputBlockCleaner;
            numericUpDownCableHankMeterage.ValueChanged += OutputBlockCleaner;
            this.VisibleChanged += OutputBlockCleaner; //Очищаем блок вывода при выходе из режима расчёта
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
            if (checkBoxCableHankMeterage.Checked)
            {
                double TechnologicalReserve = 1.10; //Коэффициент технологического запаса
                double MinPermanentLink = (double)numericUpDownMinPermanentLink.Value;
                double MaxPermanentLink = (double)numericUpDownMaxPermanentLink.Value;
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = (int)numericUpDownNumberOfWorkplaces.Value;
                int NumberOfPorts = (int)numericUpDownNumberOfPorts.Value;
                double CableHankMeterage = (double)numericUpDownCableHankMeterage.Value;
                if (AveragePermanentLink > CableHankMeterage)
                {
                    MessageBox.Show("Расчет провести невозможно! Значение средней длины постояного линка " +
                        "превышает значение метража кабеля в бухте. Согласно стандарту ISO/IEC 11801, сращивание " +
                        "витой пары запрещено. Повторите расчет с другими параметрами.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double СableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                int HankQuantity = (int)Math.Ceiling(NumberOfWorkplaces * NumberOfPorts /
                    Math.Floor(CableHankMeterage / AveragePermanentLink));
                double TotalСableQuantity = HankQuantity * CableHankMeterage;
                configurations.Add(new(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink,
                    NumberOfWorkplaces, NumberOfPorts, СableQuantity, CableHankMeterage, HankQuantity, TotalСableQuantity));
                textBoxOutputMinPermanentLink.Text = MinPermanentLink.ToString("F" + 2);
                textBoxOutputMaxPermanentLink.Text = MaxPermanentLink.ToString("F" + 2);
                textBoxOutputAveragePermanentLink.Text = AveragePermanentLink.ToString("F" + 2);
                textBoxOutputNumberOfWorkplaces.Text = NumberOfWorkplaces.ToString();
                textBoxOutputNumberOfPorts.Text = NumberOfPorts.ToString();
                textBoxOutputСableQuantity.Text = СableQuantity.ToString("F" + 2);
                textBoxOutputCableHankMeterage.Text = CableHankMeterage.ToString("F" + 2);
                textBoxOutputHankQuantity.Text = HankQuantity.ToString();
                textBoxOutputTotalСableQuantity.Text = TotalСableQuantity.ToString("F" + 2);
            }
            else
            {
                double TechnologicalReserve = 1.10; //Коэффициент технологического запаса
                double MinPermanentLink = (double)numericUpDownMinPermanentLink.Value;
                double MaxPermanentLink = (double)numericUpDownMaxPermanentLink.Value;
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = (int)numericUpDownNumberOfWorkplaces.Value;
                int NumberOfPorts = (int)numericUpDownNumberOfPorts.Value;
                double TotalСableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                configurations.Add(new(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink,
                    NumberOfWorkplaces, NumberOfPorts, null, null, null, TotalСableQuantity));
                textBoxOutputMinPermanentLink.Text = MinPermanentLink.ToString("F" + 2);
                textBoxOutputMaxPermanentLink.Text = MaxPermanentLink.ToString("F" + 2);
                textBoxOutputAveragePermanentLink.Text = AveragePermanentLink.ToString("F" + 2);
                textBoxOutputNumberOfWorkplaces.Text = NumberOfWorkplaces.ToString();
                textBoxOutputNumberOfPorts.Text = NumberOfPorts.ToString();
                textBoxOutputTotalСableQuantity.Text = TotalСableQuantity.ToString("F" + 2);
            }
            buttonOutputSaveToTxt.Enabled = true;
        }

        private void buttonOutputSaveToTxt_Click(object sender, EventArgs e)
        {
            configurations[^1].SaveToTXT();
        }

        private void OutputBlockCleaner(object? sender, EventArgs e) //Обработчик для очистки блока вывода
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

        private void Saver(object? sender, EventArgs e) //Обработчик для сохранения данных списка конфигураций
        {
            using (FileStream fs = new(docPath, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, configurations);
            }
        }
    }
}
