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
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from system.USER_LOGIN where username = :user_name and pass_word = :pwd";

            cmd.Parameters.Add(":user_name", user_name.Text);
            cmd.Parameters.Add(":pwd", pwd.Text);

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                //int flag_role = 0;
                string role = dt.Rows[0]["Role_ABC"].ToString();
                //int check = Int32.Parse(role);

                if (role == "BTC")
                {
                    Form1 form = new Form1(user_name.Text, pwd.Text);
                    con.Close();
                    form.Show();
                }

                if (role == "LDS")
                {
                    MessageBox.Show("The role of this user is: " + role);
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }
    }
}
