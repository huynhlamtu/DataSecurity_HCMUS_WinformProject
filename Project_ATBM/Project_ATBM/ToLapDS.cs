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
    public partial class ToLapDS : Form
    {
        string pwd, user_name, ho_ten;
        int ma_tv;
        private void button1_Click(object sender, EventArgs e)
        {
            BauCu form = new BauCu(user_name, pwd, ho_ten, ma_tv);
            form.Show();
        }

        public ToLapDS(string username, string password, string hoten, int view, int matv)
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

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
            OracleCommand getRoleList = new OracleCommand();

            if (view == 1)
            {
                getRoleList.CommandText = "select * from ADMIN_ABC.view_lapds_to1";// + view_data;
            }
            if (view == 2)
            {
                getRoleList.CommandText = "select * from ADMIN_ABC.view_lapds_to2";// + view_data;
            }
            if (view == 3)
            {
                getRoleList.CommandText = "select * from ADMIN_ABC.view_lapds_to3";// + view_data;
            }

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            con.Close();
        }

        private void ToLapDS_Load(object sender, EventArgs e)
        {

        }
    }
}
