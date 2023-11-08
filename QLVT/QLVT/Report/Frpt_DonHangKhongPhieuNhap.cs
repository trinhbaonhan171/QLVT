﻿using DevExpress.XtraReports.UI;
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
    public partial class Frpt_DonHangKhongPhieuNhap : Form
    {
        public Frpt_DonHangKhongPhieuNhap()
        {
            InitializeComponent();
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
        private void btnPreview_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            string toDay = ngayHienTai.ToString("dd/MM/yyyy");

            Xrpt_DonHangKhongPhieuNhap rpt = new Xrpt_DonHangKhongPhieuNhap();
            rpt.lblNgayTao.Text = toDay;
            rpt.lblNhanVien.Text = Program.mHoTen;
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
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
    }
}
