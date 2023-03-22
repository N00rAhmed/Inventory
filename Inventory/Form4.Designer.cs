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
            this.Btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Manager";
            // 
            // dgvInventoryViewer
            // 
            this.dgvInventoryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryViewer.Location = new System.Drawing.Point(68, 100);
            this.dgvInventoryViewer.Name = "dgvInventoryViewer";
            this.dgvInventoryViewer.Size = new System.Drawing.Size(634, 301);
            this.dgvInventoryViewer.TabIndex = 1;
            // 
            // Btnlogout
            // 
            this.Btnlogout.Location = new System.Drawing.Point(640, 61);
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Size = new System.Drawing.Size(75, 23);
            this.Btnlogout.TabIndex = 2;
            this.Btnlogout.Text = "Log out";
            this.Btnlogout.UseVisualStyleBackColor = true;
            this.Btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnlogout);
            this.Controls.Add(this.dgvInventoryViewer);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryViewer;
        private System.Windows.Forms.Button Btnlogout;
    }
}