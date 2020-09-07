namespace Project_ATBM
{
    partial class Home
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
            this.btn_phanhe1 = new System.Windows.Forms.Button();
            this.btn_phanhe2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_phanhe1
            // 
            this.btn_phanhe1.BackColor = System.Drawing.Color.DarkRed;
            this.btn_phanhe1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_phanhe1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_phanhe1.Location = new System.Drawing.Point(100, 150);
            this.btn_phanhe1.Name = "btn_phanhe1";
            this.btn_phanhe1.Size = new System.Drawing.Size(230, 250);
            this.btn_phanhe1.TabIndex = 0;
            this.btn_phanhe1.Text = "Phân hệ 1";
            this.btn_phanhe1.UseVisualStyleBackColor = false;
            this.btn_phanhe1.Click += new System.EventHandler(this.btn_phanhe1_Click);
            // 
            // btn_phanhe2
            // 
            this.btn_phanhe2.BackColor = System.Drawing.Color.Peru;
            this.btn_phanhe2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phanhe2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_phanhe2.Location = new System.Drawing.Point(458, 150);
            this.btn_phanhe2.Name = "btn_phanhe2";
            this.btn_phanhe2.Size = new System.Drawing.Size(230, 250);
            this.btn_phanhe2.TabIndex = 1;
            this.btn_phanhe2.Text = "Phân hệ 2";
            this.btn_phanhe2.UseVisualStyleBackColor = false;
            this.btn_phanhe2.Click += new System.EventHandler(this.btn_phanhe2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐỒ ÁN MÔN HỌC\r\nAN TOÀN VÀ BẢO MẬT DỮ LIỆU TRONG HỆ THỐNG THÔNG TIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OliveDrab;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(337, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHÓM 14";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_phanhe2);
            this.Controls.Add(this.btn_phanhe1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_phanhe1;
        private System.Windows.Forms.Button btn_phanhe2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}