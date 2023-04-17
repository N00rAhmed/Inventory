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
    public partial class ManagerRegister : Form
    {
        public ManagerRegister()
        {
            InitializeComponent();
        }

        private void AmendDatabase(string dbQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(DB.DBLocation);
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(dbQuery, conn);
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

            AmendDatabase(dbquery);

            ManagerLogin f6 = new ManagerLogin();
            f6.Show();
        }
    }
}
