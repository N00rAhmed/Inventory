namespace Inventory
{
    partial class ManagerSetUnits
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
            this.UnitInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnitInput
            // 
            this.UnitInput.Location = new System.Drawing.Point(311, 163);
            this.UnitInput.Name = "UnitInput";
            this.UnitInput.Size = new System.Drawing.Size(163, 26);
            this.UnitInput.TabIndex = 0;
            this.UnitInput.TextChanged += new System.EventHandler(this.UnitImput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set units manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(351, 226);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(80, 31);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(368, 121);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(63, 20);
            this.ResultLbl.TabIndex = 3;
            this.ResultLbl.Text = "Results";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitInput);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnitInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label ResultLbl;
    }
}