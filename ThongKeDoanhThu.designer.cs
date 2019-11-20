namespace QLNhaTro
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThu));
            this.lbTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThang = new System.Windows.Forms.DataGridView();
            this.dgvNam = new System.Windows.Forms.DataGridView();
            this.cmbChonNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.BackColor = System.Drawing.Color.White;
            this.lbTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Blue;
            this.lbTen.Location = new System.Drawing.Point(0, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(913, 66);
            this.lbTen.TabIndex = 48;
            this.lbTen.Text = "THỐNG KÊ DOANH THU TỪNG THÁNG THEO NĂM";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvThang);
            this.panel1.Controls.Add(this.dgvNam);
            this.panel1.Controls.Add(this.cmbChonNam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chartDoanhThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 359);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(87, 60);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(114, 29);
            this.btnDongY.TabIndex = 59;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "tháng";
            this.label1.Visible = false;
            // 
            // dgvThang
            // 
            this.dgvThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThang.Location = new System.Drawing.Point(7, 113);
            this.dgvThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThang.Name = "dgvThang";
            this.dgvThang.RowTemplate.Height = 28;
            this.dgvThang.Size = new System.Drawing.Size(197, 180);
            this.dgvThang.TabIndex = 57;
            // 
            // dgvNam
            // 
            this.dgvNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNam.Location = new System.Drawing.Point(20, 60);
            this.dgvNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNam.Name = "dgvNam";
            this.dgvNam.RowTemplate.Height = 28;
            this.dgvNam.Size = new System.Drawing.Size(41, 36);
            this.dgvNam.TabIndex = 56;
            // 
            // cmbChonNam
            // 
            this.cmbChonNam.FormattingEnabled = true;
            this.cmbChonNam.Location = new System.Drawing.Point(80, 22);
            this.cmbChonNam.Name = "cmbChonNam";
            this.cmbChonNam.Size = new System.Drawing.Size(122, 21);
            this.cmbChonNam.TabIndex = 55;
            this.cmbChonNam.SelectedIndexChanged += new System.EventHandler(this.cmbChonNam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Chọn năm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(208, 22);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.CustomProperties = "PointWidth=0.7";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(698, 315);
            this.chartDoanhThu.TabIndex = 53;
            this.chartDoanhThu.Text = "chart1";
            title1.Name = "Thống kê doanh thu nhà trọ";
            this.chartDoanhThu.Titles.Add(title1);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeDoanhThu";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThang;
        private System.Windows.Forms.DataGridView dgvNam;
        private System.Windows.Forms.ComboBox cmbChonNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}