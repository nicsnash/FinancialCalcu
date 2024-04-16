namespace Financial_Calculatorr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cartesianchart2 = new System.Windows.Forms.TabControl();
            this.tabCalculate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtT = new System.Windows.Forms.TextBox();
            this.lblT = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.lblPV = new System.Windows.Forms.Label();
            this.tabFormulas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ViewHistory = new System.Windows.Forms.ListBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LiveChart = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttimescompounded = new System.Windows.Forms.TextBox();
            this.txtTimePeriod = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.TxtLeftMargin = new System.Windows.Forms.ToolStripTextBox();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtTopMargin = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.continousCompoundingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartesianchart2.SuspendLayout();
            this.tabCalculate.SuspendLayout();
            this.tabFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.LiveChart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continousCompoundingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianchart2
            // 
            this.cartesianchart2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.cartesianchart2.Controls.Add(this.tabCalculate);
            this.cartesianchart2.Controls.Add(this.tabFormulas);
            this.cartesianchart2.Controls.Add(this.tabPage1);
            this.cartesianchart2.Controls.Add(this.tabPage2);
            this.cartesianchart2.Controls.Add(this.LiveChart);
            this.cartesianchart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianchart2.Location = new System.Drawing.Point(0, 32);
            this.cartesianchart2.Name = "cartesianchart2";
            this.cartesianchart2.SelectedIndex = 0;
            this.cartesianchart2.Size = new System.Drawing.Size(710, 442);
            this.cartesianchart2.TabIndex = 0;
            // 
            // tabCalculate
            // 
            this.tabCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabCalculate.BackgroundImage = global::Financial_Calculatorr.Properties.Resources.Premium_Vector___Stock_market_graph_or_forex_trading_chart_for_business_and_financial_concepts_reports_and_investment_on_dark_background_vector_illustration;
            this.tabCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCalculate.Controls.Add(this.label1);
            this.tabCalculate.Controls.Add(this.button1);
            this.tabCalculate.Controls.Add(this.lblOutput);
            this.tabCalculate.Controls.Add(this.btnCal);
            this.tabCalculate.Controls.Add(this.txtT);
            this.tabCalculate.Controls.Add(this.lblT);
            this.tabCalculate.Controls.Add(this.txtTC);
            this.tabCalculate.Controls.Add(this.lblTC);
            this.tabCalculate.Controls.Add(this.txtR);
            this.tabCalculate.Controls.Add(this.lblR);
            this.tabCalculate.Controls.Add(this.txtPV);
            this.tabCalculate.Controls.Add(this.lblPV);
            this.tabCalculate.Location = new System.Drawing.Point(4, 36);
            this.tabCalculate.Name = "tabCalculate";
            this.tabCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculate.Size = new System.Drawing.Size(702, 402);
            this.tabCalculate.TabIndex = 0;
            this.tabCalculate.Text = "Calculate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Results:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.lblOutput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOutput.Location = new System.Drawing.Point(351, 24);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 23);
            this.lblOutput.TabIndex = 9;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Crimson;
            this.btnCal.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCal.Location = new System.Drawing.Point(419, 282);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(95, 41);
            this.btnCal.TabIndex = 8;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtT
            // 
            this.txtT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtT.Location = new System.Drawing.Point(225, 186);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(126, 29);
            this.txtT.TabIndex = 7;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(145, 192);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(47, 23);
            this.lblT.TabIndex = 6;
            this.lblT.Text = "Time";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTC.Location = new System.Drawing.Point(225, 294);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(126, 29);
            this.txtTC.TabIndex = 5;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(28, 300);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(164, 23);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "Times Compounded";
            // 
            // txtR
            // 
            this.txtR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtR.Location = new System.Drawing.Point(225, 243);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(126, 29);
            this.txtR.TabIndex = 3;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.ForeColor = System.Drawing.Color.White;
            this.lblR.Location = new System.Drawing.Point(144, 248);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(48, 24);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "Rate";
            // 
            // txtPV
            // 
            this.txtPV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPV.Location = new System.Drawing.Point(225, 127);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(126, 29);
            this.txtPV.TabIndex = 1;
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.BackColor = System.Drawing.Color.Transparent;
            this.lblPV.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPV.ForeColor = System.Drawing.Color.White;
            this.lblPV.Location = new System.Drawing.Point(70, 133);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(122, 23);
            this.lblPV.TabIndex = 0;
            this.lblPV.Text = "Principal Value";
            // 
            // tabFormulas
            // 
            this.tabFormulas.BackgroundImage = global::Financial_Calculatorr.Properties.Resources.Premium_Vector___Abstract_realistic_technology_particle_background3;
            this.tabFormulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabFormulas.Controls.Add(this.label2);
            this.tabFormulas.Controls.Add(this.pictureBox1);
            this.tabFormulas.Location = new System.Drawing.Point(4, 36);
            this.tabFormulas.Name = "tabFormulas";
            this.tabFormulas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormulas.Size = new System.Drawing.Size(702, 402);
            this.tabFormulas.TabIndex = 1;
            this.tabFormulas.Text = "Formulas";
            this.tabFormulas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(298, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 304);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Financial_Calculatorr.Properties.Resources.Formulas;
            this.pictureBox1.Location = new System.Drawing.Point(25, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.BackgroundImage = global::Financial_Calculatorr.Properties.Resources.download;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.ViewHistory);
            this.tabPage1.Controls.Add(this.btnHistory);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 402);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "History";
            // 
            // ViewHistory
            // 
            this.ViewHistory.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHistory.ForeColor = System.Drawing.Color.White;
            this.ViewHistory.FormattingEnabled = true;
            this.ViewHistory.ItemHeight = 20;
            this.ViewHistory.Items.AddRange(new object[] {
            "                                                                           View H" +
                "istory"});
            this.ViewHistory.Location = new System.Drawing.Point(8, 17);
            this.ViewHistory.Name = "ViewHistory";
            this.ViewHistory.Size = new System.Drawing.Size(686, 262);
            this.ViewHistory.TabIndex = 3;
            this.ViewHistory.SelectedIndexChanged += new System.EventHandler(this.UpdateHistory_SelectedIndexChanged_1);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Black;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHistory.Location = new System.Drawing.Point(285, 333);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(142, 43);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Show History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.BackgroundImage = global::Financial_Calculatorr.Properties.Resources.Premium_Vector___Blue_bright_technological_background1;
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 402);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Details";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Financial_Calculatorr.Properties.Resources.compounding_formula_diagram_F_P;
            this.pictureBox3.Location = new System.Drawing.Point(362, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 376);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Financial_Calculatorr.Properties.Resources.Compound_interest__English_;
            this.pictureBox2.Location = new System.Drawing.Point(52, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 80);
            this.label4.TabIndex = 2;
            this.label4.Text = "\r\nContinuous Compounding:\r\nDefinition: Continuous compounding is a method where \r" +
    "\ninterest is compounded infinitely often, resulting in the\r\n growth of the inves" +
    "tment continuously over time.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(49, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 80);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // LiveChart
            // 
            this.LiveChart.BackgroundImage = global::Financial_Calculatorr.Properties.Resources.Premium_Vector___Abstract_background_with_technology_circuit_board1;
            this.LiveChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LiveChart.Controls.Add(this.label8);
            this.LiveChart.Controls.Add(this.label7);
            this.LiveChart.Controls.Add(this.label6);
            this.LiveChart.Controls.Add(this.label5);
            this.LiveChart.Controls.Add(this.txttimescompounded);
            this.LiveChart.Controls.Add(this.txtTimePeriod);
            this.LiveChart.Controls.Add(this.txtInterestRate);
            this.LiveChart.Controls.Add(this.txtPrincipal);
            this.LiveChart.Controls.Add(this.btnLoad);
            this.LiveChart.Controls.Add(this.cartesianChart1);
            this.LiveChart.ForeColor = System.Drawing.Color.Black;
            this.LiveChart.Location = new System.Drawing.Point(4, 36);
            this.LiveChart.Name = "LiveChart";
            this.LiveChart.Padding = new System.Windows.Forms.Padding(3);
            this.LiveChart.Size = new System.Drawing.Size(702, 402);
            this.LiveChart.TabIndex = 4;
            this.LiveChart.Text = "Financial Chart";
            this.LiveChart.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(292, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Times Compounded";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(292, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(42, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Principal Value";
            // 
            // txttimescompounded
            // 
            this.txttimescompounded.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttimescompounded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimescompounded.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txttimescompounded.Location = new System.Drawing.Point(296, 360);
            this.txttimescompounded.Name = "txttimescompounded";
            this.txttimescompounded.Size = new System.Drawing.Size(163, 26);
            this.txttimescompounded.TabIndex = 7;
            // 
            // txtTimePeriod
            // 
            this.txtTimePeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimePeriod.Location = new System.Drawing.Point(296, 290);
            this.txtTimePeriod.Name = "txtTimePeriod";
            this.txtTimePeriod.Size = new System.Drawing.Size(163, 26);
            this.txtTimePeriod.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInterestRate.Location = new System.Drawing.Point(46, 360);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(159, 26);
            this.txtInterestRate.TabIndex = 5;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrincipal.Location = new System.Drawing.Point(46, 290);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(159, 26);
            this.txtPrincipal.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Ivory;
            this.btnLoad.Location = new System.Drawing.Point(516, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 37);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "View";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cartesianChart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartesianChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart1.ForeColor = System.Drawing.Color.Black;
            this.cartesianChart1.Location = new System.Drawing.Point(46, 24);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(606, 199);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.marginsToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // marginsToolStripMenuItem
            // 
            this.marginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.TxtLeftMargin,
            this.rightToolStripMenuItem,
            this.TxtTopMargin});
            this.marginsToolStripMenuItem.Name = "marginsToolStripMenuItem";
            this.marginsToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.marginsToolStripMenuItem.Text = "Margins";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToolStripMenuItem1,
            this.toolStripTextBox1,
            this.bottomToolStripMenuItem,
            this.toolStripTextBox2});
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.leftToolStripMenuItem.Text = "Left";
            // 
            // rightToolStripMenuItem1
            // 
            this.rightToolStripMenuItem1.Name = "rightToolStripMenuItem1";
            this.rightToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.rightToolStripMenuItem1.Text = "Right";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.bottomToolStripMenuItem.Text = "Bottom";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // TxtLeftMargin
            // 
            this.TxtLeftMargin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtLeftMargin.Name = "TxtLeftMargin";
            this.TxtLeftMargin.Size = new System.Drawing.Size(100, 23);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.rightToolStripMenuItem.Text = "Top";
            // 
            // TxtTopMargin
            // 
            this.TxtTopMargin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTopMargin.Name = "TxtTopMargin";
            this.TxtTopMargin.Size = new System.Drawing.Size(100, 23);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(710, 472);
            this.Controls.Add(this.cartesianchart2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Calculator";
            this.cartesianchart2.ResumeLayout(false);
            this.tabCalculate.ResumeLayout(false);
            this.tabCalculate.PerformLayout();
            this.tabFormulas.ResumeLayout(false);
            this.tabFormulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.LiveChart.ResumeLayout(false);
            this.LiveChart.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continousCompoundingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl cartesianchart2;
        private System.Windows.Forms.TabPage tabCalculate;
        private System.Windows.Forms.TabPage tabFormulas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.Label lblPV;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TxtLeftMargin;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TxtTopMargin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.ListBox ViewHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage LiveChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.BindingSource continousCompoundingBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtTimePeriod;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txttimescompounded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}

