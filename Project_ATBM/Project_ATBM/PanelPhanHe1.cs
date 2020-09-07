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
    public partial class PanelPhanHe1 : Form
    {
        public PanelPhanHe1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLyUser form = new QLyUser();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolePanel form = new RolePanel();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjectList form = new ObjectList();
            form.Show();
        }
    }
}
