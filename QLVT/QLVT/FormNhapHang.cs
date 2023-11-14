using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace QLVT
{
    public partial class FormNhapHang : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        string maChiNhanh = "";
        Stack undoList = new Stack();

        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void BdsPhieuNhap_CurrentChanged(object sender, EventArgs e)
        {
            // Lấy giá trị  từ dòng hiện tại của bdsDDH
            DataRowView currentRow = (DataRowView)bdsPhieuNhap.Current;
            if (currentRow != null)
            {
                string makho = currentRow["MAKHO"].ToString().Trim();
                string maDDH = currentRow["MADDH"].ToString().Trim();

                // Tìm kiếm MAKHO trong bdsKho
                int index_kho = bdsKho.Find("MAKHO", makho);
                int index_maddh = bdsDonDatHang.Find("MADDH", maDDH);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbKho
               /* if (index_kho != -1)
                {
                    cmbKho.SelectedValue = makho;
                }
                if (index_maddh != -1)
                {
                    cmbDonDatHang.SelectedValue = maDDH;
                }*/
            }

        }
        private void BdsCT_PhieuNhap_CurrentChanged(object sender, EventArgs e)
        {
           
            /* gcCTPN.DataSource = bds_CTPhieuNhap;*/

            /*  gcCTPN.Columns["MAHH"].DataPropertyName = "MAHH";
              gcCTPN.Columns["SOLUONG"].DataPropertyName = "SOLUONG";
              gcCTPN.Columns["DONGIA"].DataPropertyName = "DONGIA";*/
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            this.cT_PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_PHIEUNHAPTableAdapter.Fill(this.DS.CT_PHIEUNHAP);

            this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOTableAdapter.Fill(this.DS.KHO);

            this.hANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANGHOATableAdapter.Fill(this.DS.HANGHOA);

            this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONDHTableAdapter.Fill(this.DS.DONDH);
            /*cmb đơn đặt hàng*/
           /* cmbDonDatHang.DataSource = bdsDonDatHang;
            cmbDonDatHang.DisplayMember = "MADDH";
            cmbDonDatHang.ValueMember = "MADDH";*/


            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

           

            bdsPhieuNhap.CurrentChanged += BdsPhieuNhap_CurrentChanged;
            bds_CTPhieuNhap.CurrentChanged += BdsCT_PhieuNhap_CurrentChanged;
            BdsPhieuNhap_CurrentChanged(sender, e);
            BdsCT_PhieuNhap_CurrentChanged(sender, e);

            

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;
                this.btnMENU.Enabled = false;


                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;

                /*this.gbPN_edit.Enabled = true;
                this.gbCTPN.Enabled = true;*/
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;


               /* this.gbPN_edit.Enabled = true;
                this.gbCTPN.Enabled = true;*/
            }

        }

        private void cT_PHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_CTPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

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
                Program.mChiNhanh_cnn = cmbChiNhanh.SelectedIndex;
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
                /*Do du lieu tu dataSet vao grid Control*/
                this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

                this.cT_PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_PHIEUNHAPTableAdapter.Fill(this.DS.CT_PHIEUNHAP);

                this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOTableAdapter.Fill(this.DS.KHO);

                this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dONDHTableAdapter.Fill(this.DS.DONDH);
            }
        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuNhap.Position;
            dangThemMoi = true;

            gcPN.Enabled = true;
            gcCTPN.Enabled = true;
           /* gbPN_edit.Enabled = true;
            gbCTPN.Enabled = true;*/


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsPhieuNhap.AddNew();
            bds_CTPhieuNhap.AddNew();

            int viTriHienTai = bdsPhieuNhap.Position;
          /*  int trangThaiXoa = int.Parse(((DataRowView)(bds[viTriHienTai]))["TRANGTHAIXOA"].ToString());
            string maNhanVien = ((DataRowView)(bds[viTriHienTai]))["MANV"].ToString();*/


            /*Step 2 Kiem tra xem form da co trong bo nho chua*/
            Form f = this.CheckExists(typeof(FormThemPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            FormThemPhieuNhap form = new FormThemPhieuNhap();

            
            form.GetbdsDDH = bdsDonDatHang;
            form.GetbdsHangHoa = bdsHangHoa;
            form.GetbdsKho = bdsKho;
            form.Show();
            /*Step 3*/
            /*đóng gói hàm themPhieuNhap từ formNhapHang đem về formThemPhieuNhap để làm việc*/
            form.branchTransfer = new FormThemPhieuNhap.MyDelegate(themPhieuNhap);

            /*Step 4*/
            this.btnHOANTAC.Enabled = true;

        }
        public void themPhieuNhap(Dictionary<string, string> listData, DataGridView dataCTPN)
        {
            try
            {
                 
                /*string maVatTu = txtMaVatChiTietPhieuNhap.Text.Trim();
                    int soLuong = (int)txtSoLuongChiTietPhieuNhap.Value;

                    capNhatSoLuongVatTu(maVatTu, soLuong);*/

                    /*TH3: chinh sua phieu nhap -> chang co gi co the chinh sua
                     * duoc -> chang can xu ly*/
                    /*TH4: chinh sua chi tiet phieu nhap - > thi chi can may dong lenh duoi la xong*/
                    /* undoList.Push(cauTruyVanHoanTac);
                     Console.WriteLine("cau truy van hoan tac");
                     Console.WriteLine(cauTruyVanHoanTac);*/
                ((DataRowView)(bdsPhieuNhap.Current))["SOPN"] = listData["SOPN"];
                ((DataRowView)(bdsPhieuNhap.Current))["NGAYLAP"] = listData["NGAYLAP"];
                ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = listData["MAKHO"];
                ((DataRowView)(bdsPhieuNhap.Current))["MADDH"] = listData["MADDH"];
                this.bdsPhieuNhap.EndEdit();
                /*this.bds_CTPhieuNhap.EndEdit();*/
                this.pHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);
                /*chi tiet pn*/
                foreach (DataGridViewRow row in dataCTPN.Rows)
                {
                    DataGridViewComboBoxCell comboBoxCell = row.Cells["MAHH"] as DataGridViewComboBoxCell;
                    string mahh = comboBoxCell.Value?.ToString();

                    DataGridViewCell soLuongCell = row.Cells["SOLUONG"];
                    DataGridViewCell donGiaCell = row.Cells["DONGIA"];

                    if(mahh != null && soLuongCell.Value != null && !string.IsNullOrEmpty(soLuongCell.Value.ToString()) && donGiaCell.Value != null && !string.IsNullOrEmpty(donGiaCell.Value.ToString()))
                    {
                        /*DataRowView newCTPhieuNhap = (DataRowView)bds_CTPhieuNhap.AddNew();*/
                        DataRowView row_save = (DataRowView)bds_CTPhieuNhap.AddNew();
                        row_save["MAHH"] = mahh.ToString();
                        row_save["SOPN"] = listData["SOPN"].ToString();
                        row_save["SOLUONG"] = soLuongCell.Value.ToString();
                        row_save["DONGIA"] = donGiaCell.Value.ToString();
                    }    
                    
                }
                this.bds_CTPhieuNhap.EndEdit();
                this.cT_PHIEUNHAPTableAdapter.Update(this.DS.CT_PHIEUNHAP);

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = true;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.gcPN.Enabled = true;
                this.gcCTPN.Enabled = true;

                /*this.txtSoLuongChiTietPhieuNhap.Enabled = false;
                this.txtDonGiaChiTietPhieuNhap.Enabled = false;*/
                /*cập nhật lại trạng thái thêm mới cho chắc*/
               /* dangThemMoi = false;*/
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                bdsPhieuNhap.RemoveCurrent();
                MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
    }
}
