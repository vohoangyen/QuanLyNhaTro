using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    
    public partial class FrmMain : Form
    {
        

        public FrmMain()
        {
            InitializeComponent();

        }

        
        // click nhieu lan chi hien thi form 1 lan
        private bool CheckExistForm(String name)
        {
            bool check = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }

            return check;
        }


        private void ActiveChildForm(String name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void tSBXemDSKT_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("XemDanhSachKhachTro"))
            {
                XemDanhSachKhachTro frm = new XemDanhSachKhachTro();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("XemDanhSachKhachTro");
            }
        }

        private void tSBTimKiemThemSuaXoa_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QuanLyKhachTro"))
            {
                QuanLyKhachTro frm = new QuanLyKhachTro();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("QuanLyKhachTro");
            }
        }

        private void tSBTraCuu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("TraCuuPhong"))
            {
                TraCuuPhong frm = new TraCuuPhong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("TraCuuPhong");
            }
        }

        private void tSBThuePhong_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ThuePhong"))
            {
                ThuePhong frm = new ThuePhong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("ThuePhong");
            }
        }

        private void tSBTraPhong_Click(object sender, EventArgs e)
        {

            if (!CheckExistForm("TraPhong"))
            {
                TraPhong frm = new TraPhong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("TraPhong");
            }
        }

        private void tSBLapHoaDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("LapHoaDon"))
            {
                LapHoaDon frm = new LapHoaDon();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("LapHoaDon");
            }
        }

        private void tSBThemPhong_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ThemPhong"))
            {
                ThemPhong frm = new ThemPhong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("ThemPhong");
            }
        }

        private void tSBXemHoaDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("InHoaDon"))
            {
                XemHoaDon frm = new XemHoaDon();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("InHoaDon");
            }
        }

        private void tSBTKDoanhThu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ThongKeDoanhThu"))
            {
                ThongKeDoanhThu frm = new ThongKeDoanhThu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("ThongKeDoanhThu");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("DangNhap"))
            {
                DangNhap frm = new DangNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("DangNhap");
            }
        }
    }
}
