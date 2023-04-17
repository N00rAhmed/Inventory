namespace Inventory
{
    partial class WelcomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Titletxtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create_account
            // 
            this.Create_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Create_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_account.Location = new System.Drawing.Point(350, 123);
            this.Create_account.Name = "Create_account";
            this.Create_account.Size = new System.Drawing.Size(108, 42);
            this.Create_account.TabIndex = 0;
            this.Create_account.Text = "Create";
            this.Create_account.UseVisualStyleBackColor = true;
            this.Create_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(350, 198);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(108, 42);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManagerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerBtn.Location = new System.Drawing.Point(350, 281);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Size = new System.Drawing.Size(108, 42);
            this.ManagerBtn.TabIndex = 2;
            this.ManagerBtn.Text = "Manager";
            this.ManagerBtn.UseVisualStyleBackColor = true;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(127)))), ((int)(((byte)(24)))));
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 53);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(127)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 74);
            this.panel2.TabIndex = 8;
            // 
            // Titletxtbox
            // 
            this.Titletxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.Titletxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Titletxtbox.Location = new System.Drawing.Point(0, -3);
            this.Titletxtbox.Name = "Titletxtbox";
            this.Titletxtbox.Size = new System.Drawing.Size(76, 38);
            this.Titletxtbox.TabIndex = 9;
            this.Titletxtbox.Text = "Cool";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Location = new System.Drawing.Point(67, -3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 38);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Kaftan";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Titletxtbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManagerBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Create_account);
            this.MinimumSize = new System.Drawing.Size(200, 470);
            this.Name = "WelcomePage";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_account;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button ManagerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Titletxtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

