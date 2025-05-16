namespace edp_Project
{
    partial class ForgotPassword
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
            this.label8 = new System.Windows.Forms.Label();
            this.motto_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_but = new System.Windows.Forms.Button();
            this.email_box = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "What is your motto?";
            // 
            // motto_box
            // 
            this.motto_box.Location = new System.Drawing.Point(248, 220);
            this.motto_box.Name = "motto_box";
            this.motto_box.Size = new System.Drawing.Size(300, 22);
            this.motto_box.TabIndex = 36;
            this.motto_box.TextChanged += new System.EventHandler(this.motto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 36);
            this.label3.TabIndex = 35;
            this.label3.Text = "Account Recovery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // confirm_but
            // 
            this.confirm_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_but.Location = new System.Drawing.Point(453, 272);
            this.confirm_but.Name = "confirm_but";
            this.confirm_but.Size = new System.Drawing.Size(95, 30);
            this.confirm_but.TabIndex = 33;
            this.confirm_but.Text = "Continue";
            this.confirm_but.UseVisualStyleBackColor = true;
            this.confirm_but.Click += new System.EventHandler(this.confirm_but_Click);
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(248, 152);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(300, 22);
            this.email_box.TabIndex = 32;
            this.email_box.TextChanged += new System.EventHandler(this.email_box_TextChanged);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(245, 280);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 38;
            this.back.TabStop = true;
            this.back.Text = "Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.motto_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_but);
            this.Controls.Add(this.email_box);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox motto_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_but;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.LinkLabel back;
    }
}