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
    public partial class GrantPrivToUser : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public GrantPrivToUser()
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            // Đổ danh sách role
            OracleCommand getUserList3 = new OracleCommand();

            getUserList3.CommandText = "select username from all_users";

            getUserList3.Connection = con;

            getUserList3.CommandType = CommandType.Text;

            OracleDataReader userListData2 = getUserList3.ExecuteReader();

            while (userListData2.Read())
            {
                UserList.Items.Add(userListData2[0]);
            }

            // Đổ danh sách prilves
            OracleCommand getUserList4 = new OracleCommand();

            getUserList4.CommandText = "select distinct privilege from dba_sys_privs";

            getUserList4.Connection = con;

            getUserList4.CommandType = CommandType.Text;

            OracleDataReader userListData3 = getUserList4.ExecuteReader();

            while (userListData3.Read())
            {
                PrivesList.Items.Add(userListData3[0]);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand commandCheckToTruong = new OracleCommand();
            commandCheckToTruong.Connection = con;

            if (optionCombobox.Text == "Không có")
            {
                commandCheckToTruong.CommandText = "proc_grant_priv_user";
                commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = UserList.Text.Trim().ToUpper();// pwd.Text.Trim();
                commandCheckToTruong.Parameters.Add(new OracleParameter("priv_name", OracleDbType.Varchar2)).Value = PrivesList.Text.Trim().ToUpper();// pwd.Text.Trim();
                try
                {
                    commandCheckToTruong.ExecuteNonQuery();
                    MessageBox.Show("Đã grant thành công quyền " + PrivesList.Text.Trim() + " cho user " + UserList.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("Đã xảy ra lỗi khi thực hiện xóa user!");
                }
            }
            else
            {
                commandCheckToTruong.CommandText = "proc_grant_priv_user_withoption";
                commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = UserList.Text.Trim().ToUpper();// pwd.Text.Trim();
                commandCheckToTruong.Parameters.Add(new OracleParameter("priv_name", OracleDbType.Varchar2)).Value = PrivesList.Text.Trim().ToUpper();// pwd.Text.Trim();
                commandCheckToTruong.Parameters.Add(new OracleParameter("with_option", OracleDbType.Varchar2)).Value = optionCombobox.Text.Trim().ToUpper();// pwd.Text.Trim();
                try
                {
                    commandCheckToTruong.ExecuteNonQuery();
                    MessageBox.Show("Đã grant thành công quyền " + PrivesList.Text.Trim() + " cho user " + UserList.Text.Trim() + " " + optionCombobox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("Đã xảy ra lỗi khi thực hiện xóa user!");
                }
            }
            con.Close();
        }
    }
}
