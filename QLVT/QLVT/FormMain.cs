using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLVT.Report;
namespace QLVT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

            pageNhapXuat.Visible = false;
            pageBaoCao.Visible = false;
            btnLapTaiKhoan.Enabled = false;
            FormDangNhap form = new FormDangNhap();
            form.MdiParent = this;
            form.Show();
        }
        /************************************************************
         * CheckExists:
         * Để tránh việc người dùng ấn vào 1 form đến 2 lần chúng ta
         * cần sử dụng hàm này để kiểm tra xem cái form hiện tại đã
         * có trong bộ nhớ chưa
         * Nếu có trả về "f"
         * Nếu không trả về "null"
         ************************************************************/
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        /************************************************************
         *enableButtons: kích hoạt các tab chức năng và nút đăng xuất
         ************************************************************/
        public void enableButtons()
        {

            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;

            pageNhapXuat.Visible = true;
            pageBaoCao.Visible = true;
            btnLapTaiKhoan.Enabled = true;

            if (Program.mGroup == "USER")
            {
                btnLapTaiKhoan.Enabled = false;
            }

            //pageTaiKhoan.Visible = true;


        }
        /************************************************************
         * Dispose: giải phóng các form khỏi bộ nhớ. Ví dụ form nhân viên,...
         * Close: đóng hoàn toàn chương trình lại
         ************************************************************/
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();

            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

            pageNhapXuat.Visible = false;
            pageBaoCao.Visible = false;
            //pageTaiKhoan.Visible = false;

            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                //form.MdiParent = this;
                form.Show();
            }

            Program.formMain.MANV.Text = "MÃ NHÂN VIÊN : ";
            Program.formMain.HOTEN.Text = "HỌ TÊN : ";
            Program.formMain.NHOM.Text = "NHÓM : ";
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Form f = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTaoTaiKhoan form = new FormTaoTaiKhoan();
                //form.MdiParent = this;
                form.Show();
            }*/
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(Frpt_TongHopNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Frpt_TongHopNhapXuat form = new Frpt_TongHopNhapXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnHoatDongNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormHoatDongNhanVien form = new FormHoatDongNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
