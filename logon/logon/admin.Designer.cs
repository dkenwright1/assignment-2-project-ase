namespace logon
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_account = new System.Windows.Forms.Button();
            this.create_admin = new System.Windows.Forms.Button();
            this.admin_logoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(242, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Delete_account
            // 
            this.Delete_account.Location = new System.Drawing.Point(24, 316);
            this.Delete_account.Name = "Delete_account";
            this.Delete_account.Size = new System.Drawing.Size(160, 52);
            this.Delete_account.TabIndex = 1;
            this.Delete_account.Text = "edit user accounts";
            this.Delete_account.UseVisualStyleBackColor = true;
            this.Delete_account.Click += new System.EventHandler(this.Delete_account_Click);
            // 
            // create_admin
            // 
            this.create_admin.Location = new System.Drawing.Point(243, 317);
            this.create_admin.Name = "create_admin";
            this.create_admin.Size = new System.Drawing.Size(156, 51);
            this.create_admin.TabIndex = 2;
            this.create_admin.Text = "edit admin accounts";
            this.create_admin.UseVisualStyleBackColor = true;
            this.create_admin.Click += new System.EventHandler(this.create_admin_Click);
            // 
            // admin_logoff
            // 
            this.admin_logoff.Location = new System.Drawing.Point(456, 320);
            this.admin_logoff.Name = "admin_logoff";
            this.admin_logoff.Size = new System.Drawing.Size(151, 47);
            this.admin_logoff.TabIndex = 3;
            this.admin_logoff.Text = "Log off";
            this.admin_logoff.UseVisualStyleBackColor = true;
            this.admin_logoff.Click += new System.EventHandler(this.admin_logoff_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 407);
            this.Controls.Add(this.admin_logoff);
            this.Controls.Add(this.create_admin);
            this.Controls.Add(this.Delete_account);
            this.Controls.Add(this.label1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_account;
        private System.Windows.Forms.Button create_admin;
        private System.Windows.Forms.Button admin_logoff;
    }
}