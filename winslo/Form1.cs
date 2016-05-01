using System;
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
            SendersList sl = new SendersList(SafeSendersFileName, "publicdomains.txt");
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Email";
            column1.Name = "Email";
            column1.SortMode = DataGridViewColumnSortMode.Automatic;
            column1.Width = 300;
            dataGridView1.Columns.Add(column1);
            /* 
            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Local";
            column2.Name = "Local";
            column2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Domain";
            column3.Name = "Domain";
            column3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns.Add(column3);
            */
            DataGridViewColumn column4 = new DataGridViewCheckBoxColumn();
            column4.DataPropertyName = "PublicD";
            column4.Name = "Public";
            column4.SortMode = DataGridViewColumnSortMode.Automatic;
            column4.Width = 48;
            dataGridView1.Columns.Add(column4);

            dataGridView1.DataSource = sl.Senders;
           
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
