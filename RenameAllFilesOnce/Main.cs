using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RenameAllFilesOnce
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cmbTypeFrom.SelectedIndex = 0;
            cmbTypeTo.SelectedIndex = 0;
        }

        private void cmdRename_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,you want to rename files..!","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C ren " + cmbTypeFrom.Text + " " + cmbTypeTo.Text;
                process.StartInfo = startInfo;
                process.Start(); 
            }
        }
      
    }
}