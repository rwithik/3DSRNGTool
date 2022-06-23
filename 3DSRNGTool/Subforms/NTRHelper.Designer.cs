namespace Pk3DSRNGTool
{
    partial class NTRHelper
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
            ntrclient?.disconnect();
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
            this.B_OneClick = new System.Windows.Forms.Button();
            this.L_NTRLog = new System.Windows.Forms.Label();
            this.B_Disconnect = new System.Windows.Forms.Button();
            this.B_Connect = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.NTR_Timer = new System.Windows.Forms.Timer(this.components);
            this.B_Help = new System.Windows.Forms.Button();
            this.JPN = new System.Windows.Forms.CheckBox();
            this.L_Speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopFrame = new System.Windows.Forms.NumericUpDown();
            this.StartFrame = new System.Windows.Forms.NumericUpDown();
            this.B_Start = new System.Windows.Forms.Button();
            this.B_B = new System.Windows.Forms.Button();
            this.B_MashA = new System.Windows.Forms.Button();
            this.B_A = new System.Windows.Forms.Button();
            this.B_Stop = new System.Windows.Forms.Button();
            this.B_Begin = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.ORAS_Button = new System.Windows.Forms.RadioButton();
            this.XY_Button = new System.Windows.Forms.RadioButton();
            this.L_Count = new System.Windows.Forms.Label();
            this.L_Reseed = new System.Windows.Forms.Label();
            this.SeedDelay5 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay4 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay3 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay2 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay1 = new System.Windows.Forms.NumericUpDown();
            this.BotList = new System.Windows.Forms.TabControl();
            this.SeedTab = new System.Windows.Forms.TabPage();
            this.IDTab = new System.Windows.Forms.TabPage();
            this.L_ID_Adv = new System.Windows.Forms.Label();
            this.L_Delay_1 = new System.Windows.Forms.Label();
            this.L_Delay_2 = new System.Windows.Forms.Label();
            this.L_Delay_3 = new System.Windows.Forms.Label();
            this.L_Delay_4 = new System.Windows.Forms.Label();
            this.L_Delay_5 = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StopFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay1)).BeginInit();
            this.BotList.SuspendLayout();
            this.SeedTab.SuspendLayout();
            this.IDTab.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_OneClick
            // 
            this.B_OneClick.Location = new System.Drawing.Point(184, 34);
            this.B_OneClick.Name = "B_OneClick";
            this.B_OneClick.Size = new System.Drawing.Size(143, 25);
            this.B_OneClick.TabIndex = 120;
            this.B_OneClick.Text = "One Click";
            this.B_OneClick.UseVisualStyleBackColor = true;
            this.B_OneClick.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // L_NTRLog
            // 
            this.L_NTRLog.AutoSize = true;
            this.L_NTRLog.Location = new System.Drawing.Point(276, 80);
            this.L_NTRLog.Name = "L_NTRLog";
            this.L_NTRLog.Size = new System.Drawing.Size(38, 13);
            this.L_NTRLog.TabIndex = 116;
            this.L_NTRLog.Text = "Ready";
            // 
            // B_Disconnect
            // 
            this.B_Disconnect.Enabled = false;
            this.B_Disconnect.Location = new System.Drawing.Point(184, 74);
            this.B_Disconnect.Name = "B_Disconnect";
            this.B_Disconnect.Size = new System.Drawing.Size(69, 25);
            this.B_Disconnect.TabIndex = 117;
            this.B_Disconnect.Text = "Disconnect";
            this.B_Disconnect.UseVisualStyleBackColor = true;
            this.B_Disconnect.Click += new System.EventHandler(this.B_Disconnect_Click);
            // 
            // B_Connect
            // 
            this.B_Connect.Location = new System.Drawing.Point(94, 74);
            this.B_Connect.Name = "B_Connect";
            this.B_Connect.Size = new System.Drawing.Size(69, 25);
            this.B_Connect.TabIndex = 114;
            this.B_Connect.Text = "Connect";
            this.B_Connect.UseVisualStyleBackColor = true;
            this.B_Connect.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 113;
            this.label18.Text = "IP";
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(68, 36);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(102, 22);
            this.IP.TabIndex = 112;
            this.IP.Text = "192.168.0.1";
            // 
            // NTR_Timer
            // 
            this.NTR_Timer.Tick += new System.EventHandler(this.NTRTick);
            // 
            // B_Help
            // 
            this.B_Help.Image = global::Pk3DSRNGTool.Properties.Resources.Info;
            this.B_Help.Location = new System.Drawing.Point(333, 34);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(27, 25);
            this.B_Help.TabIndex = 121;
            this.B_Help.UseVisualStyleBackColor = true;
            this.B_Help.Click += new System.EventHandler(this.B_Help_Click);
            // 
            // JPN
            // 
            this.JPN.AutoSize = true;
            this.JPN.Location = new System.Drawing.Point(20, 112);
            this.JPN.Name = "JPN";
            this.JPN.Size = new System.Drawing.Size(46, 17);
            this.JPN.TabIndex = 126;
            this.JPN.Text = "JPN";
            this.JPN.UseVisualStyleBackColor = true;
            // 
            // L_Speed
            // 
            this.L_Speed.AutoSize = true;
            this.L_Speed.Location = new System.Drawing.Point(17, 73);
            this.L_Speed.Name = "L_Speed";
            this.L_Speed.Size = new System.Drawing.Size(57, 13);
            this.L_Speed.TabIndex = 123;
            this.L_Speed.Text = "Bot Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "->";
            // 
            // StopFrame
            // 
            this.StopFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopFrame.Location = new System.Drawing.Point(185, 25);
            this.StopFrame.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.StopFrame.Name = "StopFrame";
            this.StopFrame.Size = new System.Drawing.Size(73, 22);
            this.StopFrame.TabIndex = 99;
            this.StopFrame.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // StartFrame
            // 
            this.StartFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFrame.Location = new System.Drawing.Point(88, 25);
            this.StartFrame.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.StartFrame.Name = "StartFrame";
            this.StartFrame.Size = new System.Drawing.Size(75, 22);
            this.StartFrame.TabIndex = 98;
            this.StartFrame.Value = new decimal(new int[] {
            1012,
            0,
            0,
            0});
            // 
            // B_Start
            // 
            this.B_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Start.Location = new System.Drawing.Point(195, 24);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(75, 24);
            this.B_Start.TabIndex = 128;
            this.B_Start.Text = "Start";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click_1);
            // 
            // B_B
            // 
            this.B_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_B.Location = new System.Drawing.Point(163, 24);
            this.B_B.Name = "B_B";
            this.B_B.Size = new System.Drawing.Size(26, 25);
            this.B_B.TabIndex = 127;
            this.B_B.Text = "B";
            this.B_B.UseVisualStyleBackColor = true;
            this.B_B.Click += new System.EventHandler(this.B_B_Click);
            // 
            // B_MashA
            // 
            this.B_MashA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_MashA.Location = new System.Drawing.Point(50, 25);
            this.B_MashA.Name = "B_MashA";
            this.B_MashA.Size = new System.Drawing.Size(75, 25);
            this.B_MashA.TabIndex = 125;
            this.B_MashA.Text = "Mash A";
            this.B_MashA.UseVisualStyleBackColor = true;
            this.B_MashA.Click += new System.EventHandler(this.B_MashA_Click);
            // 
            // B_A
            // 
            this.B_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_A.Location = new System.Drawing.Point(131, 24);
            this.B_A.Name = "B_A";
            this.B_A.Size = new System.Drawing.Size(26, 25);
            this.B_A.TabIndex = 123;
            this.B_A.Text = "A";
            this.B_A.UseVisualStyleBackColor = true;
            this.B_A.Click += new System.EventHandler(this.B_A_Click);
            // 
            // B_Stop
            // 
            this.B_Stop.Enabled = false;
            this.B_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Stop.Location = new System.Drawing.Point(203, 385);
            this.B_Stop.Name = "B_Stop";
            this.B_Stop.Size = new System.Drawing.Size(75, 30);
            this.B_Stop.TabIndex = 124;
            this.B_Stop.Text = "Stop";
            this.B_Stop.UseVisualStyleBackColor = true;
            this.B_Stop.Click += new System.EventHandler(this.B_Stop_Click);
            // 
            // B_Begin
            // 
            this.B_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Begin.Location = new System.Drawing.Point(122, 385);
            this.B_Begin.Name = "B_Begin";
            this.B_Begin.Size = new System.Drawing.Size(75, 30);
            this.B_Begin.TabIndex = 123;
            this.B_Begin.Text = "Begin";
            this.B_Begin.UseVisualStyleBackColor = true;
            this.B_Begin.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(88, 71);
            this.Speed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(32, 20);
            this.Speed.TabIndex = 125;
            this.Speed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ORAS_Button
            // 
            this.ORAS_Button.AutoSize = true;
            this.ORAS_Button.Location = new System.Drawing.Point(240, 14);
            this.ORAS_Button.Name = "ORAS_Button";
            this.ORAS_Button.Size = new System.Drawing.Size(55, 17);
            this.ORAS_Button.TabIndex = 132;
            this.ORAS_Button.Text = "ORAS";
            this.ORAS_Button.UseVisualStyleBackColor = true;
            // 
            // XY_Button
            // 
            this.XY_Button.AutoSize = true;
            this.XY_Button.Checked = true;
            this.XY_Button.Location = new System.Drawing.Point(179, 14);
            this.XY_Button.Name = "XY_Button";
            this.XY_Button.Size = new System.Drawing.Size(39, 17);
            this.XY_Button.TabIndex = 131;
            this.XY_Button.TabStop = true;
            this.XY_Button.Text = "XY";
            this.XY_Button.UseVisualStyleBackColor = true;
            this.XY_Button.CheckedChanged += new System.EventHandler(this.XY_Button_CheckedChanged);
            // 
            // L_Count
            // 
            this.L_Count.AutoSize = true;
            this.L_Count.Location = new System.Drawing.Point(268, 67);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(13, 13);
            this.L_Count.TabIndex = 6;
            this.L_Count.Text = "0";
            // 
            // L_Reseed
            // 
            this.L_Reseed.AutoSize = true;
            this.L_Reseed.Location = new System.Drawing.Point(189, 67);
            this.L_Reseed.Name = "L_Reseed";
            this.L_Reseed.Size = new System.Drawing.Size(81, 13);
            this.L_Reseed.TabIndex = 5;
            this.L_Reseed.Text = "Reseed Count: ";
            // 
            // SeedDelay5
            // 
            this.SeedDelay5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay5.Location = new System.Drawing.Point(95, 121);
            this.SeedDelay5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SeedDelay5.Name = "SeedDelay5";
            this.SeedDelay5.Size = new System.Drawing.Size(55, 22);
            this.SeedDelay5.TabIndex = 4;
            this.SeedDelay5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SeedDelay4
            // 
            this.SeedDelay4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay4.Location = new System.Drawing.Point(95, 93);
            this.SeedDelay4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SeedDelay4.Name = "SeedDelay4";
            this.SeedDelay4.Size = new System.Drawing.Size(55, 22);
            this.SeedDelay4.TabIndex = 3;
            this.SeedDelay4.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // SeedDelay3
            // 
            this.SeedDelay3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay3.Location = new System.Drawing.Point(95, 65);
            this.SeedDelay3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SeedDelay3.Name = "SeedDelay3";
            this.SeedDelay3.Size = new System.Drawing.Size(55, 22);
            this.SeedDelay3.TabIndex = 2;
            this.SeedDelay3.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // SeedDelay2
            // 
            this.SeedDelay2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay2.Location = new System.Drawing.Point(95, 37);
            this.SeedDelay2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SeedDelay2.Name = "SeedDelay2";
            this.SeedDelay2.Size = new System.Drawing.Size(55, 22);
            this.SeedDelay2.TabIndex = 1;
            this.SeedDelay2.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            // 
            // SeedDelay1
            // 
            this.SeedDelay1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay1.Location = new System.Drawing.Point(95, 9);
            this.SeedDelay1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SeedDelay1.Name = "SeedDelay1";
            this.SeedDelay1.Size = new System.Drawing.Size(55, 22);
            this.SeedDelay1.TabIndex = 0;
            this.SeedDelay1.Value = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            // 
            // BotList
            // 
            this.BotList.Controls.Add(this.SeedTab);
            this.BotList.Controls.Add(this.IDTab);
            this.BotList.Location = new System.Drawing.Point(40, 118);
            this.BotList.Name = "BotList";
            this.BotList.SelectedIndex = 0;
            this.BotList.Size = new System.Drawing.Size(326, 178);
            this.BotList.TabIndex = 132;
            // 
            // SeedTab
            // 
            this.SeedTab.Controls.Add(this.ORAS_Button);
            this.SeedTab.Controls.Add(this.L_Delay_5);
            this.SeedTab.Controls.Add(this.XY_Button);
            this.SeedTab.Controls.Add(this.L_Delay_4);
            this.SeedTab.Controls.Add(this.L_Delay_3);
            this.SeedTab.Controls.Add(this.L_Delay_2);
            this.SeedTab.Controls.Add(this.L_Delay_1);
            this.SeedTab.Controls.Add(this.SeedDelay4);
            this.SeedTab.Controls.Add(this.SeedDelay1);
            this.SeedTab.Controls.Add(this.L_Count);
            this.SeedTab.Controls.Add(this.SeedDelay2);
            this.SeedTab.Controls.Add(this.L_Reseed);
            this.SeedTab.Controls.Add(this.SeedDelay3);
            this.SeedTab.Controls.Add(this.SeedDelay5);
            this.SeedTab.Location = new System.Drawing.Point(4, 22);
            this.SeedTab.Name = "SeedTab";
            this.SeedTab.Padding = new System.Windows.Forms.Padding(3);
            this.SeedTab.Size = new System.Drawing.Size(318, 152);
            this.SeedTab.TabIndex = 0;
            this.SeedTab.Text = "Seed Bot";
            this.SeedTab.UseVisualStyleBackColor = true;
            // 
            // IDTab
            // 
            this.IDTab.Controls.Add(this.L_ID_Adv);
            this.IDTab.Controls.Add(this.JPN);
            this.IDTab.Controls.Add(this.StopFrame);
            this.IDTab.Controls.Add(this.Speed);
            this.IDTab.Controls.Add(this.StartFrame);
            this.IDTab.Controls.Add(this.label1);
            this.IDTab.Controls.Add(this.L_Speed);
            this.IDTab.Location = new System.Drawing.Point(4, 22);
            this.IDTab.Name = "IDTab";
            this.IDTab.Padding = new System.Windows.Forms.Padding(3);
            this.IDTab.Size = new System.Drawing.Size(318, 152);
            this.IDTab.TabIndex = 1;
            this.IDTab.Text = "ID Bot";
            this.IDTab.UseVisualStyleBackColor = true;
            // 
            // L_ID_Adv
            // 
            this.L_ID_Adv.AutoSize = true;
            this.L_ID_Adv.Location = new System.Drawing.Point(17, 27);
            this.L_ID_Adv.Name = "L_ID_Adv";
            this.L_ID_Adv.Size = new System.Drawing.Size(55, 13);
            this.L_ID_Adv.TabIndex = 127;
            this.L_ID_Adv.Text = "Advances";
            // 
            // L_Delay_1
            // 
            this.L_Delay_1.AutoSize = true;
            this.L_Delay_1.Location = new System.Drawing.Point(31, 11);
            this.L_Delay_1.Name = "L_Delay_1";
            this.L_Delay_1.Size = new System.Drawing.Size(43, 13);
            this.L_Delay_1.TabIndex = 7;
            this.L_Delay_1.Text = "Delay 1";
            // 
            // L_Delay_2
            // 
            this.L_Delay_2.AutoSize = true;
            this.L_Delay_2.Location = new System.Drawing.Point(31, 39);
            this.L_Delay_2.Name = "L_Delay_2";
            this.L_Delay_2.Size = new System.Drawing.Size(43, 13);
            this.L_Delay_2.TabIndex = 8;
            this.L_Delay_2.Text = "Delay 2";
            // 
            // L_Delay_3
            // 
            this.L_Delay_3.AutoSize = true;
            this.L_Delay_3.Location = new System.Drawing.Point(31, 67);
            this.L_Delay_3.Name = "L_Delay_3";
            this.L_Delay_3.Size = new System.Drawing.Size(43, 13);
            this.L_Delay_3.TabIndex = 9;
            this.L_Delay_3.Text = "Delay 3";
            // 
            // L_Delay_4
            // 
            this.L_Delay_4.AutoSize = true;
            this.L_Delay_4.Location = new System.Drawing.Point(31, 95);
            this.L_Delay_4.Name = "L_Delay_4";
            this.L_Delay_4.Size = new System.Drawing.Size(43, 13);
            this.L_Delay_4.TabIndex = 10;
            this.L_Delay_4.Text = "Delay 4";
            // 
            // L_Delay_5
            // 
            this.L_Delay_5.AutoSize = true;
            this.L_Delay_5.Location = new System.Drawing.Point(31, 123);
            this.L_Delay_5.Name = "L_Delay_5";
            this.L_Delay_5.Size = new System.Drawing.Size(43, 13);
            this.L_Delay_5.TabIndex = 11;
            this.L_Delay_5.Text = "Delay 5";
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.B_MashA);
            this.ButtonGroupBox.Controls.Add(this.B_A);
            this.ButtonGroupBox.Controls.Add(this.B_Start);
            this.ButtonGroupBox.Controls.Add(this.B_B);
            this.ButtonGroupBox.Location = new System.Drawing.Point(40, 302);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Size = new System.Drawing.Size(324, 67);
            this.ButtonGroupBox.TabIndex = 133;
            this.ButtonGroupBox.TabStop = false;
            this.ButtonGroupBox.Text = "Buttons";
            // 
            // NTRHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 436);
            this.Controls.Add(this.ButtonGroupBox);
            this.Controls.Add(this.BotList);
            this.Controls.Add(this.B_Stop);
            this.Controls.Add(this.B_Help);
            this.Controls.Add(this.B_Begin);
            this.Controls.Add(this.B_OneClick);
            this.Controls.Add(this.L_NTRLog);
            this.Controls.Add(this.B_Disconnect);
            this.Controls.Add(this.B_Connect);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.IP);
            this.MaximumSize = new System.Drawing.Size(430, 475);
            this.MinimumSize = new System.Drawing.Size(430, 475);
            this.Name = "NTRHelper";
            this.Text = "NTRHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NTRHelper_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StopFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay1)).EndInit();
            this.BotList.ResumeLayout(false);
            this.SeedTab.ResumeLayout(false);
            this.SeedTab.PerformLayout();
            this.IDTab.ResumeLayout(false);
            this.IDTab.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OneClick;
        private System.Windows.Forms.Label L_NTRLog;
        private System.Windows.Forms.Button B_Disconnect;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Timer NTR_Timer;
        private System.Windows.Forms.Button B_Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StopFrame;
        private System.Windows.Forms.NumericUpDown StartFrame;
        private System.Windows.Forms.Button B_Stop;
        private System.Windows.Forms.Button B_Begin;
        private System.Windows.Forms.Label L_Speed;
        private System.Windows.Forms.Button B_A;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.Button B_MashA;
        private System.Windows.Forms.CheckBox JPN;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Button B_B;
        private System.Windows.Forms.NumericUpDown SeedDelay5;
        private System.Windows.Forms.NumericUpDown SeedDelay4;
        private System.Windows.Forms.NumericUpDown SeedDelay3;
        private System.Windows.Forms.NumericUpDown SeedDelay2;
        private System.Windows.Forms.NumericUpDown SeedDelay1;
        private System.Windows.Forms.Label L_Reseed;
        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.RadioButton ORAS_Button;
        private System.Windows.Forms.RadioButton XY_Button;
        private System.Windows.Forms.TabControl BotList;
        private System.Windows.Forms.TabPage SeedTab;
        private System.Windows.Forms.Label L_Delay_5;
        private System.Windows.Forms.Label L_Delay_4;
        private System.Windows.Forms.Label L_Delay_3;
        private System.Windows.Forms.Label L_Delay_2;
        private System.Windows.Forms.Label L_Delay_1;
        private System.Windows.Forms.TabPage IDTab;
        private System.Windows.Forms.Label L_ID_Adv;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
    }
}