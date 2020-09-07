namespace Project_ATBM
{
    partial class QLyUser
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
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.findUsernameOfPriv = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.GranteeList = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFindGrantee = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_grantRole = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UsernameListDel = new System.Windows.Forms.ComboBox();
            this.usernameListFind = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btn_findUsername = new System.Windows.Forms.Button();
            this.btn_DelUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temp1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameFindLock = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.findUsernameOfPriv);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.GranteeList);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.btnFindGrantee);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 176);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách quyền của User";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // findUsernameOfPriv
            // 
            this.findUsernameOfPriv.FormattingEnabled = true;
            this.findUsernameOfPriv.Location = new System.Drawing.Point(6, 146);
            this.findUsernameOfPriv.Name = "findUsernameOfPriv";
            this.findUsernameOfPriv.Size = new System.Drawing.Size(173, 24);
            this.findUsernameOfPriv.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(193, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Tìm username";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GranteeList
            // 
            this.GranteeList.FormattingEnabled = true;
            this.GranteeList.Location = new System.Drawing.Point(6, 237);
            this.GranteeList.Name = "GranteeList";
            this.GranteeList.Size = new System.Drawing.Size(194, 24);
            this.GranteeList.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(58, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Hiển thị tất cả record";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFindGrantee
            // 
            this.btnFindGrantee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindGrantee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindGrantee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindGrantee.Location = new System.Drawing.Point(206, 238);
            this.btnFindGrantee.Name = "btnFindGrantee";
            this.btnFindGrantee.Size = new System.Drawing.Size(104, 23);
            this.btnFindGrantee.TabIndex = 18;
            this.btnFindGrantee.Text = "Tìm grantee";
            this.btnFindGrantee.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(58, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(208, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Thu hồi quyền";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(58, 69);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(208, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Cấp quyền";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_grantRole
            // 
            this.btn_grantRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_grantRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grantRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_grantRole.Location = new System.Drawing.Point(58, 76);
            this.btn_grantRole.Name = "btn_grantRole";
            this.btn_grantRole.Size = new System.Drawing.Size(208, 23);
            this.btn_grantRole.TabIndex = 3;
            this.btn_grantRole.Text = "Cấp role";
            this.btn_grantRole.UseVisualStyleBackColor = false;
            this.btn_grantRole.Click += new System.EventHandler(this.btn_grantRole_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(17, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Chức năng";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.usernameFindLock);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.UsernameListDel);
            this.groupBox3.Controls.Add(this.usernameListFind);
            this.groupBox3.Controls.Add(this.btnShowAll);
            this.groupBox3.Controls.Add(this.btn_findUsername);
            this.groupBox3.Controls.Add(this.btn_DelUser);
            this.groupBox3.Controls.Add(this.btn_AddUser);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 275);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách User hệ thống";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // UsernameListDel
            // 
            this.UsernameListDel.FormattingEnabled = true;
            this.UsernameListDel.Location = new System.Drawing.Point(6, 113);
            this.UsernameListDel.Name = "UsernameListDel";
            this.UsernameListDel.Size = new System.Drawing.Size(173, 24);
            this.UsernameListDel.TabIndex = 20;
            // 
            // usernameListFind
            // 
            this.usernameListFind.FormattingEnabled = true;
            this.usernameListFind.Location = new System.Drawing.Point(6, 155);
            this.usernameListFind.Name = "usernameListFind";
            this.usernameListFind.Size = new System.Drawing.Size(173, 24);
            this.usernameListFind.TabIndex = 19;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAll.Location = new System.Drawing.Point(58, 32);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(208, 23);
            this.btnShowAll.TabIndex = 18;
            this.btnShowAll.Text = "Hiển thị tất cả record";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btn_findUsername
            // 
            this.btn_findUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_findUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_findUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_findUsername.Location = new System.Drawing.Point(193, 155);
            this.btn_findUsername.Name = "btn_findUsername";
            this.btn_findUsername.Size = new System.Drawing.Size(117, 23);
            this.btn_findUsername.TabIndex = 4;
            this.btn_findUsername.Text = "Tìm Username";
            this.btn_findUsername.UseVisualStyleBackColor = false;
            this.btn_findUsername.Click += new System.EventHandler(this.btn_findUsername_Click);
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DelUser.Location = new System.Drawing.Point(193, 114);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.Size = new System.Drawing.Size(117, 23);
            this.btn_DelUser.TabIndex = 1;
            this.btn_DelUser.Text = "Xóa User";
            this.btn_DelUser.UseVisualStyleBackColor = false;
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click_1);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddUser.Location = new System.Drawing.Point(58, 71);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(208, 23);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Tạo User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 700);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.btn_grantRole);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(23, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 158);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách quyền của User";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(58, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Hiển thị tất cả record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(206, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Tìm grantee";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(58, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thu hồi role";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(826, 230);
            this.dataGridView1.TabIndex = 9;
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.ForeColor = System.Drawing.SystemColors.Control;
            this.temp1.Location = new System.Drawing.Point(310, 256);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(0, 13);
            this.temp1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 545);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(826, 143);
            this.dataGridView2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách role được gán cho các user trong hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách quyền của user trên các đối tượng dữ liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.temp1);
            this.groupBox2.Controls.Add(this.temp2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(399, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 700);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 333);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(826, 158);
            this.dataGridView3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Danh sách role được gán cho các user trong hệ thống";
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.ForeColor = System.Drawing.SystemColors.Control;
            this.temp2.Location = new System.Drawing.Point(55, 277);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(0, 13);
            this.temp2.TabIndex = 15;
            // 
            // usernameFindLock
            // 
            this.usernameFindLock.FormattingEnabled = true;
            this.usernameFindLock.Location = new System.Drawing.Point(6, 196);
            this.usernameFindLock.Name = "usernameFindLock";
            this.usernameFindLock.Size = new System.Drawing.Size(173, 24);
            this.usernameFindLock.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(193, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Lock User";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(58, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Unlock User";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // QLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QLyUser";
            this.Text = "QLyUser";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_grantRole;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DelUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Button btn_findUsername;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFindGrantee;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox UsernameListDel;
        private System.Windows.Forms.ComboBox usernameListFind;
        private System.Windows.Forms.ComboBox GranteeList;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox findUsernameOfPriv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox usernameFindLock;
        private System.Windows.Forms.Button button6;
    }
}