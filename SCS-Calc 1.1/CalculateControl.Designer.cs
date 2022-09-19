namespace SKS_Calc_1._1
{
    partial class CalculateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateControl));
            this.labelMinPermanentLink = new System.Windows.Forms.Label();
            this.numericUpDownMinPermanentLink = new System.Windows.Forms.NumericUpDown();
            this.labelMaxPermanentLink = new System.Windows.Forms.Label();
            this.numericUpDownMaxPermanentLink = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfWorkplaces = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfWorkplaces = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfPorts = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfPorts = new System.Windows.Forms.NumericUpDown();
            this.labelMeters1 = new System.Windows.Forms.Label();
            this.labelMeters2 = new System.Windows.Forms.Label();
            this.checkBoxCableHankMeterage = new System.Windows.Forms.CheckBox();
            this.numericUpDownCableHankMeterage = new System.Windows.Forms.NumericUpDown();
            this.labelMeters3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelMeters8 = new System.Windows.Forms.Label();
            this.labelOutputCableHankMeterage = new System.Windows.Forms.Label();
            this.textBoxOutputCableHankMeterage = new System.Windows.Forms.TextBox();
            this.textBoxOutputNumberOfWorkplaces = new System.Windows.Forms.TextBox();
            this.labelOutputNumberOfWorkplaces = new System.Windows.Forms.Label();
            this.buttonOutputSaveToTxt = new System.Windows.Forms.Button();
            this.labelOutputTotalСableQuantity = new System.Windows.Forms.Label();
            this.labelMetersTotal = new System.Windows.Forms.Label();
            this.textBoxOutputTotalСableQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputHankQuantity = new System.Windows.Forms.Label();
            this.textBoxOutputHankQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputСableQuantity = new System.Windows.Forms.Label();
            this.labelMeters7 = new System.Windows.Forms.Label();
            this.textBoxOutputСableQuantity = new System.Windows.Forms.TextBox();
            this.labelOutputNumberOfPorts = new System.Windows.Forms.Label();
            this.textBoxOutputNumberOfPorts = new System.Windows.Forms.TextBox();
            this.labelOutputAveragePermanentLink = new System.Windows.Forms.Label();
            this.labelMeters6 = new System.Windows.Forms.Label();
            this.textBoxOutputAveragePermanentLink = new System.Windows.Forms.TextBox();
            this.labelOutputMaxPermanentLink = new System.Windows.Forms.Label();
            this.labelMeters5 = new System.Windows.Forms.Label();
            this.textBoxOutputMaxPermanentLink = new System.Windows.Forms.TextBox();
            this.labelMeters4 = new System.Windows.Forms.Label();
            this.textBoxOutputMinPermanentLink = new System.Windows.Forms.TextBox();
            this.labelOutputMinPermanentLink = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermanentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermanentLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCableHankMeterage)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinPermanentLink
            // 
            this.labelMinPermanentLink.AutoSize = true;
            this.labelMinPermanentLink.Location = new System.Drawing.Point(3, 0);
            this.labelMinPermanentLink.Name = "labelMinPermanentLink";
            this.labelMinPermanentLink.Size = new System.Drawing.Size(229, 15);
            this.labelMinPermanentLink.TabIndex = 0;
            this.labelMinPermanentLink.Text = "Наименьшая длина постоянного линка:";
            this.toolTipHelp.SetToolTip(this.labelMinPermanentLink, resources.GetString("labelMinPermanentLink.ToolTip"));
            // 
            // numericUpDownMinPermanentLink
            // 
            this.numericUpDownMinPermanentLink.DecimalPlaces = 2;
            this.numericUpDownMinPermanentLink.Location = new System.Drawing.Point(3, 18);
            this.numericUpDownMinPermanentLink.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinPermanentLink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMinPermanentLink.Name = "numericUpDownMinPermanentLink";
            this.numericUpDownMinPermanentLink.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMinPermanentLink.TabIndex = 1;
            this.toolTipHelp.SetToolTip(this.numericUpDownMinPermanentLink, resources.GetString("numericUpDownMinPermanentLink.ToolTip"));
            this.numericUpDownMinPermanentLink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMaxPermanentLink
            // 
            this.labelMaxPermanentLink.AutoSize = true;
            this.labelMaxPermanentLink.Location = new System.Drawing.Point(3, 44);
            this.labelMaxPermanentLink.Name = "labelMaxPermanentLink";
            this.labelMaxPermanentLink.Size = new System.Drawing.Size(228, 15);
            this.labelMaxPermanentLink.TabIndex = 2;
            this.labelMaxPermanentLink.Text = "Наибольшая длина постоянного линка:";
            this.toolTipHelp.SetToolTip(this.labelMaxPermanentLink, resources.GetString("labelMaxPermanentLink.ToolTip"));
            // 
            // numericUpDownMaxPermanentLink
            // 
            this.numericUpDownMaxPermanentLink.DecimalPlaces = 2;
            this.numericUpDownMaxPermanentLink.Location = new System.Drawing.Point(3, 62);
            this.numericUpDownMaxPermanentLink.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxPermanentLink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMaxPermanentLink.Name = "numericUpDownMaxPermanentLink";
            this.numericUpDownMaxPermanentLink.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMaxPermanentLink.TabIndex = 3;
            this.toolTipHelp.SetToolTip(this.numericUpDownMaxPermanentLink, resources.GetString("numericUpDownMaxPermanentLink.ToolTip"));
            this.numericUpDownMaxPermanentLink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberOfWorkplaces
            // 
            this.labelNumberOfWorkplaces.AutoSize = true;
            this.labelNumberOfWorkplaces.Location = new System.Drawing.Point(3, 88);
            this.labelNumberOfWorkplaces.Name = "labelNumberOfWorkplaces";
            this.labelNumberOfWorkplaces.Size = new System.Drawing.Size(154, 15);
            this.labelNumberOfWorkplaces.TabIndex = 4;
            this.labelNumberOfWorkplaces.Text = "Количество рабочих мест:";
            this.toolTipHelp.SetToolTip(this.labelNumberOfWorkplaces, "Пожалуйста, введите количество рабочих мест");
            // 
            // numericUpDownNumberOfWorkplaces
            // 
            this.numericUpDownNumberOfWorkplaces.Location = new System.Drawing.Point(3, 106);
            this.numericUpDownNumberOfWorkplaces.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNumberOfWorkplaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfWorkplaces.Name = "numericUpDownNumberOfWorkplaces";
            this.numericUpDownNumberOfWorkplaces.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNumberOfWorkplaces.TabIndex = 5;
            this.toolTipHelp.SetToolTip(this.numericUpDownNumberOfWorkplaces, "Пожалуйста, введите количество рабочих мест");
            this.numericUpDownNumberOfWorkplaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberOfPorts
            // 
            this.labelNumberOfPorts.AutoSize = true;
            this.labelNumberOfPorts.Location = new System.Drawing.Point(3, 132);
            this.labelNumberOfPorts.Name = "labelNumberOfPorts";
            this.labelNumberOfPorts.Size = new System.Drawing.Size(227, 15);
            this.labelNumberOfPorts.TabIndex = 6;
            this.labelNumberOfPorts.Text = "Количество портов на 1 рабочее место:";
            this.toolTipHelp.SetToolTip(this.labelNumberOfPorts, "Пожалуйста, введите количество портов на 1 рабочее место.\r\nНапоминаем, что соглас" +
        "но стандарту ISO/IEC 11801 на 1 рабочее место должно быть выделено не менее 2-х " +
        "портов");
            // 
            // numericUpDownNumberOfPorts
            // 
            this.numericUpDownNumberOfPorts.Location = new System.Drawing.Point(3, 150);
            this.numericUpDownNumberOfPorts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfPorts.Name = "numericUpDownNumberOfPorts";
            this.numericUpDownNumberOfPorts.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNumberOfPorts.TabIndex = 7;
            this.toolTipHelp.SetToolTip(this.numericUpDownNumberOfPorts, "Пожалуйста, введите количество портов на 1 рабочее место.\r\nНапоминаем, что соглас" +
        "но стандарту ISO/IEC 11801 на 1 рабочее место должно быть выделено не менее 2-х " +
        "портов");
            this.numericUpDownNumberOfPorts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMeters1
            // 
            this.labelMeters1.AutoSize = true;
            this.labelMeters1.Location = new System.Drawing.Point(129, 26);
            this.labelMeters1.Name = "labelMeters1";
            this.labelMeters1.Size = new System.Drawing.Size(19, 15);
            this.labelMeters1.TabIndex = 8;
            this.labelMeters1.Text = "м.";
            // 
            // labelMeters2
            // 
            this.labelMeters2.AutoSize = true;
            this.labelMeters2.Location = new System.Drawing.Point(129, 70);
            this.labelMeters2.Name = "labelMeters2";
            this.labelMeters2.Size = new System.Drawing.Size(19, 15);
            this.labelMeters2.TabIndex = 9;
            this.labelMeters2.Text = "м.";
            // 
            // checkBoxCableHankMeterage
            // 
            this.checkBoxCableHankMeterage.AutoSize = true;
            this.checkBoxCableHankMeterage.Location = new System.Drawing.Point(3, 179);
            this.checkBoxCableHankMeterage.Name = "checkBoxCableHankMeterage";
            this.checkBoxCableHankMeterage.Size = new System.Drawing.Size(156, 19);
            this.checkBoxCableHankMeterage.TabIndex = 10;
            this.checkBoxCableHankMeterage.Text = "Метраж кабеля в бухте:";
            this.toolTipHelp.SetToolTip(this.checkBoxCableHankMeterage, "Отметьте, если хотите ввести метраж кабеля в 1-й кабельной катушке (бухте).\r\nНеоб" +
        "ходимое количество кабеля будет рассчитано с учетом количества кабельных проброс" +
        "ов, которые можно сделать с 1-й бухты");
            this.checkBoxCableHankMeterage.UseVisualStyleBackColor = true;
            this.checkBoxCableHankMeterage.CheckedChanged += new System.EventHandler(this.checkBoxCableHankMeterage_CheckedChanged);
            // 
            // numericUpDownCableHankMeterage
            // 
            this.numericUpDownCableHankMeterage.DecimalPlaces = 2;
            this.numericUpDownCableHankMeterage.Location = new System.Drawing.Point(3, 204);
            this.numericUpDownCableHankMeterage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCableHankMeterage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCableHankMeterage.Name = "numericUpDownCableHankMeterage";
            this.numericUpDownCableHankMeterage.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCableHankMeterage.TabIndex = 11;
            this.toolTipHelp.SetToolTip(this.numericUpDownCableHankMeterage, "Введите метраж кабеля в 1-й кабельной катушке (бухте).\r\nНеобходимое количество ка" +
        "беля будет рассчитано с учетом количества кабельных пробросов, которые можно сде" +
        "лать с 1-й бухты");
            this.numericUpDownCableHankMeterage.Value = new decimal(new int[] {
            305,
            0,
            0,
            0});
            // 
            // labelMeters3
            // 
            this.labelMeters3.AutoSize = true;
            this.labelMeters3.Location = new System.Drawing.Point(129, 212);
            this.labelMeters3.Name = "labelMeters3";
            this.labelMeters3.Size = new System.Drawing.Size(19, 15);
            this.labelMeters3.TabIndex = 12;
            this.labelMeters3.Text = "м.";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(3, 233);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(105, 23);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Рассчитать";
            this.toolTipHelp.SetToolTip(this.buttonCalculate, "Рассчитать конфигурацию. Расчёт будет автоматически сохранен в истории расчётов.\r" +
        "\nВы в любой момент сможете посмотреть или удалить его");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelMeters8);
            this.groupBoxOutput.Controls.Add(this.labelOutputCableHankMeterage);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputCableHankMeterage);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputNumberOfWorkplaces);
            this.groupBoxOutput.Controls.Add(this.labelOutputNumberOfWorkplaces);
            this.groupBoxOutput.Controls.Add(this.buttonOutputSaveToTxt);
            this.groupBoxOutput.Controls.Add(this.labelOutputTotalСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelMetersTotal);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputTotalСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputHankQuantity);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputHankQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelMeters7);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputСableQuantity);
            this.groupBoxOutput.Controls.Add(this.labelOutputNumberOfPorts);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputNumberOfPorts);
            this.groupBoxOutput.Controls.Add(this.labelOutputAveragePermanentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters6);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputAveragePermanentLink);
            this.groupBoxOutput.Controls.Add(this.labelOutputMaxPermanentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters5);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputMaxPermanentLink);
            this.groupBoxOutput.Controls.Add(this.labelMeters4);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputMinPermanentLink);
            this.groupBoxOutput.Controls.Add(this.labelOutputMinPermanentLink);
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 262);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(508, 316);
            this.groupBoxOutput.TabIndex = 14;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // labelMeters8
            // 
            this.labelMeters8.AutoSize = true;
            this.labelMeters8.Location = new System.Drawing.Point(480, 204);
            this.labelMeters8.Name = "labelMeters8";
            this.labelMeters8.Size = new System.Drawing.Size(19, 15);
            this.labelMeters8.TabIndex = 30;
            this.labelMeters8.Text = "м.";
            // 
            // labelOutputCableHankMeterage
            // 
            this.labelOutputCableHankMeterage.AutoSize = true;
            this.labelOutputCableHankMeterage.Location = new System.Drawing.Point(6, 204);
            this.labelOutputCableHankMeterage.Name = "labelOutputCableHankMeterage";
            this.labelOutputCableHankMeterage.Size = new System.Drawing.Size(161, 15);
            this.labelOutputCableHankMeterage.TabIndex = 29;
            this.labelOutputCableHankMeterage.Text = "Метраж кабеля в 1-й бухте: ";
            this.toolTipHelp.SetToolTip(this.labelOutputCableHankMeterage, "Введённый вами метраж кабеля в 1-й бухте");
            // 
            // textBoxOutputCableHankMeterage
            // 
            this.textBoxOutputCableHankMeterage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputCableHankMeterage.Location = new System.Drawing.Point(374, 196);
            this.textBoxOutputCableHankMeterage.Name = "textBoxOutputCableHankMeterage";
            this.textBoxOutputCableHankMeterage.ReadOnly = true;
            this.textBoxOutputCableHankMeterage.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputCableHankMeterage.TabIndex = 28;
            this.toolTipHelp.SetToolTip(this.textBoxOutputCableHankMeterage, "Введённый вами метраж кабеля в 1-й бухте");
            // 
            // textBoxOutputNumberOfWorkplaces
            // 
            this.textBoxOutputNumberOfWorkplaces.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputNumberOfWorkplaces.Location = new System.Drawing.Point(374, 109);
            this.textBoxOutputNumberOfWorkplaces.Name = "textBoxOutputNumberOfWorkplaces";
            this.textBoxOutputNumberOfWorkplaces.ReadOnly = true;
            this.textBoxOutputNumberOfWorkplaces.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputNumberOfWorkplaces.TabIndex = 27;
            this.toolTipHelp.SetToolTip(this.textBoxOutputNumberOfWorkplaces, "Введённое вами количество рабочих мест");
            // 
            // labelOutputNumberOfWorkplaces
            // 
            this.labelOutputNumberOfWorkplaces.AutoSize = true;
            this.labelOutputNumberOfWorkplaces.Location = new System.Drawing.Point(6, 117);
            this.labelOutputNumberOfWorkplaces.Name = "labelOutputNumberOfWorkplaces";
            this.labelOutputNumberOfWorkplaces.Size = new System.Drawing.Size(154, 15);
            this.labelOutputNumberOfWorkplaces.TabIndex = 26;
            this.labelOutputNumberOfWorkplaces.Text = "Количество рабочих мест:";
            this.toolTipHelp.SetToolTip(this.labelOutputNumberOfWorkplaces, "Введённое вами количество рабочих мест");
            // 
            // buttonOutputSaveToTxt
            // 
            this.buttonOutputSaveToTxt.Location = new System.Drawing.Point(7, 283);
            this.buttonOutputSaveToTxt.Name = "buttonOutputSaveToTxt";
            this.buttonOutputSaveToTxt.Size = new System.Drawing.Size(107, 23);
            this.buttonOutputSaveToTxt.TabIndex = 15;
            this.buttonOutputSaveToTxt.Text = "Сохранить в TXT";
            this.toolTipHelp.SetToolTip(this.buttonOutputSaveToTxt, "Сохранить конфигурацию в текстовый документ (TXT)");
            this.buttonOutputSaveToTxt.UseVisualStyleBackColor = true;
            this.buttonOutputSaveToTxt.Click += new System.EventHandler(this.buttonOutputSaveToTxt_Click);
            // 
            // labelOutputTotalСableQuantity
            // 
            this.labelOutputTotalСableQuantity.AutoSize = true;
            this.labelOutputTotalСableQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutputTotalСableQuantity.Location = new System.Drawing.Point(6, 262);
            this.labelOutputTotalСableQuantity.Name = "labelOutputTotalСableQuantity";
            this.labelOutputTotalСableQuantity.Size = new System.Drawing.Size(251, 15);
            this.labelOutputTotalСableQuantity.TabIndex = 25;
            this.labelOutputTotalСableQuantity.Text = "Итоговое необходимое количество кабеля:";
            this.toolTipHelp.SetToolTip(this.labelOutputTotalСableQuantity, resources.GetString("labelOutputTotalСableQuantity.ToolTip"));
            // 
            // labelMetersTotal
            // 
            this.labelMetersTotal.AutoSize = true;
            this.labelMetersTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMetersTotal.Location = new System.Drawing.Point(480, 262);
            this.labelMetersTotal.Name = "labelMetersTotal";
            this.labelMetersTotal.Size = new System.Drawing.Size(19, 15);
            this.labelMetersTotal.TabIndex = 24;
            this.labelMetersTotal.Text = "м.";
            // 
            // textBoxOutputTotalСableQuantity
            // 
            this.textBoxOutputTotalСableQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputTotalСableQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOutputTotalСableQuantity.Location = new System.Drawing.Point(374, 254);
            this.textBoxOutputTotalСableQuantity.Name = "textBoxOutputTotalСableQuantity";
            this.textBoxOutputTotalСableQuantity.ReadOnly = true;
            this.textBoxOutputTotalСableQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputTotalСableQuantity.TabIndex = 23;
            this.toolTipHelp.SetToolTip(this.textBoxOutputTotalСableQuantity, resources.GetString("textBoxOutputTotalСableQuantity.ToolTip"));
            // 
            // labelOutputHankQuantity
            // 
            this.labelOutputHankQuantity.AutoSize = true;
            this.labelOutputHankQuantity.Location = new System.Drawing.Point(6, 233);
            this.labelOutputHankQuantity.Name = "labelOutputHankQuantity";
            this.labelOutputHankQuantity.Size = new System.Drawing.Size(225, 15);
            this.labelOutputHankQuantity.TabIndex = 22;
            this.labelOutputHankQuantity.Text = "Необходимое количество бухт кабеля: ";
            this.toolTipHelp.SetToolTip(this.labelOutputHankQuantity, "Необходимое количество кабельных катушек (бухт). Рассчитывается с учётом \r\nколиче" +
        "ства кабельных пробросов, которые можно сделать с 1-й бухты");
            // 
            // textBoxOutputHankQuantity
            // 
            this.textBoxOutputHankQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputHankQuantity.Location = new System.Drawing.Point(374, 225);
            this.textBoxOutputHankQuantity.Name = "textBoxOutputHankQuantity";
            this.textBoxOutputHankQuantity.ReadOnly = true;
            this.textBoxOutputHankQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputHankQuantity.TabIndex = 21;
            this.toolTipHelp.SetToolTip(this.textBoxOutputHankQuantity, "Необходимое количество кабельных катушек (бухт). Рассчитывается с учётом \r\nколиче" +
        "ства кабельных пробросов, которые можно сделать с 1-й бухты");
            // 
            // labelOutputСableQuantity
            // 
            this.labelOutputСableQuantity.AutoSize = true;
            this.labelOutputСableQuantity.Location = new System.Drawing.Point(7, 175);
            this.labelOutputСableQuantity.Name = "labelOutputСableQuantity";
            this.labelOutputСableQuantity.Size = new System.Drawing.Size(198, 15);
            this.labelOutputСableQuantity.TabIndex = 20;
            this.labelOutputСableQuantity.Text = "Необходимое количество кабеля: ";
            this.toolTipHelp.SetToolTip(this.labelOutputСableQuantity, "Необходимое количество кабеля. Рассчитывается общая длина необходимого кабеля без" +
        " \r\nучета метража кабеля в кабельных катушках (бухтах)");
            // 
            // labelMeters7
            // 
            this.labelMeters7.AutoSize = true;
            this.labelMeters7.Location = new System.Drawing.Point(480, 175);
            this.labelMeters7.Name = "labelMeters7";
            this.labelMeters7.Size = new System.Drawing.Size(19, 15);
            this.labelMeters7.TabIndex = 19;
            this.labelMeters7.Text = "м.";
            // 
            // textBoxOutputСableQuantity
            // 
            this.textBoxOutputСableQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputСableQuantity.Location = new System.Drawing.Point(374, 167);
            this.textBoxOutputСableQuantity.Name = "textBoxOutputСableQuantity";
            this.textBoxOutputСableQuantity.ReadOnly = true;
            this.textBoxOutputСableQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputСableQuantity.TabIndex = 18;
            this.toolTipHelp.SetToolTip(this.textBoxOutputСableQuantity, "Необходимое количество кабеля. Рассчитывается общая длина необходимого кабеля без" +
        " \r\nучета метража кабеля в кабельных катушках (бухтах)");
            // 
            // labelOutputNumberOfPorts
            // 
            this.labelOutputNumberOfPorts.AutoSize = true;
            this.labelOutputNumberOfPorts.Location = new System.Drawing.Point(6, 146);
            this.labelOutputNumberOfPorts.Name = "labelOutputNumberOfPorts";
            this.labelOutputNumberOfPorts.Size = new System.Drawing.Size(227, 15);
            this.labelOutputNumberOfPorts.TabIndex = 17;
            this.labelOutputNumberOfPorts.Text = "Количество портов на 1 рабочее место:";
            this.toolTipHelp.SetToolTip(this.labelOutputNumberOfPorts, "Введённое вами количество портов на 1 рабочее место");
            // 
            // textBoxOutputNumberOfPorts
            // 
            this.textBoxOutputNumberOfPorts.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputNumberOfPorts.Location = new System.Drawing.Point(374, 138);
            this.textBoxOutputNumberOfPorts.Name = "textBoxOutputNumberOfPorts";
            this.textBoxOutputNumberOfPorts.ReadOnly = true;
            this.textBoxOutputNumberOfPorts.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputNumberOfPorts.TabIndex = 16;
            this.toolTipHelp.SetToolTip(this.textBoxOutputNumberOfPorts, "Введённое вами количество портов на 1 рабочее место");
            // 
            // labelOutputAveragePermanentLink
            // 
            this.labelOutputAveragePermanentLink.AutoSize = true;
            this.labelOutputAveragePermanentLink.Location = new System.Drawing.Point(7, 88);
            this.labelOutputAveragePermanentLink.Name = "labelOutputAveragePermanentLink";
            this.labelOutputAveragePermanentLink.Size = new System.Drawing.Size(296, 15);
            this.labelOutputAveragePermanentLink.TabIndex = 15;
            this.labelOutputAveragePermanentLink.Text = "Средняя длина постоянного линка (Permanent Link):";
            this.toolTipHelp.SetToolTip(this.labelOutputAveragePermanentLink, resources.GetString("labelOutputAveragePermanentLink.ToolTip"));
            // 
            // labelMeters6
            // 
            this.labelMeters6.AutoSize = true;
            this.labelMeters6.Location = new System.Drawing.Point(480, 88);
            this.labelMeters6.Name = "labelMeters6";
            this.labelMeters6.Size = new System.Drawing.Size(19, 15);
            this.labelMeters6.TabIndex = 14;
            this.labelMeters6.Text = "м.";
            // 
            // textBoxOutputAveragePermanentLink
            // 
            this.textBoxOutputAveragePermanentLink.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputAveragePermanentLink.Location = new System.Drawing.Point(374, 80);
            this.textBoxOutputAveragePermanentLink.Name = "textBoxOutputAveragePermanentLink";
            this.textBoxOutputAveragePermanentLink.ReadOnly = true;
            this.textBoxOutputAveragePermanentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputAveragePermanentLink.TabIndex = 13;
            this.toolTipHelp.SetToolTip(this.textBoxOutputAveragePermanentLink, resources.GetString("textBoxOutputAveragePermanentLink.ToolTip"));
            // 
            // labelOutputMaxPermanentLink
            // 
            this.labelOutputMaxPermanentLink.AutoSize = true;
            this.labelOutputMaxPermanentLink.Location = new System.Drawing.Point(7, 59);
            this.labelOutputMaxPermanentLink.Name = "labelOutputMaxPermanentLink";
            this.labelOutputMaxPermanentLink.Size = new System.Drawing.Size(322, 15);
            this.labelOutputMaxPermanentLink.TabIndex = 12;
            this.labelOutputMaxPermanentLink.Text = "Наибольшая длина постоянного линка (Permanent Link):";
            this.toolTipHelp.SetToolTip(this.labelOutputMaxPermanentLink, "Введённое вами значение наибольшей длины постоянного линка (Permanent Link)");
            // 
            // labelMeters5
            // 
            this.labelMeters5.AutoSize = true;
            this.labelMeters5.Location = new System.Drawing.Point(480, 59);
            this.labelMeters5.Name = "labelMeters5";
            this.labelMeters5.Size = new System.Drawing.Size(19, 15);
            this.labelMeters5.TabIndex = 11;
            this.labelMeters5.Text = "м.";
            // 
            // textBoxOutputMaxPermanentLink
            // 
            this.textBoxOutputMaxPermanentLink.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputMaxPermanentLink.Location = new System.Drawing.Point(374, 51);
            this.textBoxOutputMaxPermanentLink.Name = "textBoxOutputMaxPermanentLink";
            this.textBoxOutputMaxPermanentLink.ReadOnly = true;
            this.textBoxOutputMaxPermanentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputMaxPermanentLink.TabIndex = 10;
            this.toolTipHelp.SetToolTip(this.textBoxOutputMaxPermanentLink, "Введённое вами значение наибольшей длины постоянного линка (Permanent Link)");
            // 
            // labelMeters4
            // 
            this.labelMeters4.AutoSize = true;
            this.labelMeters4.Location = new System.Drawing.Point(480, 30);
            this.labelMeters4.Name = "labelMeters4";
            this.labelMeters4.Size = new System.Drawing.Size(19, 15);
            this.labelMeters4.TabIndex = 9;
            this.labelMeters4.Text = "м.";
            // 
            // textBoxOutputMinPermanentLink
            // 
            this.textBoxOutputMinPermanentLink.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOutputMinPermanentLink.Location = new System.Drawing.Point(374, 22);
            this.textBoxOutputMinPermanentLink.Name = "textBoxOutputMinPermanentLink";
            this.textBoxOutputMinPermanentLink.ReadOnly = true;
            this.textBoxOutputMinPermanentLink.Size = new System.Drawing.Size(100, 23);
            this.textBoxOutputMinPermanentLink.TabIndex = 2;
            this.toolTipHelp.SetToolTip(this.textBoxOutputMinPermanentLink, "Введённое вами значение наименьшей длины постоянного линка (Permanent Link)");
            // 
            // labelOutputMinPermanentLink
            // 
            this.labelOutputMinPermanentLink.AutoSize = true;
            this.labelOutputMinPermanentLink.Location = new System.Drawing.Point(6, 30);
            this.labelOutputMinPermanentLink.Name = "labelOutputMinPermanentLink";
            this.labelOutputMinPermanentLink.Size = new System.Drawing.Size(323, 15);
            this.labelOutputMinPermanentLink.TabIndex = 1;
            this.labelOutputMinPermanentLink.Text = "Наименьшая длина постоянного линка (Permanent Link):";
            this.toolTipHelp.SetToolTip(this.labelOutputMinPermanentLink, "Введённое вами значение наименьшей длины постоянного линка (Permanent Link)");
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(406, 233);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(105, 23);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.Text = "Информация";
            this.toolTipHelp.SetToolTip(this.buttonInfo, "Просмотреть информацию о приложении и получить помощь в работе с приложением");
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(406, 204);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(105, 23);
            this.buttonHistory.TabIndex = 16;
            this.buttonHistory.Text = "История";
            this.toolTipHelp.SetToolTip(this.buttonHistory, "Просмотреть историю расчётов конфигураций. В режиме истории вы сможете просматрив" +
        "ать или удалять\r\nпредыдущие конфигурации, а так же сохранять в TXT любую выбранн" +
        "ую предыдущую конфигурацию");
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 1000;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(406, 175);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(105, 23);
            this.buttonSettings.TabIndex = 17;
            this.buttonSettings.Text = "Настройки";
            this.toolTipHelp.SetToolTip(this.buttonSettings, "Просмотреть историю расчётов конфигураций. В режиме истории вы сможете просматрив" +
        "ать или удалять\r\nпредыдущие конфигурации, а так же сохранять в TXT любую выбранн" +
        "ую предыдущую конфигурацию");
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelMeters3);
            this.Controls.Add(this.numericUpDownCableHankMeterage);
            this.Controls.Add(this.checkBoxCableHankMeterage);
            this.Controls.Add(this.labelMeters2);
            this.Controls.Add(this.labelMeters1);
            this.Controls.Add(this.numericUpDownNumberOfPorts);
            this.Controls.Add(this.labelNumberOfPorts);
            this.Controls.Add(this.numericUpDownNumberOfWorkplaces);
            this.Controls.Add(this.labelNumberOfWorkplaces);
            this.Controls.Add(this.numericUpDownMaxPermanentLink);
            this.Controls.Add(this.labelMaxPermanentLink);
            this.Controls.Add(this.numericUpDownMinPermanentLink);
            this.Controls.Add(this.labelMinPermanentLink);
            this.Name = "CalculateControl";
            this.Size = new System.Drawing.Size(514, 585);
            this.Load += new System.EventHandler(this.CalculateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPermanentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPermanentLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfWorkplaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPorts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCableHankMeterage)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMinPermanentLink;
        private NumericUpDown numericUpDownMinPermanentLink;
        private Label labelMaxPermanentLink;
        private NumericUpDown numericUpDownMaxPermanentLink;
        private Label labelNumberOfWorkplaces;
        private NumericUpDown numericUpDownNumberOfWorkplaces;
        private Label labelNumberOfPorts;
        private NumericUpDown numericUpDownNumberOfPorts;
        private Label labelMeters1;
        private Label labelMeters2;
        private CheckBox checkBoxCableHankMeterage;
        private NumericUpDown numericUpDownCableHankMeterage;
        private Label labelMeters3;
        private Button buttonCalculate;
        private GroupBox groupBoxOutput;
        private Label labelMeters4;
        private TextBox textBoxOutputMinPermanentLink;
        private Label labelOutputMinPermanentLink;
        private Label labelOutputAveragePermanentLink;
        private Label labelMeters6;
        private TextBox textBoxOutputAveragePermanentLink;
        private Label labelOutputMaxPermanentLink;
        private Label labelMeters5;
        private TextBox textBoxOutputMaxPermanentLink;
        private Label labelOutputNumberOfPorts;
        private TextBox textBoxOutputNumberOfPorts;
        private Button buttonOutputSaveToTxt;
        private Label labelOutputTotalСableQuantity;
        private Label labelMetersTotal;
        private TextBox textBoxOutputTotalСableQuantity;
        private Label labelOutputHankQuantity;
        private TextBox textBoxOutputHankQuantity;
        private Label labelOutputСableQuantity;
        private Label labelMeters7;
        private TextBox textBoxOutputСableQuantity;
        private Button buttonInfo;
        private Button buttonHistory;
        private ToolTip toolTipHelp;
        private TextBox textBoxOutputNumberOfWorkplaces;
        private Label labelOutputNumberOfWorkplaces;
        private Label labelOutputCableHankMeterage;
        private TextBox textBoxOutputCableHankMeterage;
        private Label labelMeters8;
        private Button buttonSettings;
    }
}
