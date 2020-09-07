namespace Project_ATBM
{
    partial class RevokePrivOfRole
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
            this.label3 = new System.Windows.Forms.Label();
            this.PrivesList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RoleList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Role thu hồi quyền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrivesList
            // 
            this.PrivesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivesList.FormattingEnabled = true;
            this.PrivesList.Location = new System.Drawing.Point(262, 147);
            this.PrivesList.Name = "PrivesList";
            this.PrivesList.Size = new System.Drawing.Size(214, 24);
            this.PrivesList.TabIndex = 32;
            this.PrivesList.SelectedIndexChanged += new System.EventHandler(this.PrivesList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(170, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Thu hồi quyền";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoleList
            // 
            this.RoleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(262, 50);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(214, 24);
            this.RoleList.TabIndex = 31;
            this.RoleList.SelectedIndexChanged += new System.EventHandler(this.RoleList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quyền thu hồi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "Nạp danh sách quyền của Role";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RevokePrivOfRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrivesList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RoleList);
            this.Controls.Add(this.label4);
            this.Name = "RevokePrivOfRole";
            this.Text = "RevokePrivOfRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PrivesList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RoleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}