namespace caseledstripcontrol
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_prev = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_cmd_1 = new System.Windows.Forms.Button();
            this.bt_cmd_2 = new System.Windows.Forms.Button();
            this.bt_cmd_3 = new System.Windows.Forms.Button();
            this.bt_cmd_4 = new System.Windows.Forms.Button();
            this.bt_cmd_5 = new System.Windows.Forms.Button();
            this.bt_cmd_6 = new System.Windows.Forms.Button();
            this.bt_cmd_12 = new System.Windows.Forms.Button();
            this.bt_cmd_11 = new System.Windows.Forms.Button();
            this.bt_cmd_10 = new System.Windows.Forms.Button();
            this.bt_cmd_9 = new System.Windows.Forms.Button();
            this.bt_cmd_8 = new System.Windows.Forms.Button();
            this.bt_cmd_7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cycle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxCOMList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConnectCOM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_manualControl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_cmd_0 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // bt_prev
            // 
            this.bt_prev.Location = new System.Drawing.Point(14, 152);
            this.bt_prev.Name = "bt_prev";
            this.bt_prev.Size = new System.Drawing.Size(75, 23);
            this.bt_prev.TabIndex = 0;
            this.bt_prev.Text = "prev";
            this.bt_prev.UseVisualStyleBackColor = true;
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(95, 152);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 1;
            this.bt_next.Text = "next";
            this.bt_next.UseVisualStyleBackColor = true;
            // 
            // bt_cmd_1
            // 
            this.bt_cmd_1.Location = new System.Drawing.Point(12, 264);
            this.bt_cmd_1.Name = "bt_cmd_1";
            this.bt_cmd_1.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_1.TabIndex = 2;
            this.bt_cmd_1.Text = "1";
            this.bt_cmd_1.UseVisualStyleBackColor = true;
            this.bt_cmd_1.Click += new System.EventHandler(this.bt_cmd_1_Click);
            // 
            // bt_cmd_2
            // 
            this.bt_cmd_2.Location = new System.Drawing.Point(12, 289);
            this.bt_cmd_2.MaximumSize = new System.Drawing.Size(29, 23);
            this.bt_cmd_2.MinimumSize = new System.Drawing.Size(29, 23);
            this.bt_cmd_2.Name = "bt_cmd_2";
            this.bt_cmd_2.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_2.TabIndex = 3;
            this.bt_cmd_2.Text = "2";
            this.bt_cmd_2.UseVisualStyleBackColor = true;
            this.bt_cmd_2.Click += new System.EventHandler(this.bt_cmd_2_Click);
            // 
            // bt_cmd_3
            // 
            this.bt_cmd_3.Location = new System.Drawing.Point(12, 314);
            this.bt_cmd_3.Name = "bt_cmd_3";
            this.bt_cmd_3.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_3.TabIndex = 4;
            this.bt_cmd_3.Text = "3";
            this.bt_cmd_3.UseVisualStyleBackColor = true;
            this.bt_cmd_3.Click += new System.EventHandler(this.bt_cmd_3_Click);
            // 
            // bt_cmd_4
            // 
            this.bt_cmd_4.Location = new System.Drawing.Point(12, 339);
            this.bt_cmd_4.Name = "bt_cmd_4";
            this.bt_cmd_4.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_4.TabIndex = 5;
            this.bt_cmd_4.Text = "4";
            this.bt_cmd_4.UseVisualStyleBackColor = true;
            this.bt_cmd_4.Click += new System.EventHandler(this.bt_cmd_4_Click);
            // 
            // bt_cmd_5
            // 
            this.bt_cmd_5.Location = new System.Drawing.Point(12, 364);
            this.bt_cmd_5.Name = "bt_cmd_5";
            this.bt_cmd_5.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_5.TabIndex = 6;
            this.bt_cmd_5.Text = "5";
            this.bt_cmd_5.UseVisualStyleBackColor = true;
            this.bt_cmd_5.Click += new System.EventHandler(this.bt_cmd_5_Click);
            // 
            // bt_cmd_6
            // 
            this.bt_cmd_6.Location = new System.Drawing.Point(12, 389);
            this.bt_cmd_6.Name = "bt_cmd_6";
            this.bt_cmd_6.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_6.TabIndex = 7;
            this.bt_cmd_6.Text = "6";
            this.bt_cmd_6.UseVisualStyleBackColor = true;
            this.bt_cmd_6.Click += new System.EventHandler(this.bt_cmd_6_Click);
            // 
            // bt_cmd_12
            // 
            this.bt_cmd_12.Location = new System.Drawing.Point(12, 539);
            this.bt_cmd_12.Name = "bt_cmd_12";
            this.bt_cmd_12.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_12.TabIndex = 13;
            this.bt_cmd_12.Text = "12";
            this.bt_cmd_12.UseVisualStyleBackColor = true;
            this.bt_cmd_12.Click += new System.EventHandler(this.bt_cmd_12_Click);
            // 
            // bt_cmd_11
            // 
            this.bt_cmd_11.Location = new System.Drawing.Point(12, 514);
            this.bt_cmd_11.Name = "bt_cmd_11";
            this.bt_cmd_11.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_11.TabIndex = 12;
            this.bt_cmd_11.Text = "11";
            this.bt_cmd_11.UseVisualStyleBackColor = true;
            this.bt_cmd_11.Click += new System.EventHandler(this.bt_cmd_11_Click);
            // 
            // bt_cmd_10
            // 
            this.bt_cmd_10.Location = new System.Drawing.Point(12, 489);
            this.bt_cmd_10.Name = "bt_cmd_10";
            this.bt_cmd_10.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_10.TabIndex = 11;
            this.bt_cmd_10.Text = "10";
            this.bt_cmd_10.UseVisualStyleBackColor = true;
            this.bt_cmd_10.Click += new System.EventHandler(this.bt_cmd_10_Click);
            // 
            // bt_cmd_9
            // 
            this.bt_cmd_9.Location = new System.Drawing.Point(12, 464);
            this.bt_cmd_9.Name = "bt_cmd_9";
            this.bt_cmd_9.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_9.TabIndex = 10;
            this.bt_cmd_9.Text = "9";
            this.bt_cmd_9.UseVisualStyleBackColor = true;
            this.bt_cmd_9.Click += new System.EventHandler(this.bt_cmd_9_Click);
            // 
            // bt_cmd_8
            // 
            this.bt_cmd_8.Location = new System.Drawing.Point(12, 439);
            this.bt_cmd_8.Name = "bt_cmd_8";
            this.bt_cmd_8.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_8.TabIndex = 9;
            this.bt_cmd_8.Text = "8";
            this.bt_cmd_8.UseVisualStyleBackColor = true;
            this.bt_cmd_8.Click += new System.EventHandler(this.bt_cmd_8_Click);
            // 
            // bt_cmd_7
            // 
            this.bt_cmd_7.Location = new System.Drawing.Point(12, 414);
            this.bt_cmd_7.Name = "bt_cmd_7";
            this.bt_cmd_7.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_7.TabIndex = 8;
            this.bt_cmd_7.Text = "7";
            this.bt_cmd_7.UseVisualStyleBackColor = true;
            this.bt_cmd_7.Click += new System.EventHandler(this.bt_cmd_7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 183);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "sec";
            // 
            // bt_cycle
            // 
            this.bt_cycle.Location = new System.Drawing.Point(95, 181);
            this.bt_cycle.Name = "bt_cycle";
            this.bt_cycle.Size = new System.Drawing.Size(75, 23);
            this.bt_cycle.TabIndex = 16;
            this.bt_cycle.Text = "cycle";
            this.bt_cycle.UseVisualStyleBackColor = true;
            this.bt_cycle.Click += new System.EventHandler(this.bt_cycle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 58);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "controls arduino connected over usb with stripcontrol ws2811/2812 firmware with s" +
    "erial commands";
            // 
            // comboBoxCOMList
            // 
            this.comboBoxCOMList.FormattingEnabled = true;
            this.comboBoxCOMList.Location = new System.Drawing.Point(66, 87);
            this.comboBoxCOMList.Name = "comboBoxCOMList";
            this.comboBoxCOMList.Size = new System.Drawing.Size(80, 21);
            this.comboBoxCOMList.Sorted = true;
            this.comboBoxCOMList.TabIndex = 18;
            this.comboBoxCOMList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Com- Port";
            // 
            // btConnectCOM
            // 
            this.btConnectCOM.Location = new System.Drawing.Point(66, 114);
            this.btConnectCOM.Name = "btConnectCOM";
            this.btConnectCOM.Size = new System.Drawing.Size(75, 23);
            this.btConnectCOM.TabIndex = 20;
            this.btConnectCOM.Text = "connect";
            this.btConnectCOM.UseVisualStyleBackColor = true;
            this.btConnectCOM.Click += new System.EventHandler(this.buttonConnectCOM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "constatus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "NC";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(9, 86);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(55, 23);
            this.btRefresh.TabIndex = 23;
            this.btRefresh.Text = "refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.button17_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(153, 566);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(34, 13);
            this.labelVersion.TabIndex = 24;
            this.labelVersion.Text = "v0.02";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stripcontrol Application Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Stripcontrol Firmware Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "N/A";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bt_manualControl
            // 
            this.bt_manualControl.Location = new System.Drawing.Point(13, 210);
            this.bt_manualControl.Name = "bt_manualControl";
            this.bt_manualControl.Size = new System.Drawing.Size(117, 23);
            this.bt_manualControl.TabIndex = 28;
            this.bt_manualControl.Text = "open manual control";
            this.bt_manualControl.UseVisualStyleBackColor = true;
            this.bt_manualControl.Click += new System.EventHandler(this.bt_manualControl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "boot";
            // 
            // bt_cmd_0
            // 
            this.bt_cmd_0.Location = new System.Drawing.Point(12, 239);
            this.bt_cmd_0.Name = "bt_cmd_0";
            this.bt_cmd_0.Size = new System.Drawing.Size(29, 23);
            this.bt_cmd_0.TabIndex = 30;
            this.bt_cmd_0.Text = "0";
            this.bt_cmd_0.UseVisualStyleBackColor = true;
            this.bt_cmd_0.Click += new System.EventHandler(this.bt_cmd_0_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "white";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "rainbow";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "rainbowwithGlitter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "confetti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "sinelon";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "juggle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "bpm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "black";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 469);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "razerRainbow";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "CaseLedstripControl";
            this.notifyIcon1.Text = "CaseLedstripControl";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 590);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_cmd_0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_manualControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConnectCOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCOMList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_cycle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_cmd_12);
            this.Controls.Add(this.bt_cmd_11);
            this.Controls.Add(this.bt_cmd_10);
            this.Controls.Add(this.bt_cmd_9);
            this.Controls.Add(this.bt_cmd_8);
            this.Controls.Add(this.bt_cmd_7);
            this.Controls.Add(this.bt_cmd_6);
            this.Controls.Add(this.bt_cmd_5);
            this.Controls.Add(this.bt_cmd_4);
            this.Controls.Add(this.bt_cmd_3);
            this.Controls.Add(this.bt_cmd_2);
            this.Controls.Add(this.bt_cmd_1);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_prev);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "WS2812-CaseLedstripControl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_prev;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_cmd_1;
        private System.Windows.Forms.Button bt_cmd_2;
        private System.Windows.Forms.Button bt_cmd_3;
        private System.Windows.Forms.Button bt_cmd_4;
        private System.Windows.Forms.Button bt_cmd_5;
        private System.Windows.Forms.Button bt_cmd_6;
        private System.Windows.Forms.Button bt_cmd_12;
        private System.Windows.Forms.Button bt_cmd_11;
        private System.Windows.Forms.Button bt_cmd_10;
        private System.Windows.Forms.Button bt_cmd_9;
        private System.Windows.Forms.Button bt_cmd_8;
        private System.Windows.Forms.Button bt_cmd_7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cycle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxCOMList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConnectCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRefresh;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_manualControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_cmd_0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

