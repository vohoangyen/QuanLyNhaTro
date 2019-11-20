 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace QLNhaTro
{
    public partial class TraCuuPhong : Form
    {
        //tạo kết nối
        SqlConnection connection;
        //tạo truy vấn
        SqlCommand command;
        //chuỗi kết nối
        string str = @"Data Source=DESKTOP-QIQ8G50;Initial Catalog=QLNhaTro;Integrated Security=True";
        //lọc data lên 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        

        //hiển thị data
        void loadData(string query)
        {
            command = connection.CreateCommand();//khởi tạo xử lí kết nối
            command.CommandText = query;//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dgvDsPhongTro.DataSource = table;
        }

        
        public TraCuuPhong()
        {
            InitializeComponent();
        }

        private void TraCuuPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData("SELECT * FROM PhongTro");

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        
        private void rdbPhongDaThue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            switch (radioButton.Name.ToString())
            {
                case "rdbPhongDaThue":
                    loadData("SELECT * FROM PhongTro WHERE MaPhong IN (SELECT MaPhong FROM ThuePhong)");
                    break;
                case "rdbPhongTrong":
                    loadData("SELECT * FROM PhongTro WHERE MaPhong NOT IN (SELECT MaPhong FROM ThuePhong)");
                    break;
                case "rdbXemTatCa":
                    loadData("SELECT * FROM PhongTro");
                    break;
            }
        }
    }
}
