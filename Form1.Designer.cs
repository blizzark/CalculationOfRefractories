namespace BSUWF2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LayerGB1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CTB1 = new System.Windows.Forms.TextBox();
            this.BTB1 = new System.Windows.Forms.TextBox();
            this.ATB1 = new System.Windows.Forms.TextBox();
            this.WidthTB1 = new System.Windows.Forms.TextBox();
            this.LayerGB2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CTB2 = new System.Windows.Forms.TextBox();
            this.BTB2 = new System.Windows.Forms.TextBox();
            this.ATB2 = new System.Windows.Forms.TextBox();
            this.WidthTB2 = new System.Windows.Forms.TextBox();
            this.LayerGB3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.CTB3 = new System.Windows.Forms.TextBox();
            this.BTB3 = new System.Windows.Forms.TextBox();
            this.ATB3 = new System.Windows.Forms.TextBox();
            this.WidthTB3 = new System.Windows.Forms.TextBox();
            this.ExistenceCB1 = new System.Windows.Forms.CheckBox();
            this.ExistenceCB2 = new System.Windows.Forms.CheckBox();
            this.ExistenceCB3 = new System.Windows.Forms.CheckBox();
            this.LayersGB = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IterationsTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.TempetureEthernTB = new System.Windows.Forms.TextBox();
            this.TempetureExternTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LayerGB1.SuspendLayout();
            this.LayerGB2.SuspendLayout();
            this.LayerGB3.SuspendLayout();
            this.LayersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LayerGB1
            // 
            this.LayerGB1.Controls.Add(this.comboBox1);
            this.LayerGB1.Controls.Add(this.CTB1);
            this.LayerGB1.Controls.Add(this.BTB1);
            this.LayerGB1.Controls.Add(this.ATB1);
            this.LayerGB1.Controls.Add(this.WidthTB1);
            this.LayerGB1.Controls.Add(this.label2);
            this.LayerGB1.Controls.Add(this.label4);
            this.LayerGB1.Controls.Add(this.label3);
            this.LayerGB1.Location = new System.Drawing.Point(651, 114);
            this.LayerGB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB1.Name = "LayerGB1";
            this.LayerGB1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB1.Size = new System.Drawing.Size(358, 54);
            this.LayerGB1.TabIndex = 0;
            this.LayerGB1.TabStop = false;
            this.LayerGB1.Text = "Слой 1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.comboBox1.Location = new System.Drawing.Point(219, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CTB1
            // 
            this.CTB1.Location = new System.Drawing.Point(169, 19);
            this.CTB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTB1.Name = "CTB1";
            this.CTB1.Size = new System.Drawing.Size(46, 20);
            this.CTB1.TabIndex = 5;
            this.CTB1.Text = "0";
            // 
            // BTB1
            // 
            this.BTB1.Location = new System.Drawing.Point(119, 19);
            this.BTB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTB1.Name = "BTB1";
            this.BTB1.Size = new System.Drawing.Size(46, 20);
            this.BTB1.TabIndex = 4;
            this.BTB1.Text = "-1,7";
            // 
            // ATB1
            // 
            this.ATB1.Location = new System.Drawing.Point(69, 19);
            this.ATB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ATB1.Name = "ATB1";
            this.ATB1.Size = new System.Drawing.Size(46, 20);
            this.ATB1.TabIndex = 1;
            this.ATB1.Text = "4,7";
            // 
            // WidthTB1
            // 
            this.WidthTB1.Location = new System.Drawing.Point(15, 19);
            this.WidthTB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTB1.Name = "WidthTB1";
            this.WidthTB1.Size = new System.Drawing.Size(50, 20);
            this.WidthTB1.TabIndex = 0;
            this.WidthTB1.Text = "0,2";
            // 
            // LayerGB2
            // 
            this.LayerGB2.Controls.Add(this.label16);
            this.LayerGB2.Controls.Add(this.label14);
            this.LayerGB2.Controls.Add(this.label11);
            this.LayerGB2.Controls.Add(this.comboBox2);
            this.LayerGB2.Controls.Add(this.CTB2);
            this.LayerGB2.Controls.Add(this.BTB2);
            this.LayerGB2.Controls.Add(this.ATB2);
            this.LayerGB2.Controls.Add(this.WidthTB2);
            this.LayerGB2.Location = new System.Drawing.Point(651, 172);
            this.LayerGB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB2.Name = "LayerGB2";
            this.LayerGB2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB2.Size = new System.Drawing.Size(357, 51);
            this.LayerGB2.TabIndex = 1;
            this.LayerGB2.TabStop = false;
            this.LayerGB2.Text = "Слой 2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.comboBox2.Location = new System.Drawing.Point(219, 16);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CTB2
            // 
            this.CTB2.Location = new System.Drawing.Point(169, 17);
            this.CTB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTB2.Name = "CTB2";
            this.CTB2.Size = new System.Drawing.Size(46, 20);
            this.CTB2.TabIndex = 8;
            this.CTB2.Text = "0";
            // 
            // BTB2
            // 
            this.BTB2.Location = new System.Drawing.Point(119, 17);
            this.BTB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTB2.Name = "BTB2";
            this.BTB2.Size = new System.Drawing.Size(46, 20);
            this.BTB2.TabIndex = 7;
            this.BTB2.Text = "0,465";
            // 
            // ATB2
            // 
            this.ATB2.Location = new System.Drawing.Point(69, 17);
            this.ATB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ATB2.Name = "ATB2";
            this.ATB2.Size = new System.Drawing.Size(46, 20);
            this.ATB2.TabIndex = 6;
            this.ATB2.Text = "0,44";
            // 
            // WidthTB2
            // 
            this.WidthTB2.Location = new System.Drawing.Point(15, 17);
            this.WidthTB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTB2.Name = "WidthTB2";
            this.WidthTB2.Size = new System.Drawing.Size(50, 20);
            this.WidthTB2.TabIndex = 0;
            this.WidthTB2.Text = "0,35";
            // 
            // LayerGB3
            // 
            this.LayerGB3.Controls.Add(this.label17);
            this.LayerGB3.Controls.Add(this.label15);
            this.LayerGB3.Controls.Add(this.label13);
            this.LayerGB3.Controls.Add(this.comboBox3);
            this.LayerGB3.Controls.Add(this.CTB3);
            this.LayerGB3.Controls.Add(this.BTB3);
            this.LayerGB3.Controls.Add(this.ATB3);
            this.LayerGB3.Controls.Add(this.WidthTB3);
            this.LayerGB3.Location = new System.Drawing.Point(651, 227);
            this.LayerGB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB3.Name = "LayerGB3";
            this.LayerGB3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayerGB3.Size = new System.Drawing.Size(357, 48);
            this.LayerGB3.TabIndex = 4;
            this.LayerGB3.TabStop = false;
            this.LayerGB3.Text = "Слой 3";
            this.LayerGB3.Enter += new System.EventHandler(this.LayerGB3_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Высокоглиноземистый",
            "Графит",
            "Динас",
            "Доломит",
            "Карборунд на нитридной связке",
            "Карборунд на оксидной связке",
            "Карборунд самосвязанный",
            "Карборунд, сиалоновая связка",
            "Корунд",
            "Красный кирпич",
            "Магнезит",
            "Магнезитохромит",
            "Огнеупорный бетон",
            "Периклазоуглеродистый",
            "Тальк",
            "Углеродистый",
            "Хромомагнезит",
            "Циркон",
            "Шамот"});
            this.comboBox3.Location = new System.Drawing.Point(219, 17);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(126, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CTB3
            // 
            this.CTB3.Location = new System.Drawing.Point(169, 17);
            this.CTB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CTB3.Name = "CTB3";
            this.CTB3.Size = new System.Drawing.Size(46, 20);
            this.CTB3.TabIndex = 8;
            this.CTB3.Text = "-1,429";
            // 
            // BTB3
            // 
            this.BTB3.Location = new System.Drawing.Point(119, 17);
            this.BTB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTB3.Name = "BTB3";
            this.BTB3.Size = new System.Drawing.Size(46, 20);
            this.BTB3.TabIndex = 7;
            this.BTB3.Text = "0,886";
            // 
            // ATB3
            // 
            this.ATB3.Location = new System.Drawing.Point(69, 17);
            this.ATB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ATB3.Name = "ATB3";
            this.ATB3.Size = new System.Drawing.Size(46, 20);
            this.ATB3.TabIndex = 6;
            this.ATB3.Text = "3,180";
            // 
            // WidthTB3
            // 
            this.WidthTB3.Location = new System.Drawing.Point(15, 17);
            this.WidthTB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTB3.Name = "WidthTB3";
            this.WidthTB3.Size = new System.Drawing.Size(50, 20);
            this.WidthTB3.TabIndex = 0;
            this.WidthTB3.Text = "0,45";
            // 
            // ExistenceCB1
            // 
            this.ExistenceCB1.AutoSize = true;
            this.ExistenceCB1.Checked = true;
            this.ExistenceCB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExistenceCB1.Location = new System.Drawing.Point(141, 28);
            this.ExistenceCB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExistenceCB1.Name = "ExistenceCB1";
            this.ExistenceCB1.Size = new System.Drawing.Size(50, 17);
            this.ExistenceCB1.TabIndex = 5;
            this.ExistenceCB1.Text = "Есть";
            this.ExistenceCB1.UseVisualStyleBackColor = true;
            // 
            // ExistenceCB2
            // 
            this.ExistenceCB2.AutoSize = true;
            this.ExistenceCB2.Checked = true;
            this.ExistenceCB2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExistenceCB2.Location = new System.Drawing.Point(87, 28);
            this.ExistenceCB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExistenceCB2.Name = "ExistenceCB2";
            this.ExistenceCB2.Size = new System.Drawing.Size(50, 17);
            this.ExistenceCB2.TabIndex = 6;
            this.ExistenceCB2.Text = "Есть";
            this.ExistenceCB2.UseVisualStyleBackColor = true;
            // 
            // ExistenceCB3
            // 
            this.ExistenceCB3.AutoSize = true;
            this.ExistenceCB3.Checked = true;
            this.ExistenceCB3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExistenceCB3.Location = new System.Drawing.Point(23, 28);
            this.ExistenceCB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExistenceCB3.Name = "ExistenceCB3";
            this.ExistenceCB3.Size = new System.Drawing.Size(50, 17);
            this.ExistenceCB3.TabIndex = 7;
            this.ExistenceCB3.Text = "Есть";
            this.ExistenceCB3.UseVisualStyleBackColor = true;
            // 
            // LayersGB
            // 
            this.LayersGB.Controls.Add(this.button1);
            this.LayersGB.Controls.Add(this.label19);
            this.LayersGB.Controls.Add(this.label18);
            this.LayersGB.Controls.Add(this.label10);
            this.LayersGB.Controls.Add(this.label9);
            this.LayersGB.Controls.Add(this.label8);
            this.LayersGB.Controls.Add(this.label7);
            this.LayersGB.Controls.Add(this.IterationsTB);
            this.LayersGB.Controls.Add(this.chart1);
            this.LayersGB.Controls.Add(this.label6);
            this.LayersGB.Controls.Add(this.label1);
            this.LayersGB.Controls.Add(this.LayerGB1);
            this.LayersGB.Controls.Add(this.label5);
            this.LayersGB.Controls.Add(this.LayerGB2);
            this.LayersGB.Controls.Add(this.CalculateBtn);
            this.LayersGB.Controls.Add(this.TempetureEthernTB);
            this.LayersGB.Controls.Add(this.LayerGB3);
            this.LayersGB.Controls.Add(this.TempetureExternTB);
            this.LayersGB.Controls.Add(this.ExistenceCB3);
            this.LayersGB.Controls.Add(this.ExistenceCB2);
            this.LayersGB.Controls.Add(this.ExistenceCB1);
            this.LayersGB.Location = new System.Drawing.Point(9, 10);
            this.LayersGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayersGB.Name = "LayersGB";
            this.LayersGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LayersGB.Size = new System.Drawing.Size(1022, 452);
            this.LayersGB.TabIndex = 10;
            this.LayersGB.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(646, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Результат:  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(915, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Огнеупор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(647, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Коэффициенты теплопроводности, Вт/(м*К)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(856, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Количество итераций";
            // 
            // IterationsTB
            // 
            this.IterationsTB.Location = new System.Drawing.Point(885, 38);
            this.IterationsTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IterationsTB.Name = "IterationsTB";
            this.IterationsTB.Size = new System.Drawing.Size(85, 20);
            this.IterationsTB.TabIndex = 29;
            this.IterationsTB.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(185, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(137, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "A";
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkVertical;
            chartArea8.BackColor = System.Drawing.Color.White;
            chartArea8.BorderWidth = 100;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend8.AutoFitMinFontSize = 8;
            legend8.BackColor = System.Drawing.Color.White;
            legend8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            legend8.BorderColor = System.Drawing.Color.Black;
            legend8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            legend8.BorderWidth = 2;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(9, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "Слой 1";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "Слой 2";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Color = System.Drawing.Color.Red;
            series24.LabelBackColor = System.Drawing.Color.White;
            series24.Legend = "Legend1";
            series24.Name = "Слой 3";
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(619, 421);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "0";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(763, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Т (внеш.), К";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Толщина слоя, м";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(669, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "T (внут.), К";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(651, 279);
            this.CalculateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(358, 51);
            this.CalculateBtn.TabIndex = 23;
            this.CalculateBtn.Text = "Начать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TempetureEthernTB
            // 
            this.TempetureEthernTB.Location = new System.Drawing.Point(666, 38);
            this.TempetureEthernTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TempetureEthernTB.Name = "TempetureEthernTB";
            this.TempetureEthernTB.Size = new System.Drawing.Size(84, 20);
            this.TempetureEthernTB.TabIndex = 21;
            this.TempetureEthernTB.Text = "1700";
            // 
            // TempetureExternTB
            // 
            this.TempetureExternTB.Location = new System.Drawing.Point(766, 38);
            this.TempetureExternTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TempetureExternTB.Name = "TempetureExternTB";
            this.TempetureExternTB.Size = new System.Drawing.Size(84, 20);
            this.TempetureExternTB.TabIndex = 22;
            this.TempetureExternTB.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(87, -2);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(87, -2);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(137, -2);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "B";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(137, -2);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(185, -2);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(185, -2);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "C";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(919, 400);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 25);
            this.label18.TabIndex = 34;
            this.label18.Text = "Вт/м^2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(813, 400);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 25);
            this.label19.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(651, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 51);
            this.button1.TabIndex = 36;
            this.button1.Text = "Информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 467);
            this.Controls.Add(this.LayersGB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Тепловой поток";
            this.LayerGB1.ResumeLayout(false);
            this.LayerGB1.PerformLayout();
            this.LayerGB2.ResumeLayout(false);
            this.LayerGB2.PerformLayout();
            this.LayerGB3.ResumeLayout(false);
            this.LayerGB3.PerformLayout();
            this.LayersGB.ResumeLayout(false);
            this.LayersGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LayerGB1;
        private System.Windows.Forms.TextBox ATB1;
        private System.Windows.Forms.TextBox WidthTB1;
        private System.Windows.Forms.GroupBox LayerGB2;
        private System.Windows.Forms.TextBox WidthTB2;
        private System.Windows.Forms.GroupBox LayerGB3;
        private System.Windows.Forms.TextBox WidthTB3;
        private System.Windows.Forms.CheckBox ExistenceCB1;
        private System.Windows.Forms.CheckBox ExistenceCB2;
        private System.Windows.Forms.CheckBox ExistenceCB3;
        private System.Windows.Forms.GroupBox LayersGB;
        private System.Windows.Forms.TextBox CTB1;
        private System.Windows.Forms.TextBox BTB1;
        private System.Windows.Forms.TextBox CTB2;
        private System.Windows.Forms.TextBox BTB2;
        private System.Windows.Forms.TextBox ATB2;
        private System.Windows.Forms.TextBox CTB3;
        private System.Windows.Forms.TextBox BTB3;
        private System.Windows.Forms.TextBox ATB3;
        private System.Windows.Forms.TextBox TempetureExternTB;
        private System.Windows.Forms.TextBox TempetureEthernTB;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IterationsTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

