using System.ComponentModel;
using System.Text.Json;
using SCSCalc.Settings;
using SCSCalc;

namespace SKS_Calc_1._1
{
    public partial class FormSCSCalc : Form
    {
        private SettingsPresent settingsPresent;
        private BindingList<Configuration> configurations;
        private CalculateControl calculateControl;
        private HistoryControl historyControl;
        private SettingsControl settingsControl;
        private InformationControl informationControl;
        private string folderPath;
        private string docPath;
        private string settingsDocPath;

        public FormSCSCalc()
        {
            InitializeComponent();
            folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SCS-Calc Data Folder");
            docPath = Path.Combine(folderPath, "SCS-CalcData.json");
            settingsDocPath = "SCS-CalcSettingsData.json";
            Loader();
            
            Loader2();
            calculateControl = new(settingsPresent, configurations, docPath, settingsDocPath);
            historyControl = new(settingsPresent, configurations, docPath, settingsDocPath);
            settingsControl = new(settingsPresent, configurations, docPath, settingsDocPath);
            informationControl = new(settingsPresent, configurations, docPath, settingsDocPath);
            calculateControl.ChildControls.Add(historyControl);
            calculateControl.ChildControls.Add(settingsControl);
            calculateControl.ChildControls.Add(informationControl);
            historyControl.ParentControl = calculateControl;
            settingsControl.ParentControl = calculateControl;
            informationControl.ParentControl = calculateControl;
            this.FormClosed += (o, e) => SettingsPresent.SettingsJSONSerializer(settingsPresent, settingsDocPath);

            /* При добавлении в приложение новых UserControl-ов, которые будут представлять новый режим, уровень или
              пункт меню, необходимо указать, какой U.Control является родительским (с какого U.Control-а был вызван
              этот U.Control) и какие U.Control-ы являются дочерними (какие U.Control-ы вызываются с этого U.Control-а).
              Примеры взаимодействия U.Control-ов можно посмотреть в любом уже созданном.
              При загрузке формы на ней размещаются все созданные U.Control-ы, все незадействованные скрываются.
              При переходе с одного режима на другой родительский U.Control скрывается, выбранный дочерний -
              отображается. Пример скрытия/отображения можно посмотреть в любом созданном U.Control-е. */
        }

        private void FormSCSCalc_Load(object sender, EventArgs e)
        {
            calculateControl.Location = new Point(5, 7);
            this.Controls.Add(calculateControl);

            historyControl.Location = new Point(5, 7);
            this.Controls.Add(historyControl);

            informationControl.Location = new Point(5, 7);
            this.Controls.Add(informationControl);

            settingsControl.Location = new Point(5, 7);
            this.Controls.Add(settingsControl);

            historyControl.Visible = false;
            settingsControl.Visible = false;
            informationControl.Visible = false;
        }

        private void Loader() //Метод для загрузки данных
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if(File.Exists(docPath))
            {
                using (FileStream fs = new(docPath, FileMode.Open))
                {
                    configurations = JsonSerializer.Deserialize<BindingList<Configuration>>(fs);
                }
            }
            else
            {
                configurations = new();
            }
        }

        private void Loader2() //Метод для загрузки настроек параметров расчёта конфигураций
        {
            if (File.Exists(settingsDocPath))
            {
                try
                {
                    settingsPresent = SettingsPresent.SettingsJSONDeserializer(settingsDocPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка считывания настроек параметров расчёта конфигураций:{Environment.NewLine}{ex.Message}{Environment.NewLine}" +
                        $"Настройки сброшены до стандартных значений.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    settingsPresent = new();
                    settingsPresent.SetStrictСomplianceWithTheStandart();
                    settingsPresent.SetAnArbitraryNumberOfPorts();
                    settingsPresent.SetTechnologicalReserveAvailability();
                    SettingsPresent.SettingsJSONSerializer(settingsPresent, settingsDocPath);
                }
            }
            else
            {
                //Первичная настройка
                settingsPresent = new();
                settingsPresent.SetStrictСomplianceWithTheStandart();
                settingsPresent.SetAnArbitraryNumberOfPorts();
                settingsPresent.SetTechnologicalReserveAvailability();
                SettingsPresent.SettingsJSONSerializer(settingsPresent, settingsDocPath);
            }
        }
    }
}