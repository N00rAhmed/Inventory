using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.SQLite;

namespace Inventory
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        public static string uid = "";

        public Form2()
        {
            InitializeComponent();

            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Elias\source\repos\Cool Kftan 3.0\Inventory\inventory.db");
            conn.Open();

            string query = "SELECT UserName, Password, UserID from Login";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);


            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool login = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr["UserName"].ToString() == userNametxt.Text && dr["Password"].ToString() == Passwordtxt.Text)
                {
                    uid = dr["UserID"].ToString();

                    this.Close();
                    Form4 f4 = new Form4();
                    f4.Show();
                    login = true;
                    break;
                }
            }
            if (login == false)
            {
                string message = "Incorrect login details";
                MessageBox.Show(message);
                Form2 f2 = new Form2();
                f2.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
