namespace Project_ATBM
{
    partial class delRoler
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
            this.temp2 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maThanhVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.ForeColor = System.Drawing.SystemColors.Control;
            this.temp2.Location = new System.Drawing.Point(252, 143);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(0, 13);
            this.temp2.TabIndex = 21;
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.ForeColor = System.Drawing.SystemColors.Control;
            this.temp1.Location = new System.Drawing.Point(418, 256);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(0, 13);
            this.temp1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(206, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã thành viên";
            // 
            // maThanhVien
            // 
            this.maThanhVien.Location = new System.Drawing.Point(45, 86);
            this.maThanhVien.Name = "maThanhVien";
            this.maThanhVien.Size = new System.Drawing.Size(183, 20);
            this.maThanhVien.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Xóa thành viên trong tổ quản lý";
            // 
            // selectRole
            // 
            this.selectRole.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRole.FormattingEnabled = true;
            this.selectRole.Items.AddRange(new object[] {
            "To lap danh sach",
            "To theo doi",
            "To giam sat"});
            this.selectRole.Location = new System.Drawing.Point(333, 82);
            this.selectRole.Name = "selectRole";
            this.selectRole.Size = new System.Drawing.Size(183, 24);
            this.selectRole.TabIndex = 15;
            this.selectRole.Text = "Vai trò";
            // 
            // delRoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 215);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectRole);
            this.Controls.Add(this.maThanhVien);
            this.Controls.Add(this.label1);
            this.Name = "delRoler";
            this.Text = "delRoler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maThanhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectRole;
    }
}