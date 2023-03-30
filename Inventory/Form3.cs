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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            string dbquery = "INSERT INTO User(FirstName, LastName, UserName, Password)" + "VALUES ('" + Firstnametxtbox.Text + "', '" + lastnametxtbox.Text + "', '" + Usernametxtbox.Text + "', '" + Passwordtxtbox.Text + "')";

            AmendDatabase(dbquery);

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
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
