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

namespace DeTaiQuanLyNhaTro
{
    public partial class TraPhong : Form
    {
        //tạo kết nối
        SqlConnection connection;
        //tạo truy vấn
        SqlCommand command;
        //chuỗi kết nối
        string str = @"Data Source=DESKTOP-QIQ8G50;Initial Catalog=QLNhaTro;Integrated Security=True";
        //lọc data lên 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablePhongThue = new DataTable();
        DataTable tableTraPhong = new DataTable();

        //hiển thị data
        void loadData(string query, DataTable table, DataGridView dataGridView)
        {
            command = connection.CreateCommand();//khởi tạo xử lí kết nối
            command.CommandText = query;//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            khoiTao();
        }

        void khoiTao()
        {
            cmbKhachTra.Text = lbMaPhongTro.Text = lbTenPhong.Text = lbMaKT.Text = lbTenKT.Text = lbSDT.Text = "";
            dtpNgayThue.Text = dtpNgayTra.Text;
            btnXacNhan.Enabled = false;
        }

        public TraPhong()
        {
            InitializeComponent();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData("SELECT ThuePhong.MaPhong, NgayThue, TenPhong, KhachTro.MaKT, HoTen, SDT From ThuePhong, PhongTro, KhachTro WHERE ThuePhong.MaPhong = PhongTro.MaPhong AND ThuePhong.MaKT = KhachTro.MaKT", tablePhongThue, dgvPhongThue);
            loadData("SELECT * FROM TraPhong", tableTraPhong, dgvTraPhong);
            for (int i = 0; i < dgvPhongThue.Rows.Count - 1; i++)
            {
                cmbKhachTra.Items.Add(dgvPhongThue.Rows[i].Cells[4].Value.ToString());
            }
            dgvPhongThue.Hide();
            dgvTraPhong.Hide();
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (TestChonPhongTra() == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO TraPhong VALUES ('" + lbMaKT.Text + "','" + lbMaPhongTro.Text + "','" + dtpNgayTra.Text + "')";
                command.CommandText = "DELETE FROM ThuePhong WHERE MaKT ='" + lbMaKT.Text + "' AND MaPhong ='" + lbMaPhongTro.Text + "'";
                command.ExecuteNonQuery();
                loadData("SELECT * FROM TraPhong", tableTraPhong, dgvTraPhong);
                loadData("SELECT ThuePhong.MaPhong, NgayThue, TenPhong, KhachTro.MaKT, HoTen, SDT From ThuePhong, PhongTro, KhachTro WHERE ThuePhong.MaPhong = PhongTro.MaPhong AND ThuePhong.MaKT = KhachTro.MaKT", tablePhongThue, dgvPhongThue);
                khoiTao();
                MessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool TestChonPhongTra()
        {
            if (cmbKhachTra.Text != "")
                return true;
            return false;
        }
        private void cmbKhachTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPhongThue.Rows.Count - 1; i++)
            {
                if (cmbKhachTra.Text.Equals(dgvPhongThue.Rows[i].Cells[4].Value.ToString()))
                {
                    lbMaPhongTro.Text = dgvPhongThue.Rows[i].Cells[0].Value.ToString();
                    dtpNgayThue.Text = dgvPhongThue.Rows[i].Cells[1].Value.ToString();
                    lbTenPhong.Text = dgvPhongThue.Rows[i].Cells[2].Value.ToString();
                    lbMaKT.Text = dgvPhongThue.Rows[i].Cells[3].Value.ToString();
                    lbTenKT.Text = dgvPhongThue.Rows[i].Cells[4].Value.ToString();
                    lbSDT.Text = dgvPhongThue.Rows[i].Cells[5].Value.ToString();

                }
            }
            btnXacNhan.Enabled = true;
        }
    }
}
