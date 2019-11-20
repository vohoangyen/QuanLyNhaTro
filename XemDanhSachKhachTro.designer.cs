namespace QLNhaTro
{
    partial class XemDanhSachKhachTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDanhSachKhachTro));
            this.dgvDanhSachKT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachKT
            // 
            this.dgvDanhSachKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKT.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachKT.Name = "dgvDanhSachKT";
            this.dgvDanhSachKT.Size = new System.Drawing.Size(913, 487);
            this.dgvDanhSachKT.TabIndex = 1;
            // 
            // XemDanhSachKhachTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.dgvDanhSachKT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XemDanhSachKhachTro";
            this.Text = "Danh sách khách trọ";
            this.Load += new System.EventHandler(this.XemDanhSachKhachTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachKT;
    }
}