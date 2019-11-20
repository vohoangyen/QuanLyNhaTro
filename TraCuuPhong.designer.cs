namespace QLNhaTro
{
    partial class TraCuuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsPhongTro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXemTatCa = new System.Windows.Forms.RadioButton();
            this.rdbPhongTrong = new System.Windows.Forms.RadioButton();
            this.rdbPhongDaThue = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTro)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(792, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRA CỨU PHÒNG TRỌ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 382);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDsPhongTro);
            this.groupBox2.Location = new System.Drawing.Point(13, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng trọ";
            // 
            // dgvDsPhongTro
            // 
            this.dgvDsPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongTro.Location = new System.Drawing.Point(6, 19);
            this.dgvDsPhongTro.Name = "dgvDsPhongTro";
            this.dgvDsPhongTro.Size = new System.Drawing.Size(748, 275);
            this.dgvDsPhongTro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXemTatCa);
            this.groupBox1.Controls.Add(this.rdbPhongTrong);
            this.groupBox1.Controls.Add(this.rdbPhongDaThue);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu theo";
            // 
            // rdbXemTatCa
            // 
            this.rdbXemTatCa.AutoSize = true;
            this.rdbXemTatCa.Location = new System.Drawing.Point(373, 17);
            this.rdbXemTatCa.Name = "rdbXemTatCa";
            this.rdbXemTatCa.Size = new System.Drawing.Size(76, 17);
            this.rdbXemTatCa.TabIndex = 0;
            this.rdbXemTatCa.TabStop = true;
            this.rdbXemTatCa.Text = "Xem tất cả";
            this.rdbXemTatCa.UseVisualStyleBackColor = true;
            this.rdbXemTatCa.CheckedChanged += new System.EventHandler(this.rdbPhongDaThue_CheckedChanged);
            // 
            // rdbPhongTrong
            // 
            this.rdbPhongTrong.AutoSize = true;
            this.rdbPhongTrong.Location = new System.Drawing.Point(237, 17);
            this.rdbPhongTrong.Name = "rdbPhongTrong";
            this.rdbPhongTrong.Size = new System.Drawing.Size(83, 17);
            this.rdbPhongTrong.TabIndex = 0;
            this.rdbPhongTrong.TabStop = true;
            this.rdbPhongTrong.Text = "Phòng trống";
            this.rdbPhongTrong.UseVisualStyleBackColor = true;
            this.rdbPhongTrong.CheckedChanged += new System.EventHandler(this.rdbPhongDaThue_CheckedChanged);
            // 
            // rdbPhongDaThue
            // 
            this.rdbPhongDaThue.AutoSize = true;
            this.rdbPhongDaThue.Location = new System.Drawing.Point(102, 17);
            this.rdbPhongDaThue.Name = "rdbPhongDaThue";
            this.rdbPhongDaThue.Size = new System.Drawing.Size(96, 17);
            this.rdbPhongDaThue.TabIndex = 0;
            this.rdbPhongDaThue.TabStop = true;
            this.rdbPhongDaThue.Text = "Phòng đã thuê";
            this.rdbPhongDaThue.UseVisualStyleBackColor = true;
            this.rdbPhongDaThue.CheckedChanged += new System.EventHandler(this.rdbPhongDaThue_CheckedChanged);
            // 
            // TraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraCuuPhong";
            this.Text = "Tra cứu phòng";
            this.Load += new System.EventHandler(this.TraCuuPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongTro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDsPhongTro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbXemTatCa;
        private System.Windows.Forms.RadioButton rdbPhongTrong;
        private System.Windows.Forms.RadioButton rdbPhongDaThue;
    }
}