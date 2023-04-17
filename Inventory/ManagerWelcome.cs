using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ManagerWelcome : Form
    {
        public ManagerWelcome()
        {
            InitializeComponent();
        }

        private void MLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin f6 = new ManagerLogin();
            f6.Show();

        }

        private void MRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerRegister f7 = new ManagerRegister();
            f7.Show();

        }
    }
}
