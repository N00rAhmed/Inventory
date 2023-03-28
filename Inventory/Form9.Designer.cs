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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(272, 296);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBufferLimit
            // 
            this.txtBufferLimit.Location = new System.Drawing.Point(67, 296);
            this.txtBufferLimit.Name = "txtBufferLimit";
            this.txtBufferLimit.Size = new System.Drawing.Size(175, 20);
            this.txtBufferLimit.TabIndex = 1;
            this.txtBufferLimit.TextChanged += new System.EventHandler(this.txtBufferLimit_TextChanged);
            // 
            // dgvStockLimit
            // 
            this.dgvStockLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockLimit.Location = new System.Drawing.Point(54, 26);
            this.dgvStockLimit.Name = "dgvStockLimit";
            this.dgvStockLimit.Size = new System.Drawing.Size(476, 234);
            this.dgvStockLimit.TabIndex = 2;
            this.dgvStockLimit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockLimit_CellContentClick);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStockLimit);
            this.Controls.Add(this.txtBufferLimit);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBufferLimit;
        private System.Windows.Forms.DataGridView dgvStockLimit;
    }
}