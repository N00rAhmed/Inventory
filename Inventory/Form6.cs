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

namespace Inventory
{
    public partial class Form6 : Form
    {
        DataTable dt = new DataTable();
        public static string Uid = "";

        public Form6()
        {
            InitializeComponent();

            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\KoolKaftan\Inventory\inventory.db");
            conn.Open();

            string query = "SELECT Email, Password, AdminID from LoginAdmin";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);


            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool login = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr["Email"].ToString() == Manageremail.Text && dr["Password"].ToString() == Managerpassword.Text)
                {
                    Uid = dr["AdminID"].ToString();

                    Form5 f5 = new Form5();
                    f5.Show();
                    login = true;
                    break;
                }
            }

            if (login == false)
            {
                string message = "Incorrect login details";
                MessageBox.Show(message);
                Form5 f2 = new Form5();
                f2.Show();
            }

        }
    }
}
