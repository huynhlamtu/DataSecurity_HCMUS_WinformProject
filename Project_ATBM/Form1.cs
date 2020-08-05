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
        public Form1(string username, string password)
        {
            InitializeComponent();
            user_name.Text = username;
            pass_word.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(user_name.Text + " and " + pass_word.Text);
            
            string connectionString = @"Data Source=(DESCRIPTION =
    (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
    (CONNECT_DATA =
      (SERVER = DEDICATED)
      (SERVICE_NAME = XE)
    )
  );User Id = " + user_name.Text + ";password="+ pass_word.Text;

          //  MessageBox.Show(connectionString);

            
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from SYSTEM.vaitro";

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
