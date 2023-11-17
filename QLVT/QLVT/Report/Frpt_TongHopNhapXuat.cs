using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Frpt_TongHopNhapXuat : Form
    {
        public Frpt_TongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void Frpt_TongHopNhapXuat_Load(object sender, EventArgs e)
        {
            dteTuNgay.DateTime = DateTime.Now;
            dteToiNgay.DateTime = DateTime.Now;

            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            /*Step 3 */
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
             
            }
            else
                cmbChiNhanh.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue == null)
                return;
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.server_name = cmbChiNhanh.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private bool kiemtradulieu()
        {
            DateTime currentDate = DateTime.Now.Date;

            // Kiểm tra tính hợp lệ của dữ liệu
            DateTime tuNgay = dteTuNgay.DateTime.Date;
            DateTime toiNgay = dteToiNgay.DateTime.Date;
            if (tuNgay > toiNgay)
            {
                // Ngày bắt đầu (tuNgay) lớn hơn ngày kết thúc (toiNgay)
                // Thực hiện xử lý khi dữ liệu không hợp lệ
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tuNgay > currentDate || toiNgay > currentDate)
            {
                // Ngày bắt đầu (tuNgay) hoặc ngày kết thúc (toiNgay) lớn hơn ngày thực tại
                // Thực hiện xử lý khi dữ liệu không hợp lệ
                MessageBox.Show("Ngày không được lớn hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemtradulieu();
            if (ketQua == false) return;
            DateTime ngayHienTai = DateTime.Now;
            string toDay = ngayHienTai.ToString("dd/MM/yyyy");

            DateTime fromDateTime = (DateTime)dteTuNgay.DateTime;
            string fromDate = fromDateTime.ToString("dd-MM-yyyy");

            DateTime toDateTime = (DateTime)dteToiNgay.DateTime;
            string toDate = toDateTime.ToString("dd-MM-yyyy");

            string chiNhanh = cmbChiNhanh.SelectedValue.ToString().Contains("1") ? "THỦ ĐỨC" : "BẾN THÀNH";



            Xrpt_TongHopNhapXuat rpt = new Xrpt_TongHopNhapXuat(fromDateTime, toDateTime);
            rpt.lblTieuDe.Text = "BẢNG TỔNG HỢP NHẬP XUẤT TỪ " + fromDate + " ĐẾN " + toDate;
            rpt.lblChiNhanh.Text = chiNhanh;
            rpt.lblNgayTao.Text = toDay;
            rpt.lblNhanVien.Text = Program.mHoTen;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }
    }
}
