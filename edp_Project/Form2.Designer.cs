namespace edp_Project
{
    partial class Customer
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
            this.update_but = new System.Windows.Forms.Button();
            this.delete_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_but = new System.Windows.Forms.Button();
            this.categories_but = new System.Windows.Forms.Button();
            this.suppliers_but = new System.Windows.Forms.Button();
            this.products_but = new System.Windows.Forms.Button();
            this.pets_but = new System.Windows.Forms.Button();
            this.orders_but = new System.Windows.Forms.Button();
            this.orderdetails_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.add_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_data = new System.Windows.Forms.DataGridView();
            this.customer_reportgenerator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).BeginInit();
            this.SuspendLayout();
            // 
            // update_but
            // 
            this.update_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_but.Location = new System.Drawing.Point(817, 851);
            this.update_but.Name = "update_but";
            this.update_but.Size = new System.Drawing.Size(162, 61);
            this.update_but.TabIndex = 32;
            this.update_but.Text = "Update Customer";
            this.update_but.UseVisualStyleBackColor = true;
            this.update_but.UseWaitCursor = true;
            this.update_but.Click += new System.EventHandler(this.update_but_Click);
            // 
            // delete_but
            // 
            this.delete_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_but.Location = new System.Drawing.Point(618, 851);
            this.delete_but.Name = "delete_but";
            this.delete_but.Size = new System.Drawing.Size(162, 61);
            this.delete_but.TabIndex = 31;
            this.delete_but.Text = "Delete Customer";
            this.delete_but.UseVisualStyleBackColor = true;
            this.delete_but.UseWaitCursor = true;
            this.delete_but.Click += new System.EventHandler(this.delete_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(426, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 33);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.customer_but);
            this.panel1.Controls.Add(this.categories_but);
            this.panel1.Controls.Add(this.suppliers_but);
            this.panel1.Controls.Add(this.products_but);
            this.panel1.Controls.Add(this.pets_but);
            this.panel1.Controls.Add(this.orders_but);
            this.panel1.Controls.Add(this.orderdetails_but);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 1041);
            this.panel1.TabIndex = 25;
            this.panel1.UseWaitCursor = true;
            // 
            // customer_but
            // 
            this.customer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_but.Location = new System.Drawing.Point(107, 165);
            this.customer_but.Name = "customer_but";
            this.customer_but.Size = new System.Drawing.Size(161, 52);
            this.customer_but.TabIndex = 11;
            this.customer_but.Text = "Customers";
            this.customer_but.UseVisualStyleBackColor = true;
            this.customer_but.UseWaitCursor = true;
            this.customer_but.Click += new System.EventHandler(this.button13_Click);
            // 
            // categories_but
            // 
            this.categories_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories_but.Location = new System.Drawing.Point(107, 580);
            this.categories_but.Name = "categories_but";
            this.categories_but.Size = new System.Drawing.Size(161, 52);
            this.categories_but.TabIndex = 7;
            this.categories_but.Text = "Users";
            this.categories_but.UseVisualStyleBackColor = true;
            this.categories_but.UseWaitCursor = true;
            this.categories_but.Click += new System.EventHandler(this.categories_but_Click);
            // 
            // suppliers_but
            // 
            this.suppliers_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_but.Location = new System.Drawing.Point(107, 509);
            this.suppliers_but.Name = "suppliers_but";
            this.suppliers_but.Size = new System.Drawing.Size(161, 52);
            this.suppliers_but.TabIndex = 6;
            this.suppliers_but.Text = "Suppliers";
            this.suppliers_but.UseVisualStyleBackColor = true;
            this.suppliers_but.UseWaitCursor = true;
            this.suppliers_but.Click += new System.EventHandler(this.suppliers_but_Click);
            // 
            // products_but
            // 
            this.products_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_but.Location = new System.Drawing.Point(107, 437);
            this.products_but.Name = "products_but";
            this.products_but.Size = new System.Drawing.Size(161, 52);
            this.products_but.TabIndex = 5;
            this.products_but.Text = "Products";
            this.products_but.UseVisualStyleBackColor = true;
            this.products_but.UseWaitCursor = true;
            this.products_but.Click += new System.EventHandler(this.products_but_Click);
            // 
            // pets_but
            // 
            this.pets_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pets_but.Location = new System.Drawing.Point(107, 369);
            this.pets_but.Name = "pets_but";
            this.pets_but.Size = new System.Drawing.Size(161, 52);
            this.pets_but.TabIndex = 4;
            this.pets_but.Text = "Pets";
            this.pets_but.UseVisualStyleBackColor = true;
            this.pets_but.UseWaitCursor = true;
            this.pets_but.Click += new System.EventHandler(this.pets_but_Click);
            // 
            // orders_but
            // 
            this.orders_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_but.Location = new System.Drawing.Point(107, 232);
            this.orders_but.Name = "orders_but";
            this.orders_but.Size = new System.Drawing.Size(161, 52);
            this.orders_but.TabIndex = 3;
            this.orders_but.Text = "Orders";
            this.orders_but.UseVisualStyleBackColor = true;
            this.orders_but.UseWaitCursor = true;
            this.orders_but.Click += new System.EventHandler(this.button6_Click);
            // 
            // orderdetails_but
            // 
            this.orderdetails_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdetails_but.Location = new System.Drawing.Point(107, 300);
            this.orderdetails_but.Name = "orderdetails_but";
            this.orderdetails_but.Size = new System.Drawing.Size(161, 52);
            this.orderdetails_but.TabIndex = 2;
            this.orderdetails_but.Text = "Order Details";
            this.orderdetails_but.UseVisualStyleBackColor = true;
            this.orderdetails_but.UseWaitCursor = true;
            this.orderdetails_but.Click += new System.EventHandler(this.orderdetails_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dashboard";
            this.label2.UseWaitCursor = true;
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_but.Location = new System.Drawing.Point(426, 851);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(162, 61);
            this.add_but.TabIndex = 23;
            this.add_but.Text = "Add Customer";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.UseWaitCursor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customers Table";
            this.label1.UseWaitCursor = true;
            // 
            // customer_data
            // 
            this.customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data.Location = new System.Drawing.Point(426, 194);
            this.customer_data.Name = "customer_data";
            this.customer_data.RowHeadersWidth = 51;
            this.customer_data.RowTemplate.Height = 24;
            this.customer_data.Size = new System.Drawing.Size(1564, 607);
            this.customer_data.TabIndex = 24;
            this.customer_data.UseWaitCursor = true;
            this.customer_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_data_CellContentClick);
            // 
            // customer_reportgenerator
            // 
            this.customer_reportgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_reportgenerator.Location = new System.Drawing.Point(1828, 851);
            this.customer_reportgenerator.Name = "customer_reportgenerator";
            this.customer_reportgenerator.Size = new System.Drawing.Size(162, 61);
            this.customer_reportgenerator.TabIndex = 33;
            this.customer_reportgenerator.Text = "MS Excel Report";
            this.customer_reportgenerator.UseVisualStyleBackColor = true;
            this.customer_reportgenerator.UseWaitCursor = true;
            this.customer_reportgenerator.Click += new System.EventHandler(this.customer_reportgenerator_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.customer_reportgenerator);
            this.Controls.Add(this.update_but);
            this.Controls.Add(this.delete_but);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_data);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_but;
        private System.Windows.Forms.Button delete_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button categories_but;
        private System.Windows.Forms.Button suppliers_but;
        private System.Windows.Forms.Button pets_but;
        private System.Windows.Forms.Button orders_but;
        private System.Windows.Forms.Button orderdetails_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button products_but;
        private System.Windows.Forms.DataGridView customer_data;
        private System.Windows.Forms.Button customer_reportgenerator;
    }
}