namespace winslo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBlockedSendersList = new System.Windows.Forms.Label();
            this.lblSafeSendersList = new System.Windows.Forms.Label();
            this.btnSelectBlockedSendersFile = new System.Windows.Forms.Button();
            this.btnSelectSafeSendersFile = new System.Windows.Forms.Button();
            this.txtBlockedSendersList = new System.Windows.Forms.TextBox();
            this.txtSafeSendersList = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "SafeSendersListFile";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.lblBlockedSendersList);
            this.panel1.Controls.Add(this.lblSafeSendersList);
            this.panel1.Controls.Add(this.btnSelectBlockedSendersFile);
            this.panel1.Controls.Add(this.btnSelectSafeSendersFile);
            this.panel1.Controls.Add(this.txtBlockedSendersList);
            this.panel1.Controls.Add(this.txtSafeSendersList);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 189);
            this.panel1.TabIndex = 1;
            // 
            // lblBlockedSendersList
            // 
            this.lblBlockedSendersList.AutoSize = true;
            this.lblBlockedSendersList.Location = new System.Drawing.Point(14, 93);
            this.lblBlockedSendersList.Name = "lblBlockedSendersList";
            this.lblBlockedSendersList.Size = new System.Drawing.Size(159, 20);
            this.lblBlockedSendersList.TabIndex = 2;
            this.lblBlockedSendersList.Text = "Blocked Senders List";
            // 
            // lblSafeSendersList
            // 
            this.lblSafeSendersList.AutoSize = true;
            this.lblSafeSendersList.Location = new System.Drawing.Point(32, 32);
            this.lblSafeSendersList.Name = "lblSafeSendersList";
            this.lblSafeSendersList.Size = new System.Drawing.Size(136, 20);
            this.lblSafeSendersList.TabIndex = 2;
            this.lblSafeSendersList.Text = "Safe Senders List";
            // 
            // btnSelectBlockedSendersFile
            // 
            this.btnSelectBlockedSendersFile.Location = new System.Drawing.Point(660, 88);
            this.btnSelectBlockedSendersFile.Name = "btnSelectBlockedSendersFile";
            this.btnSelectBlockedSendersFile.Size = new System.Drawing.Size(159, 31);
            this.btnSelectBlockedSendersFile.TabIndex = 1;
            this.btnSelectBlockedSendersFile.Text = "Select File...";
            this.btnSelectBlockedSendersFile.UseVisualStyleBackColor = true;
            this.btnSelectBlockedSendersFile.Click += new System.EventHandler(this.btnBlockedSendersFile_click);
            // 
            // btnSelectSafeSendersFile
            // 
            this.btnSelectSafeSendersFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectSafeSendersFile.Location = new System.Drawing.Point(663, 27);
            this.btnSelectSafeSendersFile.Name = "btnSelectSafeSendersFile";
            this.btnSelectSafeSendersFile.Size = new System.Drawing.Size(159, 31);
            this.btnSelectSafeSendersFile.TabIndex = 1;
            this.btnSelectSafeSendersFile.Text = "Select File...";
            this.btnSelectSafeSendersFile.UseVisualStyleBackColor = true;
            this.btnSelectSafeSendersFile.Click += new System.EventHandler(this.btnSafeSendersFile_click);
            // 
            // txtBlockedSendersList
            // 
            this.txtBlockedSendersList.Location = new System.Drawing.Point(174, 90);
            this.txtBlockedSendersList.Name = "txtBlockedSendersList";
            this.txtBlockedSendersList.Size = new System.Drawing.Size(465, 26);
            this.txtBlockedSendersList.TabIndex = 0;
            // 
            // txtSafeSendersList
            // 
            this.txtSafeSendersList.Location = new System.Drawing.Point(174, 29);
            this.txtSafeSendersList.Name = "txtSafeSendersList";
            this.txtSafeSendersList.Size = new System.Drawing.Size(465, 26);
            this.txtSafeSendersList.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(852, 459);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmailAddress";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sender";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Domain";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(660, 145);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(159, 29);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 769);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WinSLO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectSafeSendersFile;
        private System.Windows.Forms.TextBox txtSafeSendersList;
        private System.Windows.Forms.Label lblSafeSendersList;
        private System.Windows.Forms.Label lblBlockedSendersList;
        private System.Windows.Forms.Button btnSelectBlockedSendersFile;
        private System.Windows.Forms.TextBox txtBlockedSendersList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnGo;
    }
}