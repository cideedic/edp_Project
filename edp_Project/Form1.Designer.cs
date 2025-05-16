namespace edp_Project
{
    partial class login
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
            this.username_box = new System.Windows.Forms.TextBox();
            this.login_but = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_account = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(156, 146);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(300, 22);
            this.username_box.TabIndex = 0;
            this.username_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // login_but
            // 
            this.login_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_but.Location = new System.Drawing.Point(361, 241);
            this.login_but.Name = "login_but";
            this.login_but.Size = new System.Drawing.Size(95, 30);
            this.login_but.TabIndex = 1;
            this.login_but.Text = "Log In";
            this.login_but.UseVisualStyleBackColor = true;
            this.login_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(156, 196);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(300, 22);
            this.password_box.TabIndex = 2;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pet Store Admin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // create_account
            // 
            this.create_account.AutoSize = true;
            this.create_account.Location = new System.Drawing.Point(153, 241);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(98, 16);
            this.create_account.TabIndex = 7;
            this.create_account.TabStop = true;
            this.create_account.Text = "Create Account";
            this.create_account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.create_account_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(153, 267);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 16);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 378);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.create_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_but);
            this.Controls.Add(this.username_box);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Button login_but;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel create_account;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

