namespace edp_Project
{
    partial class Pets
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
            this.updatepet_but = new System.Windows.Forms.Button();
            this.deletepet_but = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.pet_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_but = new System.Windows.Forms.Button();
            this.categories_but = new System.Windows.Forms.Button();
            this.suppliers_but = new System.Windows.Forms.Button();
            this.products_but = new System.Windows.Forms.Button();
            this.pets_but = new System.Windows.Forms.Button();
            this.orders_but = new System.Windows.Forms.Button();
            this.orderdetails_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addpet_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pet_table = new System.Windows.Forms.DataGridView();
            this.pet_logs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pet_reportgenerator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pet_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // updatepet_but
            // 
            this.updatepet_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepet_but.Location = new System.Drawing.Point(817, 851);
            this.updatepet_but.Name = "updatepet_but";
            this.updatepet_but.Size = new System.Drawing.Size(162, 61);
            this.updatepet_but.TabIndex = 54;
            this.updatepet_but.Text = "Update Pet";
            this.updatepet_but.UseVisualStyleBackColor = true;
            this.updatepet_but.UseWaitCursor = true;
            this.updatepet_but.Click += new System.EventHandler(this.updatepet_but_Click);
            // 
            // deletepet_but
            // 
            this.deletepet_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletepet_but.Location = new System.Drawing.Point(618, 851);
            this.deletepet_but.Name = "deletepet_but";
            this.deletepet_but.Size = new System.Drawing.Size(162, 61);
            this.deletepet_but.TabIndex = 53;
            this.deletepet_but.Text = "Delete Pet";
            this.deletepet_but.UseVisualStyleBackColor = true;
            this.deletepet_but.UseWaitCursor = true;
            this.deletepet_but.Click += new System.EventHandler(this.deletepet_but_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(1482, 851);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 61);
            this.button12.TabIndex = 52;
            this.button12.Text = "Delete Logs";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.UseWaitCursor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pet_search
            // 
            this.pet_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pet_search.Location = new System.Drawing.Point(426, 139);
            this.pet_search.Multiline = true;
            this.pet_search.Name = "pet_search";
            this.pet_search.Size = new System.Drawing.Size(378, 33);
            this.pet_search.TabIndex = 49;
            this.pet_search.TextChanged += new System.EventHandler(this.pet_search_TextChanged);
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
            // addpet_but
            // 
            this.addpet_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpet_but.Location = new System.Drawing.Point(426, 851);
            this.addpet_but.Name = "addpet_but";
            this.addpet_but.Size = new System.Drawing.Size(162, 61);
            this.addpet_but.TabIndex = 45;
            this.addpet_but.Text = "Add Pet";
            this.addpet_but.UseVisualStyleBackColor = true;
            this.addpet_but.UseWaitCursor = true;
            this.addpet_but.Click += new System.EventHandler(this.addpet_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pets Table";
            this.label1.UseWaitCursor = true;
            // 
            // pet_table
            // 
            this.pet_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pet_table.Location = new System.Drawing.Point(426, 194);
            this.pet_table.Name = "pet_table";
            this.pet_table.RowHeadersWidth = 51;
            this.pet_table.RowTemplate.Height = 24;
            this.pet_table.Size = new System.Drawing.Size(1018, 607);
            this.pet_table.TabIndex = 46;
            this.pet_table.UseWaitCursor = true;
            this.pet_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pet_logs
            // 
            this.pet_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pet_logs.Location = new System.Drawing.Point(1482, 194);
            this.pet_logs.Name = "pet_logs";
            this.pet_logs.RowHeadersWidth = 51;
            this.pet_logs.RowTemplate.Height = 24;
            this.pet_logs.Size = new System.Drawing.Size(527, 607);
            this.pet_logs.TabIndex = 50;
            this.pet_logs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pet_logs_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1476, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Pet Logs";
            this.label3.UseWaitCursor = true;
            // 
            // pet_reportgenerator
            // 
            this.pet_reportgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pet_reportgenerator.Location = new System.Drawing.Point(1282, 851);
            this.pet_reportgenerator.Name = "pet_reportgenerator";
            this.pet_reportgenerator.Size = new System.Drawing.Size(162, 61);
            this.pet_reportgenerator.TabIndex = 55;
            this.pet_reportgenerator.Text = "MS Excel Report";
            this.pet_reportgenerator.UseVisualStyleBackColor = true;
            this.pet_reportgenerator.UseWaitCursor = true;
            this.pet_reportgenerator.Click += new System.EventHandler(this.pet_reportgenerator_Click);
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 990);
            this.Controls.Add(this.pet_reportgenerator);
            this.Controls.Add(this.updatepet_but);
            this.Controls.Add(this.deletepet_but);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pet_logs);
            this.Controls.Add(this.pet_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pet_table);
            this.Controls.Add(this.addpet_but);
            this.Controls.Add(this.label1);
            this.Name = "Pets";
            this.Text = "Pets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pets_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pet_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatepet_but;
        private System.Windows.Forms.Button deletepet_but;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox pet_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button categories_but;
        private System.Windows.Forms.Button suppliers_but;
        private System.Windows.Forms.Button products_but;
        private System.Windows.Forms.Button pets_but;
        private System.Windows.Forms.Button orders_but;
        private System.Windows.Forms.Button orderdetails_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addpet_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pet_table;
        private System.Windows.Forms.DataGridView pet_logs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pet_reportgenerator;
    }
}