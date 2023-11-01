using DevExpress.XtraReports.UI;
using QLVT.Report;
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
    public partial class FormHoatDongNhanVien : Form
    {
        string manv;
        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void FormHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);
          

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
            else
            {
                this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            }    
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DateTime fromDateTime = (DateTime)dteTuNgay.DateTime;
            string fromDate = fromDateTime.ToString("MM-dd-yyyy");

            DateTime toDateTime = (DateTime)dteToiNgay.DateTime;
            string toDate = toDateTime.ToString("MM-dd-yyyy");

            string chiNhanh = cmbChiNhanh.SelectedValue.ToString().Contains("1") ? "THỦ ĐỨC" : "BẾN THÀNH";

            manv = cmbHoTen.SelectedValue.ToString();

           

            Xrpt_HoatDongNhanVien rpt = new Xrpt_HoatDongNhanVien(manv,fromDateTime, toDateTime);
            rpt.lblMANV.Text = manv;
            rpt.lblChiNhanh.Text = chiNhanh;

            foreach (var item in bdsHoTenNV)
            {
                DataRowView rowView = (DataRowView)item;
                if(manv == rowView["MANV"].ToString())
                {
                    rpt.lblHOTEN.Text = rowView["HOTEN"].ToString();
                    rpt.lblDIACHI.Text = rowView["DIACHI"].ToString();
                    rpt.lblNGAYSINH.Text = rowView["NGAYSINH"].ToString();
                    rpt.lblPHAI.Text = rowView["PHAI"].ToString();
                    rpt.lblSDT.Text = rowView["SDT"].ToString();
                }    
            }


            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                manv = cmbHoTen.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
