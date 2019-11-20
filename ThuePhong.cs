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

    public partial class ThuePhong : Form
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
        DataTable tableKhachTro = new DataTable();
        DataTable tablePhongTrong = new DataTable();
        DataTable tablePhongChuaDay = new DataTable();

        //hiển thị data
        void loadData(string truyVan, DataGridView dataGridView, DataTable dataTable)
        {
            command = connection.CreateCommand();//khởi tạo xử lí kết nối
            command.CommandText = truyVan;//điền câu truy vấn
            adapter.SelectCommand = command;//thực thi câu truy vấn
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            khoiTao();
        }

        void khoiTao()
        {
            cmbPhongTrong.Text = txtMaPhongTrong.Text = txtMaKT.Text = cmbKhachThue.Text = txtTienDatCoc.Text = txtGhiChu.Text = "";
        }
        public ThuePhong()
        {
            InitializeComponent();
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            dgvDsKhachTro.Hide();
            dgvDsPhongTrong.Hide();
            dgvDsPhongChuaDay.Hide();
            loadData("SELECT * FROM ThuePhong", dgvDsPhongThue, tablePhongThue);
            loadData("SELECT * FROM KhachTro WHERE MaKT NOT IN (SELECT MaKT FROM ThuePhong)", dgvDsKhachTro, tableKhachTro);//lấy khách chưa thuê
            loadData("SELECT * FROM PhongTro WHERE MaPhong NOT IN (SELECT MaPhong FROM ThuePhong)", dgvDsPhongTrong, tablePhongTrong);//lấy phòng trống
            loadData("SELECT * FROM PhongTro WHERE MaPhong IN (SELECT MaPhong FROM ThuePhong WHERE PhongTro.MaPhong = ThuePhong.MaPhong GROUP BY MaPhong HAVING COUNT(ThuePhong.MaKT) < SoLuongToiDa )", dgvDsPhongChuaDay, tablePhongChuaDay);//lấy phòng đã thuê nhưng chưa đầy

            for (int i = 0; i < dgvDsKhachTro.Rows.Count - 1; i++)
            {
                cmbKhachThue.Items.Add(dgvDsKhachTro.Rows[i].Cells[1].Value.ToString());
            }
            for (int i = 0; i < dgvDsPhongTrong.Rows.Count - 1; i++)
            {
                cmbPhongTrong.Items.Add(dgvDsPhongTrong.Rows[i].Cells[1].Value.ToString());
            }
            for (int i = 0; i < dgvDsPhongChuaDay.Rows.Count - 1; i++)
            {
                cmbPhongTrong.Items.Add(dgvDsPhongChuaDay.Rows[i].Cells[1].Value.ToString());
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            // Kiểm tra khóa chính ko rỗng, ko trùng
            if (dgvDsPhongThue.Rows.Count - 1 == 0)
            {
                if (ChonPhongVaKhach() == true)
                {
                    if (TienDatCoc(txtTienDatCoc.Text) == "Đã nhập tiền đặt cọc")
                    {
                        command.CommandText = "INSERT INTO ThuePhong VALUES ('" + txtMaKT.Text + "','" + txtMaPhongTrong.Text + "','" + dtpNgayThue.Text + "','" + txtTienDatCoc.Text + "',N'" + txtGhiChu.Text + "')";
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgvDsPhongThue.Rows.Count - 1; i++)
                {
                    if (ChonPhongVaKhach() == true)
                    {
                        if (txtMaKT.Text != dgvDsPhongThue.Rows[i].Cells[0].Value.ToString())
                        {
                            if (TienDatCoc(txtTienDatCoc.Text) == "Đã nhập tiền đặt cọc")
                            {
                                command.CommandText = "INSERT INTO ThuePhong VALUES ('" + txtMaKT.Text + "','" + txtMaPhongTrong.Text + "','" + dtpNgayThue.Text + "','" + txtTienDatCoc.Text + "',N'" + txtGhiChu.Text + "')";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Khóa chính không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khóa chính không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            command.ExecuteNonQuery();
            loadData("SELECT * FROM ThuePhong", dgvDsPhongThue, tablePhongThue);
            loadData("SELECT * FROM KhachTro WHERE MaKT NOT IN (SELECT MaKT FROM ThuePhong)", dgvDsKhachTro, tableKhachTro);
            loadData("SELECT * FROM PhongTro WHERE MaPhong NOT IN (SELECT MaPhong FROM ThuePhong)", dgvDsPhongTrong, tablePhongTrong);
            loadData("SELECT * FROM PhongTro WHERE MaPhong IN (SELECT MaPhong FROM ThuePhong WHERE PhongTro.MaPhong = ThuePhong.MaPhong GROUP BY MaPhong HAVING COUNT(ThuePhong.MaKT) < SoLuongToiDa )", dgvDsPhongChuaDay, tablePhongChuaDay);//lấy phòng đã thuê nhưng chưa đầy
            btnXacNhan.Enabled = false;
        }

        public bool ChonPhongVaKhach()
        {
            if (cmbPhongTrong.Text != "" && cmbKhachThue.Text != "")
                return true;
            return false;
        }

        public string TienDatCoc(string tdc)
        {
            if (tdc != "")
                return "Đã nhập tiền đặt cọc";
            else
                return "Chưa nhập tiền đặt cọc";
        }
        private void cmbPhongTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDsPhongTrong.Rows.Count - 1; i++)
            {
                if (cmbPhongTrong.Text.Equals(dgvDsPhongTrong.Rows[i].Cells[1].Value.ToString()))
                {
                    txtMaPhongTrong.Text = dgvDsPhongTrong.Rows[i].Cells[0].Value.ToString();
                    return;
                }
            }
            for (int i = 0; i < dgvDsPhongChuaDay.Rows.Count - 1; i++)
            {
                if (cmbPhongTrong.Text.Equals(dgvDsPhongChuaDay.Rows[i].Cells[1].Value.ToString()))
                {
                    txtMaPhongTrong.Text = dgvDsPhongChuaDay.Rows[i].Cells[0].Value.ToString();
                    return;
                }
            }
            test();
        }

        private void cmbKhachThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDsKhachTro.Rows.Count - 1; i++)
            {
                if (cmbKhachThue.Text.Equals(dgvDsKhachTro.Rows[i].Cells[1].Value.ToString()))
                {
                    txtMaKT.Text = dgvDsKhachTro.Rows[i].Cells[0].Value.ToString();
                }
            }
            test();
        }

        public bool test()
        {
            if (txtMaKT.Text != "" && txtMaPhongTrong.Text != "")
            {
                btnXacNhan.Enabled = true;
                return true;
            }
            return false;
        }
    }
}
