using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace SKS_Calc_1._1
{
    public partial class InformationControl : SCSCalcControl
    {
        public InformationControl(SettingsLocator settings, BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.settings = settings;
            this.configurations = configurations;
            this.docPath = docPath;
        }

        private void buttonBack_Click(object sender, EventArgs e) => GoBack(); //Переход в предыдущий режим

        private void InformationControl_Load(object sender, EventArgs e)
        {
            textBoxInformation.Text = Properties.Resources.Text;
        }

        private void labelAuthorName_DoubleClick(object sender, EventArgs e) //Переход по ссылке на профиль GitHub автора приложения
        {
            try
            {
                using (Process process = new())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "https://github.com/Rhoxolan";
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
