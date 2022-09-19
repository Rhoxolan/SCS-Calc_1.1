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
            //Первичная настройка потом забрать
            settings.SetStrictСomplianceWithTheStandart();
            settings.SetAnArbitraryNumberOfPorts();
            settings.SetTechnologicalReserveAvailability();

            if (settings != null)
            {
                if(settings.ComplianceWithTheStandart is StrictСomplianceWithTheStandart) //Разобраться с этим
                {
                    checkBoxStrictСomplianceWithTheStandart.Checked = true;
                }
                else
                {
                    checkBoxStrictСomplianceWithTheStandart.Checked = false;
                }
                if(settings.NumberOfPorts is AnArbitraryNumberOfPorts)
                {
                    checkBoxAnArbitraryNumberOfPorts.Checked = true;
                }
                else
                {
                    checkBoxAnArbitraryNumberOfPorts.Checked = false;
                }
                if(settings.TechnologicalReserve is TechnologicalReserveAvailability)
                {
                    checkBoxTechnologicalReserve.Checked = true;
                }
                else
                {
                    checkBoxTechnologicalReserve.Checked = false;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) => GoBack(); //Переход в предыдущий режим

        private void checkBoxStrictСomplianceWithTheStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStrictСomplianceWithTheStandart.Checked)
            {
                checkBoxAnArbitraryNumberOfPorts.Enabled = true;
                settings.SetStrictСomplianceWithTheStandart();
            }
            if (!checkBoxStrictСomplianceWithTheStandart.Checked)
            {
                checkBoxAnArbitraryNumberOfPorts.Checked = true;
                checkBoxAnArbitraryNumberOfPorts.Enabled = false;
                settings.SetNonStrictСomplianceWithTheStandart();
            }
        }

        private void checkBoxAnArbitraryNumberOfPorts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnArbitraryNumberOfPorts.Checked)
            {
                settings.SetAnArbitraryNumberOfPorts();
            }
            if (!checkBoxAnArbitraryNumberOfPorts.Checked)
            {
                settings.SetNotAnArbitraryNumberOfPorts();
            }
        }

        private void checkBoxTechnologicalReserve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = true;
                settings.SetTechnologicalReserveAvailability();
                settings.TechnologicalReserve.SetTechnologicalReserve((double)numericUpDownTechnologicalReserve.Value);
            }
            if (!checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = false;
                settings.SetNonTechnologicalReserve();
            }
        }

        private void numericUpDownTechnologicalReserve_ValueChanged(object sender, EventArgs e)
        {
            if (settings.TechnologicalReserve is TechnologicalReserveAvailability)
            {
                settings.TechnologicalReserve.SetTechnologicalReserve((double)numericUpDownTechnologicalReserve.Value);
            }
        }
    }
}
