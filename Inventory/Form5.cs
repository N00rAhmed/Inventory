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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;




/*System.Data.SQLite.SQLiteException: 'database is locked
database is locked'
*/
namespace Inventory
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadData();
            //AllocConsole();
        }
        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();*/
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();

            string query = "SELECT * FROM Kaftan_Stock";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvInventoryCRUD.DataSource = dt;
            //dgvTasks.Columns[3].Visible = false;

            conn.Close();
        }

        private void AmendDatabase(string dbQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(DB.DBLocation);
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(dbQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            // Reset text fields
            Product.Text = "";
            Category.Text = "";
            Price.Text = "";
            Units.Text = "";
            Supplier.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string dbquery = "INSERT INTO Kaftan_Stock(Items, Detail, Buffer, Price, Manufactorer)" + "VALUES ('" + Product.Text + "','" + Category.Text + "','" + Units.Text + "','" + Price.Text + "','" + Supplier.Text + "')";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string dbquery = "DELETE FROM Kaftan_Stock WHERE StockID = '" + IDField.Text + "'";
            AmendDatabase(dbquery);
            LoadData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string dbquery = "Update Kaftan_Stock set Items='" + Product.Text + "' where StockID = '" + IDField.Text + "'";
            string query = "Update Kaftan_Stock set Detail ='" + Category.Text + "' where StockID = '" + IDField.Text + "'";
            string query2 = "Update Kaftan_Stock set Buffer ='" + Units.Text + "' where StockID = '" + IDField.Text + "'";
            string query3 = "Update Kaftan_Stock set Price ='" + Price.Text + "' where StockID = '" + IDField.Text + "'";
            string query4 = "Update Kaftan_Stock set Manufactorer ='" + Supplier.Text + "' where StockID = '" + IDField.Text + "'";
            // TO-DO: do empty string checks and prevent other data from being overwritten accidentally
            AmendDatabase(dbquery);
            AmendDatabase(query);
            AmendDatabase(query2);
            AmendDatabase(query3);
            AmendDatabase(query4);
            LoadData();
        }

        private void LimitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void ScannerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnCheckStockPerformance_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var dateTimeO = new DateTimeOffset(startDate);
            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();
            string query = "SELECT * FROM ScannedBarcodes WHERE DateTime>="+ dateTimeO.ToUnixTimeMilliseconds();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            Dictionary<int, int> itemCount = new Dictionary<int, int>();

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                var rowArray = dt.Rows[row].ItemArray;
                //Console.WriteLine("BarcodeID = {0}, DateTIme = {1}", rowArray.ElementAt(0).ToString(), rowArray.ElementAt(1).ToString());
                int O;
                if (itemCount.TryGetValue(Int32.Parse(rowArray.ElementAt(0).ToString()), out O)) // if exists in dictionary
                {
                    itemCount[Int32.Parse(rowArray.ElementAt(0).ToString())] = O+1;
                }
                else // if doesn't exist in dictionary
                {
                    itemCount[Int32.Parse(rowArray.ElementAt(0).ToString())] = 1;
                }
            }
            foreach (KeyValuePair<int, int> kvp in itemCount)
            {
                if (kvp.Value < 5) {
                    string name = "";
                    string detail = "";
                    string value = kvp.Value.ToString();
                    SQLiteConnection connection = new SQLiteConnection(DB.DBLocation);
                    connection.Open();
                    // Get Current BufferLimit from database
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "SELECT Items, Detail FROM Kaftan_Stock";

                        // execute query and get data reader
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            name = reader.GetString(0);
                            detail = reader.GetString(1);
                        }
                        connection.Close();
                    }
                    SendEmail(name, detail, "");
                }
            }
        }
        private void SendEmail(string name, string detail, string value)
        {
            string fromEmail = "testing2398462394623@outlook.com";
            string toEmail = "Tronn232003@gmail.com"; // Replace with the user's email address
            string emailSubject = "Stock Alert";
            string emailBody = $"Product {name} {detail} has been scanned less than {value}.";

            MailMessage mail = new MailMessage
            {
                From = new MailAddress("testing2398462394623@gmail.com"), // Replace with your Gmail address
                Subject = emailSubject,
                Body = emailBody
            };
            mail.To.Add(toEmail);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("testing2398462394623@outlook.com", "BHgiidc98696vJFYJ"), // Replace with your Gmail address and password
                EnableSsl = true,
                Timeout = 20000
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = emailSubject,
                Body = emailBody
            })
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email: " + ex.Message);
                }
        }
    }
}
