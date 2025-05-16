namespace edp_Project
{
    partial class deleteOrder
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
            this.deleteOrder_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_orderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(77, 277);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 16);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // deleteOrder_but
            // 
            this.deleteOrder_but.Location = new System.Drawing.Point(446, 265);
            this.deleteOrder_but.Name = "deleteOrder_but";
            this.deleteOrder_but.Size = new System.Drawing.Size(104, 41);
            this.deleteOrder_but.TabIndex = 42;
            this.deleteOrder_but.Text = "Confirm";
            this.deleteOrder_but.UseVisualStyleBackColor = true;
            this.deleteOrder_but.Click += new System.EventHandler(this.deleteOrder_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Customer ID";
            // 
            // textBox_customerID
            // 
            this.textBox_customerID.Location = new System.Drawing.Point(176, 121);
            this.textBox_customerID.Name = "textBox_customerID";
            this.textBox_customerID.Size = new System.Drawing.Size(245, 22);
            this.textBox_customerID.TabIndex = 40;
            this.textBox_customerID.TextChanged += new System.EventHandler(this.textBox_customerID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Delete Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Order ID";
            // 
            // textbox_orderID
            // 
            this.textbox_orderID.Location = new System.Drawing.Point(176, 203);
            this.textbox_orderID.Name = "textbox_orderID";
            this.textbox_orderID.Size = new System.Drawing.Size(245, 22);
            this.textbox_orderID.TabIndex = 45;
            this.textbox_orderID.TextChanged += new System.EventHandler(this.textbox_orderID_TextChanged);
            // 
            // deleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_orderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.deleteOrder_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_customerID);
            this.Controls.Add(this.label1);
            this.Name = "deleteOrder";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.deleteOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button deleteOrder_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_orderID;
    }
}