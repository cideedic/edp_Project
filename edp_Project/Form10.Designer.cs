namespace edp_Project
{
    partial class ChangePassword
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
            this.label8 = new System.Windows.Forms.Label();
            this.con_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.con_but = new System.Windows.Forms.Button();
            this.new_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Confirm Password";
            // 
            // con_box
            // 
            this.con_box.Location = new System.Drawing.Point(252, 273);
            this.con_box.Name = "con_box";
            this.con_box.Size = new System.Drawing.Size(300, 22);
            this.con_box.TabIndex = 43;
            this.con_box.TextChanged += new System.EventHandler(this.con_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 36);
            this.label3.TabIndex = 42;
            this.label3.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "New Password";
            // 
            // con_but
            // 
            this.con_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_but.Location = new System.Drawing.Point(351, 326);
            this.con_but.Name = "con_but";
            this.con_but.Size = new System.Drawing.Size(95, 30);
            this.con_but.TabIndex = 40;
            this.con_but.Text = "Continue";
            this.con_but.UseVisualStyleBackColor = true;
            this.con_but.Click += new System.EventHandler(this.con_but_Click);
            // 
            // new_box
            // 
            this.new_box.Location = new System.Drawing.Point(252, 205);
            this.new_box.Name = "new_box";
            this.new_box.Size = new System.Drawing.Size(300, 22);
            this.new_box.TabIndex = 39;
            this.new_box.TextChanged += new System.EventHandler(this.new_box_TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.con_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.con_but);
            this.Controls.Add(this.new_box);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox con_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button con_but;
        private System.Windows.Forms.TextBox new_box;
    }
}