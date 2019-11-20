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
    public partial class DangNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIQ8G50;Initial Catalog=QLNhaTro;Integrated Security=True");

        public DangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }



        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TaoTK t = new TaoTK();
            t.ShowDialog();
            this.Close();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            Nhap();

        }

        public string SignIn(string a, string b)
        {
            if (a == "" || b == "" || a == "" && b == "")
            {
                return "Hãy nhập đủ tên đăng nhập và mật khẩu!";
            }
            return "Đã nhập thông tin đăng nhập!";
        }



        //public Boolean TestData()
        //{
        //    KiemTra k = new KiemTra();          
        //    if (k.Check(txtbTenDN.Text,txtMK.Text) == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        private void TxtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.Text = txtMK.Text.Trim();
        }

        private void TxtbTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMK.Focus();
        }

        private void TxtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Nhap();
        }

        void Nhap()
        {
            if (SignIn(txtbTenDN.Text, txtMK.Text) == "Hãy nhập đủ tên đăng nhập và mật khẩu!")
            {
                MessageBox.Show("Hãy nhập đủ tên đăng nhập và mật khẩu", "Thông báo");
                txtbTenDN.Focus();
                txtMK.Focus();
            }
            else
            {
                KiemTra k = new KiemTra();
                if (k.Check(txtbTenDN.Text, txtMK.Text) == 1)
                {
                    //this.Hide();
                    //FrmMain f = new FrmMain();
                    //f.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hãy nhập lại!", "Lỗi!");
                }
            }
        }
    }
}
