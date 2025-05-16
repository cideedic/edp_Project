namespace edp_Project
{
    partial class addProduct
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
            this.categoryid_textbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addprod_but = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stock_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productname_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoryid_textbox
            // 
            this.categoryid_textbox.Location = new System.Drawing.Point(179, 307);
            this.categoryid_textbox.Name = "categoryid_textbox";
            this.categoryid_textbox.Size = new System.Drawing.Size(245, 22);
            this.categoryid_textbox.TabIndex = 48;
            this.categoryid_textbox.TextChanged += new System.EventHandler(this.categoryid_textbox_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(79, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // addprod_but
            // 
            this.addprod_but.Location = new System.Drawing.Point(466, 360);
            this.addprod_but.Name = "addprod_but";
            this.addprod_but.Size = new System.Drawing.Size(104, 41);
            this.addprod_but.TabIndex = 44;
            this.addprod_but.Text = "Confirm";
            this.addprod_but.UseVisualStyleBackColor = true;
            this.addprod_but.Click += new System.EventHandler(this.addprod_but_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Category ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stock Quantity";
            // 
            // stock_textbox
            // 
            this.stock_textbox.Location = new System.Drawing.Point(179, 250);
            this.stock_textbox.Name = "stock_textbox";
            this.stock_textbox.Size = new System.Drawing.Size(245, 22);
            this.stock_textbox.TabIndex = 41;
            this.stock_textbox.TextChanged += new System.EventHandler(this.stock_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price";
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(179, 204);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(245, 22);
            this.price_textbox.TabIndex = 39;
            this.price_textbox.TextChanged += new System.EventHandler(this.price_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Description";
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(179, 157);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(245, 22);
            this.description_textbox.TabIndex = 37;
            this.description_textbox.TextChanged += new System.EventHandler(this.description_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            // 
            // productname_textbox
            // 
            this.productname_textbox.Location = new System.Drawing.Point(179, 112);
            this.productname_textbox.Name = "productname_textbox";
            this.productname_textbox.Size = new System.Drawing.Size(245, 22);
            this.productname_textbox.TabIndex = 35;
            this.productname_textbox.TextChanged += new System.EventHandler(this.productname_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Add Product";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryid_textbox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.addprod_but);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stock_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productname_textbox);
            this.Name = "addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox categoryid_textbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addprod_but;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stock_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productname_textbox;
        private System.Windows.Forms.Label label1;
    }
}