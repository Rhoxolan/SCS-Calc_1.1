using System.ComponentModel;
using SCSCalcClassLibrary;

namespace SKS_Calc_1._1
{
    public partial class SettingsControl : SCSCalcControl
    {
        public SettingsControl(SettingsPresent settingsPresent, BindingList<Configuration> configurations, string docPath, string settingsDocPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settingsPresent = settingsPresent;
            this.configurations = configurations;
            this.docPath = docPath;
            this.settingsDocPath = settingsDocPath;
            this.VisibleChanged += (s, e) => SettingsPresent.SettingsJSONSerializer(settingsPresent, settingsDocPath);
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            numericUpDownTechnologicalReserve.Minimum = settingsPresent.Diapasons.TechnologicalReserveDiapason.Min;
            numericUpDownTechnologicalReserve.Maximum = settingsPresent.Diapasons.TechnologicalReserveDiapason.Max;
            numericUpDownTechnologicalReserve.Value = (decimal)settingsPresent.TechnologicalReserve;

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
                    if (!settingsPresent.IsStrictСomplianceWithTheStandart)
                    {
                        checkBoxAnArbitraryNumberOfPorts.Checked = true;
                        checkBoxAnArbitraryNumberOfPorts.Enabled = false;
                    }
                    else
                    {
                        checkBoxAnArbitraryNumberOfPorts.Checked = true;
                    }
                }
                else
                {
                    if (!settingsPresent.IsStrictСomplianceWithTheStandart)
                    {
                        checkBoxAnArbitraryNumberOfPorts.Checked = true;
                        checkBoxAnArbitraryNumberOfPorts.Enabled = false;
                    }
                    else
                    {
                        checkBoxAnArbitraryNumberOfPorts.Checked = false;
                    }
                }

                if(settingsPresent.IsTechnologicalReserveAvailability)
                {
                    checkBoxTechnologicalReserve.Checked = true;
                }
                else
                {
                    checkBoxTechnologicalReserve.Checked = false;
                    numericUpDownTechnologicalReserve.Enabled = false;
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
                settingsPresent.TechnologicalReserve = (double)numericUpDownTechnologicalReserve.Value;
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
                settingsPresent.TechnologicalReserve = (double)numericUpDownTechnologicalReserve.Value;
            }
        }
    }
}
