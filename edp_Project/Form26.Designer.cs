namespace edp_Project
{
    partial class addUser
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.adduser_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.motto_textbox = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 77;
            this.label1.Text = "Add User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(66, 316);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 75;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // adduser_but
            // 
            this.adduser_but.Location = new System.Drawing.Point(453, 304);
            this.adduser_but.Name = "adduser_but";
            this.adduser_but.Size = new System.Drawing.Size(104, 41);
            this.adduser_but.TabIndex = 74;
            this.adduser_but.Text = "Confirm";
            this.adduser_but.UseVisualStyleBackColor = true;
            this.adduser_but.Click += new System.EventHandler(this.adduser_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Motto";
            // 
            // motto_textbox
            // 
            this.motto_textbox.Location = new System.Drawing.Point(165, 252);
            this.motto_textbox.Name = "motto_textbox";
            this.motto_textbox.Size = new System.Drawing.Size(245, 22);
            this.motto_textbox.TabIndex = 71;
            this.motto_textbox.TextChanged += new System.EventHandler(this.motto_textbox_TextChanged);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(162, 187);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(68, 16);
            this.phone.TabIndex = 70;
            this.phone.Text = "Full Name";
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.Location = new System.Drawing.Point(165, 206);
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(245, 22);
            this.fullname_textbox.TabIndex = 69;
            this.fullname_textbox.TextChanged += new System.EventHandler(this.fullname_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(165, 159);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(245, 22);
            this.password_textbox.TabIndex = 67;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(162, 95);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 66;
            this.email.Text = "Email";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(165, 114);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(245, 22);
            this.email_textbox.TabIndex = 65;
            this.email_textbox.TextChanged += new System.EventHandler(this.suppliername_textbox_TextChanged);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.adduser_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.motto_textbox);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fullname_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_textbox);
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button adduser_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox motto_textbox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email_textbox;
    }
}