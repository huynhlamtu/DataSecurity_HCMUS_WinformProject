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
    public partial class BauCu : Form
    {
        string pwd, user_name, ho_ten;
        int ma_tv1;
        public BauCu(string username, string password, string hoten, int ma_tv)
        {
            InitializeComponent();
            //MessageBox.Show(username + password + hoten + ma_tv);
            welcome.Text = "Welcome " + hoten;
            user_name = username;
            pwd = password;
            ho_ten = hoten;
            ma_tv1 = ma_tv;
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

            // Bầu cử
            OracleCommand getUserList3 = new OracleCommand();

            getUserList3.CommandText = "select maucv from admin_abc.view_ds_ucv";

            getUserList3.Connection = con;

            getUserList3.CommandType = CommandType.Text;

            OracleDataReader userListData2 = getUserList3.ExecuteReader();

            while (userListData2.Read())
            {
                comboBox1.Items.Add(userListData2[0]);
                comboBox2.Items.Add(userListData2[0]);
                comboBox3.Items.Add(userListData2[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + user_name + ";password=" + pwd;

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;

            OracleCommand command = new OracleCommand();
            command.Connection = con;

            command.CommandText = "admin_abc.CHECK_DA_BAUCU";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = ma_tv1;

            command.Parameters.Add("para_check", OracleDbType.Decimal).Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                string check = command.Parameters["para_check"].Value.ToString();
                con.Close();
                //MessageBox.Show(check);

                if (check == "1")
                {
                    OracleCommand commandAddRoler1 = new OracleCommand();
                    commandAddRoler1.Connection = con;
                    commandAddRoler1.CommandText = "admin_abc.proc_baucu_edit";
                    commandAddRoler1.CommandType = CommandType.StoredProcedure;
                    commandAddRoler1.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = ma_tv1;

                    commandAddRoler1.Parameters.Add(new OracleParameter("para_ucv1", OracleDbType.Decimal)).Value = comboBox1.Text.Trim();

                    commandAddRoler1.Parameters.Add(new OracleParameter("para_ucv2", OracleDbType.Decimal)).Value = comboBox2.Text.Trim();

                    commandAddRoler1.Parameters.Add(new OracleParameter("para_ucv3", OracleDbType.Decimal)).Value = comboBox3.Text.Trim();

                    try
                    {
                        con.Open();
                        commandAddRoler1.ExecuteNonQuery();
                        MessageBox.Show("Tiến hành bầu cử thành công");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Đã xảy ra lỗi khi thực hiện bầu cử!");
                        con.Close();
                    }
                }
                else
                {
                    OracleCommand commandAddRoler = new OracleCommand();

                    commandAddRoler.CommandText = "admin_abc.proc_baucu";
                    commandAddRoler.Connection = con;
                    commandAddRoler.CommandType = CommandType.StoredProcedure;
                    commandAddRoler.Parameters.Add(new OracleParameter("para_matv", OracleDbType.Decimal)).Value = ma_tv1;

                    commandAddRoler.Parameters.Add(new OracleParameter("para_ucv1", OracleDbType.Decimal)).Value = comboBox1.Text.Trim();

                    commandAddRoler.Parameters.Add(new OracleParameter("para_ucv2", OracleDbType.Decimal)).Value = comboBox2.Text.Trim();

                    commandAddRoler.Parameters.Add(new OracleParameter("para_ucv3", OracleDbType.Decimal)).Value = comboBox3.Text.Trim();

                    try
                    {
                        con.Open();
                        commandAddRoler.ExecuteNonQuery();
                        MessageBox.Show("Tiến hành bầu cử thành công");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Đã xảy ra lỗi khi thực hiện bầu cử!");
                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Đã xảy ra lỗi khi thực hiện bầu cử!");
                con.Close();
            }
        }
    }
}
