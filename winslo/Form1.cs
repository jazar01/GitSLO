﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenderListOptimizer;


namespace winslo
{
    public partial class Form1 : Form
    {
        public string SafeSendersFileName;
        public string BlockedSendersFileName;
        public Form1()
        {
            InitializeComponent();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSafeSendersFile_click(object sender, EventArgs e)
        {
            openFileDialog1.FileName="SafeSendersList.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                SafeSendersFileName = openFileDialog1.FileName;
                txtSafeSendersList.Text = openFileDialog1.FileName;
            }
        }

        private void btnBlockedSendersFile_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BlockedSendersFileName = openFileDialog1.FileName;
                txtBlockedSendersList.Text = openFileDialog1.FileName;
            }
        }

        private void btnGo_click(object sender, EventArgs e)
        {
            SendersList sl = new SendersList(SafeSendersFileName, "");
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Email";
            column1.Name = "Email";
            dataGridView1.Columns.Add(column1);

            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Local";
            column2.Name = "Local";
            dataGridView1.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "domain";
            column3.Name = "Domain";      
            dataGridView1.Columns.Add(column3);

            DataGridViewColumn column4 = new DataGridViewCheckBoxColumn();
            column4.DataPropertyName = "PublicID";
            column4.Name = "Public";
            dataGridView1.Columns.Add(column4);

            dataGridView1.DataSource = sl.Senders;
           
            dataGridView1.Show();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
