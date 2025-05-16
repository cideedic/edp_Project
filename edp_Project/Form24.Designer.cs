namespace edp_Project
{
    partial class deleteSupplier
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
            this.deleteSupplier_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(74, 163);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 16);
            this.linkLabel2.TabIndex = 48;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // deleteSupplier_but
            // 
            this.deleteSupplier_but.Location = new System.Drawing.Point(443, 151);
            this.deleteSupplier_but.Name = "deleteSupplier_but";
            this.deleteSupplier_but.Size = new System.Drawing.Size(104, 41);
            this.deleteSupplier_but.TabIndex = 47;
            this.deleteSupplier_but.Text = "Confirm";
            this.deleteSupplier_but.UseVisualStyleBackColor = true;
            this.deleteSupplier_but.Click += new System.EventHandler(this.deleteSupplier_but_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Supplier ID";
            // 
            // supplierid_textbox
            // 
            this.supplierid_textbox.Location = new System.Drawing.Point(171, 106);
            this.supplierid_textbox.Name = "supplierid_textbox";
            this.supplierid_textbox.Size = new System.Drawing.Size(245, 22);
            this.supplierid_textbox.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Delete Supplier";
            // 
            // deleteSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 233);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.deleteSupplier_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierid_textbox);
            this.Controls.Add(this.label1);
            this.Name = "deleteSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button deleteSupplier_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierid_textbox;
        private System.Windows.Forms.Label label1;
    }
}