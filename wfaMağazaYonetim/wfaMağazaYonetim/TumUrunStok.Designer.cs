namespace wfaMağazaYonetim
{
    partial class TumUrunStok
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
            this.TumUrunler = new System.Windows.Forms.DataGridView();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ürün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TumUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // TumUrunler
            // 
            this.TumUrunler.AllowUserToAddRows = false;
            this.TumUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TumUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategori,
            this.Ürün,
            this.UrunID,
            this.Adet});
            this.TumUrunler.Location = new System.Drawing.Point(27, 36);
            this.TumUrunler.Name = "TumUrunler";
            this.TumUrunler.Size = new System.Drawing.Size(464, 368);
            this.TumUrunler.TabIndex = 1;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            // 
            // Ürün
            // 
            this.Ürün.HeaderText = "Ürün";
            this.Ürün.Name = "Ürün";
            // 
            // UrunID
            // 
            this.UrunID.HeaderText = "UrunId";
            this.UrunID.Name = "UrunID";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // TumUrunStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.TumUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TumUrunStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TumUrunStok";
            this.Load += new System.EventHandler(this.TumUrunStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TumUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TumUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ürün;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
    }
}