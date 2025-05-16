namespace edp_Project
{
    partial class Orders
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delete_logs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.order_logs_table = new System.Windows.Forms.DataGridView();
            this.orders_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_but = new System.Windows.Forms.Button();
            this.categories_but = new System.Windows.Forms.Button();
            this.suppliers_but = new System.Windows.Forms.Button();
            this.products_but = new System.Windows.Forms.Button();
            this.pets_but = new System.Windows.Forms.Button();
            this.orders_but = new System.Windows.Forms.Button();
            this.orderdetails_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orders_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orders_reportgenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.order_logs_table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(817, 851);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 61);
            this.button3.TabIndex = 43;
            this.button3.Text = "Update Status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(618, 851);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 61);
            this.button2.TabIndex = 42;
            this.button2.Text = "Delete Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete_logs
            // 
            this.delete_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_logs.Location = new System.Drawing.Point(1482, 851);
            this.delete_logs.Name = "delete_logs";
            this.delete_logs.Size = new System.Drawing.Size(159, 61);
            this.delete_logs.TabIndex = 41;
            this.delete_logs.Text = "Delete Logs";
            this.delete_logs.UseVisualStyleBackColor = true;
            this.delete_logs.UseWaitCursor = true;
            this.delete_logs.Click += new System.EventHandler(this.delete_logs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1476, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Order Logs";
            this.label3.UseWaitCursor = true;
            // 
            // order_logs_table
            // 
            this.order_logs_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_logs_table.Location = new System.Drawing.Point(1482, 194);
            this.order_logs_table.Name = "order_logs_table";
            this.order_logs_table.RowHeadersWidth = 51;
            this.order_logs_table.RowTemplate.Height = 24;
            this.order_logs_table.Size = new System.Drawing.Size(527, 607);
            this.order_logs_table.TabIndex = 39;
            this.order_logs_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_logs_table_CellContentClick);
            // 
            // orders_search
            // 
            this.orders_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_search.Location = new System.Drawing.Point(426, 139);
            this.orders_search.Multiline = true;
            this.orders_search.Name = "orders_search";
            this.orders_search.Size = new System.Drawing.Size(378, 33);
            this.orders_search.TabIndex = 38;
            this.orders_search.TextChanged += new System.EventHandler(this.orders_search_TextChanged);
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
            this.panel1.TabIndex = 36;
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
            this.customer_but.Click += new System.EventHandler(this.customer_but_Click);
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
            this.orders_but.Click += new System.EventHandler(this.orders_but_Click);
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
            // orders_table
            // 
            this.orders_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_table.Location = new System.Drawing.Point(426, 194);
            this.orders_table.Name = "orders_table";
            this.orders_table.RowHeadersWidth = 51;
            this.orders_table.RowTemplate.Height = 24;
            this.orders_table.Size = new System.Drawing.Size(1018, 607);
            this.orders_table.TabIndex = 35;
            this.orders_table.UseWaitCursor = true;
            this.orders_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_table_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 851);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 34;
            this.button1.Text = "Get Customer Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Orders Table";
            this.label1.UseWaitCursor = true;
            // 
            // orders_reportgenerator
            // 
            this.orders_reportgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_reportgenerator.Location = new System.Drawing.Point(1282, 851);
            this.orders_reportgenerator.Name = "orders_reportgenerator";
            this.orders_reportgenerator.Size = new System.Drawing.Size(162, 61);
            this.orders_reportgenerator.TabIndex = 44;
            this.orders_reportgenerator.Text = "MS Excel Report";
            this.orders_reportgenerator.UseVisualStyleBackColor = true;
            this.orders_reportgenerator.UseWaitCursor = true;
            this.orders_reportgenerator.Click += new System.EventHandler(this.orders_reportgenerator_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.orders_reportgenerator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete_logs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.order_logs_table);
            this.Controls.Add(this.orders_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orders_table);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_logs_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delete_logs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView order_logs_table;
        private System.Windows.Forms.TextBox orders_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button categories_but;
        private System.Windows.Forms.Button suppliers_but;
        private System.Windows.Forms.Button products_but;
        private System.Windows.Forms.Button pets_but;
        private System.Windows.Forms.Button orders_but;
        private System.Windows.Forms.Button orderdetails_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orders_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orders_reportgenerator;
    }
}