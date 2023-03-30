using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(Inventory.DB.DBLocation);
            conn.Open();

            string query = "SELECT * FROM Kaftan_Stock";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
            adapter.Fill(dt);

            dgvStockLimit.DataSource = dt;
            conn.Close();
            CheckBuffer();
        }

        void CheckBuffer()
        {
            int rowCount = dgvStockLimit.Rows.Count;
            int bufferLimit = 0;
            SQLiteConnection connection = new SQLiteConnection(Inventory.DB.DBLocation);
            connection.Open();
            // Get Current BufferLimit from database
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM StockLimit";

                // execute query and get data reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    bufferLimit = reader.GetInt32(0);
                }
                connection.Close();
            }
            txtBufferLimit.Text = bufferLimit.ToString(); // Set textbox to have set limit in db
            // loop through each cell
            for (int row = 3; row < rowCount; row++)
            {
                DataGridViewCell bufferCell = dgvStockLimit.Rows[row].Cells["Buffer"];
                DataGridViewCell itemCell = dgvStockLimit.Rows[row].Cells["Items"];
                DataGridViewCell detailCell = dgvStockLimit.Rows[row].Cells["Detail"];
                if (bufferCell.Value != null && detailCell.Value != null && itemCell.Value != null && bufferCell.Value.ToString() != null && bufferCell.Value.ToString() != "" && itemCell.Value.ToString() != "")
                {
                    int bufferValue = 0;
                    try
                    {
                        bufferValue = Int32.Parse(bufferCell.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (bufferValue < bufferLimit)
                    {
                        //label1.Text = dgvStockLimit.Rows[row].Cells["Buffer"].Value.ToString();
                        SendEmail(itemCell.Value.ToString(),detailCell.Value.ToString(), bufferCell.Value.ToString());
                    }
                }
            }
        }


        void SendEmail(string name, string detail, string value)
        {
            string fromEmail = "testing2398462394623@outlook.com";
            string toEmail = "Tronn232003@gmail.com"; // Replace with the user's email address
            string emailSubject = "Stock Alert";
            string emailBody = $"Product buffer {name} {detail} has more than {value}.";

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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string insertQuery = "UPDATE StockLimit SET \"Limit\" = " + txtBufferLimit.Text.ToString();
            SQLiteConnection connection = new SQLiteConnection(Inventory.DB.DBLocation);
            connection.Open();
            SQLiteCommand query = new SQLiteCommand(insertQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
            CheckBuffer();
        }
    }
}
