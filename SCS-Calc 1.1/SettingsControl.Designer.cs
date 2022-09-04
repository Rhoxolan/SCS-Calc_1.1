namespace SKS_Calc_1._1
{
    partial class SettingsControl
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkBoxStrictСomplianceWithTheStandart = new System.Windows.Forms.CheckBox();
            this.checkBoxAnArbitraryNumberOfPorts = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownTechnologicalReserve = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechnologicalReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(406, 559);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // checkBoxStrictСomplianceWithTheStandart
            // 
            this.checkBoxStrictСomplianceWithTheStandart.AutoSize = true;
            this.checkBoxStrictСomplianceWithTheStandart.Location = new System.Drawing.Point(3, 3);
            this.checkBoxStrictСomplianceWithTheStandart.Name = "checkBoxStrictСomplianceWithTheStandart";
            this.checkBoxStrictСomplianceWithTheStandart.Size = new System.Drawing.Size(279, 19);
            this.checkBoxStrictСomplianceWithTheStandart.TabIndex = 22;
            this.checkBoxStrictСomplianceWithTheStandart.Text = "Строгое соответствие стандарту ISO/IEC 11801";
            this.checkBoxStrictСomplianceWithTheStandart.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnArbitraryNumberOfPorts
            // 
            this.checkBoxAnArbitraryNumberOfPorts.AutoSize = true;
            this.checkBoxAnArbitraryNumberOfPorts.Location = new System.Drawing.Point(3, 28);
            this.checkBoxAnArbitraryNumberOfPorts.Name = "checkBoxAnArbitraryNumberOfPorts";
            this.checkBoxAnArbitraryNumberOfPorts.Size = new System.Drawing.Size(387, 19);
            this.checkBoxAnArbitraryNumberOfPorts.TabIndex = 23;
            this.checkBoxAnArbitraryNumberOfPorts.Text = "Разрешить произвольное количество портов на 1 рабочее место";
            this.checkBoxAnArbitraryNumberOfPorts.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(306, 19);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Учитывать коэффициент технологического запаса";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTechnologicalReserve
            // 
            this.numericUpDownTechnologicalReserve.DecimalPlaces = 2;
            this.numericUpDownTechnologicalReserve.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownTechnologicalReserve.Location = new System.Drawing.Point(3, 78);
            this.numericUpDownTechnologicalReserve.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.numericUpDownTechnologicalReserve.Name = "numericUpDownTechnologicalReserve";
            this.numericUpDownTechnologicalReserve.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTechnologicalReserve.TabIndex = 25;
            this.numericUpDownTechnologicalReserve.Value = new decimal(new int[] {
            110,
            0,
            0,
            131072});
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.numericUpDownTechnologicalReserve);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxAnArbitraryNumberOfPorts);
            this.Controls.Add(this.checkBoxStrictСomplianceWithTheStandart);
            this.Controls.Add(this.buttonBack);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(514, 585);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechnologicalReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private CheckBox checkBoxStrictСomplianceWithTheStandart;
        private CheckBox checkBoxAnArbitraryNumberOfPorts;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDownTechnologicalReserve;
    }
}
