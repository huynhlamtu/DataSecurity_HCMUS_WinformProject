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
    public partial class addRoler : Form
    {
        public addRoler(string username, string password)
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

            bool continue_para = true;
            bool continue_para_lds = true;

            if (selectRole.Text.Trim() == "To lap danh sach")
            {
                //MessageBox.Show(selectRole.Text.Trim());
                OracleConnection con1 = new OracleConnection();
                con1.ConnectionString = connectionString;
                con1.Open();

                //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
                OracleCommand getRoleList = new OracleCommand();
                getRoleList.CommandText = "select count(*) from ADMIN_ABC.vaitro where vaitro = 'To lap danh sach'";

                getRoleList.Connection = con1;

                getRoleList.CommandType = CommandType.Text;

                OracleDataReader dr = getRoleList.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dr);

                if (dt.Rows[0]["count(*)"].ToString() == "3")
                {
                    MessageBox.Show("Tổ lập danh sách đã đủ thành viên!");
                    continue_para = false;
                }
            }
            if (selectRole.Text.Trim() == "To theo doi")
            {
                OracleConnection con1 = new OracleConnection();
                con1.ConnectionString = connectionString;
                con1.Open();

                //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
                OracleCommand getRoleList = new OracleCommand();
                getRoleList.CommandText = "select count(*) from ADMIN_ABC.vaitro where vaitro = 'To theo doi'";

                getRoleList.Connection = con1;

                getRoleList.CommandType = CommandType.Text;

                OracleDataReader dr = getRoleList.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dr);

                if (dt.Rows[0]["count(*)"].ToString() == "2")
                {
                    MessageBox.Show("Tổ theo dõi đã đủ thành viên!");
                    continue_para = false;
                }
            }
            if (selectRole.Text.Trim() == "To giam sat")
            {
                OracleConnection con1 = new OracleConnection();
                con1.ConnectionString = connectionString;
                con1.Open();

                //Lấy dữ liệu cho table danh sách những người thuộc tổ lập danh sách người đi bầu, tổ theo dõi kết quả và tổ giám sát.
                OracleCommand getRoleList = new OracleCommand();
                getRoleList.CommandText = "select count(*) from ADMIN_ABC.vaitro where vaitro = 'To giam sat'";

                getRoleList.Connection = con1;

                getRoleList.CommandType = CommandType.Text;

                OracleDataReader dr = getRoleList.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dr);

                if (dt.Rows[0]["count(*)"].ToString() == "2")
                {
                    MessageBox.Show("Tổ giám sát đã đủ thành viên!");
                    continue_para = false;
                }
            }
            if (continue_para && continue_para_lds)
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connectionString;

                OracleCommand commandCheckExistMemeber = new OracleCommand();
                commandCheckExistMemeber.Connection = con;

                commandCheckExistMemeber.CommandText = "admin_ABC.check_exist_member";
                commandCheckExistMemeber.CommandType = CommandType.StoredProcedure;
                commandCheckExistMemeber.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

                commandCheckExistMemeber.Parameters.Add(new OracleParameter("para_name", OracleDbType.Varchar2)).Value = tenThanhVien.Text.Trim();

                commandCheckExistMemeber.Parameters.Add("para_check", OracleDbType.Decimal).Direction = ParameterDirection.Output; ;
                try
                {
                    con.Open();
                    commandCheckExistMemeber.ExecuteNonQuery();
                    int check = Int32.Parse(commandCheckExistMemeber.Parameters["para_check"].Value.ToString());
                    if (check == 1)
                    {
                        //continue_para = true;
                        if (flag_totruong.Checked)
                        {
                            OracleCommand commandCheckToTruong = new OracleCommand();
                            commandCheckToTruong.Connection = con;

                            commandCheckToTruong.CommandText = "admin_ABC.check_exist_totruong";
                            commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                            commandCheckToTruong.Parameters.Add(new OracleParameter("para_role", OracleDbType.Varchar2)).Value = selectRole.Text.Trim();

                            commandCheckToTruong.Parameters.Add("para_check", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                            commandCheckToTruong.ExecuteNonQuery();
                            int check_totruong = Int32.Parse(commandCheckToTruong.Parameters["para_check"].Value.ToString());

                            if (check_totruong == 1)
                            {
                                MessageBox.Show(selectRole.Text + " đã có tổ trưởng!");
                                continue_para = false;
                            }
                        }

                        if (selectDonvi.Text != "Đơn vị phụ trách")
                        {
                            OracleCommand commandCheckDviDaLSD = new OracleCommand();
                            commandCheckDviDaLSD.Connection = con;

                            commandCheckDviDaLSD.CommandText = "admin_ABC.check_dvi_lds";
                            commandCheckDviDaLSD.CommandType = CommandType.StoredProcedure;

                            commandCheckDviDaLSD.Parameters.Add(new OracleParameter("para_dvi", OracleDbType.Decimal)).Value = selectDonvi.Text.Trim();

                            commandCheckDviDaLSD.Parameters.Add("para_check", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                            commandCheckDviDaLSD.ExecuteNonQuery();
                            int check_DviDaLDS = Int32.Parse(commandCheckDviDaLSD.Parameters["para_check"].Value.ToString());

                            if (check_DviDaLDS == 1)
                            {
                                MessageBox.Show("Đơn vị " + selectDonvi.Text + " đã có người nhận lập danh sách!");
                                continue_para = false;
                            }
                        }

                        if (continue_para)
                        {
                            int check_totruong = 0;
                            if (flag_totruong.Checked)
                            {
                                check_totruong = 1;
                            }

                            OracleCommand commandAddRoler = new OracleCommand();
                            commandAddRoler.Connection = con;

                            if (selectRole.Text.Trim() == "To lap danh sach")
                            {
                                commandAddRoler.CommandText = "admin_abc.add_roler_lds";
                                commandAddRoler.CommandType = CommandType.StoredProcedure;
                                commandAddRoler.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

                                commandAddRoler.Parameters.Add(new OracleParameter("para_flag", OracleDbType.Decimal)).Value = check_totruong;

                                commandAddRoler.Parameters.Add(new OracleParameter("para_dvi", OracleDbType.Decimal)).Value = selectDonvi.Text.Trim();

                                try
                                {
                                    //con.Open();
                                    commandAddRoler.ExecuteNonQuery();
                                    MessageBox.Show("Đã thêm thành viên có mã " + maThanhVien.Text + " thành công vào vai trò " + selectRole.Text);
                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm vai trò của thành viên!");
                                    con.Close();
                                }
                            }
                            else
                            {
                                string role = "";
                                if (selectRole.Text.Trim() == "To theo doi")
                                {
                                    role = "THEODOI";
                                }
                                if (selectRole.Text.Trim() == "To giam sat")
                                {
                                    role = "GIAMSAT";
                                }

                                commandAddRoler.CommandText = "admin_abc.add_roler";
                                commandAddRoler.CommandType = CommandType.StoredProcedure;
                                commandAddRoler.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = maThanhVien.Text.Trim();

                                commandAddRoler.Parameters.Add(new OracleParameter("para_vaitro", OracleDbType.Varchar2)).Value = selectRole.Text.Trim();

                                commandAddRoler.Parameters.Add(new OracleParameter("para_role", OracleDbType.Varchar2)).Value = role;

                                commandAddRoler.Parameters.Add(new OracleParameter("para_flag", OracleDbType.Decimal)).Value = check_totruong;

                                try
                                {
                                    //con.Open();
                                    commandAddRoler.ExecuteNonQuery();
                                    MessageBox.Show("Đã thêm thành viên có mã " + maThanhVien.Text + " thành công vào vai trò " + selectRole.Text);
                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    //MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm vai trò của thành viên!");
                                    con.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại thành viên có mã " + maThanhVien.Text + " với tên " + tenThanhVien.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Đã xảy ra lỗi khi thực hiện thêm vai trò của thành viên!");
                }
            }
        }
    }
}
