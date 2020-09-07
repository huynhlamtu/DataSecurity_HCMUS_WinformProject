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
    public partial class GrantRoleToUser : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public GrantRoleToUser()
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Đổ dữ liệu danh sách các user trong hệ thống vào combobox
            OracleCommand getUserList = new OracleCommand();

            getUserList.CommandText = "select username from all_users";

            getUserList.Connection = con;

            getUserList.CommandType = CommandType.Text;

            OracleDataReader userListData = getUserList.ExecuteReader();

            while (userListData.Read())
            {
                usernameCombobox.Items.Add(userListData[0]);
            }

            //Đổ dữ liệu danh sách các role trong hệ thống vào combobox
            OracleCommand getRoleList = new OracleCommand();

            getRoleList.CommandText = "select role from dba_roles";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            while (roleListData.Read())
            {
                roleCombobox.Items.Add(roleListData[0]);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from all_users where username = :user_name";

            cmd.Parameters.Add(":user_name", usernameCombobox.Text.Trim().ToUpper()); ;

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Username không tồn tại!");
            }
            else
            {
                OracleCommand cmd1 = new OracleCommand();
                cmd1.CommandText = "select * from dba_roles where role = :role_name";

                cmd1.Parameters.Add(":role_name", roleCombobox.Text.Trim().ToUpper()); ;

                cmd1.Connection = con;

                cmd1.CommandType = CommandType.Text;

                OracleDataReader dr1 = cmd1.ExecuteReader();

                DataTable dt1 = new DataTable();

                dt1.Load(dr1);

                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("Role không tồn tại!");
                }
                else
                {
                    OracleCommand commandCheckToTruong = new OracleCommand();
                    commandCheckToTruong.Connection = con;

                    commandCheckToTruong.CommandText = "proc_grant_role_user";
                    commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                    commandCheckToTruong.Parameters.Add(new OracleParameter("rolename", OracleDbType.Varchar2)).Value = roleCombobox.Text.Trim().ToUpper();// pwd.Text.Trim();
                    commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = usernameCombobox.Text.Trim().ToUpper();// pwd.Text.Trim();
                    try
                    {
                        commandCheckToTruong.ExecuteNonQuery();
                        MessageBox.Show("Đã grant role " + roleCombobox.Text.Trim() + " thành công cho username " + usernameCombobox.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Đã xảy ra lỗi khi thực hiện grant role cho user!");
                    }
                }
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLyUser form = new QLyUser();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RolePanel form = new RolePanel();
            form.Show();
        }
    }
}
