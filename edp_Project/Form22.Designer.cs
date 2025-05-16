namespace edp_Project
{
    partial class deleteProd
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
            this.deleteProd_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(74, 163);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 16);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // deleteProd_but
            // 
            this.deleteProd_but.Location = new System.Drawing.Point(443, 151);
            this.deleteProd_but.Name = "deleteProd_but";
            this.deleteProd_but.Size = new System.Drawing.Size(104, 41);
            this.deleteProd_but.TabIndex = 42;
            this.deleteProd_but.Text = "Confirm";
            this.deleteProd_but.UseVisualStyleBackColor = true;
            this.deleteProd_but.Click += new System.EventHandler(this.deleteProd_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product ID";
            // 
            // productid_textbox
            // 
            this.productid_textbox.Location = new System.Drawing.Point(171, 106);
            this.productid_textbox.Name = "productid_textbox";
            this.productid_textbox.Size = new System.Drawing.Size(245, 22);
            this.productid_textbox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Delete Product";
            // 
            // deleteProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 233);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.deleteProd_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productid_textbox);
            this.Controls.Add(this.label1);
            this.Name = "deleteProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button deleteProd_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productid_textbox;
        private System.Windows.Forms.Label label1;
    }
}