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
    public partial class ThemPhong : Form
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
            command.CommandText = "SELECT * FROM PhongTro";//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);
            dgvDSPhong.DataSource = table;
            khoiTao();
        }

        void khoiTao()
        {
            txtMaPhong.Text = txtTenPhong.Text = txtGiaPhong.Text = txtGhiChu.Text = "";
            nudSoLuongToiDa.Value = 0;
            txtMaPhong.ReadOnly = false;
        }
        

        public ThemPhong()
        {
            InitializeComponent();
        }

        void click()
        {
            dgvDSPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaPhong.ReadOnly = true;
            DataGridViewRow row = dgvDSPhong.CurrentRow;
            txtMaPhong.Text = row.Cells[0].Value.ToString();
            txtTenPhong.Text = row.Cells[1].Value.ToString();
            nudSoLuongToiDa.Value = (int)row.Cells[2].Value;
            txtGiaPhong.Text = row.Cells[3].Value.ToString();
            txtGhiChu.Text = row.Cells[4].Value.ToString();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            click();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            // Kiểm tra khóa chính ko rỗng, ko trùng

            if (dgvDSPhong.Rows.Count - 1 == 0)
            {
                if (txtMaPhong.Text != "")
                    command.CommandText = "INSERT INTO PhongTro VALUES ('" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "','" + nudSoLuongToiDa.Value + "','" + txtGiaPhong.Text + "',N'" + txtGhiChu.Text + "')";
            }
            else
            {
                for (int i = 0; i < dgvDSPhong.Rows.Count - 1; i++)
                {
                    if (txtMaPhong.Text != "")
                    {
                        if (txtMaPhong.Text != dgvDSPhong.Rows[i].Cells[0].Value.ToString())
                            command.CommandText = "INSERT INTO PhongTro VALUES ('" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "','" + nudSoLuongToiDa.Value + "','" + txtGiaPhong.Text + "',N'" + txtGhiChu.Text + "')";
                        else
                        {
                            MessageBox.Show("Mã phòng không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã phòng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE PhongTro SET TenPhong = N'" + txtTenPhong.Text + "',SoLuongToiDa = '" + nudSoLuongToiDa.Value + "', GiaPhong = '" + txtGiaPhong.Text + "', GhiChu = N'" + txtGhiChu.Text + "'WHERE MaPhong = '" + txtMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM PhongTro WHERE MaPhong ='" + txtMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
