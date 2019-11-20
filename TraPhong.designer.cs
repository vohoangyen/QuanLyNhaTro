namespace QLNhaTro
{
    partial class TraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPhongThue = new System.Windows.Forms.DataGridView();
            this.dgvTraPhong = new System.Windows.Forms.DataGridView();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTenKT = new System.Windows.Forms.Label();
            this.lbMaKT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaPhongTro = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKhachTra = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(716, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRẢ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPhongThue);
            this.panel1.Controls.Add(this.dgvTraPhong);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbKhachTra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 410);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvPhongThue
            // 
            this.dgvPhongThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongThue.Location = new System.Drawing.Point(424, 270);
            this.dgvPhongThue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhongThue.Name = "dgvPhongThue";
            this.dgvPhongThue.RowTemplate.Height = 28;
            this.dgvPhongThue.Size = new System.Drawing.Size(280, 131);
            this.dgvPhongThue.TabIndex = 28;
            // 
            // dgvTraPhong
            // 
            this.dgvTraPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraPhong.Location = new System.Drawing.Point(15, 270);
            this.dgvTraPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTraPhong.Name = "dgvTraPhong";
            this.dgvTraPhong.RowTemplate.Height = 28;
            this.dgvTraPhong.Size = new System.Drawing.Size(396, 131);
            this.dgvTraPhong.TabIndex = 27;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(63, 200);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(261, 57);
            this.txtGhiChu.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(13, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 25;
            this.label17.Text = "Ghi chú";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(591, 221);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(104, 35);
            this.btnXacNhan.TabIndex = 24;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSDT);
            this.groupBox2.Controls.Add(this.lbTenKT);
            this.groupBox2.Controls.Add(this.lbMaKT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(344, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 149);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách thuê";
            // 
            // lbSDT
            // 
            this.lbSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSDT.Location = new System.Drawing.Point(127, 116);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(182, 21);
            this.lbSDT.TabIndex = 17;
            this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenKT
            // 
            this.lbTenKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenKT.Location = new System.Drawing.Point(127, 71);
            this.lbTenKT.Name = "lbTenKT";
            this.lbTenKT.Size = new System.Drawing.Size(204, 21);
            this.lbTenKT.TabIndex = 17;
            this.lbTenKT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaKT
            // 
            this.lbMaKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaKT.Location = new System.Drawing.Point(127, 29);
            this.lbMaKT.Name = "lbMaKT";
            this.lbMaKT.Size = new System.Drawing.Size(135, 21);
            this.lbMaKT.TabIndex = 17;
            this.lbMaKT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(20, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Mã khách trọ:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Họ tên khách trọ:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaPhongTro);
            this.groupBox1.Controls.Add(this.lbTenPhong);
            this.groupBox1.Controls.Add(this.dtpNgayThue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 149);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng thuê";
            // 
            // lbMaPhongTro
            // 
            this.lbMaPhongTro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaPhongTro.Location = new System.Drawing.Point(101, 28);
            this.lbMaPhongTro.Name = "lbMaPhongTro";
            this.lbMaPhongTro.Size = new System.Drawing.Size(135, 21);
            this.lbMaPhongTro.TabIndex = 17;
            this.lbMaPhongTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenPhong.Location = new System.Drawing.Point(101, 71);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(135, 21);
            this.lbTenPhong.TabIndex = 17;
            this.lbTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Enabled = false;
            this.dtpNgayThue.Location = new System.Drawing.Point(101, 115);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày thuê";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phòng trọ: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên phòng: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(417, 14);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(206, 20);
            this.dtpNgayTra.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(341, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ngày trả";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chọn khách hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbKhachTra
            // 
            this.cmbKhachTra.FormattingEnabled = true;
            this.cmbKhachTra.Location = new System.Drawing.Point(114, 15);
            this.cmbKhachTra.Name = "cmbKhachTra";
            this.cmbKhachTra.Size = new System.Drawing.Size(210, 21);
            this.cmbKhachTra.TabIndex = 19;
            this.cmbKhachTra.SelectedIndexChanged += new System.EventHandler(this.cmbKhachTra_SelectedIndexChanged);
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraPhong";
            this.Text = "Trả Phòng";
            this.Load += new System.EventHandler(this.TraPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhongThue;
        private System.Windows.Forms.DataGridView dgvTraPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTenKT;
        private System.Windows.Forms.Label lbMaKT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMaPhongTro;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKhachTra;
    }
}