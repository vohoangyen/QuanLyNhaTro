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
