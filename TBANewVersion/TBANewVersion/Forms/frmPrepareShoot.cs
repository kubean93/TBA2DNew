using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TBANewVersion.Forms;

namespace TBANewVersion.Forms
{
    public partial class frmPrepareShoot : DevExpress.XtraEditors.XtraForm
    {
        public frmPrepareShoot()
        {
            InitializeComponent();
            addPanelTargetShoot();
        }

        public void addPanelTargetShoot() {
            UCTargetShoot ucTarget = new UCTargetShoot();
            ucTarget.Dock = DockStyle.Fill;

            panelTargets.Controls.Clear();
            panelTargets.Controls.Add(ucTarget);
        }
    }
}