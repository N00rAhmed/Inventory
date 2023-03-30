using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            // Reset text fields
            Mngfname.Text = "";
            mngLname.Text = "";
            mngEmail.Text = "";
            Mngusername.Text = "";
            Mngpassword.Text = "";
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            string dbquery = "INSERT INTO UserAdmin(Name, LastName, UserName, Password, Email)" + "VALUES ('" + Mngfname.Text + "', '" + mngLname.Text + "', '" + Mngusername.Text + "', '" + Mngpassword.Text + "', '" + mngEmail.Text + "')";
            string query = "INSERT INTO LoginAdmin(Email, Password, UserAdminID) SELECT Email, Password, UserAdminID FROM UserAdmin";

            AmendDatabase(dbquery);
            AmendDatabase(query);

            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
