using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DiskAccessLibrary.Win32;

namespace ISCSIConsole.Win32
{
    public partial class SelectSPTIDevice : Form
    {
        private string path;
        public string Path
        {
            get
            {
                return path;
            }
        }
        public SelectSPTIDevice()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            path = txtPath.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
