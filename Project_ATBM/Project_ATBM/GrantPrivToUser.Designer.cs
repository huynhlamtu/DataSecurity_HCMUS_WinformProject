namespace Project_ATBM
{
    partial class GrantPrivToUser
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
            this.UserList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "User được cấp quyền";
            // 
            // PrivesList
            // 
            this.PrivesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivesList.FormattingEnabled = true;
            this.PrivesList.Location = new System.Drawing.Point(285, 102);
            this.PrivesList.Name = "PrivesList";
            this.PrivesList.Size = new System.Drawing.Size(214, 24);
            this.PrivesList.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cấp quyền cho User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserList
            // 
            this.UserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(285, 45);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(214, 24);
            this.UserList.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quyền cấp";
            // 
            // optionCombobox
            // 
            this.optionCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCombobox.FormattingEnabled = true;
            this.optionCombobox.Items.AddRange(new object[] {
            "Không có",
            "with admin option",
            "with grant option"});
            this.optionCombobox.Location = new System.Drawing.Point(285, 160);
            this.optionCombobox.Name = "optionCombobox";
            this.optionCombobox.Size = new System.Drawing.Size(214, 24);
            this.optionCombobox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Option";
            // 
            // GrantPrivToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 271);
            this.Controls.Add(this.optionCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrivesList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.label4);
            this.Name = "GrantPrivToUser";
            this.Text = "GrantPrivToUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PrivesList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox optionCombobox;
        private System.Windows.Forms.Label label1;
    }
}