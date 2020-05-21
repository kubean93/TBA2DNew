using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBANewVersion.Forms;

namespace TBANewVersion
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void preInitForm() {
            UCExcerciseDetail ucExc = new UCExcerciseDetail();
            ucExc.Dock = DockStyle.Fill;

            panelControlExc.Dock = DockStyle.Fill;
            panelControlExc.Controls.Clear();
            panelControlExc.Controls.Add(ucExc);
        }

        private void btnBarK54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preInitForm();
        }
    }
}
