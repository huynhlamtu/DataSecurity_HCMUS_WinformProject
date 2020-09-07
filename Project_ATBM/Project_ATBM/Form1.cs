using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Project_ATBM
{
    public partial class Form1 : Form
    {
        string pwd, user_name, ho_ten;
        int ma_tv;
        public Form1(string username, string password, string hoten, int matv)
        {
            InitializeComponent();
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

            //  MessageBox.Show(connectionString);

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
            OracleCommand getRoleList = new OracleCommand();
            getRoleList.CommandText = "select * from admin_abc.show_list_vaitro";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách ứng cử viên.
            OracleCommand getCompetitorList = new OracleCommand();
            getCompetitorList.CommandText = "select * from admin_abc.show_list_ungcuvien";

            getCompetitorList.Connection = con;

            getCompetitorList.CommandType = CommandType.Text;

            OracleDataReader competitorListData = getCompetitorList.ExecuteReader();

            DataTable tableCompetitorList = new DataTable();

            tableCompetitorList.Load(competitorListData);

            dataGridView2.DataSource = tableCompetitorList;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            con.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender,
    DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView2_DataBindingComplete(object sender,
    DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            addRoler form = new addRoler(user_name, pwd);
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user_name + pwd);
            delRoler form = new delRoler(user_name, pwd);
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + temp1.Text + ";password=" + temp2.Text;

            bool continue_para = true;

            OracleConnection con1 = new OracleConnection();
            con1.ConnectionString = connectionString;
            con1.Open();

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
            OracleCommand getRoleList = new OracleCommand();
            getRoleList.CommandText = "select count(*) from ADMIN_ABC.ungcuvien";

            getRoleList.Connection = con1;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader dr = getRoleList.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows[0]["count(*)"].ToString() == "5")
            {
                MessageBox.Show("Danh sách đã có đủ 5 ứng cử viên!");
                continue_para = false;
            }
            con1.Close();

            if (continue_para)
            {
                OracleCommand getRoleList1 = new OracleCommand();
                getRoleList1.CommandText = "select count(*) from admin_abc.vaitro where matv =: para_matv";

                getRoleList1.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = addUCV.Text.Trim();

                getRoleList1.Connection = con1;

                getRoleList1.CommandType = CommandType.Text;

                con1.Open();

                OracleDataReader dr1 = getRoleList1.ExecuteReader();

                DataTable dt1 = new DataTable();

                dt1.Load(dr1);

                if (dt1.Rows[0]["count(*)"].ToString() == "1")
                {
                    MessageBox.Show("Nhân viên đã đảm nhiệm 1 vai trò trong tổ chức không thể tham gia làm ứng cử viên!");
                    continue_para = false;
                }
                con1.Close();
            }
            if (continue_para)
            {
                OracleCommand commandCheckDviDaLSD = new OracleCommand();
                commandCheckDviDaLSD.Connection = con1;

                commandCheckDviDaLSD.CommandText = "admin_ABC.add_ucv";
                commandCheckDviDaLSD.CommandType = CommandType.StoredProcedure;

                commandCheckDviDaLSD.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = addUCV.Text.Trim();

                try
                {
                    con1.Open();
                    commandCheckDviDaLSD.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công thành viên có mã " + addUCV.Text + " làm ứng cử viên!");
                    con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm vai trò của thành viên!");
                    con1.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + temp1.Text + ";password=" + temp2.Text;

            OracleConnection con1 = new OracleConnection();
            con1.ConnectionString = connectionString;

            OracleCommand commandCheckDviDaLSD = new OracleCommand();
            commandCheckDviDaLSD.Connection = con1;

            commandCheckDviDaLSD.CommandText = "admin_ABC.del_ucv";
            commandCheckDviDaLSD.CommandType = CommandType.StoredProcedure;

            commandCheckDviDaLSD.Parameters.Add(new OracleParameter("para_maucv", OracleDbType.Decimal)).Value = delUCV.Text.Trim();

            try
            {
                con1.Open();
                commandCheckDviDaLSD.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công ứng cử viên có mã " + delUCV.Text);
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm vai trò của thành viên!");
                con1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + temp1.Text + ";password=" + temp2.Text;

            //  MessageBox.Show(connectionString);

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách ứng cử viên.
            OracleCommand getCompetitorList = new OracleCommand();
            getCompetitorList.CommandText = "select * from admin_abc.show_list_ungcuvien";

            getCompetitorList.Connection = con;

            getCompetitorList.CommandType = CommandType.Text;

            OracleDataReader competitorListData = getCompetitorList.ExecuteReader();

            DataTable tableCompetitorList = new DataTable();

            tableCompetitorList.Load(competitorListData);

            dataGridView2.DataSource = tableCompetitorList;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + user_name + ";password=" + pwd;

            //  MessageBox.Show(connectionString);

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
            OracleCommand getRoleList = new OracleCommand();
            getRoleList.CommandText = "select * from admin_abc.show_list_vaitro";

            getRoleList.Connection = con;

            getRoleList.CommandType = CommandType.Text;

            OracleDataReader roleListData = getRoleList.ExecuteReader();

            DataTable tableRoleList = new DataTable();

            tableRoleList.Load(roleListData);

            dataGridView1.DataSource = tableRoleList;

            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BauCu form = new BauCu(user_name, pwd, ho_ten, ma_tv);
            form.Show();
        }
    }
}
