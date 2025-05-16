namespace edp_Project
{
    partial class Products
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
            this.productsales_but = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.product_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_but = new System.Windows.Forms.Button();
            this.categories_but = new System.Windows.Forms.Button();
            this.suppliers_but = new System.Windows.Forms.Button();
            this.products_but = new System.Windows.Forms.Button();
            this.pets_but = new System.Windows.Forms.Button();
            this.orders_but = new System.Windows.Forms.Button();
            this.orderdetails_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_reportgenerator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsales_but
            // 
            this.productsales_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsales_but.Location = new System.Drawing.Point(817, 851);
            this.productsales_but.Name = "productsales_but";
            this.productsales_but.Size = new System.Drawing.Size(162, 61);
            this.productsales_but.TabIndex = 54;
            this.productsales_but.Text = "Show Product Sales";
            this.productsales_but.UseVisualStyleBackColor = true;
            this.productsales_but.UseWaitCursor = true;
            this.productsales_but.Click += new System.EventHandler(this.productsales_but_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(618, 851);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(162, 61);
            this.deleteProduct.TabIndex = 53;
            this.deleteProduct.Text = "Delete Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.UseWaitCursor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // product_search
            // 
            this.product_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_search.Location = new System.Drawing.Point(426, 139);
            this.product_search.Multiline = true;
            this.product_search.Name = "product_search";
            this.product_search.Size = new System.Drawing.Size(378, 33);
            this.product_search.TabIndex = 49;
            this.product_search.TextChanged += new System.EventHandler(this.product_search_TextChanged);
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
            this.panel1.TabIndex = 47;
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
            // addProduct
            // 
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(426, 851);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(162, 61);
            this.addProduct.TabIndex = 45;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.UseWaitCursor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Products Table";
            this.label1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1564, 607);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // product_reportgenerator
            // 
            this.product_reportgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_reportgenerator.Location = new System.Drawing.Point(1828, 851);
            this.product_reportgenerator.Name = "product_reportgenerator";
            this.product_reportgenerator.Size = new System.Drawing.Size(162, 61);
            this.product_reportgenerator.TabIndex = 56;
            this.product_reportgenerator.Text = "MS Excel Report";
            this.product_reportgenerator.UseVisualStyleBackColor = true;
            this.product_reportgenerator.UseWaitCursor = true;
            this.product_reportgenerator.Click += new System.EventHandler(this.product_reportgenerator_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.product_reportgenerator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productsales_but);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.product_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productsales_but;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.TextBox product_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button categories_but;
        private System.Windows.Forms.Button suppliers_but;
        private System.Windows.Forms.Button products_but;
        private System.Windows.Forms.Button pets_but;
        private System.Windows.Forms.Button orders_but;
        private System.Windows.Forms.Button orderdetails_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button product_reportgenerator;
    }
}