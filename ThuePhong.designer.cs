namespace QLNhaTro
{
    partial class ThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDsPhongChuaDay = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsPhongThue = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDsKhachTro = new System.Windows.Forms.DataGridView();
            this.txtMaPhongTrong = new System.Windows.Forms.TextBox();
            this.txtMaKT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKhachThue = new System.Windows.Forms.ComboBox();
            this.cmbPhongTrong = new System.Windows.Forms.ComboBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDsPhongTrong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongChuaDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongThue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKhachTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "THUÊ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDsPhongChuaDay);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvDsPhongTrong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 393);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvDsPhongChuaDay
            // 
            this.dgvDsPhongChuaDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongChuaDay.Location = new System.Drawing.Point(700, 129);
            this.dgvDsPhongChuaDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDsPhongChuaDay.Name = "dgvDsPhongChuaDay";
            this.dgvDsPhongChuaDay.RowTemplate.Height = 28;
            this.dgvDsPhongChuaDay.Size = new System.Drawing.Size(260, 145);
            this.dgvDsPhongChuaDay.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsPhongThue);
            this.groupBox2.Location = new System.Drawing.Point(51, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuê phòng";
            // 
            // dgvDsPhongThue
            // 
            this.dgvDsPhongThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongThue.Location = new System.Drawing.Point(6, 19);
            this.dgvDsPhongThue.Name = "dgvDsPhongThue";
            this.dgvDsPhongThue.Size = new System.Drawing.Size(625, 122);
            this.dgvDsPhongThue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDsKhachTro);
            this.groupBox1.Controls.Add(this.txtMaPhongTrong);
            this.groupBox1.Controls.Add(this.txtMaKT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpNgayThue);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKhachThue);
            this.groupBox1.Controls.Add(this.cmbPhongTrong);
            this.groupBox1.Controls.Add(this.txtTienDatCoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(51, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 217);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuê phòng";
            // 
            // dgvDsKhachTro
            // 
            this.dgvDsKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKhachTro.Location = new System.Drawing.Point(549, 23);
            this.dgvDsKhachTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDsKhachTro.Name = "dgvDsKhachTro";
            this.dgvDsKhachTro.RowTemplate.Height = 28;
            this.dgvDsKhachTro.Size = new System.Drawing.Size(45, 39);
            this.dgvDsKhachTro.TabIndex = 9;
            // 
            // txtMaPhongTrong
            // 
            this.txtMaPhongTrong.Enabled = false;
            this.txtMaPhongTrong.Location = new System.Drawing.Point(429, 21);
            this.txtMaPhongTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhongTrong.Name = "txtMaPhongTrong";
            this.txtMaPhongTrong.Size = new System.Drawing.Size(68, 20);
            this.txtMaPhongTrong.TabIndex = 16;
            // 
            // txtMaKT
            // 
            this.txtMaKT.Enabled = false;
            this.txtMaKT.Location = new System.Drawing.Point(429, 54);
            this.txtMaKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKT.Name = "txtMaKT";
            this.txtMaKT.Size = new System.Drawing.Size(68, 20);
            this.txtMaKT.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã phòng trống";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(340, 118);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(291, 64);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(337, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ghi chú";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(112, 124);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThue.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(555, 188);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ngày thuê";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn phòng trống";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbKhachThue
            // 
            this.cmbKhachThue.FormattingEnabled = true;
            this.cmbKhachThue.Location = new System.Drawing.Point(112, 54);
            this.cmbKhachThue.Name = "cmbKhachThue";
            this.cmbKhachThue.Size = new System.Drawing.Size(200, 21);
            this.cmbKhachThue.TabIndex = 4;
            this.cmbKhachThue.SelectedIndexChanged += new System.EventHandler(this.cmbKhachThue_SelectedIndexChanged);
            // 
            // cmbPhongTrong
            // 
            this.cmbPhongTrong.FormattingEnabled = true;
            this.cmbPhongTrong.Location = new System.Drawing.Point(112, 18);
            this.cmbPhongTrong.Name = "cmbPhongTrong";
            this.cmbPhongTrong.Size = new System.Drawing.Size(200, 21);
            this.cmbPhongTrong.TabIndex = 4;
            this.cmbPhongTrong.SelectedIndexChanged += new System.EventHandler(this.cmbPhongTrong_SelectedIndexChanged);
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(112, 90);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(200, 20);
            this.txtTienDatCoc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiền đặt cọc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ tên khách trọ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDsPhongTrong
            // 
            this.dgvDsPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongTrong.Location = new System.Drawing.Point(700, 12);
            this.dgvDsPhongTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDsPhongTrong.Name = "dgvDsPhongTrong";
            this.dgvDsPhongTrong.RowTemplate.Height = 28;
            this.dgvDsPhongTrong.Size = new System.Drawing.Size(229, 110);
            this.dgvDsPhongTrong.TabIndex = 13;
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThuePhong";
            this.Text = "ThuePhong";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongChuaDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongThue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKhachTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDsPhongChuaDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDsPhongThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDsKhachTro;
        private System.Windows.Forms.TextBox txtMaPhongTrong;
        private System.Windows.Forms.TextBox txtMaKT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKhachThue;
        private System.Windows.Forms.ComboBox cmbPhongTrong;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDsPhongTrong;
    }
}