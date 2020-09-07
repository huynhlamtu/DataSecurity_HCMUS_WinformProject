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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
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

            cmd.Parameters.Add(":user_name", txtusername.Text.Trim().ToUpper()); ;

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username đã tồn tại!");
            }
            else
            {
                OracleCommand commandCheckToTruong = new OracleCommand();
                commandCheckToTruong.Connection = con;

                commandCheckToTruong.CommandText = "proc_create_user";
                commandCheckToTruong.CommandType = CommandType.StoredProcedure;

                commandCheckToTruong.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = txtusername.Text.Trim();// pwd.Text.Trim();
                commandCheckToTruong.Parameters.Add(new OracleParameter("pwd", OracleDbType.Varchar2)).Value = txtpassword.Text.Trim();// pwd.Text.Trim();
                try
                {
                    commandCheckToTruong.ExecuteNonQuery();
                    MessageBox.Show("Thêm user mới thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
            }
        }
    }
}
