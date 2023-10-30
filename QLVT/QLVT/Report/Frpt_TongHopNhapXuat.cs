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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DateTime fromDateTime = (DateTime)dteTuNgay.DateTime;
            string fromDate = fromDateTime.ToString("MM-dd-yyyy");

            DateTime toDateTime = (DateTime)dteToiNgay.DateTime;
            string toDate = toDateTime.ToString("MM-dd-yyyy");

            string chiNhanh = cmbChiNhanh.SelectedValue.ToString().Contains("1") ? "THỦ ĐỨC" : "BẾN THÀNH";



            Xrpt_TongHopNhapXuat rpt = new Xrpt_TongHopNhapXuat(fromDateTime, toDateTime);
            rpt.lblTieuDe.Text = "BẢNG TỔNG HỢP NHẬP XUẤT TỪ " + fromDate + " ĐẾN " + toDate;
            rpt.lblChiNhanh.Text = chiNhanh;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void dteToiNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
