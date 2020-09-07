namespace Project_ATBM
{
    partial class ToLapDS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các thành viên có thể tham gia bầu cử";
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Location = new System.Drawing.Point(764, 37);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(0, 13);
            this.temp1.TabIndex = 2;
            this.temp1.Visible = false;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(4, 2);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(41, 15);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "label2";
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.Location = new System.Drawing.Point(447, 219);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(0, 13);
            this.temp2.TabIndex = 4;
            this.temp2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(830, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tham gia bầu cử";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToLapDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ToLapDS";
            this.Text = "ToLapDS";
            this.Load += new System.EventHandler(this.ToLapDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Button button1;
    }
}