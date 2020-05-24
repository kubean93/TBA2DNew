using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBANewVersion.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using TBANewVersion.DAO;

namespace TBANewVersion
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void preInitForm()
        {
            UCExcerciseDetail ucExc = new UCExcerciseDetail();
            ucExc.Dock = DockStyle.Fill;

            panelControlExc.Dock = DockStyle.Fill;
            panelControlExc.Controls.Clear();
            panelControlExc.Controls.Add(ucExc);
        }

        private void btnBarK54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preInitForm();
            QueryEmployee();
        }

        private static void QueryEmployee()
        {
            string sql = "Select id, test1, test2, test3 from configuration";
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            // Tạo một đối tượng Command.
            MySqlCommand cmd = new MySqlCommand();

            // Liên hợp Command với Connection.

            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Chỉ số (index) của cột Emp_ID trong câu lệnh SQL.
                        int empIdIndex = reader.GetOrdinal("id"); // 0
                        long empId = Convert.ToInt64(reader.GetValue(empIdIndex));

                        int empNameIndex = reader.GetOrdinal("test1");// 1
                        string empName = reader.GetString(empNameIndex);

                        int test2 = reader.GetOrdinal("test2");// 2
                        int empNametest = reader.GetInt32(test2);

                        // Chỉ số (index) của cột Mng_Id trong câu lệnh SQL.
                        int mngIdIndex = reader.GetOrdinal("test3"); //3
                        string empName1 = reader.GetString(mngIdIndex);
                    }
                }
            }

            conn.Close();
        }
    }
}
