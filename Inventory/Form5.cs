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
        }
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\KoolKaftan\Inventory\inventory.db");
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

        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\User\Desktop\KoolKaftan\Inventory\inventory.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            Product.Text = "";
            Category.Text = "";
            Price.Text = "";
            Units.Text = "";
            Supplier.Text = "";
/*            textBox1.Text = "";
*/        }

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


            AmendDatabase(dbquery);
            AmendDatabase(query);
            AmendDatabase(query2);
            AmendDatabase(query3);
            AmendDatabase(query4);

            LoadData();
            

        }

        private void dgvInventoryCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void IDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
