namespace edp_Project
{
    partial class CreateAccount
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
            this.back = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.create_but = new System.Windows.Forms.Button();
            this.email_box = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.motto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(222, 452);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 21;
            this.back.TabStop = true;
            this.back.Text = "Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Creating Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(225, 344);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(300, 22);
            this.password_box.TabIndex = 17;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // create_but
            // 
            this.create_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_but.Location = new System.Drawing.Point(430, 444);
            this.create_but.Name = "create_but";
            this.create_but.Size = new System.Drawing.Size(95, 30);
            this.create_but.TabIndex = 16;
            this.create_but.Text = "Create";
            this.create_but.UseVisualStyleBackColor = true;
            this.create_but.Click += new System.EventHandler(this.create_but_Click);
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(225, 145);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(300, 22);
            this.email_box.TabIndex = 15;
            this.email_box.TextChanged += new System.EventHandler(this.email_box_TextChanged);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(225, 197);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(148, 22);
            this.firstname.TabIndex = 22;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(377, 197);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(148, 22);
            this.lastname.TabIndex = 24;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Phone Number";
            // 
            // phonenum
            // 
            this.phonenum.Location = new System.Drawing.Point(225, 297);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(300, 22);
            this.phonenum.TabIndex = 26;
            this.phonenum.TextChanged += new System.EventHandler(this.phonenum_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(225, 247);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(300, 22);
            this.address.TabIndex = 28;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "What is your motto?";
            // 
            // motto
            // 
            this.motto.Location = new System.Drawing.Point(225, 395);
            this.motto.Name = "motto";
            this.motto.Size = new System.Drawing.Size(300, 22);
            this.motto.TabIndex = 30;
            this.motto.TextChanged += new System.EventHandler(this.motto_TextChanged);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.motto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.create_but);
            this.Controls.Add(this.email_box);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button create_but;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox motto;
    }
}