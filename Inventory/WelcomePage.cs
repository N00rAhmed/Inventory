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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f3 = new Register();
            f3.Show();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.Show();

        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerWelcome f8 = new ManagerWelcome();
            f8.Show();
        }
    }
}
