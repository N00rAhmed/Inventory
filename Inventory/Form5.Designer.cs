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
            this.Btnlogoutmanager = new System.Windows.Forms.Button();
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
            this.dgvInventoryCRUD.Location = new System.Drawing.Point(26, 115);
            this.dgvInventoryCRUD.Name = "dgvInventoryCRUD";
            this.dgvInventoryCRUD.Size = new System.Drawing.Size(739, 276);
            this.dgvInventoryCRUD.TabIndex = 1;
            // 
            // Btnlogoutmanager
            // 
            this.Btnlogoutmanager.Location = new System.Drawing.Point(608, 54);
            this.Btnlogoutmanager.Name = "Btnlogoutmanager";
            this.Btnlogoutmanager.Size = new System.Drawing.Size(75, 23);
            this.Btnlogoutmanager.TabIndex = 2;
            this.Btnlogoutmanager.Text = "Log out";
            this.Btnlogoutmanager.UseVisualStyleBackColor = true;
            this.Btnlogoutmanager.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnlogoutmanager);
            this.Controls.Add(this.dgvInventoryCRUD);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryCRUD;
        private System.Windows.Forms.Button Btnlogoutmanager;
    }
}