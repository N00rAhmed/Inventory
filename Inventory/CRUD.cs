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
    public partial class CRUD : Form
    {
        public CRUD()
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

            dgvStockData.DataSource = dt;
            conn.Close();
        }



        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void dgvStockData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
