﻿namespace edp_Project
{
    partial class getOrder
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.confirm_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_cus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(61, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // confirm_but
            // 
            this.confirm_but.Location = new System.Drawing.Point(455, 167);
            this.confirm_but.Name = "confirm_but";
            this.confirm_but.Size = new System.Drawing.Size(104, 41);
            this.confirm_but.TabIndex = 24;
            this.confirm_but.Text = "Confirm";
            this.confirm_but.UseVisualStyleBackColor = true;
            this.confirm_but.Click += new System.EventHandler(this.confirm_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer ID";
            // 
            // textbox_cus
            // 
            this.textbox_cus.Location = new System.Drawing.Point(177, 119);
            this.textbox_cus.Name = "textbox_cus";
            this.textbox_cus.Size = new System.Drawing.Size(245, 22);
            this.textbox_cus.TabIndex = 14;
            this.textbox_cus.TextChanged += new System.EventHandler(this.textbox_cus_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Get Customer Order";
            // 
            // getOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 282);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.confirm_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_cus);
            this.Controls.Add(this.label1);
            this.Name = "getOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button confirm_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_cus;
        private System.Windows.Forms.Label label1;
    }
}