namespace logon
{
    partial class edit_admin
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
            this.admin_data = new System.Windows.Forms.DataGridView();
            this.Add_admin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_user = new System.Windows.Forms.TextBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.admin_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(287, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit admin";
            // 
            // admin_data
            // 
            this.admin_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_data.Location = new System.Drawing.Point(242, 67);
            this.admin_data.Name = "admin_data";
            this.admin_data.Size = new System.Drawing.Size(226, 199);
            this.admin_data.TabIndex = 1;
            this.admin_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_admin
            // 
            this.Add_admin.Location = new System.Drawing.Point(280, 433);
            this.Add_admin.Name = "Add_admin";
            this.Add_admin.Size = new System.Drawing.Size(139, 54);
            this.Add_admin.TabIndex = 2;
            this.Add_admin.Text = "Add admin";
            this.Add_admin.UseVisualStyleBackColor = true;
            this.Add_admin.Click += new System.EventHandler(this.Add_admin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // admin_user
            // 
            this.admin_user.Location = new System.Drawing.Point(242, 301);
            this.admin_user.Name = "admin_user";
            this.admin_user.Size = new System.Drawing.Size(226, 20);
            this.admin_user.TabIndex = 5;
            // 
            // admin_pass
            // 
            this.admin_pass.Location = new System.Drawing.Point(242, 348);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.Size = new System.Drawing.Size(226, 20);
            this.admin_pass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm password";
            // 
            // confpass
            // 
            this.confpass.Location = new System.Drawing.Point(242, 395);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(226, 20);
            this.confpass.TabIndex = 8;
            // 
            // edit_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 499);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_admin);
            this.Controls.Add(this.admin_data);
            this.Controls.Add(this.label1);
            this.Name = "edit_admin";
            this.Text = "edit_admin";
            this.Load += new System.EventHandler(this.edit_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView admin_data;
        private System.Windows.Forms.Button Add_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin_user;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confpass;
    }
}