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
            this.IDBot = new System.Windows.Forms.GroupBox();
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
            this.ID_R_Button = new System.Windows.Forms.RadioButton();
            this.Seed_R_Button = new System.Windows.Forms.RadioButton();
            this.SeedBOT = new System.Windows.Forms.GroupBox();
            this.ORAS_Button = new System.Windows.Forms.RadioButton();
            this.XY_Button = new System.Windows.Forms.RadioButton();
            this.L_Count = new System.Windows.Forms.Label();
            this.L_Reseed = new System.Windows.Forms.Label();
            this.SeedDelay5 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay4 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay3 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay2 = new System.Windows.Forms.NumericUpDown();
            this.SeedDelay1 = new System.Windows.Forms.NumericUpDown();
            this.IDBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.SeedBOT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_OneClick
            // 
            this.B_OneClick.Location = new System.Drawing.Point(188, 19);
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
            this.L_NTRLog.Location = new System.Drawing.Point(280, 65);
            this.L_NTRLog.Name = "L_NTRLog";
            this.L_NTRLog.Size = new System.Drawing.Size(38, 13);
            this.L_NTRLog.TabIndex = 116;
            this.L_NTRLog.Text = "Ready";
            // 
            // B_Disconnect
            // 
            this.B_Disconnect.Enabled = false;
            this.B_Disconnect.Location = new System.Drawing.Point(188, 59);
            this.B_Disconnect.Name = "B_Disconnect";
            this.B_Disconnect.Size = new System.Drawing.Size(69, 25);
            this.B_Disconnect.TabIndex = 117;
            this.B_Disconnect.Text = "Disconnect";
            this.B_Disconnect.UseVisualStyleBackColor = true;
            this.B_Disconnect.Click += new System.EventHandler(this.B_Disconnect_Click);
            // 
            // B_Connect
            // 
            this.B_Connect.Location = new System.Drawing.Point(98, 59);
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
            this.label18.Location = new System.Drawing.Point(49, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 113;
            this.label18.Text = "IP";
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(72, 21);
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
            this.B_Help.Location = new System.Drawing.Point(337, 19);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(27, 25);
            this.B_Help.TabIndex = 121;
            this.B_Help.UseVisualStyleBackColor = true;
            this.B_Help.Click += new System.EventHandler(this.B_Help_Click);
            // 
            // IDBot
            // 
            this.IDBot.Controls.Add(this.JPN);
            this.IDBot.Controls.Add(this.L_Speed);
            this.IDBot.Controls.Add(this.label1);
            this.IDBot.Controls.Add(this.StopFrame);
            this.IDBot.Controls.Add(this.StartFrame);
            this.IDBot.Enabled = false;
            this.IDBot.Location = new System.Drawing.Point(69, 90);
            this.IDBot.Name = "IDBot";
            this.IDBot.Size = new System.Drawing.Size(335, 77);
            this.IDBot.TabIndex = 122;
            this.IDBot.TabStop = false;
            this.IDBot.Text = "ID Bot";
            // 
            // JPN
            // 
            this.JPN.AutoSize = true;
            this.JPN.Location = new System.Drawing.Point(252, 0);
            this.JPN.Name = "JPN";
            this.JPN.Size = new System.Drawing.Size(46, 17);
            this.JPN.TabIndex = 126;
            this.JPN.Text = "JPN";
            this.JPN.UseVisualStyleBackColor = true;
            // 
            // L_Speed
            // 
            this.L_Speed.AutoSize = true;
            this.L_Speed.Location = new System.Drawing.Point(201, 32);
            this.L_Speed.Name = "L_Speed";
            this.L_Speed.Size = new System.Drawing.Size(57, 13);
            this.L_Speed.TabIndex = 123;
            this.L_Speed.Text = "Bot Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "->";
            // 
            // StopFrame
            // 
            this.StopFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopFrame.Location = new System.Drawing.Point(115, 28);
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
            this.StartFrame.Location = new System.Drawing.Point(18, 28);
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
            this.B_Start.Location = new System.Drawing.Point(297, 357);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(75, 24);
            this.B_Start.TabIndex = 128;
            this.B_Start.Text = "Start";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click_1);
            // 
            // B_B
            // 
            this.B_B.Location = new System.Drawing.Point(376, 356);
            this.B_B.Name = "B_B";
            this.B_B.Size = new System.Drawing.Size(26, 25);
            this.B_B.TabIndex = 127;
            this.B_B.Text = "B";
            this.B_B.UseVisualStyleBackColor = true;
            this.B_B.Click += new System.EventHandler(this.B_B_Click);
            // 
            // B_MashA
            // 
            this.B_MashA.Location = new System.Drawing.Point(297, 326);
            this.B_MashA.Name = "B_MashA";
            this.B_MashA.Size = new System.Drawing.Size(75, 25);
            this.B_MashA.TabIndex = 125;
            this.B_MashA.Text = "MashA";
            this.B_MashA.UseVisualStyleBackColor = true;
            this.B_MashA.Click += new System.EventHandler(this.B_MashA_Click);
            // 
            // B_A
            // 
            this.B_A.Location = new System.Drawing.Point(376, 326);
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
            this.B_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Stop.Location = new System.Drawing.Point(183, 326);
            this.B_Stop.Name = "B_Stop";
            this.B_Stop.Size = new System.Drawing.Size(108, 55);
            this.B_Stop.TabIndex = 124;
            this.B_Stop.Text = "Stop";
            this.B_Stop.UseVisualStyleBackColor = true;
            this.B_Stop.Click += new System.EventHandler(this.B_Stop_Click);
            // 
            // B_Begin
            // 
            this.B_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Begin.Location = new System.Drawing.Point(69, 326);
            this.B_Begin.Name = "B_Begin";
            this.B_Begin.Size = new System.Drawing.Size(108, 55);
            this.B_Begin.TabIndex = 123;
            this.B_Begin.Text = "Begin";
            this.B_Begin.UseVisualStyleBackColor = true;
            this.B_Begin.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(333, 119);
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
            // ID_R_Button
            // 
            this.ID_R_Button.AutoSize = true;
            this.ID_R_Button.Location = new System.Drawing.Point(12, 105);
            this.ID_R_Button.Name = "ID_R_Button";
            this.ID_R_Button.Size = new System.Drawing.Size(36, 17);
            this.ID_R_Button.TabIndex = 129;
            this.ID_R_Button.Text = "ID";
            this.ID_R_Button.UseVisualStyleBackColor = true;
            this.ID_R_Button.CheckedChanged += new System.EventHandler(this.ID_R_Button_CheckedChanged);
            // 
            // Seed_R_Button
            // 
            this.Seed_R_Button.AutoSize = true;
            this.Seed_R_Button.Checked = true;
            this.Seed_R_Button.Location = new System.Drawing.Point(12, 199);
            this.Seed_R_Button.Name = "Seed_R_Button";
            this.Seed_R_Button.Size = new System.Drawing.Size(50, 17);
            this.Seed_R_Button.TabIndex = 130;
            this.Seed_R_Button.TabStop = true;
            this.Seed_R_Button.Text = "Seed";
            this.Seed_R_Button.UseVisualStyleBackColor = true;
            // 
            // SeedBOT
            // 
            this.SeedBOT.Controls.Add(this.ORAS_Button);
            this.SeedBOT.Controls.Add(this.XY_Button);
            this.SeedBOT.Controls.Add(this.L_Count);
            this.SeedBOT.Controls.Add(this.L_Reseed);
            this.SeedBOT.Controls.Add(this.SeedDelay5);
            this.SeedBOT.Controls.Add(this.SeedDelay4);
            this.SeedBOT.Controls.Add(this.SeedDelay3);
            this.SeedBOT.Controls.Add(this.SeedDelay2);
            this.SeedBOT.Controls.Add(this.SeedDelay1);
            this.SeedBOT.Location = new System.Drawing.Point(69, 181);
            this.SeedBOT.Name = "SeedBOT";
            this.SeedBOT.Size = new System.Drawing.Size(335, 139);
            this.SeedBOT.TabIndex = 131;
            this.SeedBOT.TabStop = false;
            this.SeedBOT.Text = "Seed Bot";
            // 
            // ORAS_Button
            // 
            this.ORAS_Button.AutoSize = true;
            this.ORAS_Button.Location = new System.Drawing.Point(158, 18);
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
            this.XY_Button.Location = new System.Drawing.Point(97, 18);
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
            this.L_Count.Location = new System.Drawing.Point(301, 114);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(13, 13);
            this.L_Count.TabIndex = 6;
            this.L_Count.Text = "0";
            // 
            // L_Reseed
            // 
            this.L_Reseed.AutoSize = true;
            this.L_Reseed.Location = new System.Drawing.Point(217, 114);
            this.L_Reseed.Name = "L_Reseed";
            this.L_Reseed.Size = new System.Drawing.Size(81, 13);
            this.L_Reseed.TabIndex = 5;
            this.L_Reseed.Text = "Reseed Count: ";
            // 
            // SeedDelay5
            // 
            this.SeedDelay5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedDelay5.Location = new System.Drawing.Point(264, 68);
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
            this.SeedDelay4.Location = new System.Drawing.Point(203, 68);
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
            this.SeedDelay3.Location = new System.Drawing.Point(142, 68);
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
            this.SeedDelay2.Location = new System.Drawing.Point(81, 68);
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
            this.SeedDelay1.Location = new System.Drawing.Point(20, 68);
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
            // NTRHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 396);
            this.Controls.Add(this.SeedBOT);
            this.Controls.Add(this.Seed_R_Button);
            this.Controls.Add(this.ID_R_Button);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.B_MashA);
            this.Controls.Add(this.B_B);
            this.Controls.Add(this.B_A);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.IDBot);
            this.Controls.Add(this.B_Stop);
            this.Controls.Add(this.B_Help);
            this.Controls.Add(this.B_Begin);
            this.Controls.Add(this.B_OneClick);
            this.Controls.Add(this.L_NTRLog);
            this.Controls.Add(this.B_Disconnect);
            this.Controls.Add(this.B_Connect);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.IP);
            this.MaximumSize = new System.Drawing.Size(430, 435);
            this.MinimumSize = new System.Drawing.Size(430, 435);
            this.Name = "NTRHelper";
            this.Text = "NTRHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NTRHelper_FormClosing);
            this.IDBot.ResumeLayout(false);
            this.IDBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.SeedBOT.ResumeLayout(false);
            this.SeedBOT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedDelay1)).EndInit();
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
        private System.Windows.Forms.GroupBox IDBot;
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
        private System.Windows.Forms.RadioButton ID_R_Button;
        private System.Windows.Forms.RadioButton Seed_R_Button;
        private System.Windows.Forms.GroupBox SeedBOT;
        private System.Windows.Forms.NumericUpDown SeedDelay5;
        private System.Windows.Forms.NumericUpDown SeedDelay4;
        private System.Windows.Forms.NumericUpDown SeedDelay3;
        private System.Windows.Forms.NumericUpDown SeedDelay2;
        private System.Windows.Forms.NumericUpDown SeedDelay1;
        private System.Windows.Forms.Label L_Reseed;
        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.RadioButton ORAS_Button;
        private System.Windows.Forms.RadioButton XY_Button;
    }
}