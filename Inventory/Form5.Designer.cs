﻿namespace Inventory
{
    partial class Form5
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
            this.dgvInventoryCRUD = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.TextBox();
            this.Units = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Supplier = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Inventory CRUD";
            // 
            // dgvInventoryCRUD
            // 
            this.dgvInventoryCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryCRUD.Location = new System.Drawing.Point(12, 90);
            this.dgvInventoryCRUD.Name = "dgvInventoryCRUD";
            this.dgvInventoryCRUD.Size = new System.Drawing.Size(855, 276);
            this.dgvInventoryCRUD.TabIndex = 1;
            this.dgvInventoryCRUD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryCRUD_CellContentClick);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(106, 393);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(171, 20);
            this.Category.TabIndex = 2;
            // 
            // Units
            // 
            this.Units.Location = new System.Drawing.Point(106, 463);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(171, 20);
            this.Units.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(106, 428);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(171, 20);
            this.Price.TabIndex = 4;
            // 
            // Supplier
            // 
            this.Supplier.Location = new System.Drawing.Point(106, 490);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(171, 20);
            this.Supplier.TabIndex = 5;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(106, 367);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(171, 20);
            this.Product.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "supplier";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(404, 385);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 35);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(404, 428);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(98, 35);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IDField
            // 
            this.IDField.Location = new System.Drawing.Point(320, 436);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(65, 20);
            this.IDField.TabIndex = 14;
            this.IDField.TextChanged += new System.EventHandler(this.IDField_TextChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(404, 479);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(98, 35);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.dgvInventoryCRUD);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryCRUD;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Units;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Supplier;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label7;
    }
}