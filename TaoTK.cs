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
    public partial class TaoTK : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIQ8G50;Initial Catalog=QLNhaTro;Integrated Security=True");

        public TaoTK()
        {
            InitializeComponent();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap n = new DangNhap();
            n.ShowDialog();
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Length < 100 && txtUser.Text.Length > 0)
                    errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(txtUser, "Sử dụng 100 kí tự trở xuống cho tên người dùng!");
            }
        }

        private void TaoTK_Load(object sender, EventArgs e)
        {
            //Xoa();
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.Text = txtPass.Text.Trim();
        }

        private void TxtConf_TextChanged(object sender, EventArgs e)
        {
            txtConf.Text = txtConf.Text.Trim();
        }

        private void TxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPass.Focus();
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtConf.Focus();
        }

        private void TxtConf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Nhap();
        }

        void Nhap()
        {
            errorProvider1.Clear();

            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Nhập tên người dùng!");
            }
            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Nhập mật khẩu!");
            }
            if (txtConf.Text == "")
            {
                errorProvider1.SetError(txtConf, "Xác nhận lại mật khẩu!");
            }
            else if (txtPass.Text.Length < 5)
            {
                errorProvider1.SetError(txtPass, "Sử dụng 5 kí tự trở lên cho mật khẩu!");
                txtConf.Clear();
                txtPass.Focus();
            }
            else if (txtPass.Text.Length > 50)
            {
                errorProvider1.SetError(txtPass, "Sử dụng 50 kí tự trở xuống cho mật khẩu!");
            }
            else if (txtPass.Text != txtConf.Text)
            {
                txtConf.Clear();
                txtConf.Focus();
                errorProvider1.SetError(txtConf, "Xác nhận mật khẩu không đúng. Hãy nhập lại!");
            }
            else
            {
                errorProvider1.Clear();
                KiemTra k = new KiemTra();
                if (k.Check(txtUser.Text, txtPass.Text) == 1)
                {
                    MessageBox.Show("Đã tồn tại. Hãy tạo tài khoản khác!");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtConf.Clear();
                    txtUser.Focus();
                }

                else if (k.Check(txtUser.Text, txtPass.Text) == 0)
                {
                    con.Open(); //mở kết nối
                    var cmd = new SqlCommand("INSERT INTO TaoTaiKhoan(TenNguoiDung,MatKhau) VALUES((N'" + txtUser.Text + "'),('" + txtPass.Text + "'))", con); //lấy dữ liệu từ textbox để lưu
                    cmd.ExecuteNonQuery();  //thực thi lệnh
                    con.Close(); //đóng kết nôi  

                    DialogResult r = MessageBox.Show("Đã tạo tài khoản thành công. Hãy đăng nhập vào hệ thống!", "Thông báo", MessageBoxButtons.OK);
                    if (r == DialogResult.OK)
                    {
                        this.Hide();
                        DangNhap n = new DangNhap();
                        n.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
