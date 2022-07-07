namespace inventory
{
    partial class editeanbar
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
            this.btnedite = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridViewshow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnedite
            // 
            this.btnedite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnedite.Location = new System.Drawing.Point(420, 359);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(96, 31);
            this.btnedite.TabIndex = 16;
            this.btnedite.Text = "ویرایش";
            this.btnedite.UseVisualStyleBackColor = true;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(197, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(352, 28);
            this.txtsearch.TabIndex = 15;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearch.Location = new System.Drawing.Point(592, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 27);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridViewshow
            // 
            this.dataGridViewshow.AllowUserToDeleteRows = false;
            this.dataGridViewshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewshow.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewshow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewshow.Name = "dataGridViewshow";
            this.dataGridViewshow.ReadOnly = true;
            this.dataGridViewshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewshow.Size = new System.Drawing.Size(939, 305);
            this.dataGridViewshow.TabIndex = 13;
            // 
            // editeanbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 402);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridViewshow);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(956, 441);
            this.MinimumSize = new System.Drawing.Size(956, 441);
            this.Name = "editeanbar";
            this.Text = "ویرایش موجودی انبار";
            this.Load += new System.EventHandler(this.editeanbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedite;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridViewshow;
    }
}