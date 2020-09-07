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
    public partial class ToGiamSat : Form
    {
        string pwd, user_name, ho_ten;
        int ma_tv;
        public ToGiamSat(string username, string password, string hoten, int matv)
        {
            InitializeComponent();
            welcome.Text = "Welcome " + hoten;
            user_name = username;
            pwd = password;
            ma_tv = matv;
            ho_ten = hoten;
            // pass_word.Text = password;

            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + username + ";password=" + password;

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách thành viên
            OracleCommand getRoleList = new OracleCommand();
            getRoleList.CommandText = "select * from ADMIN_ABC.THANHVIEN";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            //Lấy dữ liệu cho table danh sách cán bộ
            OracleCommand getRoleList1 = new OracleCommand();
            getRoleList1.CommandText = "select * from ADMIN_ABC.vaitro";

            getRoleList1.Connection = con;

            getRoleList1.CommandType = CommandType.Text;

            OracleDataReader roleListData1 = getRoleList1.ExecuteReader();

            DataTable tableRoleList1 = new DataTable();

            tableRoleList1.Load(roleListData1);

            dataGridView2.DataSource = tableRoleList1;

            //Lấy dữ liệu cho table danh sách cán bộ
            OracleCommand getRoleList2 = new OracleCommand();
            getRoleList2.CommandText = "select * from ADMIN_ABC.donvi";

            getRoleList2.Connection = con;

            getRoleList2.CommandType = CommandType.Text;

            OracleDataReader roleListData2 = getRoleList2.ExecuteReader();

            DataTable tableRoleList2 = new DataTable();

            tableRoleList2.Load(roleListData2);

            dataGridView3.DataSource = tableRoleList2;

            //Lấy dữ liệu cho table danh sách ứng cử viên
            OracleCommand getRoleList3 = new OracleCommand();
            getRoleList3.CommandText = "select * from ADMIN_ABC.UNGCUVIEN";

            getRoleList3.Connection = con;

            getRoleList3.CommandType = CommandType.Text;

            OracleDataReader roleListData3 = getRoleList3.ExecuteReader();

            DataTable tableRoleList3 = new DataTable();

            tableRoleList3.Load(roleListData3);

            dataGridView4.DataSource = tableRoleList3;

            //Lấy dữ liệu cho table danh sách bầu cử
            OracleCommand getRoleList4 = new OracleCommand();
            getRoleList4.CommandText = "select * from ADMIN_ABC.baucu";

            getRoleList4.Connection = con;

            getRoleList4.CommandType = CommandType.Text;

            OracleDataReader roleListData4 = getRoleList4.ExecuteReader();

            DataTable tableRoleList4 = new DataTable();

            tableRoleList4.Load(roleListData4);

            dataGridView5.DataSource = tableRoleList4;

            con.Close();
        }

        private void ToGiamSat_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BauCu form = new BauCu(user_name, pwd, ho_ten, ma_tv);
            form.Show();
        }
    }
}
