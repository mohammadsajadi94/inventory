namespace inventory
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.tabedite = new System.Windows.Forms.TabPage();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridshow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcreate = new System.Windows.Forms.TabPage();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxdasres = new System.Windows.Forms.ComboBox();
            this.comboBoxvahed = new System.Windows.Forms.ComboBox();
            this.txtemployid = new System.Windows.Forms.TextBox();
            this.txtpersonalid = new System.Windows.Forms.TextBox();
            this.txtnamef = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtsemat = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.tabuser = new System.Windows.Forms.TabControl();
            this.tabedite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridshow)).BeginInit();
            this.tabcreate.SuspendLayout();
            this.tabuser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabedite
            // 
            this.tabedite.BackColor = System.Drawing.Color.White;
            this.tabedite.Controls.Add(this.btnedit);
            this.tabedite.Controls.Add(this.btnsearch);
            this.tabedite.Controls.Add(this.textBox1);
            this.tabedite.Controls.Add(this.dataGridshow);
            this.tabedite.Location = new System.Drawing.Point(4, 28);
            this.tabedite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabedite.Name = "tabedite";
            this.tabedite.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabedite.Size = new System.Drawing.Size(832, 357);
            this.tabedite.TabIndex = 1;
            this.tabedite.Text = "ویرایش کاربران";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(371, 309);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(105, 38);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnsave2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(498, 8);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(105, 32);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(182, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridshow
            // 
            this.dataGridshow.AllowUserToAddRows = false;
            this.dataGridshow.AllowUserToDeleteRows = false;
            this.dataGridshow.AllowUserToOrderColumns = true;
            this.dataGridshow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridshow.GridColor = System.Drawing.Color.White;
            this.dataGridshow.Location = new System.Drawing.Point(0, 44);
            this.dataGridshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridshow.Name = "dataGridshow";
            this.dataGridshow.ReadOnly = true;
            this.dataGridshow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridshow.Size = new System.Drawing.Size(829, 258);
            this.dataGridshow.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "کد پرسنلی";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "نام پدر";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "کد ملی";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "واحد";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "سمت";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "رمز ورود";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "سطح دسترسی";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // tabcreate
            // 
            this.tabcreate.BackColor = System.Drawing.Color.White;
            this.tabcreate.Controls.Add(this.btncancel);
            this.tabcreate.Controls.Add(this.btnreset);
            this.tabcreate.Controls.Add(this.btnsave);
            this.tabcreate.Controls.Add(this.label10);
            this.tabcreate.Controls.Add(this.label5);
            this.tabcreate.Controls.Add(this.label9);
            this.tabcreate.Controls.Add(this.label4);
            this.tabcreate.Controls.Add(this.label8);
            this.tabcreate.Controls.Add(this.label3);
            this.tabcreate.Controls.Add(this.label7);
            this.tabcreate.Controls.Add(this.lable2);
            this.tabcreate.Controls.Add(this.label6);
            this.tabcreate.Controls.Add(this.label1);
            this.tabcreate.Controls.Add(this.comboBoxdasres);
            this.tabcreate.Controls.Add(this.comboBoxvahed);
            this.tabcreate.Controls.Add(this.txtemployid);
            this.tabcreate.Controls.Add(this.txtpersonalid);
            this.tabcreate.Controls.Add(this.txtnamef);
            this.tabcreate.Controls.Add(this.txtfamily);
            this.tabcreate.Controls.Add(this.txtpass);
            this.tabcreate.Controls.Add(this.txtuser);
            this.tabcreate.Controls.Add(this.txtsemat);
            this.tabcreate.Controls.Add(this.txtname);
            this.tabcreate.Location = new System.Drawing.Point(4, 28);
            this.tabcreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabcreate.Name = "tabcreate";
            this.tabcreate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabcreate.Size = new System.Drawing.Size(832, 357);
            this.tabcreate.TabIndex = 0;
            this.tabcreate.Text = "ایجاد کاربر جدید";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncancel.Location = new System.Drawing.Point(111, 266);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 33);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnreset.Location = new System.Drawing.Point(399, 266);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 33);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "از نو";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsave.Location = new System.Drawing.Point(701, 266);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(244, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "سطح دسترسی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(720, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "شماره پرسنلی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(244, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "رمز ورود";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(720, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "کد ملی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(244, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(720, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام پدر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(244, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "سمت";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lable2.Location = new System.Drawing.Point(720, 79);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(82, 26);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "نام خانوادگی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(244, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "واحد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(720, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            // 
            // comboBoxdasres
            // 
            this.comboBoxdasres.FormattingEnabled = true;
            this.comboBoxdasres.Location = new System.Drawing.Point(17, 204);
            this.comboBoxdasres.Name = "comboBoxdasres";
            this.comboBoxdasres.Size = new System.Drawing.Size(169, 27);
            this.comboBoxdasres.TabIndex = 1;
            // 
            // comboBoxvahed
            // 
            this.comboBoxvahed.FormattingEnabled = true;
            this.comboBoxvahed.Location = new System.Drawing.Point(17, 35);
            this.comboBoxvahed.Name = "comboBoxvahed";
            this.comboBoxvahed.Size = new System.Drawing.Size(169, 27);
            this.comboBoxvahed.TabIndex = 1;
            // 
            // txtemployid
            // 
            this.txtemployid.Location = new System.Drawing.Point(483, 204);
            this.txtemployid.Name = "txtemployid";
            this.txtemployid.Size = new System.Drawing.Size(169, 27);
            this.txtemployid.TabIndex = 0;
            // 
            // txtpersonalid
            // 
            this.txtpersonalid.Location = new System.Drawing.Point(483, 162);
            this.txtpersonalid.Name = "txtpersonalid";
            this.txtpersonalid.Size = new System.Drawing.Size(169, 27);
            this.txtpersonalid.TabIndex = 0;
            // 
            // txtnamef
            // 
            this.txtnamef.Location = new System.Drawing.Point(483, 120);
            this.txtnamef.Name = "txtnamef";
            this.txtnamef.Size = new System.Drawing.Size(169, 27);
            this.txtnamef.TabIndex = 0;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(483, 78);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(169, 27);
            this.txtfamily.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(17, 163);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(169, 27);
            this.txtpass.TabIndex = 0;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(17, 121);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(169, 27);
            this.txtuser.TabIndex = 0;
            // 
            // txtsemat
            // 
            this.txtsemat.Location = new System.Drawing.Point(17, 78);
            this.txtsemat.Name = "txtsemat";
            this.txtsemat.Size = new System.Drawing.Size(169, 27);
            this.txtsemat.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(483, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 27);
            this.txtname.TabIndex = 0;
            // 
            // tabuser
            // 
            this.tabuser.Controls.Add(this.tabcreate);
            this.tabuser.Controls.Add(this.tabedite);
            this.tabuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabuser.Location = new System.Drawing.Point(0, 0);
            this.tabuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabuser.Name = "tabuser";
            this.tabuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabuser.RightToLeftLayout = true;
            this.tabuser.SelectedIndex = 0;
            this.tabuser.Size = new System.Drawing.Size(840, 389);
            this.tabuser.TabIndex = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 389);
            this.Controls.Add(this.tabuser);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(856, 428);
            this.MinimumSize = new System.Drawing.Size(856, 428);
            this.Name = "User";
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.User_Load);
            this.tabedite.ResumeLayout(false);
            this.tabedite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridshow)).EndInit();
            this.tabcreate.ResumeLayout(false);
            this.tabcreate.PerformLayout();
            this.tabuser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabedite;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridshow;
        private System.Windows.Forms.TabPage tabcreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxdasres;
        private System.Windows.Forms.ComboBox comboBoxvahed;
        private System.Windows.Forms.TextBox txtemployid;
        private System.Windows.Forms.TextBox txtpersonalid;
        private System.Windows.Forms.TextBox txtnamef;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtsemat;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TabControl tabuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnedit;

    }
}