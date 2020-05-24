using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TBANewVersion.Forms;

namespace TBANewVersion.Forms
{
    public partial class UCExcerciseDetail : DevExpress.XtraEditors.XtraUserControl
    {
        public UCExcerciseDetail()
        {
            InitializeComponent();
        }

        public void addImageListBox() {
            //LBExcercises.Controls.
        }

        public void showPrepareShootForm() {
            frmPrepareShoot frmPre = new frmPrepareShoot();
            frmPre.ShowDialog();
        }

        private void btnPrepareShoot_Click(object sender, EventArgs e)
        {
            showPrepareShootForm();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
