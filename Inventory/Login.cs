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
using System.Data.Entity.Core.Common.CommandTrees;

namespace Inventory
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable(); // Store a copy of the database to be easily indexable
        public static string uid = "";

        public Login()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection(DB.DBLocation);
            conn.Open();

            string query = "SELECT UserName, Password, UserID from User";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Check if username or password fields are empty
            if (userNametxt.Text == "" || userNametxt == null)
            {
                MessageBox.Show("Enter a username!");
                return;
            }

            if (Passwordtxt.Text == "" || Passwordtxt.Text == null)
            {
                MessageBox.Show("Enter a password!");
                return;
            }
            // Loop through datatable which is a copy of the database fields we need
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i]; // Get data row of current index
                if (dr["UserName"].ToString() == userNametxt.Text && dr["Password"].ToString() == Passwordtxt.Text)
                {
                    // Redundant?
                    uid = dr["UserID"].ToString();
                    // Switch to form4
                    this.Hide();
                    InventoryManager f4 = new InventoryManager();
                    f4.Show();
                    return;
                }
            }
            MessageBox.Show("Incorrect login details");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage welcome = new WelcomePage();
            welcome.Show();
        }
    }
}
