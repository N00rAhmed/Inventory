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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
/*if statement currently for manager redirect*/
            if (userNametxt.Text == "manager")
            {
                this.Hide();
                InventoryC f5 = new InventoryC();
                f5.Show();

            }
            else
            {
                this.Hide();
                InventoryM f4 = new InventoryM();
                f4.Show();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
