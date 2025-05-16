namespace edp_Project
{
    partial class updateStatus
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
            this.updateOrder_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(85, 213);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 16);
            this.linkLabel2.TabIndex = 51;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Back";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // updateOrder_but
            // 
            this.updateOrder_but.Location = new System.Drawing.Point(447, 188);
            this.updateOrder_but.Name = "updateOrder_but";
            this.updateOrder_but.Size = new System.Drawing.Size(104, 41);
            this.updateOrder_but.TabIndex = 50;
            this.updateOrder_but.Text = "Confirm";
            this.updateOrder_but.UseVisualStyleBackColor = true;
            this.updateOrder_but.Click += new System.EventHandler(this.deleteOrder_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Update Status";
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "Completed",
            "Pending",
            "Canceled"});
            this.statusCombo.Location = new System.Drawing.Point(164, 128);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(245, 24);
            this.statusCombo.TabIndex = 55;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Status";
            // 
            // updateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.updateOrder_but);
            this.Controls.Add(this.label1);
            this.Name = "updateStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button updateOrder_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Label label2;
    }
}