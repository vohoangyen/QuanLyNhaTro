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

namespace QLNhaTro
{
    public partial class XemDanhSachKhachTro : Form
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
        void loadData()
        {
            command = connection.CreateCommand();//khởi tạo xử lí kết nối
            command.CommandText = "SELECT * FROM KhachTro";//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachKT.DataSource = table;
        }

        
        public XemDanhSachKhachTro()
        {
            InitializeComponent();
        }

        private void XemDanhSachKhachTro_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
