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
            DateTime fromDateTime = (DateTime)dteTuNgay.DateTime;
            string fromDate = fromDateTime.ToString("MM-dd-yyyy");

            DateTime toDateTime = (DateTime)dteToiNgay.DateTime;
            string toDate = toDateTime.ToString("MM-dd-yyyy");
            string type = (cmbLoaiPhieu.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

            string role = Program.mGroup;

            XrptChiTietSLTGHangHoaNhapXuat rpt = new XrptChiTietSLTGHangHoaNhapXuat(role, type, fromDateTime, toDateTime);

            rpt.lblTieuDe.Text = " BẢNG KÊ CHI TIẾT SỐ LƯỢNG  - TRỊ GIÁ HÀNG " + type + " THEO TỪNG THÁNG TỪ NGÀY " + fromDate + " ĐẾN NGÀY " + toDate;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }
    }
}
