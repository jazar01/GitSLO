using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
