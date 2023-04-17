using AForge.Video.DirectShow;
using ZXing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;

namespace Inventory
{
    public partial class Barcodescanner : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public Barcodescanner()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice == null)
            { 
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
            else
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bitmapDecode = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            if (bitmap != null && pictureBox != null)
            {
                try
                {
                    pictureBox.BeginInvoke(new Action(() => pictureBox.Image = bitmap));
                }
                catch
                {
                    return;
                }
            }
            var result = reader.Decode(bitmapDecode);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                }));
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "" || txtBarcode != null)
            {
                SQLiteConnection conn = new SQLiteConnection(DB.DBLocation);
                conn.Open();
                string dbQuery = "INSERT INTO ScannedBarcodes(BarcodeID, DateTime)" + "VALUES ('" + txtBarcode.Text + "', '" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + "')";
                SQLiteCommand cmd = new SQLiteCommand(dbQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
