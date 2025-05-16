namespace edp_Project
{
    partial class deleteCustomer
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.deleteCustomer_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(80, 162);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 16);
            this.linkLabel2.TabIndex = 38;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // deleteCustomer_but
            // 
            this.deleteCustomer_but.Location = new System.Drawing.Point(449, 150);
            this.deleteCustomer_but.Name = "deleteCustomer_but";
            this.deleteCustomer_but.Size = new System.Drawing.Size(104, 41);
            this.deleteCustomer_but.TabIndex = 37;
            this.deleteCustomer_but.Text = "Confirm";
            this.deleteCustomer_but.UseVisualStyleBackColor = true;
            this.deleteCustomer_but.Click += new System.EventHandler(this.deleteCustomer_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Customer ID";
            // 
            // textBox_customerID
            // 
            this.textBox_customerID.Location = new System.Drawing.Point(177, 105);
            this.textBox_customerID.Name = "textBox_customerID";
            this.textBox_customerID.Size = new System.Drawing.Size(245, 22);
            this.textBox_customerID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Delete Customer";
            // 
            // deleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 271);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.deleteCustomer_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_customerID);
            this.Controls.Add(this.label1);
            this.Name = "deleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button deleteCustomer_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_customerID;
        private System.Windows.Forms.Label label1;
    }
}