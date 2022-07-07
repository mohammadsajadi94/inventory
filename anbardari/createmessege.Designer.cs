namespace inventory
{
    partial class createmessege
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxeid = new System.Windows.Forms.ComboBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 198);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBoxeid
            // 
            this.comboBoxeid.FormattingEnabled = true;
            this.comboBoxeid.Location = new System.Drawing.Point(297, 12);
            this.comboBoxeid.Name = "comboBoxeid";
            this.comboBoxeid.Size = new System.Drawing.Size(152, 27);
            this.comboBoxeid.TabIndex = 1;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(297, 64);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(152, 27);
            this.txtsubject.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(472, 298);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 35);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "ارسال";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "فرستاده شود به";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "موضوع";
            // 
            // txtmid
            // 
            this.txtmid.Location = new System.Drawing.Point(12, 10);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(152, 27);
            this.txtmid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره پیام";
            // 
            // createmessege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.comboBoxeid);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(612, 380);
            this.MinimumSize = new System.Drawing.Size(612, 380);
            this.Name = "createmessege";
            this.Text = "ایجاد پیام جدید";
            this.Load += new System.EventHandler(this.createmessege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxeid;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.Label label3;
    }
}