using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            string dbquery = "INSERT INTO User(FirstName, LastName, UserName, Password)" + "VALUES ('" + Firstnametxtbox.Text + "', '" + lastnametxtbox.Text + "', '" + Usernametxtbox.Text + "', '" + Passwordtxtbox.Text + "')";

            AmendDatabase(dbquery);

            Login f2 = new Login();
            f2.Show();
        }

        private void AmendDatabase(string dbQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(DB.DBLocation);
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(dbQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            // Reset fields
            Firstnametxtbox.Text = "";
            lastnametxtbox.Text = "";
            Usernametxtbox.Text = "";
            Passwordtxtbox.Text = "";
        }
    }
}
