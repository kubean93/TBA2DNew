using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace TBANewVersion.DAO
{
    class DBUtils
    {
        public MySqlConnection conn;

        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "tbanew";
            string username = "root";
            string password = "123456";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

        private void openConnection()
        {
            conn = DBUtils.GetDBConnection();
            conn.Open();
            
        }

        private void closeConnection()
        {
            if (conn != null)
            {
                // Đóng kết nối.
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
                conn = null;
            }
        }

    }
}
