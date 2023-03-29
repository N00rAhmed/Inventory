namespace Inventory
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventoryViewer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogoutBTN1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Manager";
            // 
            // dgvInventoryViewer
            // 
            this.dgvInventoryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryViewer.Location = new System.Drawing.Point(79, 103);
            this.dgvInventoryViewer.Name = "dgvInventoryViewer";
            this.dgvInventoryViewer.Size = new System.Drawing.Size(634, 301);
            this.dgvInventoryViewer.TabIndex = 1;
            this.dgvInventoryViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryViewer_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(-894, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2588, 31);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Location = new System.Drawing.Point(-894, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2588, 354);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cool";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(73, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kaftan";
            // 
            // LogoutBTN1
            // 
            this.LogoutBTN1.Location = new System.Drawing.Point(713, 12);
            this.LogoutBTN1.Name = "LogoutBTN1";
            this.LogoutBTN1.Size = new System.Drawing.Size(75, 23);
            this.LogoutBTN1.TabIndex = 25;
            this.LogoutBTN1.Text = "Logout";
            this.LogoutBTN1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBTN1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInventoryViewer);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LogoutBTN1;
    }
}