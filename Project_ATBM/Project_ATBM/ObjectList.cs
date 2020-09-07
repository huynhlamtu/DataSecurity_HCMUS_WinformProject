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
    public partial class ObjectList : Form
    {
        string connectionString = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-II7U9L8)(PORT = 1521))
            (CONNECT_DATA =
              (SERVER = DEDICATED)
              (SERVICE_NAME = XE)
            )
            );User Id = dbadmin;password=dbadmin";
        public ObjectList()
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();

            OracleCommand getCompetitorList = new OracleCommand();
            getCompetitorList.CommandText = "select object_name, object_id, object_type, created, last_ddl_time, status from user_objects";

            getCompetitorList.Connection = con;

            getCompetitorList.CommandType = CommandType.Text;

            OracleDataReader competitorListData = getCompetitorList.ExecuteReader();

            DataTable tableCompetitorList = new DataTable();

            tableCompetitorList.Load(competitorListData);

            dataGridView1.DataSource = tableCompetitorList;

            con.Close();
        }
    }
}
