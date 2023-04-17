using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ManagerSetUnits : Form
    {
        public ManagerSetUnits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void UnitImput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int userInput;
            if (!int.TryParse(UnitInput.Text, out userInput))
            {
                ResultLbl.Text = "invalid input please enter a number";
                return;
            }



            string connectionString = "Data Source=myDatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

            {
                SQLiteConnection conn = new SQLiteConnection(@"C:\kraftan\Inventory");
                conn.Open();
                string query = "SELECT Buffer(*) FROM Kaftan_Stock WHERE myColumn > @userInput";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {


                    command.Parameters.AddWithValue("@userInput", userInput);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        ResultLbl.Text = "There are values greater than the input.";
                        SendEmail(userInput);
                    }
                    else
                    {
                        ResultLbl.Text = "No values are greater than the input.";
                    }
                    connection.Close();
                }


                void SendEmail(int value)
                {
                    string userEmail = "user@example.com"; // Replace with the user's email address
                    string emailSubject = "Values greater than input";
                    string emailBody = $"There are values in the database greater than {value}.";

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress("your_email@gmail.com"), // Replace with your Gmail address
                        Subject = emailSubject,
                        Body = emailBody
                    };
                    mail.To.Add(userEmail);

                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "",
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential("your_email@gmail.com", "your_password"), // Replace with your Gmail address and password
                        EnableSsl = true
                    };

                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email: " + ex.Message);


                    }
                }
            }
        }   }
    
}
