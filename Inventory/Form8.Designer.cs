namespace Inventory
{
    partial class Form8
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
            this.MLogin = new System.Windows.Forms.Button();
            this.MRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MLogin
            // 
            this.MLogin.Location = new System.Drawing.Point(352, 95);
            this.MLogin.Name = "MLogin";
            this.MLogin.Size = new System.Drawing.Size(97, 39);
            this.MLogin.TabIndex = 1;
            this.MLogin.Text = "manager login";
            this.MLogin.UseVisualStyleBackColor = true;
            this.MLogin.Click += new System.EventHandler(this.MLogin_Click);
            // 
            // MRegister
            // 
            this.MRegister.Location = new System.Drawing.Point(352, 186);
            this.MRegister.Name = "MRegister";
            this.MRegister.Size = new System.Drawing.Size(97, 39);
            this.MRegister.TabIndex = 2;
            this.MRegister.Text = "create account";
            this.MRegister.UseVisualStyleBackColor = true;
            this.MRegister.Click += new System.EventHandler(this.MRegister_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MRegister);
            this.Controls.Add(this.MLogin);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MLogin;
        private System.Windows.Forms.Button MRegister;
    }
}