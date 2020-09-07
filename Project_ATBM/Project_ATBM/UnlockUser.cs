using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Project_ATBM
{
    public partial class UnlockUser : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public UnlockUser()
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            // Đổ danh sách username bị lock
            OracleCommand getUserList3 = new OracleCommand();

            getUserList3.CommandText = "select username from dba_users where account_status like '%LOCK%'";

            getUserList3.Connection = con;

            getUserList3.CommandType = CommandType.Text;

            OracleDataReader userListData2 = getUserList3.ExecuteReader();

            while (userListData2.Read())
            {
                lockedUserList.Items.Add(userListData2[0]);
            }
            con.Close();
        }

        private void UnlockUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand commandCheckToTruong = new OracleCommand();
            commandCheckToTruong.Connection = con;

            commandCheckToTruong.CommandText = "proc_unlock_user";
            commandCheckToTruong.CommandType = CommandType.StoredProcedure;

            commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = lockedUserList.Text.Trim();// pwd.Text.Trim();
            commandCheckToTruong.Parameters.Add(new OracleParameter("pwd", OracleDbType.Varchar2)).Value = txtpassword.Text.Trim();// pwd.Text.Trim();
            try
            {
                commandCheckToTruong.ExecuteNonQuery();
                MessageBox.Show("Unlock thành công user " + lockedUserList.Text.Trim() +  " với mật khẩu mới là " + txtpassword.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
    }
}
