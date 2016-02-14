﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ardustripcontrol2811
{
    public partial class MainForm : Form
    {

        public String comSelected;
        public arduino arduino = new arduino();
        public bool connectionState = false;
        private manualLEDcontrol manualLEDcontrol = new manualLEDcontrol();



        public MainForm()
        {
            InitializeComponent();
            initializeCOMList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            form_Set_Actions(false);
            
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                if (arduino.isComPortOpen()) { arduino.CloseArduinoConnection(); }
       
        }

        private void form_Set_Actions(bool state)
        {
            bt_manualControl.Enabled = state;
            bt_cmd_1.Enabled = state;
            bt_cmd_2.Enabled = state;
            bt_cmd_3.Enabled = state;
            bt_cmd_4.Enabled = state;
            bt_cmd_5.Enabled = state;
            bt_cmd_6.Enabled = state;
            bt_cmd_7.Enabled = state;
            bt_cmd_8.Enabled = state;
            bt_cmd_9.Enabled = state;
            bt_cmd_10.Enabled = state;
            bt_cmd_11.Enabled = state;
            bt_cmd_12.Enabled = state;
            bt_cycle.Enabled = state;
            bt_next.Enabled = state;
            bt_prev.Enabled = state;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            comboBoxCOMList.Items.Clear();
            comboBoxCOMList.Items.AddRange(SerialPort.GetPortNames());
            //ToDo: change sorting
            comboBoxCOMList.SelectedIndex = 0;
            //comSelected = comboBoxCOMList.SelectedItem.ToString();
            Console.WriteLine("refreshing com-list");
           
        }

        private void initializeCOMList()
        {
            comboBoxCOMList.Items.Clear();
            comboBoxCOMList.Items.AddRange(SerialPort.GetPortNames());
            //ToDo: change sorting
            comboBoxCOMList.SelectedIndex = 0;
            //comSelected = comboBoxCOMList.SelectedItem.ToString();
            //Console.WriteLine(comSelected);
            
        }

        private void comboBoxCOMList_SelectedIndexChanged(object sender, EventArgs e)
        {
            comSelected = comboBoxCOMList.SelectedItem.ToString();
            //Console.WriteLine("index changed for com-list. new index = " + comboBoxCOMList.SelectedIndex + " entry = " + comSelected );
        }

        private void buttonConnectCOM_Click(object sender, EventArgs e)
        {
            if (!connectionState)
            {
                arduino.OpenArduinoConnection(comSelected);
                if (arduino.isComPortOpen())
                {
                    comboBoxCOMList.Enabled = false;
                    btConnectCOM.Text = "disconnect";
                    connectionState = true;
                    form_Set_Actions(true);
                }
            }
            else
            {
                arduino.CloseArduinoConnection();
                comboBoxCOMList.Enabled = true;
                btConnectCOM.Text = "connect";
                connectionState = false;
                form_Set_Actions(false);
            }
            
        }

        #region Buttons for Send Commands 0-12

        private void bt_cmd_0_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(00);
        }

        private void bt_cmd_1_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(01);
        }

        private void bt_cmd_2_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(02);
        }

        private void bt_cmd_3_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(03);
        }

        private void bt_cmd_4_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(04);
        }

        private void bt_cmd_5_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(05);
        }

        private void bt_cmd_6_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(06);
        }

        private void bt_cmd_7_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(07);
        }

        private void bt_cmd_8_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(08);
        }

        private void bt_cmd_9_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(09);
        }

        private void bt_cmd_10_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(10);
        }

        private void bt_cmd_11_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(11);
        }

        private void bt_cmd_12_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(12);
        }

        #endregion

        private void bt_manualControl_Click(object sender, EventArgs e)
        {
            if (!manualLEDcontrol.Visible) {
                
                form_Set_Actions(false);
                manualLEDcontrol.StartPosition = FormStartPosition.Manual;
                manualLEDcontrol.Left = (this.Left);
                manualLEDcontrol.Top =  (this.Top + 300);
                manualLEDcontrol.Show();

            }
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_cycle_Click(object sender, EventArgs e)
        {
            arduino.SCsendCommand(55);
        }
    }
}