namespace Inventory
{
    partial class Form7
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
            this.Mngfname = new System.Windows.Forms.TextBox();
            this.mngLname = new System.Windows.Forms.MaskedTextBox();
            this.mngEmail = new System.Windows.Forms.TextBox();
            this.Mngusername = new System.Windows.Forms.TextBox();
            this.Mngpassword = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mngfname
            // 
            this.Mngfname.Location = new System.Drawing.Point(384, 123);
            this.Mngfname.Name = "Mngfname";
            this.Mngfname.Size = new System.Drawing.Size(124, 20);
            this.Mngfname.TabIndex = 0;
            // 
            // mngLname
            // 
            this.mngLname.Location = new System.Drawing.Point(384, 149);
            this.mngLname.Name = "mngLname";
            this.mngLname.Size = new System.Drawing.Size(124, 20);
            this.mngLname.TabIndex = 1;
            // 
            // mngEmail
            // 
            this.mngEmail.Location = new System.Drawing.Point(384, 184);
            this.mngEmail.Name = "mngEmail";
            this.mngEmail.Size = new System.Drawing.Size(124, 20);
            this.mngEmail.TabIndex = 2;
            // 
            // Mngusername
            // 
            this.Mngusername.Location = new System.Drawing.Point(384, 215);
            this.Mngusername.Name = "Mngusername";
            this.Mngusername.Size = new System.Drawing.Size(124, 20);
            this.Mngusername.TabIndex = 3;
            // 
            // Mngpassword
            // 
            this.Mngpassword.Location = new System.Drawing.Point(384, 247);
            this.Mngpassword.Name = "Mngpassword";
            this.Mngpassword.Size = new System.Drawing.Size(124, 20);
            this.Mngpassword.TabIndex = 4;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(288, 126);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(57, 13);
            this.F.TabIndex = 5;
            this.F.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manager Register";
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(384, 302);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(75, 28);
            this.Registerbtn.TabIndex = 11;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F);
            this.Controls.Add(this.Mngpassword);
            this.Controls.Add(this.Mngusername);
            this.Controls.Add(this.mngEmail);
            this.Controls.Add(this.mngLname);
            this.Controls.Add(this.Mngfname);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mngfname;
        private System.Windows.Forms.MaskedTextBox mngLname;
        private System.Windows.Forms.TextBox mngEmail;
        private System.Windows.Forms.TextBox Mngusername;
        private System.Windows.Forms.TextBox Mngpassword;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Registerbtn;
    }
}