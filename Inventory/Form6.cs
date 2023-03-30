using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form6 : Form
    {
        DataTable dt = new DataTable();
        public static string uid = "";

        public Form6()
        {
            InitializeComponent();

            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();

            string query = "SELECT Email, Password, UserAdminID from UserAdmin";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Check if username or password fields are empty
            if (Manageremail.Text == "" || Manageremail.Text == null)
            {
                MessageBox.Show("Enter a username!");
                return;
            }

            if (Managerpassword.Text == "" || Managerpassword.Text == null)
            {
                MessageBox.Show("Enter a password!");
                return;
            }
            // Loop through datatable which is a copy of the database fields we need
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i]; // Get data row of current index
                if (dr["Email"].ToString() == Manageremail.Text && dr["Password"].ToString() == Managerpassword.Text)
                {
                    // Redundant?
                    uid = dr["UserAdminID"].ToString();
                    // Switch to form5
                    this.Hide();
                    Form5 f5 = new Form5();
                    f5.Show();
                    return;
                }
            }
            MessageBox.Show("Incorrect login details");
        }
    }
}
