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
    public partial class delRoler : Form
    {
        public delRoler(string username, string password)
        {
            InitializeComponent();
            temp1.Text = username;
            temp2.Text = password;
            //MessageBox.Show(username + " and " + password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
    ); User Id = " + temp1.Text + ";password=" + temp2.Text;

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;

            OracleCommand commandCheckMatch = new OracleCommand();
            commandCheckMatch.Connection = con;

            commandCheckMatch.CommandText = "admin_ABC.check_matv_role";
            commandCheckMatch.CommandType = CommandType.StoredProcedure;

            commandCheckMatch.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

            commandCheckMatch.Parameters.Add(new OracleParameter("para_role", OracleDbType.Varchar2)).Value = selectRole.Text.Trim();

            commandCheckMatch.Parameters.Add("para_check", OracleDbType.Decimal).Direction = ParameterDirection.Output;

            con.Open();
            commandCheckMatch.ExecuteNonQuery();
            int check_DviDaLDS = Int32.Parse(commandCheckMatch.Parameters["para_check"].Value.ToString());
            con.Close();

            if (check_DviDaLDS == 0)
            {
                MessageBox.Show("Không tồn tại mã thành viên " + maThanhVien.Text + " với tai trò " + selectRole.Text);
            }
            else
            {
                if (selectRole.Text.Trim().ToString() == "To lap danh sach")
                {
                    OracleConnection con1 = new OracleConnection();
                    con1.ConnectionString = connectionString;

                    OracleCommand commandCheckMatch1 = new OracleCommand();
                    commandCheckMatch1.Connection = con1;

                    commandCheckMatch1.CommandText = "admin_ABC.get_dvi_lds";
                    commandCheckMatch1.CommandType = CommandType.StoredProcedure;

                    commandCheckMatch1.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

                    commandCheckMatch1.Parameters.Add("para_dvi", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                    con1.Open();
                    commandCheckMatch1.ExecuteNonQuery();
                    int madonvi = Int32.Parse(commandCheckMatch1.Parameters["para_dvi"].Value.ToString());
                    con1.Close();

                    //del_roler_lds( para_matv int, para_donvi varchar2, para_username varchar2)
                    OracleConnection con2 = new OracleConnection();

                    OracleCommand commandCheckMatch2 = new OracleCommand();
                    commandCheckMatch2.Connection = con1;

                    commandCheckMatch2.CommandText = "admin_ABC.del_roler_lds";
                    commandCheckMatch2.CommandType = CommandType.StoredProcedure;

                    commandCheckMatch2.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();
                    commandCheckMatch2.Parameters.Add(new OracleParameter("para_donvi", OracleDbType.Decimal)).Value = madonvi;

                    con1.Open();
                    try
                    {
                        commandCheckMatch2.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa vai trò " + selectRole.Text + " của thành viên có mã " + maThanhVien.Text + " thành công!");
                        con1.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Đã xảy ra lỗi khi thực hiện xóa vai trò của thành viên!");
                    }
                }
                else
                {
                    string role = "";
                    if (selectRole.Text == "To theo doi")
                        role = "THEODOI";
                    if (selectRole.Text == "To giam sat")
                        role = "GIAMSAT";

                    OracleCommand commandDelRoler = new OracleCommand();
                    commandDelRoler.Connection = con;

                    con.Open();

                    commandDelRoler.CommandText = "admin_abc.del_roler";
                    commandDelRoler.CommandType = CommandType.StoredProcedure;
                    commandDelRoler.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

                    commandDelRoler.Parameters.Add(new OracleParameter("para_vaitro", OracleDbType.Varchar2)).Value = selectRole.Text.Trim();

                    commandDelRoler.Parameters.Add(new OracleParameter("para_role", OracleDbType.Varchar2)).Value = role;

                    try
                    {
                        commandDelRoler.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa vai trò " + selectRole.Text + " của thành viên có mã " + maThanhVien.Text + " thành công!");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Đã xảy ra lỗi khi thực hiện xóa vai trò của thành viên!");
                    }
                }
            }    
        }
    }
}
