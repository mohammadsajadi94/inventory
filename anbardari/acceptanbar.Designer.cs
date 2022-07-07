namespace inventory
{
    partial class acceptanbar
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
            this.dataGridViewshow = new System.Windows.Forms.DataGridView();
            this.checkBoxaccept = new System.Windows.Forms.CheckBox();
            this.btnacept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewshow
            // 
            this.dataGridViewshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewshow.Location = new System.Drawing.Point(-1, 2);
            this.dataGridViewshow.Name = "dataGridViewshow";
            this.dataGridViewshow.Size = new System.Drawing.Size(604, 291);
            this.dataGridViewshow.TabIndex = 0;
            // 
            // checkBoxaccept
            // 
            this.checkBoxaccept.AutoSize = true;
            this.checkBoxaccept.Location = new System.Drawing.Point(12, 308);
            this.checkBoxaccept.Name = "checkBoxaccept";
            this.checkBoxaccept.Size = new System.Drawing.Size(89, 24);
            this.checkBoxaccept.TabIndex = 2;
            this.checkBoxaccept.Text = "تایید می شود";
            this.checkBoxaccept.UseVisualStyleBackColor = true;
            // 
            // btnacept
            // 
            this.btnacept.Location = new System.Drawing.Point(12, 338);
            this.btnacept.Name = "btnacept";
            this.btnacept.Size = new System.Drawing.Size(75, 32);
            this.btnacept.TabIndex = 3;
            this.btnacept.Text = "ثبت تایید";
            this.btnacept.UseVisualStyleBackColor = true;
            this.btnacept.Click += new System.EventHandler(this.btnacept_Click);
            // 
            // acceptanbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 402);
            this.Controls.Add(this.btnacept);
            this.Controls.Add(this.checkBoxaccept);
            this.Controls.Add(this.dataGridViewshow);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(620, 441);
            this.MinimumSize = new System.Drawing.Size(620, 441);
            this.Name = "acceptanbar";
            this.Text = "تایید موجودی انبار";
            this.Load += new System.EventHandler(this.acceptanbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewshow;
        private System.Windows.Forms.CheckBox checkBoxaccept;
        private System.Windows.Forms.Button btnacept;
    }
}