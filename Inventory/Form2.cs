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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNametxt.Text == "manager")
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();

            }
            else
            {
                this.Hide();
                Form4 f4 = new Form4();
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
