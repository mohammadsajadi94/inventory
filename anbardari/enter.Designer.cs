namespace inventory
{
    partial class enter
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.comBoxsemat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(12, 83);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(152, 20);
            this.txtpass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(210, 80);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "رمز ورود ";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(12, 54);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(152, 20);
            this.txtuser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(200, 51);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری ";
            // 
            // btnenter
            // 
            this.btnenter.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnenter.Location = new System.Drawing.Point(206, 109);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(61, 30);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "ورود";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnreset.Location = new System.Drawing.Point(12, 109);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(60, 30);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "از نو";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // comBoxsemat
            // 
            this.comBoxsemat.FormattingEnabled = true;
            this.comBoxsemat.Location = new System.Drawing.Point(12, 23);
            this.comBoxsemat.Name = "comBoxsemat";
            this.comBoxsemat.Size = new System.Drawing.Size(152, 21);
            this.comBoxsemat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(227, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(45, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "سمت ";
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxsemat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 188);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 188);
            this.Name = "enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "enter";
            this.Load += new System.EventHandler(this.enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox comBoxsemat;
        private System.Windows.Forms.Label label3;
    }
}