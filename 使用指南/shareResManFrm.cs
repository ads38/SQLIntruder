using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
namespace 使用指南
{
    public partial class shareResManFrm : Form
    {
        public shareResManFrm()
        {
            InitializeComponent();
        }

        private void shareResManFrm_Load(object sender, EventArgs e)
        {
            string s = "";
           // string[] subRes = new string[4];
            ManagementObjectSearcher sr = new ManagementObjectSearcher("SELECT * FROM Win32_share");

            foreach (ManagementObject share in sr.Get())
            {
                resultLstv.Items.Add(share["Name"].ToString()).SubItems.AddRange(
                    new string[] {
                                    share["Path"].ToString(),
                                    share["Description"].ToString(),
                                    share["Caption"].ToString(),
                                    share["Status"].ToString()
                                 }
                    );
            }
          
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            resultLstv.Items.Clear();
            shareResManFrm_Load(sender, e);
        }
    }
}
