namespace Project_ATBM
{
    partial class addRoler
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
            this.maThanhVien = new System.Windows.Forms.TextBox();
            this.tenThanhVien = new System.Windows.Forms.TextBox();
            this.flag_totruong = new System.Windows.Forms.CheckBox();
            this.selectRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDonvi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm thành viên vào tổ quản lý";
            // 
            // maThanhVien
            // 
            this.maThanhVien.Location = new System.Drawing.Point(81, 77);
            this.maThanhVien.Name = "maThanhVien";
            this.maThanhVien.Size = new System.Drawing.Size(183, 20);
            this.maThanhVien.TabIndex = 1;
            // 
            // tenThanhVien
            // 
            this.tenThanhVien.Location = new System.Drawing.Point(353, 76);
            this.tenThanhVien.Name = "tenThanhVien";
            this.tenThanhVien.Size = new System.Drawing.Size(183, 20);
            this.tenThanhVien.TabIndex = 2;
            // 
            // flag_totruong
            // 
            this.flag_totruong.AutoSize = true;
            this.flag_totruong.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag_totruong.Location = new System.Drawing.Point(81, 138);
            this.flag_totruong.Name = "flag_totruong";
            this.flag_totruong.Size = new System.Drawing.Size(102, 20);
            this.flag_totruong.TabIndex = 3;
            this.flag_totruong.Text = "Tổ trưởng";
            this.flag_totruong.UseVisualStyleBackColor = true;
            // 
            // selectRole
            // 
            this.selectRole.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRole.FormattingEnabled = true;
            this.selectRole.Items.AddRange(new object[] {
            "To lap danh sach",
            "To theo doi",
            "To giam sat"});
            this.selectRole.Location = new System.Drawing.Point(81, 197);
            this.selectRole.Name = "selectRole";
            this.selectRole.Size = new System.Drawing.Size(183, 24);
            this.selectRole.TabIndex = 4;
            this.selectRole.Text = "Vai trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã thành viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên thành viên";
            // 
            // selectDonvi
            // 
            this.selectDonvi.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDonvi.FormattingEnabled = true;
            this.selectDonvi.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.selectDonvi.Location = new System.Drawing.Point(353, 197);
            this.selectDonvi.Name = "selectDonvi";
            this.selectDonvi.Size = new System.Drawing.Size(183, 24);
            this.selectDonvi.TabIndex = 7;
            this.selectDonvi.Text = "Đơn vị phụ trách";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(240, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.ForeColor = System.Drawing.SystemColors.Control;
            this.temp1.Location = new System.Drawing.Point(454, 247);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(0, 13);
            this.temp1.TabIndex = 9;
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.ForeColor = System.Drawing.SystemColors.Control;
            this.temp2.Location = new System.Drawing.Point(288, 134);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(0, 13);
            this.temp2.TabIndex = 10;
            // 
            // addRoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 280);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectDonvi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectRole);
            this.Controls.Add(this.flag_totruong);
            this.Controls.Add(this.tenThanhVien);
            this.Controls.Add(this.maThanhVien);
            this.Controls.Add(this.label1);
            this.Name = "addRoler";
            this.Text = "addRoler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maThanhVien;
        private System.Windows.Forms.TextBox tenThanhVien;
        private System.Windows.Forms.CheckBox flag_totruong;
        private System.Windows.Forms.ComboBox selectRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectDonvi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label temp2;
    }
}