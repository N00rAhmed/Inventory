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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"C:\kraftan\Inventory");
            conn.Open();

            string query = "SELECT * FROM Kaftan_Stock";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvInventoryViewer.DataSource = dt;
            //dgvTasks.Columns[3].Visible = false;





            conn.Close();

        }

        private void dgvInventoryViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
