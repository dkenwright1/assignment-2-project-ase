﻿namespace logon
{
    partial class edit_user
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
            this.userdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_user = new System.Windows.Forms.Button();
            this.update_user = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update_name = new System.Windows.Forms.TextBox();
            this.update_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // userdata
            // 
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdata.Location = new System.Drawing.Point(168, 58);
            this.userdata.Name = "userdata";
            this.userdata.Size = new System.Drawing.Size(343, 199);
            this.userdata.TabIndex = 0;
            this.userdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit user";
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(12, 414);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(129, 45);
            this.delete_user.TabIndex = 2;
            this.delete_user.Text = "Delete record";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_user
            // 
            this.update_user.Location = new System.Drawing.Point(199, 414);
            this.update_user.Name = "update_user";
            this.update_user.Size = new System.Drawing.Size(141, 45);
            this.update_user.TabIndex = 3;
            this.update_user.Text = "Update user details";
            this.update_user.UseVisualStyleBackColor = true;
            this.update_user.Click += new System.EventHandler(this.update_user_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // update_name
            // 
            this.update_name.Location = new System.Drawing.Point(211, 295);
            this.update_name.Name = "update_name";
            this.update_name.Size = new System.Drawing.Size(191, 20);
            this.update_name.TabIndex = 6;
            // 
            // update_password
            // 
            this.update_password.Location = new System.Drawing.Point(211, 348);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(191, 20);
            this.update_password.TabIndex = 7;
            // 
            // edit_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 471);
            this.Controls.Add(this.update_password);
            this.Controls.Add(this.update_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_user);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userdata);
            this.Name = "edit_user";
            this.Text = "edit_user";
            this.Load += new System.EventHandler(this.edit_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Button update_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox update_name;
        private System.Windows.Forms.TextBox update_password;
    }
}