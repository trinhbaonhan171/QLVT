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
using System.Transactions;
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
         


            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

          

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnMENU.Enabled = false;


                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = false;
                this.btnSua.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;
               
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
           


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsPhieuNhap.AddNew();
            bds_CTPhieuNhap.AddNew();

            int viTriHienTai = bdsPhieuNhap.Position;
         

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
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    ((DataRowView)(bdsPhieuNhap.Current))["SOPN"] = listData["SOPN"];
                    ((DataRowView)(bdsPhieuNhap.Current))["NGAYLAP"] = listData["NGAYLAP"];
                    ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.username;
                    ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = listData["MAKHO"];
                    ((DataRowView)(bdsPhieuNhap.Current))["MADDH"] = listData["MADDH"];
                    this.bdsPhieuNhap.EndEdit();
                    this.pHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);
                    /*chi tiet pn*/
                    foreach (DataGridViewRow row in dataCTPN.Rows)
                    {
                        DataGridViewCell mahhCell = row.Cells["MAHH"];

                        DataGridViewCell soLuongCell = row.Cells["SOLUONG"];
                        DataGridViewCell donGiaCell = row.Cells["DONGIA"];

                        if (mahhCell.Value != null && !string.IsNullOrEmpty(mahhCell.Value.ToString()) && soLuongCell.Value != null && !string.IsNullOrEmpty(soLuongCell.Value.ToString()) && donGiaCell.Value != null && !string.IsNullOrEmpty(donGiaCell.Value.ToString()))
                        {
                            string mahh = mahhCell.Value.ToString().Trim();
                            string sopn = listData["SOPN"].ToString().Trim();
                            int soluong = int.Parse(soLuongCell.EditedFormattedValue.ToString().Trim());
                            float dongia = float.Parse(donGiaCell.EditedFormattedValue.ToString().Trim());
                            if (dangThemMoi == true)
                            {
                                DataRowView row_save = (DataRowView)bds_CTPhieuNhap.AddNew();
                                row_save["MAHH"] = mahh;
                                row_save["SOPN"] = sopn;
                                row_save["SOLUONG"] = soluong;
                                row_save["DONGIA"] = dongia;
                                capNhatSoLuongVatTu(mahh, soluong);
                            }
                            else
                            {
                                string cauTruyVan = "EXEC sp_UpdateChiTietPhieuNhap '" + mahh + "', '" + sopn + "', " + soluong + ", " + dongia;

                                int n = Program.ExecSqlNonQuery(cauTruyVan);
                            }
                            
                        }

                    }
                    this.bds_CTPhieuNhap.EndEdit();
                    this.cT_PHIEUNHAPTableAdapter.Update(this.DS.CT_PHIEUNHAP);


                    this.btnTHEM.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnSua.Enabled = true;

                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnMENU.Enabled = true;
                    this.btnTHOAT.Enabled = true;

                    this.gcPN.Enabled = true;
                    this.gcCTPN.Enabled = true;

                    /*cập nhật lại trạng thái thêm mới */
                    dangThemMoi = false;
                    scope.Complete();
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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuNhap.Position;
            
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);

           
            String maNhanVien = drv["MANV"].ToString().Trim();
            if(maNhanVien == "" || maNhanVien == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            if (Program.username != maNhanVien)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (gvPN.FocusedRowHandle >= 0)
            {
                object currentRow = gvPN.GetFocusedRow();

                if (currentRow is DataRowView rowView)
                {
                    string soPN = rowView["SOPN"].ToString().Trim();
                    string ngaylap = rowView["NGAYLAP"].ToString().Trim();
                   

                    string manv = rowView["MANV"].ToString().Trim();
                    string makho = rowView["MAKHO"].ToString().Trim();
                    string maddh = rowView["MADDH"].ToString().Trim();

                    Dictionary<string, string> listDataPNEdit = new Dictionary<string, string>();

                    listDataPNEdit["SOPN"] = soPN;
                    listDataPNEdit["NGAYLAP"] = ngaylap;
                    listDataPNEdit["MANV"] = manv;
                    listDataPNEdit["MAKHO"] = makho;
                    listDataPNEdit["MADDH"] = maddh;


                    Form f = this.CheckExists(typeof(FormThemPhieuNhap));
                    if (f != null)
                    {
                        f.Activate();
                    }
                    FormThemPhieuNhap form = new FormThemPhieuNhap();

                    form.GetbdsDDH = bdsDonDatHang;
                    form.GetbdsHangHoa = bdsHangHoa;
                    form.GetbdsKho = bdsKho;
                    form.GetbdsCTPN = bds_CTPhieuNhap;
                    form.SetDictionaryDataPNEdit(listDataPNEdit);

                    form.Show();
                    /*Step 3*/
                    /*đóng gói hàm themPhieuNhap từ formNhapHang đem về formThemPhieuNhap để làm việc*/
                    form.branchTransfer = new FormThemPhieuNhap.MyDelegate(themPhieuNhap);

                    /*Step 4*/
                    this.btnHOANTAC.Enabled = true;
                }
            }    
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
                this.cT_PHIEUNHAPTableAdapter.Fill(this.DS.CT_PHIEUNHAP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mời dữ liệu\n\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }
        private void capNhatSoLuongVatTu(string maVatTu, int soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'IMPORT','" + maVatTu + "', " + soLuong;


            int n = Program.ExecSqlNonQuery(cauTruyVan);
           
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
            string mahh = "";
            string soluong = "";
            string cheDo = (btnMENU.Links[0].Caption == "Phiếu Nhập") ? "Phiếu Nhập" : "Chi Tiết Phiếu Nhập";



            if (cheDo == "Phiếu Nhập")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bds_CTPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập vì có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUNHAP(SOPN, NGAYLAP, MADDH, MANV, MAKHO) " +
                    "VALUES( '" + drv["SOPN"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MADDH"].ToString().Trim() + "', '" +
                    drv["MANV"].ToString().Trim() + "', '" +
                    drv["MAKHO"].ToString().Trim() + "')";

            }

            if (cheDo == "Chi Tiết Phiếu Nhập")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bds_CTPhieuNhap[bds_CTPhieuNhap.Position]);
                cauTruyVanHoanTac = "INSERT INTO DBO.CTPN(SOPN, MAHH, SOLUONG, DONGIA) " +
                    "VALUES('" + drv["SOPN"].ToString().Trim() + "', '" +
                    drv["MAHH"].ToString().Trim() + "', " +
                    drv["SOLUONG"].ToString().Trim() + ", " +
                    drv["DONGIA"].ToString().Trim() + ")";
                mahh = drv["MAHH"].ToString().Trim();
                soluong = drv["SOLUONG"].ToString().Trim();
            }

            undoList.Push(cauTruyVanHoanTac);
           
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Phiếu Nhập")
                    {
                        bdsPhieuNhap.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Phiếu Nhập")
                    {
                        bds_CTPhieuNhap.RemoveCurrent();
                        string capnhatsl = "EXEC sp_CapNhatSoLuongVatTu 'EXPORT','" + mahh + "', " + soluong;


                        int n = Program.ExecSqlNonQuery(capnhatsl);
                    }


                    this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.pHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);

                    this.cT_PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_PHIEUNHAPTableAdapter.Update(this.DS.CT_PHIEUNHAP);

                    
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa phiếu nhập. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.pHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);

                    this.cT_PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_PHIEUNHAPTableAdapter.Update(this.DS.CT_PHIEUNHAP);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }
       

        private void btnCheDoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Phiếu Nhập";

            /*Step 1*/
            bds = bdsPhieuNhap;
            gc = gcPN;
          
            /*Bat cac grid control len*/
            gcPN.Enabled = true;
            gcCTPN.Enabled = false;


            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnSua.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsPhieuNhap.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnSua.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

            }
        }

        private void btnCheDoChiTietPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Chi Tiết Phiếu Nhập";

            /*Step 1*/
            bds = bds_CTPhieuNhap;
            gc = gcPN;


            /*Bat cac grid control len*/
            gcPN.Enabled = false;
            gcCTPN.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bds_CTPhieuNhap.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnSua.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }
        }
    }
}
