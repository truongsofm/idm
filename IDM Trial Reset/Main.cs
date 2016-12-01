using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IDM_Trial_Reset
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Process regeditProcess = Process.Start("regedit.exe", "/s idm_reset.reg");
            regeditProcess.WaitForExit();
            MessageBox.Show("Reset Success");
        }
    }
}
