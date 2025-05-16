namespace edp_Project
{
    partial class Suppliers
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
            this.updatesupplier_but = new System.Windows.Forms.Button();
            this.deletesupplier_but = new System.Windows.Forms.Button();
            this.supplier_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_but = new System.Windows.Forms.Button();
            this.categories_but = new System.Windows.Forms.Button();
            this.suppliers_but = new System.Windows.Forms.Button();
            this.products_but = new System.Windows.Forms.Button();
            this.pets_but = new System.Windows.Forms.Button();
            this.orders_but = new System.Windows.Forms.Button();
            this.orderdetails_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addsupplier_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.supplier_table = new System.Windows.Forms.DataGridView();
            this.supplier_reportgenerator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_table)).BeginInit();
            this.SuspendLayout();
            // 
            // updatesupplier_but
            // 
            this.updatesupplier_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesupplier_but.Location = new System.Drawing.Point(817, 851);
            this.updatesupplier_but.Name = "updatesupplier_but";
            this.updatesupplier_but.Size = new System.Drawing.Size(162, 61);
            this.updatesupplier_but.TabIndex = 54;
            this.updatesupplier_but.Text = "Update Supplier";
            this.updatesupplier_but.UseVisualStyleBackColor = true;
            this.updatesupplier_but.UseWaitCursor = true;
            this.updatesupplier_but.Click += new System.EventHandler(this.updatesupplier_but_Click);
            // 
            // deletesupplier_but
            // 
            this.deletesupplier_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletesupplier_but.Location = new System.Drawing.Point(618, 851);
            this.deletesupplier_but.Name = "deletesupplier_but";
            this.deletesupplier_but.Size = new System.Drawing.Size(162, 61);
            this.deletesupplier_but.TabIndex = 53;
            this.deletesupplier_but.Text = "Delete Supplier";
            this.deletesupplier_but.UseVisualStyleBackColor = true;
            this.deletesupplier_but.UseWaitCursor = true;
            this.deletesupplier_but.Click += new System.EventHandler(this.deletesupplier_but_Click);
            // 
            // supplier_search
            // 
            this.supplier_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_search.Location = new System.Drawing.Point(426, 139);
            this.supplier_search.Multiline = true;
            this.supplier_search.Name = "supplier_search";
            this.supplier_search.Size = new System.Drawing.Size(378, 33);
            this.supplier_search.TabIndex = 49;
            this.supplier_search.TextChanged += new System.EventHandler(this.supplier_search_TextChanged);
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
            // addsupplier_but
            // 
            this.addsupplier_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsupplier_but.Location = new System.Drawing.Point(426, 851);
            this.addsupplier_but.Name = "addsupplier_but";
            this.addsupplier_but.Size = new System.Drawing.Size(162, 61);
            this.addsupplier_but.TabIndex = 45;
            this.addsupplier_but.Text = "Add Supplier";
            this.addsupplier_but.UseVisualStyleBackColor = true;
            this.addsupplier_but.UseWaitCursor = true;
            this.addsupplier_but.Click += new System.EventHandler(this.addsupplier_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Suppliers Table";
            this.label1.UseWaitCursor = true;
            // 
            // supplier_table
            // 
            this.supplier_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplier_table.Location = new System.Drawing.Point(426, 194);
            this.supplier_table.Name = "supplier_table";
            this.supplier_table.RowHeadersWidth = 51;
            this.supplier_table.RowTemplate.Height = 24;
            this.supplier_table.Size = new System.Drawing.Size(1564, 607);
            this.supplier_table.TabIndex = 55;
            this.supplier_table.UseWaitCursor = true;
            this.supplier_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplier_table_CellContentClick);
            // 
            // supplier_reportgenerator
            // 
            this.supplier_reportgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_reportgenerator.Location = new System.Drawing.Point(1828, 851);
            this.supplier_reportgenerator.Name = "supplier_reportgenerator";
            this.supplier_reportgenerator.Size = new System.Drawing.Size(162, 61);
            this.supplier_reportgenerator.TabIndex = 56;
            this.supplier_reportgenerator.Text = "MS Excel Report";
            this.supplier_reportgenerator.UseVisualStyleBackColor = true;
            this.supplier_reportgenerator.UseWaitCursor = true;
            this.supplier_reportgenerator.Click += new System.EventHandler(this.supplier_reportgenerator_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.supplier_reportgenerator);
            this.Controls.Add(this.supplier_table);
            this.Controls.Add(this.updatesupplier_but);
            this.Controls.Add(this.deletesupplier_but);
            this.Controls.Add(this.supplier_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addsupplier_but);
            this.Controls.Add(this.label1);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatesupplier_but;
        private System.Windows.Forms.Button deletesupplier_but;
        private System.Windows.Forms.TextBox supplier_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button categories_but;
        private System.Windows.Forms.Button suppliers_but;
        private System.Windows.Forms.Button products_but;
        private System.Windows.Forms.Button pets_but;
        private System.Windows.Forms.Button orders_but;
        private System.Windows.Forms.Button orderdetails_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addsupplier_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView supplier_table;
        private System.Windows.Forms.Button supplier_reportgenerator;
    }
}