namespace SKS_Calc_1._1
{
    partial class HistoryControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxConfigurationsList = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxShowConfigurationDetails = new System.Windows.Forms.TextBox();
            this.buttonOutputSaveToTxt = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBoxConfigurationsList
            // 
            this.listBoxConfigurationsList.FormattingEnabled = true;
            this.listBoxConfigurationsList.ItemHeight = 15;
            this.listBoxConfigurationsList.Location = new System.Drawing.Point(3, 3);
            this.listBoxConfigurationsList.Name = "listBoxConfigurationsList";
            this.listBoxConfigurationsList.Size = new System.Drawing.Size(395, 259);
            this.listBoxConfigurationsList.TabIndex = 0;
            this.listBoxConfigurationsList.SelectedIndexChanged += new System.EventHandler(this.listBoxConfigurationsList_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(404, 32);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.toolTipHelp.SetToolTip(this.buttonDelete, "Удалить выбранную конфигурацию");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(404, 61);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(107, 23);
            this.buttonRemoveAll.TabIndex = 18;
            this.buttonRemoveAll.Text = "Удалить всё";
            this.toolTipHelp.SetToolTip(this.buttonRemoveAll, "Удалить ВСЕ конфигурации");
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(404, 240);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 23);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.toolTipHelp.SetToolTip(this.buttonBack, "Вернуться в предыдущий режим");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxShowConfigurationDetails
            // 
            this.textBoxShowConfigurationDetails.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxShowConfigurationDetails.Location = new System.Drawing.Point(3, 269);
            this.textBoxShowConfigurationDetails.Multiline = true;
            this.textBoxShowConfigurationDetails.Name = "textBoxShowConfigurationDetails";
            this.textBoxShowConfigurationDetails.ReadOnly = true;
            this.textBoxShowConfigurationDetails.Size = new System.Drawing.Size(508, 313);
            this.textBoxShowConfigurationDetails.TabIndex = 20;
            // 
            // buttonOutputSaveToTxt
            // 
            this.buttonOutputSaveToTxt.Location = new System.Drawing.Point(404, 3);
            this.buttonOutputSaveToTxt.Name = "buttonOutputSaveToTxt";
            this.buttonOutputSaveToTxt.Size = new System.Drawing.Size(107, 23);
            this.buttonOutputSaveToTxt.TabIndex = 21;
            this.buttonOutputSaveToTxt.Text = "Сохранить в TXT";
            this.toolTipHelp.SetToolTip(this.buttonOutputSaveToTxt, "Сохранить конфигурацию в текстовый документ (TXT)");
            this.buttonOutputSaveToTxt.UseVisualStyleBackColor = true;
            this.buttonOutputSaveToTxt.Click += new System.EventHandler(this.buttonOutputSaveToTxt_Click);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 1000;
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonOutputSaveToTxt);
            this.Controls.Add(this.textBoxShowConfigurationDetails);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxConfigurationsList);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(514, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxConfigurationsList;
        private Button buttonDelete;
        private Button buttonRemoveAll;
        private Button buttonBack;
        private TextBox textBoxShowConfigurationDetails;
        private Button buttonOutputSaveToTxt;
        private ToolTip toolTipHelp;
    }
}
