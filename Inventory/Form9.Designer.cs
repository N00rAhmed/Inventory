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
            this.dgvStockLimit = new System.Windows.Forms.DataGridView();
            this.txtBufferLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockLimit
            // 
            this.dgvStockLimit.AllowUserToOrderColumns = true;
            this.dgvStockLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockLimit.Location = new System.Drawing.Point(52, 35);
            this.dgvStockLimit.Name = "dgvStockLimit";
            this.dgvStockLimit.Size = new System.Drawing.Size(539, 296);
            this.dgvStockLimit.TabIndex = 0;
            // 
            // txtBufferLimit
            // 
            this.txtBufferLimit.Location = new System.Drawing.Point(111, 354);
            this.txtBufferLimit.Name = "txtBufferLimit";
            this.txtBufferLimit.Size = new System.Drawing.Size(100, 20);
            this.txtBufferLimit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BufferLimit";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(111, 381);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBufferLimit);
            this.Controls.Add(this.dgvStockLimit);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockLimit;
        private System.Windows.Forms.TextBox txtBufferLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
    }
}