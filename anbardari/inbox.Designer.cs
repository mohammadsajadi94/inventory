namespace inventory
{
    partial class inbox
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
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewshow
            // 
            this.dataGridViewshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewshow.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewshow.Name = "dataGridViewshow";
            this.dataGridViewshow.Size = new System.Drawing.Size(426, 342);
            this.dataGridViewshow.TabIndex = 0;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(322, 361);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 29);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "از نو";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dataGridViewshow);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inbox";
            this.Text = "پیام های دریافتی";
            this.Load += new System.EventHandler(this.inbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewshow;
        private System.Windows.Forms.Button btnreset;
    }
}