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
    public partial class RolePanel : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public RolePanel()
        {
            InitializeComponent();
            //select role, role_id, password_required from dba_roles;
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách các user trong hệ thống
            OracleCommand getRoleList = new OracleCommand();

            getRoleList.CommandText = "select role, role_id, password_required from dba_roles";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            //Lấy dữ liệu cho table danh sách các privileges của các user trong hệ thống

            OracleCommand getCompetitorList = new OracleCommand();
            getCompetitorList.CommandText = "select db.grantee, db.privilege, db.admin_option, db.common from dba_sys_privs db, dba_roles rl where db.grantee = rl.role";

            getCompetitorList.Connection = con;

            getCompetitorList.CommandType = CommandType.Text;

            OracleDataReader competitorListData = getCompetitorList.ExecuteReader();

            DataTable tableCompetitorList = new DataTable();

            tableCompetitorList.Load(competitorListData);

            dataGridView2.DataSource = tableCompetitorList;

            //Đổ danh sách Role
            OracleCommand getUserList1 = new OracleCommand();

            getUserList1.CommandText = "select distinct role from dba_roles";

            getUserList1.Connection = con;

            getUserList1.CommandType = CommandType.Text;

            OracleDataReader userListData = getUserList1.ExecuteReader();

            while (userListData.Read())
            {
                cbbFindRole.Items.Add(userListData[0]);
                cbbDelRole.Items.Add(userListData[0]);
                comboBox1.Items.Add(userListData[0]);
            }

            con.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách các user trong hệ thống
            OracleCommand getRoleList = new OracleCommand();

            getRoleList.CommandText = "select role, role_id, password_required from dba_roles";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            //Đổ danh sách Role
            OracleCommand getUserList1 = new OracleCommand();

            getUserList1.CommandText = "select distinct role from dba_roles";

            getUserList1.Connection = con;

            getUserList1.CommandType = CommandType.Text;

            OracleDataReader userListData = getUserList1.ExecuteReader();

            while (userListData.Read())
            {
                cbbFindRole.Items.Add(userListData[0]);
                cbbDelRole.Items.Add(userListData[0]);
            }

            con.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from dba_roles where role = :role_name";

            cmd.Parameters.Add(":role_name", txtNewRoleName.Text.Trim().ToUpper()); ;

            cmd.Connection = con;           cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Role " + txtNewRoleName.Text.Trim().ToUpper() + " đã tồn tại!"); ;
            }
            else
            {
                OracleCommand commandCheckToTruong = new OracleCommand();
                commandCheckToTruong.Connection = con;

                commandCheckToTruong.CommandText = "sp_create_role";
                commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                commandCheckToTruong.Parameters.Add(new OracleParameter("rolename", OracleDbType.Varchar2)).Value = txtNewRoleName.Text.Trim().ToUpper();// pwd.Text.Trim();
                try
                {
                    commandCheckToTruong.ExecuteNonQuery();
                    MessageBox.Show("Đã tạo role " + txtNewRoleName.Text + " thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm role!");
                }
                con.Close();
            }
        }

        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from dba_roles where role = :role_name";

            cmd.Parameters.Add(":role_name", cbbDelRole.Text.Trim().ToUpper()); ;

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Role " + cbbDelRole.Text.Trim().ToUpper() + " không tồn tại!"); ;
            }
            else
            {
                OracleCommand commandCheckToTruong = new OracleCommand();
                commandCheckToTruong.Connection = con;

                commandCheckToTruong.CommandText = "sp_drop_role";
                commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                commandCheckToTruong.Parameters.Add(new OracleParameter("rolename", OracleDbType.Varchar2)).Value = cbbDelRole.Text.Trim().ToUpper();// pwd.Text.Trim();
                try
                {
                    commandCheckToTruong.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa role " + cbbDelRole.Text + " thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                   // MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm role!");
                }
                con.Close();
            }
        }

        private void btn_findUsername_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách các user trong hệ thống
            OracleCommand getRoleList = new OracleCommand();

            getRoleList.CommandText = "select role, role_id, password_required from dba_roles where role = :role_name";

            getRoleList.Parameters.Add(":role_name", cbbFindRole.Text.Trim().ToUpper()); ;

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand getCompetitorList = new OracleCommand();
            getCompetitorList.CommandText = "select grantee, granted_role, admin_option from dba_role_privs";

            getCompetitorList.Connection = con;

            getCompetitorList.CommandType = CommandType.Text;

            OracleDataReader competitorListData = getCompetitorList.ExecuteReader();

            DataTable tableCompetitorList = new DataTable();

            tableCompetitorList.Load(competitorListData);

            dataGridView2.DataSource = tableCompetitorList;

            //Đổ danh sách Grantee
            OracleCommand getUserList1 = new OracleCommand();

            getUserList1.CommandText = "select distinct grantee from dba_role_privs";

            getUserList1.Connection = con;

            getUserList1.CommandType = CommandType.Text;

            OracleDataReader userListData = getUserList1.ExecuteReader();

            while (userListData.Read())
            {
                comboBox1.Items.Add(userListData[0]);
            }

            con.Close();
        }

        private void btnFindGrantee_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách các user trong hệ thống
            OracleCommand getRoleList = new OracleCommand();

            getRoleList.CommandText = "select db.grantee, db.privilege, db.admin_option, db.common from dba_sys_privs db, dba_roles rl where db.grantee = rl.role and db.grantee = :grantee_name";

            getRoleList.Parameters.Add(":grantee_name", comboBox1.Text.Trim().ToUpper()); ;

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView2.DataSource = tableRoleList;

            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GrantToRole form = new GrantToRole();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RevokePrivOfRole form = new RevokePrivOfRole();
            form.Show();
        }
    }
}
