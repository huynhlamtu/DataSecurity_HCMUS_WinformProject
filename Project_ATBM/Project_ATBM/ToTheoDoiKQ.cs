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
    public partial class ToTheoDoiKQ : Form
    {
        string pwd, user_name, ho_ten;
        int ma_tv;
        private void button1_Click(object sender, EventArgs e)
        {
            BauCu form = new BauCu(user_name, pwd, ho_ten, ma_tv);
            form.Show();
        }
        public ToTheoDoiKQ(string username, string password, string hoten, int matv)
        {
            InitializeComponent();
            welcome.Text = "Welcome " + hoten;
            user_name = username;
            pwd = password;
            ho_ten = hoten;
            ma_tv = matv;
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

            //Lấy dữ liệu cho table danh sách những người chưa tham gia đi bầu
            OracleCommand getRoleList = new OracleCommand();
            getRoleList.CommandText = "select * from ADMIN_ABC.chuadibau_list";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            //Lấy dữ liệu cho table danh sách những người đã tham gia đi bầu
            OracleCommand getRoleList2 = new OracleCommand();
            getRoleList2.CommandText = "select * from ADMIN_ABC.dadibau_list";

            getRoleList2.Connection = con;

            getRoleList2.CommandType = CommandType.Text;

            OracleDataReader roleListData2 = getRoleList2.ExecuteReader();

            DataTable tableRoleList2 = new DataTable();

            tableRoleList2.Load(roleListData2);

            dataGridView2.DataSource = tableRoleList2;

            // danh sách kết quả bầu cử
            OracleCommand getRoleList3 = new OracleCommand();
            getRoleList3.CommandText = "select * from ADMIN_ABC.view_theodoi_kq";

            getRoleList3.Connection = con;

            getRoleList3.CommandType = CommandType.Text;

            OracleDataReader roleListData3 = getRoleList3.ExecuteReader();

            DataTable tableRoleList3 = new DataTable();

            tableRoleList3.Load(roleListData3);

            dataGridView3.DataSource = tableRoleList3;

            con.Close();
        }

        private void ToTheoDoiKQ_Load(object sender, EventArgs e)
        {

        }
    }
}
