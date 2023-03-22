namespace Inventory
{
    partial class Form1
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
            this.Create_account = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.ManagerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_account
            // 
            this.Create_account.Location = new System.Drawing.Point(324, 123);
            this.Create_account.Name = "Create_account";
            this.Create_account.Size = new System.Drawing.Size(108, 42);
            this.Create_account.TabIndex = 0;
            this.Create_account.Text = "create account";
            this.Create_account.UseVisualStyleBackColor = true;
            this.Create_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(324, 198);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(108, 42);
            this.Login.TabIndex = 1;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Location = new System.Drawing.Point(324, 281);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Size = new System.Drawing.Size(108, 42);
            this.ManagerBtn.TabIndex = 2;
            this.ManagerBtn.Text = "Manager";
            this.ManagerBtn.UseVisualStyleBackColor = true;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ManagerBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Create_account);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_account;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button ManagerBtn;
    }
}

