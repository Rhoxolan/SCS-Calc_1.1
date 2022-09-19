using System.ComponentModel;

namespace SKS_Calc_1._1
{
    public partial class SettingsControl : SCSCalcControl
    {
        public SettingsControl(SettingsPresent settingsPresent, BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settingsPresent = settingsPresent;
            this.configurations = configurations;
            this.docPath = docPath;
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            //Первичная настройка потом забрать
            settingsPresent.SetStrictСomplianceWithTheStandart();
            settingsPresent.SetAnArbitraryNumberOfPorts();
            settingsPresent.SetTechnologicalReserveAvailability();

            if (settingsPresent != null)
            {
                if(settingsPresent.IsStrictСomplianceWithTheStandart)
                {
                    checkBoxStrictСomplianceWithTheStandart.Checked = true;
                }
                else
                {
                    checkBoxStrictСomplianceWithTheStandart.Checked = false;
                }
                if(settingsPresent.IsAnArbitraryNumberOfPorts)
                {
                    checkBoxAnArbitraryNumberOfPorts.Checked = true;
                }
                else
                {
                    checkBoxAnArbitraryNumberOfPorts.Checked = false;
                }
                if(settingsPresent.IsTechnologicalReserveAvailability)
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
                settingsPresent.SetStrictСomplianceWithTheStandart();
            }
            if (!checkBoxStrictСomplianceWithTheStandart.Checked)
            {
                checkBoxAnArbitraryNumberOfPorts.Checked = true;
                checkBoxAnArbitraryNumberOfPorts.Enabled = false;
                settingsPresent.SetNonStrictСomplianceWithTheStandart();
            }
        }

        private void checkBoxAnArbitraryNumberOfPorts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnArbitraryNumberOfPorts.Checked)
            {
                settingsPresent.SetAnArbitraryNumberOfPorts();
            }
            if (!checkBoxAnArbitraryNumberOfPorts.Checked)
            {
                settingsPresent.SetNotAnArbitraryNumberOfPorts();
            }
        }

        private void checkBoxTechnologicalReserve_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = true;
                settingsPresent.SetTechnologicalReserveAvailability();
                settingsPresent.SetTechnologicalReserve((double)numericUpDownTechnologicalReserve.Value);
            }
            if (!checkBoxTechnologicalReserve.Checked)
            {
                numericUpDownTechnologicalReserve.Enabled = false;
                settingsPresent.SetNonTechnologicalReserve();
            }
        }

        private void numericUpDownTechnologicalReserve_ValueChanged(object sender, EventArgs e)
        {
            if (settingsPresent.IsTechnologicalReserveAvailability)
            {
                settingsPresent.SetTechnologicalReserve((double)numericUpDownTechnologicalReserve.Value);
            }
        }
    }
}
