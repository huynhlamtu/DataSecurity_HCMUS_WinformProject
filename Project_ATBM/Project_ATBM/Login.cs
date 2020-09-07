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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
                (CONNECT_DATA =
                  (SERVER = DEDICATED)
                  (SERVICE_NAME = XE)
                )
              );User Id = admin_ABC;password=123";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;

            OracleCommand command = new OracleCommand();
            command.Connection = con;

            command.CommandText = "admin_abc.users_login";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new OracleParameter("para_username", OracleDbType.Varchar2, 32767)).Value = user_name.Text.Trim().ToUpper();

            command.Parameters.Add(new OracleParameter("para_pass_word", OracleDbType.Varchar2, 32767)).Value = pwd.Text.Trim();

            command.Parameters.Add("para_hoten", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;

            command.Parameters.Add("para_role", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                string hoten = command.Parameters["para_hoten"].Value.ToString();
                string role = command.Parameters["para_role"].Value.ToString();

                //Lấy dữ liệu mã thành viên
                OracleCommand getRoleList = new OracleCommand();
                getRoleList.CommandText = "select owner_member from ADMIN_ABC.user_login where username = :user_name";

                getRoleList.Parameters.Add(new OracleParameter("user_name", OracleDbType.Varchar2)).Value = user_name.Text.Trim();

                getRoleList.Connection = con;

                getRoleList.CommandType = CommandType.Text;

                OracleDataReader dr = getRoleList.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dr);

                int ma_tv = Int32.Parse(dt.Rows[0]["owner_member"].ToString());

               // MessageBox.Show(user_name.Text.Trim().ToUpper() + " and " + pwd.Text.Trim() + " and " + hoten + " and " + ma_tv);

                if (role == "BTC")
                {
                   // MessageBox.Show("The role of this user is: " + role);
                    Form1 form = new Form1(user_name.Text.Trim().ToUpper(), pwd.Text.Trim(), hoten, ma_tv);
                    form.Show();
                    con.Close();
                }

                if (role == "LDS")
                {
                    OracleConnection con1 = new OracleConnection();
                    con1.ConnectionString = connectionString;
                    con1.Open();

                    //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
                    OracleCommand getRoleList1 = new OracleCommand();
                    getRoleList1.CommandText = "select vt.dviphutrach from vaitro vt, user_login ul where ul.owner_member = vt.matv and ul.username = :user_name"; //+ user_name.Text.Trim();

                    getRoleList1.Parameters.Add(new OracleParameter("user_name", OracleDbType.Varchar2)).Value = user_name.Text.Trim();

                    getRoleList1.Connection = con1;

                    getRoleList1.CommandType = CommandType.Text;

                    OracleDataReader dr1 = getRoleList1.ExecuteReader();

                    DataTable dt1 = new DataTable();

                    dt1.Load(dr1);

                    int view = Int32.Parse(dt1.Rows[0]["dviphutrach"].ToString());

                    ToLapDS form = new ToLapDS(user_name.Text.Trim().ToUpper(), pwd.Text.Trim(), hoten, view, ma_tv);
                    form.Show();
                }

                if (role == "THEODOI")
                {
                    ToTheoDoiKQ form = new ToTheoDoiKQ(user_name.Text.Trim().ToUpper(), pwd.Text.Trim(), hoten, ma_tv);
                    form.Show();
                }

                if (role == "GIAMSAT")
                {
                    ToGiamSat form = new ToGiamSat(user_name.Text.Trim().ToUpper(), pwd.Text.Trim(), hoten, ma_tv);
                    form.Show();
                }

                if (role == "THANHVIEN")
                {
                    BauCu form = new BauCu(user_name.Text.Trim().ToUpper(), pwd.Text.Trim(), hoten, ma_tv);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
