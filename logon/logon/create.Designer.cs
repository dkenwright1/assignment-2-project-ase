namespace logon
{
    partial class create
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_account = new System.Windows.Forms.Button();
            this.usercreate = new System.Windows.Forms.TextBox();
            this.passwordcreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // create_account
            // 
            this.create_account.Location = new System.Drawing.Point(123, 242);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(153, 40);
            this.create_account.TabIndex = 3;
            this.create_account.Text = "Create account";
            this.create_account.UseVisualStyleBackColor = true;
            this.create_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // usercreate
            // 
            this.usercreate.Location = new System.Drawing.Point(173, 85);
            this.usercreate.Name = "usercreate";
            this.usercreate.Size = new System.Drawing.Size(144, 20);
            this.usercreate.TabIndex = 4;
            // 
            // passwordcreate
            // 
            this.passwordcreate.Location = new System.Drawing.Point(173, 134);
            this.passwordcreate.Name = "passwordcreate";
            this.passwordcreate.Size = new System.Drawing.Size(144, 20);
            this.passwordcreate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm password";
            // 
            // confpass
            // 
            this.confpass.Location = new System.Drawing.Point(173, 189);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(144, 20);
            this.confpass.TabIndex = 7;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 294);
            this.Controls.Add(this.confpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordcreate);
            this.Controls.Add(this.usercreate);
            this.Controls.Add(this.create_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "create";
            this.Text = "create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_account;
        private System.Windows.Forms.TextBox usercreate;
        private System.Windows.Forms.TextBox passwordcreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confpass;
    }
}