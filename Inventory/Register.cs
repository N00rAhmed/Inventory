﻿using System;
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

using System.Data.SQLite;
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
/*            string query = "INSERT INTO Login(UserName, Password, UserID) SELECT UserName, Password, UserID FROM User";
*/
            /*            INSERT INTO Login(UserName, Password, UserID) SELECT UserName, Password, UserID FROM User;
            */
            AmendDatabase(dbquery);
/*            AmendDatabase(query);
*/

            Login f2 = new Login();
            f2.Show();



        }

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\c1009048\Desktop\Inventory\Inventory\inventory.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            Firstnametxtbox.Text = "";
            lastnametxtbox.Text = "";
            Usernametxtbox.Text = "";
            Passwordtxtbox.Text = "";


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Firstnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
