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
    public partial class RevokeRoleFromUser : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public RevokeRoleFromUser()
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            // Đổ danh sách username
            OracleCommand getUserList3 = new OracleCommand();

            getUserList3.CommandText = "select username from all_users";

            getUserList3.Connection = con;

            getUserList3.CommandType = CommandType.Text;

            OracleDataReader userListData2 = getUserList3.ExecuteReader();

            while (userListData2.Read())
            {
                usernameCombobox.Items.Add(userListData2[0]);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLyUser form = new QLyUser();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roleCombobox.Items.Clear();

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            // Đổ danh sách prilves
            OracleCommand getUserList4 = new OracleCommand();

            getUserList4.CommandText = "select granted_role from DBA_ROLE_PRIVS where grantee =: grantee_name";

            getUserList4.Parameters.Add("grantee_name", usernameCombobox.Text.Trim().ToUpper()); ;

            getUserList4.Connection = con;

            getUserList4.CommandType = CommandType.Text;

            OracleDataReader userListData3 = getUserList4.ExecuteReader();

            while (userListData3.Read())
            {
                roleCombobox.Items.Add(userListData3[0]);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand commandCheckToTruong = new OracleCommand();
            commandCheckToTruong.Connection = con;

            commandCheckToTruong.CommandText = "proc_revoke_role_user";
            commandCheckToTruong.CommandType = CommandType.StoredProcedure;

            commandCheckToTruong.Parameters.Add(new OracleParameter("rolename", OracleDbType.Varchar2)).Value = roleCombobox.Text.Trim().ToUpper();// pwd.Text.Trim();
            commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = usernameCombobox.Text.Trim().ToUpper();// pwd.Text.Trim();
            try
            {
                commandCheckToTruong.ExecuteNonQuery();
                MessageBox.Show("Đã thu hồi thành công role " + roleCombobox.Text.Trim() + " từ username " + usernameCombobox.Text.Trim());
                roleCombobox.Text = "";
                roleCombobox.Items.Remove(roleCombobox.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Đã xảy ra lỗi khi thực hiện xóa user!");
            }
            con.Close();
        }
    }
}
