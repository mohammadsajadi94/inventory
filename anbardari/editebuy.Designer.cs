namespace inventory
{
    partial class editebuy
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridViewshow = new System.Windows.Forms.DataGridView();
            this.btnedite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(255, 18);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(352, 28);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearch.Location = new System.Drawing.Point(685, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 27);
            this.btnsearch.TabIndex = 5;
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
            this.dataGridViewshow.Location = new System.Drawing.Point(0, 54);
            this.dataGridViewshow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewshow.Name = "dataGridViewshow";
            this.dataGridViewshow.ReadOnly = true;
            this.dataGridViewshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewshow.Size = new System.Drawing.Size(991, 251);
            this.dataGridViewshow.TabIndex = 4;
            // 
            // btnedite
            // 
            this.btnedite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnedite.Location = new System.Drawing.Point(451, 313);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(96, 31);
            this.btnedite.TabIndex = 7;
            this.btnedite.Text = "ویرایش";
            this.btnedite.UseVisualStyleBackColor = true;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // editebuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 352);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridViewshow);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "editebuy";
            this.Text = "ویرایش فاکتور های  خرید";
            this.Load += new System.EventHandler(this.editebuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridViewshow;
        private System.Windows.Forms.Button btnedite;
    }
}