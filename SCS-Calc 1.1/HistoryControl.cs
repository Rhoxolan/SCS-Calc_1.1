using System.ComponentModel;
using System.Text.Json;

namespace SKS_Calc_1._1
{
    public partial class HistoryControl : UserControl, ISCSCalcControl
    {
        protected BindingList<Configuration> configurations;
        protected string docPath;

        public UserControl? ParentControl { get; set; }

        public List<UserControl>? ChildControls { get; set; }

        public HistoryControl(BindingList<Configuration> configurations, string docPath)
        {
            InitializeComponent();
            ParentControl = null;
            ChildControls = new();
            this.configurations = configurations;
            this.docPath = docPath;
            listBoxConfigurationsList.DataSource = configurations;
        }

        private void buttonBack_Click(object sender, EventArgs e) //Переход в предыдущий режим
        {
            if (ParentControl != null)
            {
                this.Visible = false;
                ParentControl.Visible = true;
            }
        }

        private void listBoxConfigurationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configurations[listBoxConfigurationsList.SelectedIndex].СableQuantity != null
                && configurations[listBoxConfigurationsList.SelectedIndex].HankQuantity != null)
            {
                textBoxShowConfigurationDetails.Text = configurations[listBoxConfigurationsList.SelectedIndex].ToLongOutputString();
            }
            else
            {
                textBoxShowConfigurationDetails.Text = configurations[listBoxConfigurationsList.SelectedIndex].ToLongOutputString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxConfigurationsList.SelectedValue != null)
            {
                if(MessageBox.Show("Вы точно хотите удалить запись конфигурации?", "Удаление записи конфигурации",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    configurations.RemoveAt(listBoxConfigurationsList.SelectedIndex);
                    textBoxShowConfigurationDetails.Text = String.Empty;
                    using (FileStream fs = new(docPath, FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, configurations);
                    }
                }
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (configurations.Count > 0)
            {
                if (MessageBox.Show("Вы точно хотите удалить ВСЕ записи конфигурации?", "Удаление записей конфигурации",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = configurations.Count - 1; i >= 0; i--)
                    {
                        configurations.RemoveAt(i);
                    }
                    textBoxShowConfigurationDetails.Text = String.Empty;
                    using (FileStream fs = new(docPath, FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, configurations);
                    }
                }
            }
        }

        private void buttonOutputSaveToTxt_Click(object sender, EventArgs e)
        {
            if (listBoxConfigurationsList.SelectedIndex != -1)
            {
                configurations[listBoxConfigurationsList.SelectedIndex].SaveToTXT();
            }
        }
    }
}
