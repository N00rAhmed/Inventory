namespace Inventory
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBufferLimit = new System.Windows.Forms.TextBox();
            this.dgvStockLimit = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Titletxtbox = new System.Windows.Forms.TextBox();
            this.txtScanLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(411, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBufferLimit
            // 
            this.txtBufferLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBufferLimit.Location = new System.Drawing.Point(230, 324);
            this.txtBufferLimit.Name = "txtBufferLimit";
            this.txtBufferLimit.Size = new System.Drawing.Size(175, 20);
            this.txtBufferLimit.TabIndex = 1;
            this.txtBufferLimit.TextChanged += new System.EventHandler(this.txtBufferLimit_TextChanged);
            // 
            // dgvStockLimit
            // 
            this.dgvStockLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvStockLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockLimit.Location = new System.Drawing.Point(121, 84);
            this.dgvStockLimit.Name = "dgvStockLimit";
            this.dgvStockLimit.Size = new System.Drawing.Size(476, 234);
            this.dgvStockLimit.TabIndex = 2;
            this.dgvStockLimit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockLimit_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(127)))), ((int)(((byte)(24)))));
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 66);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(127)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Titletxtbox);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 70);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Location = new System.Drawing.Point(67, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 38);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Kaftan";
            // 
            // Titletxtbox
            // 
            this.Titletxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.Titletxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Titletxtbox.Location = new System.Drawing.Point(0, 8);
            this.Titletxtbox.Name = "Titletxtbox";
            this.Titletxtbox.Size = new System.Drawing.Size(76, 38);
            this.Titletxtbox.TabIndex = 11;
            this.Titletxtbox.Text = "Cool";
            // 
            // txtScanLimit
            // 
            this.txtScanLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanLimit.Location = new System.Drawing.Point(230, 346);
            this.txtScanLimit.Name = "txtScanLimit";
            this.txtScanLimit.Size = new System.Drawing.Size(175, 20);
            this.txtScanLimit.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "BufferLimit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "ScanLimit";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanLimit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvStockLimit);
            this.Controls.Add(this.txtBufferLimit);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBufferLimit;
        private System.Windows.Forms.DataGridView dgvStockLimit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Titletxtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtScanLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}