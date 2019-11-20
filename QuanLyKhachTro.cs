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
    public partial class QuanLyKhachTro : Form
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
            dgvKhachTro.DataSource = table;
            khoiTao();
        }

        void khoiTao()
        {
            txtMaKT.Text = txtHoTen.Text = cmbGioiTinh.Text = txtCMND.Text 
                         = txtNgheNghiep.Text = txtDiaChi.Text = txtDienThoai.Text = txtGhiChu.Text = "";
            ckbNguoiDatCoc.Checked = false;
            dtpNgaySinh.Text = "1/1/1980";
            txtMaKT.ReadOnly = false;
        }
        public QuanLyKhachTro()
        {
            InitializeComponent();
        }

        private void QuanLyKhachTro_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        void click()
        {
            dgvKhachTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaKT.ReadOnly = true;
            DataGridViewRow row = dgvKhachTro.CurrentRow;
            txtMaKT.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            cmbGioiTinh.Text = row.Cells[2].Value.ToString();
            dtpNgaySinh.Text = row.Cells[3].Value.ToString();
            txtCMND.Text = row.Cells[4].Value.ToString();
            txtNgheNghiep.Text = row.Cells[5].Value.ToString();
            txtDiaChi.Text = row.Cells[6].Value.ToString();
            txtDienThoai.Text = row.Cells[7].Value.ToString();

            if ((bool)row.Cells[8].Value == true)   // chọn FullRowSelect nên nhiều khi nó bị check lên dù nó là false
                ckbNguoiDatCoc.Checked = true;
            else
                ckbNguoiDatCoc.Checked = false;

            txtGhiChu.Text = row.Cells[9].Value.ToString();
        }

        

        void resetRadio()
        {
            
            cmbMaKT.Items.Clear();
            cmbHoTen.Items.Clear();
            cmbMaKT.Text = cmbHoTen.Text = "";
            cmbMaKT.Enabled = cmbHoTen.Enabled = false;
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        

        private void dgvKhachTro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            click();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            // Kiểm tra khóa chính ko rỗng, ko trùng
            if (dgvKhachTro.Rows.Count - 1 == 0)
            {
                if (txtMaKT.Text != "")
                    command.CommandText = "INSERT INTO KhachTro VALUES ('" + txtMaKT.Text + "',N'" + txtHoTen.Text + "',N'"
                        + cmbGioiTinh.Text + "','" + dtpNgaySinh.Text + "','" + txtCMND.Text + "',N'" + txtNgheNghiep.Text 
                        + "',N'" + txtDiaChi.Text + "','" + txtDienThoai.Text + "',N'" + ckbNguoiDatCoc.Checked + "',N'" 
                        + txtGhiChu.Text + "')";

            }
            else
            {
                for (int i = 0; i < dgvKhachTro.Rows.Count - 1; i++)
                {
                    if (txtMaKT.Text != "")
                    {
                        if (txtMaKT.Text != dgvKhachTro.Rows[i].Cells[0].Value.ToString())
                            command.CommandText = "INSERT INTO KhachTro VALUES ('" + txtMaKT.Text + "',N'" 
                                + txtHoTen.Text + "',N'" + cmbGioiTinh.Text + "','" + dtpNgaySinh.Text
                                + "','" + txtCMND.Text + "',N'" + txtNgheNghiep.Text + "',N'"
                                + txtDiaChi.Text + "','" + txtDienThoai.Text + "',N'" + ckbNguoiDatCoc.Checked
                                + "',N'" + txtGhiChu.Text + "')";
                        else
                        {
                            MessageBox.Show("Khóa chính không được trùng!", "Cảnh báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khóa chính không được để trống!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            command.CommandText = "UPDATE KhachTro SET HoTen = N'" + txtHoTen.Text + "',GioiTinh = N'" 
                + cmbGioiTinh.Text + "', NgaySinh = '" + dtpNgaySinh.Text + "', CMND = '" + txtCMND.Text 
                + "', NgheNghiep = N'" + txtNgheNghiep.Text + "',DiaChi = N'" + txtDiaChi.Text + "',SDT = N'"
                + txtDienThoai.Text + "',NguoiDatCoc = '" + ckbNguoiDatCoc.Checked + "',GhiChu = N'"
                + txtGhiChu.Text + "'WHERE MaKT = '" + txtMaKT.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM KhachTro WHERE MaKT ='" + txtMaKT.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void rdbMaKT_CheckedChanged(object sender, EventArgs e)
        {
            resetRadio();
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name.ToString())
            {
                case "rdbMaKT":
                    khoiTao();
                    cmbMaKT.Enabled = true;
                    for (int i = 0; i < dgvKhachTro.Rows.Count - 1; i++)
                    {
                        cmbMaKT.Items.Add(dgvKhachTro.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case "rdbTenKT":
                    khoiTao();
                    cmbHoTen.Enabled = true;
                    for (int i = 0; i < dgvKhachTro.Rows.Count - 1; i++)
                    {
                        cmbHoTen.Items.Add(dgvKhachTro.Rows[i].Cells[1].Value.ToString());
                    }
                    break;
            }
        }

        
       

        private void cmbMaKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvKhachTro.ClearSelection();
            for (int i = 0; i < dgvKhachTro.Rows.Count - 1; i++)
            {
                if (cmbMaKT.Text.Equals(dgvKhachTro.Rows[i].Cells[0].Value.ToString()))
                {
                    dgvKhachTro.CurrentCell = dgvKhachTro.Rows[i].Cells[0];
                    click();
                    break;
                }
            }

        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvKhachTro.Rows.Count - 1; i++)
            {
                if (cmbHoTen.Text.Equals(dgvKhachTro.Rows[i].Cells[1].Value.ToString()))
                {
                    dgvKhachTro.CurrentCell = dgvKhachTro.Rows[i].Cells[1];
                    click();
                    break;
                }
            }
        }
    }
}
