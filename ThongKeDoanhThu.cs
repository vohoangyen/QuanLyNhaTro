using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace DeTaiQuanLyNhaTro
{
    public partial class ThongKeDoanhThu : Form
    {

        //tạo kết nối
        SqlConnection connection;
        //tạo truy vấn
        SqlCommand command;
        //chuỗi kết nối
        string str = @"Data Source=DESKTOP-21LUHLN\SQLEXPRESS;Initial Catalog=QLNhaTro;Integrated Security=True";
        //lọc data lên 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tableNam = new DataTable();
        DataTable tableThang = new DataTable();
        double[] tongThang = new double[12];
        

        //hiển thị data
        void loadData(string query, DataTable table, DataGridView dataGridView)
        {
            command = connection.CreateCommand();//khởi tạo xử lí kết nối
            command.CommandText = query;//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            //dùng để nhập dữ liệu lên combobox
            loadData("SELECT YEAR(NgayLap) FROM HoaDon GROUP BY YEAR(NgayLap)", tableNam, dgvNam);
            dgvNam.Hide();
            dgvThang.Hide();
            //load nam
            for (int i = 0; i < dgvNam.Rows.Count - 1; i++)
            {
                cmbChonNam.Items.Add(dgvNam.Rows[i].Cells[0].Value.ToString());
            }
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        public string ChonNam()
        {
            if (cmbChonNam.Text != "")
                return "Đã chọn năm thống kê!";
            return "Chưa chọn năm thống kê!";
        }
        private void cmbChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChonNam() == "Đã chọn năm thống kê!")
            {
                double[] tongThang = new double[12];

                label1.Visible = true;
                loadData("SELECT YEAR(NgayLap), MONTH(NgayLap), TongTien FROM HOADON WHERE YEAR(NgayLap) = '" + cmbChonNam.Text + "'", tableThang, dgvThang);

                for (int i = 0; i < dgvThang.Rows.Count - 1; i++)
                {
                    int thang = int.Parse(dgvThang.Rows[i].Cells[1].Value.ToString());
                    for (int j = 0; j < tongThang.Length; j++)
                    {
                        if (thang == j + 1)
                            tongThang[j] += double.Parse(dgvThang.Rows[i].Cells[2].Value.ToString());
                    }
                }

                Axis XA = chartDoanhThu.ChartAreas[0].AxisX;
                Series S1 = chartDoanhThu.Series[0];

                List<DateTime> dates = new List<DateTime>(); // ds tháng
                DateTime dt = DateTime.Now;
                for (int i = 1; i < 13; i++)
                    dates.Add(new DateTime(dt.Year, i, 1));

                int dem = 0;
                foreach (DateTime d in dates)                           // duyệt qua từng tháng trong ds dates = 12 tháng
                    S1.Points.AddXY(d, tongThang[dem++]);              // thiet lap gia trị Y ngau nhien cho 12 tháng 
                                                                      //-> lấy giá trị từ dataGridVie
                Axis YA = chartDoanhThu.ChartAreas[0].AxisY;
                S1.XValueType = ChartValueType.Date;  // set the type
                XA.MajorGrid.Enabled = false;         // no gridlines
                XA.LabelStyle.Format = "MM";         // Jan = January
                XA.IntervalType = DateTimeIntervalType.Months;  // show axis labels.. 
                XA.Interval = 1;                                // ..moi 1 thang
                YA.LabelStyle.Format = "##0 vnd";          
                YA.MajorGrid.Enabled = false;
                chartDoanhThu.Series[0].IsValueShownAsLabel = true;
                cmbChonNam.Enabled = false;
            }
           
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            btnXacNhan();
        }

        public bool btnXacNhan()
        {
            if(ChonNam() == "Đã chọn năm thống kê!")
            {
                ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu();
                this.Dispose();
                thongKeDoanhThu.Show();
                return true;
            }
            return false;
        }
    }
}
