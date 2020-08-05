namespace Project_ATBM
{
    partial class Login
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
            this.pwd = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(173, 183);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(220, 20);
            this.pwd.TabIndex = 0;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(173, 92);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(220, 20);
            this.user_name.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.username.Location = new System.Drawing.Point(117, 62);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(85, 17);
            this.username.TabIndex = 2;
            this.username.Text = "USERNAME";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password.Location = new System.Drawing.Point(117, 153);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(88, 17);
            this.password.TabIndex = 3;
            this.password.Text = "PASSWORD";
            this.password.UseMnemonic = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Red;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(209, 227);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(148, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ QUÁ TRÌNH BÌNH BẦU TÍN NHIỆM";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pwd);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
    }
}