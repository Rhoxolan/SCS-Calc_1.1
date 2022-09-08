using System.ComponentModel;

namespace SKS_Calc_1._1
{
    public partial class SettingsControl : SCSCalcControl
    {
        public SettingsControl(SettingsLocator settings, BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settings = settings;
            this.configurations = configurations;
            this.docPath = docPath;
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            checkBoxTechnologicalReserve.Checked = true; //Здесь буде загрузка настроек из файла настроек, состояние чекбоксов будет браться из настроек
            checkBoxStrictСomplianceWithTheStandart.Checked = true;
        }

        private void buttonBack_Click(object sender, EventArgs e) => GoBack(); //Переход в предыдущий режим

        private void checkBoxStrictСomplianceWithTheStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStrictСomplianceWithTheStandart.Checked)
            {
                checkBoxAnArbitraryNumberOfPorts.Enabled = true;
            }
            if (!checkBoxStrictСomplianceWithTheStandart.Checked)
            {
                checkBoxAnArbitraryNumberOfPorts.Checked = false;
                checkBoxAnArbitraryNumberOfPorts.Enabled = false;
            }
        }

        private void checkBoxTechnologicalReserve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = true;
            }
            if (!checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = false;
            }
        }
    }
}
