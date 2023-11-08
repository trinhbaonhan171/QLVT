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
        private void btnPreview_Click(object sender, EventArgs e)
        {
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
