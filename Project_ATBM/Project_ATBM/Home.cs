using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ATBM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_phanhe1_Click(object sender, EventArgs e)
        {
            PanelPhanHe1 form = new PanelPhanHe1();
            form.Show();
        }

        private void btn_phanhe2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }
    }
}
