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
    public partial class LapHoaDon : Form
    {
        //tạo kết nối
        SqlConnection connection;
        //tạo truy vấn
        SqlCommand command;
        //chuỗi kết nối
        string str = @"Data Source=DESKTOP-21LUHLN\SQLEXPRESS;Initial Catalog=QLNhaTro;Integrated Security=True";
        //lọc data lên 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablePhongThue = new DataTable();
        DataTable tableHoaDon = new DataTable();

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
            cmbChonPhong.Text = lbMaKT.Text = lbMaPhongTro.Text = lbTenPhong.Text = lbGiaPhong.Text = txtGhiChu.Text = "";
            lbTienDien.Text = lbTienNuoc.Text = lbTienWifi.Text = lbTienXe.Text = lbTongTien.Text = "";
            txtSoDien.Text = txtSoNuoc.Text = txtGiaDien.Text = txtGiaNuoc.Text = txtGiaXe.Text = txtGiaWifi.Text = txtSLXe.Text = "0";
            cBGuiXe.Checked = cBWifi.Checked = false;
            txtSLXe.Enabled = false;
            btnLuuHoaDon.Enabled = false;
        }


        public LapHoaDon()
        {
            InitializeComponent();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            lbMaKT.Hide();
            dgvPhongThue.Hide();
            connection = new SqlConnection(str);
            connection.Open();
            loadData("SELECT ThuePhong.MaPhong, TenPhong, GiaPhong, KhachTro.MaKT From ThuePhong, PhongTro, KhachTro WHERE ThuePhong.MaPhong = PhongTro.MaPhong AND ThuePhong.MaKT = KhachTro.MaKT", tablePhongThue, dgvPhongThue);
            loadData("SELECT * FROM HoaDon", tableHoaDon, dgvHoaDon);
            for (int i = 0; i < dgvPhongThue.Rows.Count - 1; i++)
            {
                cmbChonPhong.Items.Add(dgvPhongThue.Rows[i].Cells[1].Value.ToString());
            }
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }


        private void cmbChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPhongThue.Rows.Count - 1; i++)
            {
                if (cmbChonPhong.Text.Equals(dgvPhongThue.Rows[i].Cells[1].Value.ToString()))
                {
                    lbMaPhongTro.Text = dgvPhongThue.Rows[i].Cells[0].Value.ToString();
                    lbTenPhong.Text = dgvPhongThue.Rows[i].Cells[1].Value.ToString();
                    lbGiaPhong.Text = dgvPhongThue.Rows[i].Cells[2].Value.ToString();
                    lbMaKT.Text = dgvPhongThue.Rows[i].Cells[3].Value.ToString();
                    lbTienPhong.Text = lbGiaPhong.Text;
                    //txtTienPhong.Text = lbGiaPhong.Text;
                    break;
                }
            }
        }

        private void cBGuiXe_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name.ToString())
            {
                case "cBGuiXe":
                    txtSLXe.Enabled = txtGiaXe.Enabled = true;
                    break;
                case "cBWifi":
                    txtGiaWifi.Enabled = true;
                    break;
            }
        }


        private void btnXacNhanLapHD_Click(object sender, EventArgs e)
        {
            if (ChonPhong() == true)
            {
                if (NhapDuLieu(txtSoDien.Text, txtSoNuoc.Text, txtGiaDien.Text, txtGiaNuoc.Text, txtTienPhong.Text, txtSLXe.Text, txtGiaXe.Text, txtGiaWifi.Text) == "Đã nhập dữ liệu!")
                {
                    if(NhapSoAm(txtSoDien.Text, txtSoNuoc.Text, txtGiaDien.Text, txtGiaNuoc.Text, txtTienPhong.Text, txtSLXe.Text, txtGiaXe.Text, txtGiaWifi.Text) == "Số nguyên dương")
                    {
                        lbTienDien.Text = (int.Parse(txtSoDien.Text) * int.Parse(txtGiaDien.Text)).ToString();
                        lbTienNuoc.Text = (int.Parse(txtSoNuoc.Text) * int.Parse(txtGiaNuoc.Text)).ToString();
                        lbTienXe.Text = (int.Parse(txtSLXe.Text) * int.Parse(txtGiaXe.Text)).ToString();
                        lbTienWifi.Text = txtGiaWifi.Text;
                        lb.Text = (int.Parse(txtTienPhong.Text)).ToString();
                        lbTongTien.Text = TinhTien(int.Parse(txtSoDien.Text), int.Parse(txtGiaDien.Text), int.Parse(txtSoNuoc.Text), int.Parse(txtGiaNuoc.Text), int.Parse(txtTienPhong.Text), int.Parse(txtSLXe.Text), int.Parse(txtGiaXe.Text), int.Parse(txtGiaWifi.Text)).ToString();
                    }
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                    //(int.Parse(lbTienDien.Text) + int.Parse(lbTienNuoc.Text) + int.Parse(lbTienXe.Text) + int.Parse(lbTienWifi.Text) + int.Parse(lbTienPhong.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần tính tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnLuuHoaDon.Enabled = true;
        }

        public bool ChonPhong()
        {
            if (cmbChonPhong.Text != "")
                return true;
            return false;
        }

        public string NhapDuLieu(string sd, string sn, string gd, string gn, string tp, string slx, string gx, string gw)
        {
            if (sd == "" || sn == "" || gd == "" || gn == "" || tp == "" || slx == "" || gx == "" || gw == "")
            {              
                return "Chưa nhập dữ liệu!";
            }
            return "Đã nhập dữ liệu!";
        }

        public string NhapSoAm(string sd, string sn, string gd, string gn, string tp, string slx, string gx, string gw)
        {
            if (int.Parse(sd) < 0 || int.Parse(sn) < 0 || int.Parse(gd) < 0 || int.Parse(gn) < 0 || int.Parse(tp) < 0 || int.Parse(slx) < 0 || int.Parse(gx) < 0 || int.Parse(gw) < 0)
            {
                return "Số âm";
            }
            return "Số nguyên dương";
        }
        public int TinhTien(int sd, int sn, int gd, int gn, int tp, int slx, int gx, int gw)
        {
            int kq = 0;
            return kq = (sd * gd) + (sn * gn) + tp + (slx * gx) + gw;

        }


        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO HoaDon VALUES ('" + txtSoDien.Text + "','" + txtSoNuoc.Text + "','" + txtSLXe.Text + "','" + txtGiaDien.Text + "','" + txtGiaNuoc.Text + "','" + txtGiaXe.Text + "','" + txtGiaWifi.Text + "','" + txtGhiChu.Text + "','" + lbMaKT.Text + "','" + lbMaPhongTro.Text + "','" + dtpNgayLapHD.Text + "','" + lbTongTien.Text + "')";
            command.ExecuteNonQuery();
            loadData("SELECT * FROM HoaDon", tableHoaDon, dgvHoaDon);
            khoiTao();
        }

        
        private void txtSoDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

    }
}
