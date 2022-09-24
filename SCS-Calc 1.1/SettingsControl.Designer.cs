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
            MessageBox.Show("Ha ha");
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
            this.checkBoxTechnologicalReserve = new System.Windows.Forms.CheckBox();
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
            this.checkBoxStrictСomplianceWithTheStandart.CheckedChanged += new System.EventHandler(this.checkBoxStrictСomplianceWithTheStandart_CheckedChanged);
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
            this.checkBoxAnArbitraryNumberOfPorts.CheckedChanged += new System.EventHandler(this.checkBoxAnArbitraryNumberOfPorts_CheckedChanged);
            // 
            // checkBoxTechnologicalReserve
            // 
            this.checkBoxTechnologicalReserve.AutoSize = true;
            this.checkBoxTechnologicalReserve.Location = new System.Drawing.Point(3, 53);
            this.checkBoxTechnologicalReserve.Name = "checkBoxTechnologicalReserve";
            this.checkBoxTechnologicalReserve.Size = new System.Drawing.Size(306, 19);
            this.checkBoxTechnologicalReserve.TabIndex = 24;
            this.checkBoxTechnologicalReserve.Text = "Учитывать коэффициент технологического запаса";
            this.checkBoxTechnologicalReserve.UseVisualStyleBackColor = true;
            this.checkBoxTechnologicalReserve.CheckedChanged += new System.EventHandler(this.checkBoxTechnologicalReserve_CheckedChanged);
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
            this.numericUpDownTechnologicalReserve.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
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
            this.numericUpDownTechnologicalReserve.ValueChanged += new System.EventHandler(this.numericUpDownTechnologicalReserve_ValueChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.numericUpDownTechnologicalReserve);
            this.Controls.Add(this.checkBoxTechnologicalReserve);
            this.Controls.Add(this.checkBoxAnArbitraryNumberOfPorts);
            this.Controls.Add(this.checkBoxStrictСomplianceWithTheStandart);
            this.Controls.Add(this.buttonBack);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(514, 585);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechnologicalReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private CheckBox checkBoxStrictСomplianceWithTheStandart;
        private CheckBox checkBoxAnArbitraryNumberOfPorts;
        private CheckBox checkBoxTechnologicalReserve;
        private NumericUpDown numericUpDownTechnologicalReserve;
    }
}
