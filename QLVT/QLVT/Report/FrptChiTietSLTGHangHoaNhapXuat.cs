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

namespace QLVT.Report
{
    public partial class FrptChiTietSLTGHangHoaNhapXuat : Form
    {
        public FrptChiTietSLTGHangHoaNhapXuat()
        {
            InitializeComponent();
            dteTuNgay.DateTime = DateTime.Now;
            dteToiNgay.DateTime = DateTime.Now;
            // Đặt giá trị cho ComboBox
            cmbLoaiPhieu.Items.Add("NHAP");
            cmbLoaiPhieu.Items.Add("XUAT");
            cmbLoaiPhieu.SelectedIndex = 0;
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
            string type = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

            string role = Program.mGroup;

            XrptChiTietSLTGHangHoaNhapXuat rpt = new XrptChiTietSLTGHangHoaNhapXuat(role, type, fromDateTime, toDateTime);

            rpt.lblTieuDe.Text = " BẢNG KÊ CHI TIẾT SỐ LƯỢNG  - TRỊ GIÁ HÀNG " + type + " THEO TỪNG THÁNG TỪ NGÀY " + fromDate + " ĐẾN NGÀY " + toDate;
            rpt.lblNgayTao.Text = toDay;
            rpt.lblNhanVien.Text = Program.mHoTen;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }
    }
}
