namespace Project_ATBM
{
    partial class GrantToRole
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Role được cấp quyền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrivesList
            // 
            this.PrivesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivesList.FormattingEnabled = true;
            this.PrivesList.Location = new System.Drawing.Point(281, 118);
            this.PrivesList.Name = "PrivesList";
            this.PrivesList.Size = new System.Drawing.Size(214, 24);
            this.PrivesList.TabIndex = 27;
            this.PrivesList.SelectedIndexChanged += new System.EventHandler(this.PrivesList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cấp quyền cho Role";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RoleList
            // 
            this.RoleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(281, 42);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(214, 24);
            this.RoleList.TabIndex = 26;
            this.RoleList.SelectedIndexChanged += new System.EventHandler(this.RoleList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quyền cấp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GrantToRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrivesList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RoleList);
            this.Controls.Add(this.label4);
            this.Name = "GrantToRole";
            this.Text = "GrantToRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PrivesList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RoleList;
        private System.Windows.Forms.Label label4;
    }
}