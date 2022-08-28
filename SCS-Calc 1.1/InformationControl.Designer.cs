namespace SKS_Calc_1._1
{
    partial class InformationControl
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 559);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 23);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Назад";
            this.toolTipHelp.SetToolTip(this.buttonBack, "Вернуться в предыдущий режим");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInformation.Location = new System.Drawing.Point(3, 3);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInformation.Size = new System.Drawing.Size(508, 550);
            this.textBoxInformation.TabIndex = 21;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuthorName.Location = new System.Drawing.Point(351, 561);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(160, 17);
            this.labelAuthorName.TabIndex = 22;
            this.labelAuthorName.Text = "Павел Бацемакин, 2022 г.";
            this.toolTipHelp.SetToolTip(this.labelAuthorName, "github.com/Rhoxolan\r\nКликните два раза, чтобы перейти");
            this.labelAuthorName.DoubleClick += new System.EventHandler(this.labelAuthorName_DoubleClick);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 1000;
            // 
            // InformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.buttonBack);
            this.Name = "InformationControl";
            this.Size = new System.Drawing.Size(514, 585);
            this.Load += new System.EventHandler(this.InformationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private TextBox textBoxInformation;
        private Label labelAuthorName;
        private ToolTip toolTipHelp;
    }
}
