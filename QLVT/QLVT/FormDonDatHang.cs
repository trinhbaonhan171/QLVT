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
    public partial class FormDonDatHang : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();

        BindingSource bds = null;
        GridControl gc = null;
        string type = "";

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public FormDonDatHang()
        {
            InitializeComponent();
          
        }
        private void BdsDDH_CurrentChanged(object sender, EventArgs e)
        {
            // Lấy giá trị  từ dòng hiện tại của bdsDDH
            DataRowView currentRow = (DataRowView)bdsDDH.Current;
            if (currentRow != null)
            {
                string makho = currentRow["MAKHO"].ToString().Trim();
                string manhacc = currentRow["MANCC"].ToString().Trim();
                string manv = currentRow["MANV"].ToString().Trim();
                // Tìm kiếm MAKHO trong bdsKho
                int index_kho = bdsKho.Find("MAKHO", makho);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbKho
                if (index_kho != -1)
                {
                    cmbKho.SelectedValue = makho;
                }
                // Tìm kiếm MANCC trong bdsNhacc
                int index_nhacc = bdsNhaCC.Find("MANCC", manhacc);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbNhaCC
                if (index_nhacc != -1)
                {

                    cmbNhaCC.SelectedValue = manhacc;
                }
            }
           
        }
        private void BdsCTDDH_CurrentChanged(object sender, EventArgs e)
        {
            
            // Lấy giá trị  từ dòng hiện tại của bdsCTDDH
            DataRowView currentRow = (DataRowView)bdsCTDDH.Current;
            if (currentRow != null)
            {

                string mahh = currentRow["MAHH"].ToString().Trim();
                // Tìm kiếm MAHH trong bdsHangHoa
                int index_mahh = bdsHangHoa.Find("MAHH", mahh);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbNhaCC
                if (index_mahh != -1)
                {
                    cmbHH.SelectedValue = mahh;
                }
            }
        }

        private void dONDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
           
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {

            /*không kiểm tra khóa ngoại nữa*/
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DONDH' table. You can move, or remove it, as needed.
            this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONDHTableAdapter.Fill(this.DS.DONDH);

            this.cT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);

            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            this.hOTENNV_SUBFORMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNV_SUBFORMTableAdapter.Fill(this.DS.HOTENNV_SUBFORM);

            this.kHO_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHO_SLTableAdapter.Fill(this.DS.KHO_SL);

            this.nHACC_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHACC_SLTableAdapter.Fill(this.DS.NHACC_SL);

            this.hANGHOA_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANGHOA_SLTableAdapter.Fill(this.DS.HANGHOA_SL);

            this.hOTENNV_SUBFORMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNV_SUBFORMTableAdapter.Fill(this.DS.HOTENNV_SUBFORM);

            this.kHO_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHO_SLTableAdapter.Fill(this.DS.KHO_SL);
            /*Step 2*/
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            /*kho*/
            cmbKho.DataSource = bdsKho;
            cmbKho.DisplayMember = "TENKHO";
            cmbKho.ValueMember = "MAKHO";
            /*nha cc*/
            cmbNhaCC.DataSource = bdsNhaCC;
            cmbNhaCC.DisplayMember = "TENNCC";
            cmbNhaCC.ValueMember = "MANCC";

            /*hanghoa*/
            cmbHH.DataSource = bdsHangHoa;
            cmbHH.DisplayMember = "TENHH";
            cmbHH.ValueMember = "MAHH";

            bds = bdsDDH;
            gc = gcDDH;
           

            bdsDDH.CurrentChanged += BdsDDH_CurrentChanged;
            bdsCTDDH.CurrentChanged += BdsCTDDH_CurrentChanged;
            BdsDDH_CurrentChanged(sender, e);
            BdsCTDDH_CurrentChanged(sender, e);

            /*Step 3 */
            /*CONG TY chi xem du lieu*/
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

                this.gbDH.Enabled = false;
                this.gbCTDH.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;
                this.btnMENU.Enabled = true;


                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.gbDH.Enabled = false;
                this.gbCTDH.Enabled = false;
            }

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
                this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dONDHTableAdapter.Fill(this.DS.DONDH);

                this.cT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);

                this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

                this.hOTENNV_SUBFORMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENNV_SUBFORMTableAdapter.Fill(this.DS.HOTENNV_SUBFORM);

                this.kHO_SLTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHO_SLTableAdapter.Fill(this.DS.KHO_SL);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();*/
            }
        }

        private void btnCheDoDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsDDH;
            gc = gcDDH;
            //MessageBox.Show("Chế Độ Làm Việc Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtMaDonDatHang.Enabled = true;
            dteNGAY.Enabled = false;

            cmbNhaCC.Enabled = true;
            txtMaNhanVien.Enabled = false;

            cmbKho.Enabled = true;
            /* btnChonKhoHang.Enabled = true;*/

            /*Tat chuc nang cua chi tiet don hang*/
            cmbHH.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            /*Bat cac grid control len*/
            gcDDH.Enabled = true;
            gcCTDDH.Enabled = true;
            gbDH.Enabled = true;
            gbCTDH.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = false;
                this.btnTHOAT.Enabled = true;

                this.gbDH.Enabled = false;
                this.gbCTDH.Enabled = false;

            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsDDH.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = true;

            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bds.Position;
            dangThemMoi = true;


            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Đơn Đặt Hàng")
            {
                this.txtMaDonDatHang.Enabled = true;
                //this.txtMaKho.Text = "";
                this.dteNGAY.DateTime = DateTime.Now;
                this.dteNGAY.Enabled = false;
                this.cmbNhaCC.Enabled = true;
                this.txtMaNhanVien.Text = Program.username;
                this.cmbKho.Enabled = true;

                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsDDH.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsDDH.Current))["NGAYLAP"] = DateTime.Now;
            }

            if (btnMENU.Links[0].Caption == "Chi Tiết Đơn Đặt Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCTDDH.RemoveCurrent();
                    return;
                }



                this.cmbHH.Enabled = true;

                this.txtSoLuong.Enabled = true;
                this.txtSoLuong.EditValue = 1;

                this.txtDonGia.Enabled = true;
                this.txtDonGia.EditValue = 1;
            }


            /*Step 3*/
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }

        private void btnCheDoChiTietDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Chi Tiết Đơn Đặt Hàng";

            /*Step 1*/
            bds = bdsCTDDH;
            gc = gcCTDDH;
            //MessageBox.Show("Chế Độ Làm Việc Chi Tiết Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtMaDonDatHang.Enabled = false;
            dteNGAY.Enabled = false;

            cmbNhaCC.Enabled = false;
            txtMaNhanVien.Enabled = false;

            cmbKho.Enabled = false;

            /*Bat chuc nang cua chi tiet don hang*/
            cmbHH.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;


            /*Bat cac grid control len*/
            gcDDH.Enabled = true;
            gcCTDDH.Enabled = true;
            gbDH.Enabled = true;
            gbCTDH.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnTHEM.Enabled = false;
                this.btnXOA.Enabled = false;
                this.btnGHI.Enabled = false;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = false;
                this.btnTHOAT.Enabled = true;

                this.gbDH.Enabled = false;
                this.gbCTDH.Enabled = false;

            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsCTDDH.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.txtMaDonDatHang.Enabled = false;

            }
        }
        /**************************************************
         * ham nay kiem tra du lieu dau vao
         * true là qua hết
         * false là thiếu một dữ liệu nào đó
         **************************************************/
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Đơn Đặt Hàng")
            {
                if (txtMaDonDatHang.Text.Trim() == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaDonDatHang.Text.Trim().Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaNhanVien.Text.Trim() == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cmbNhaCC.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                
                if (cmbKho.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                if (cmbHH.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtSoLuong.Value < 0 || txtDonGia.Value < 0)
                {
                    MessageBox.Show("Không thể nhỏ hơn 1", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                
            }
            return true;
        }



        /**************************************************
         * tra ve 1 cau truy van de phuc hoi du lieu
         * 
         * ket qua tra ve dua theo che do dang su dung
         **************************************************/
        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;


            /*Dang chinh sua don dat hang*/
            if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVan = "UPDATE DBO.DONDH " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "MANCC = '" + drv["MANCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MADDH = '" + drv["MADDH"].ToString().Trim() + "'";
            }
            /*Dang xoa don dat hang*/
            if (cheDo == "Đơn Đặt Hàng" && dangThemMoi == true)
            {
                drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                DateTime ngay = ((DateTime)drv["NGAYLAP"]);
                cauTruyVan = "INSERT INTO DBO.DONDH(MADDH, NGAYLAP, MANCC, MANV, MAKHO) " +
                    "VALUES('" + drv["MADDH"] + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MANCC"].ToString().Trim() + "', '" +
                    drv["MANV"].ToString().Trim() + "', '" +
                    drv["MAKHO"].ToString().Trim() + "' )";

            }

            /*Dang chinh sua chi tiet don dat hang*/
            if (cheDo == "Chi Tiết Đơn Đặt Hàng" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsCTDDH[bdsCTDDH.Position]);

                cauTruyVan = "UPDATE DBO.CT_DONDH " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString().Trim() + " , " +
                    "DONGIA = " + drv["DONGIA"].ToString().Trim() + " " +
                    "WHERE MADDH = '" + drv["MADDH"].ToString().Trim() + "'" +
                    " AND MAHH = '" + drv["MAHH"].ToString().Trim() + "'";

            }
            return cauTruyVan;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            viTri = bdsDDH.Position;
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
            /*lay maNhanVien & maDonDatHang de phong truong hop them chi tiet don hang thi se co ngay*/
            String maNhanVien = drv["MANV"].ToString().Trim();
            String maDonDatHang = drv["MADDH"].ToString().Trim();

            if (Program.username != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            /*Step 2*/
            String cheDo = (btnMENU.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            String cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine(cauTruyVanHoanTac);


            /*Step 3*/
            String maDonDatHangMoi = txtMaDonDatHang.Text;
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaDonDatHang '" +
                    maDonDatHangMoi + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();



            /*Step 4*/
            //Console.WriteLine(txtMaNhanVien.Text);
            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDDH.Find("MADDH", txtMaDonDatHang.Text.Trim());
            /******************************************************************
             * truong hop them moi don dat hang moi quan tam xem no ton tai hay
             * chua ?
             ******************************************************************/
            if (result == 1 && cheDo == "Đơn Đặt Hàng" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        try
                        {

                            /*TH1: them moi don dat hang*/
                            if (cheDo == "Đơn Đặt Hàng")
                            {
                                if (dangThemMoi == true)
                                {
                                    cauTruyVanHoanTac =
                                   "DELETE FROM DBO.DONDH " +
                                   "WHERE MADDH = '" + maDonDatHang + "'";
                                }
                                ((DataRowView)(bdsDDH.Current))["MANCC"] = cmbNhaCC.SelectedValue.ToString().Trim();
                                ((DataRowView)(bdsDDH.Current))["MAKHO"] = cmbKho.SelectedValue.ToString().Trim();

                            }

                            /*TH2: them moi chi tiet don hang*/
                            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
                            {
                                if (dangThemMoi == true)
                                {
                                    cauTruyVanHoanTac =
                                    "DELETE FROM DBO.CT_DONDH " +
                                    "WHERE MADDH = '" + maDonDatHang + "' " +
                                    "AND MAHH = '" + cmbHH.SelectedValue.ToString().Trim() + "'";
                                }
                                /*Gan tu dong may truong du lieu nay*/
                                ((DataRowView)(bdsCTDDH.Current))["MADDH"] = ((DataRowView)(bdsDDH.Current))["MADDH"];
                                ((DataRowView)(bdsCTDDH.Current))["MAHH"] = cmbHH.SelectedValue.ToString().Trim();
                                ((DataRowView)(bdsCTDDH.Current))["SOLUONG"] =
                                    (int)txtSoLuong.Value;
                                ((DataRowView)(bdsCTDDH.Current))["DONGIA"] =
                                    (float)txtDonGia.Value;

                            }

                            /*TH3: chinh sua don hang */
                            /*TH4: chinh sua chi tiet don hang*/
                            undoList.Push(cauTruyVanHoanTac);

                            this.bdsDDH.EndEdit();
                            this.bdsCTDDH.EndEdit();



                            // Cập nhật lại DataTable trong DataSet
                            this.dONDHTableAdapter.Update(this.DS.DONDH);

                            // Cập nhật lại DataTable trong DataSet
                            this.cT_DONDHTableAdapter.Update(this.DS.CT_DONDH);

                            this.btnTHEM.Enabled = true;
                            this.btnXOA.Enabled = true;
                            this.btnGHI.Enabled = true;

                            this.btnHOANTAC.Enabled = true;
                            this.btnLAMMOI.Enabled = true;
                            this.btnMENU.Enabled = true;
                            this.btnTHOAT.Enabled = true;

                            //this.groupBoxDonDatHang.Enabled = false;

                            /*cập nhật lại trạng thái thêm mới cho chắc*/
                            dangThemMoi = false;
                            MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                            scope.Complete();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            bds.RemoveCurrent();
                            MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }    
                    
                }
            }
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dONDHTableAdapter.Fill(this.DS.DONDH);
                this.cT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);

                this.gcDDH.Enabled = true;
                this.gcCTDDH.Enabled = true;

                bdsDDH.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        /**********************************************************************
         * moi lan nhan btnHOANTAC thi nen nhan them btnLAMMOI de 
         * tranh bi loi khi an btnTHEM lan nua
         * 
         * statement: chua cau y nghia chuc nang ngay truoc khi an btnHOANTAC.
         * Vi du: statement = INSERT | DELETE | CHANGEBRAND
         * 
         * bdsNhanVien.CancelEdit() - phuc hoi lai du lieu neu chua an btnGHI
         * Step 0: trường hợp đã ấn btnTHEM nhưng chưa ấn btnGHI
         * Step 1: kiểm tra undoList có trông hay không ?
         * Step 2: Neu undoList khong trống thì lấy ra khôi phục
         *********************************************************************/
        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Don Dat Hang*/
                if (btnMENU.Links[0].Caption == "Đơn Đặt Hàng")
                {
                    this.txtMaDonDatHang.Enabled = false;

                    //this.dteNGAY.EditValue = DateTime.Now;
                    this.dteNGAY.Enabled = false;
                    this.cmbNhaCC.Enabled = true;
                    //this.txtMaNhanVien.Text = Program.userName;
                    this.cmbKho.Enabled = true;
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (btnMENU.Links[0].Caption == "Chi Tiết Đơn Đặt Hàng")
                {
                    this.cmbHH.Enabled = true;

                    this.txtSoLuong.Enabled = true;
                    this.txtSoLuong.EditValue = 1;

                    this.txtDonGia.Enabled = true;
                    this.txtDonGia.EditValue = 1;
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;


                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bds.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            /*Step 2*/
            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.dONDHTableAdapter.Fill(this.DS.DONDH);
            this.cT_DONDHTableAdapter.Fill(this.DS.CT_DONDH);

            bdsDDH.Position = viTri;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (btnMENU.Links[0].Caption == "Đơn Đặt Hàng") ? "Đơn Đặt Hàng" : "Chi Tiết Đơn Đặt Hàng";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Đơn Đặt Hàng")
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


            }
            if (cheDo == "Chi Tiết Đơn Đặt Hàng")
            {
                DataRowView drv = ((DataRowView)bdsDDH[bdsDDH.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Đơn Đặt Hàng")
                    {
                        bdsDDH.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Đơn Đặt Hàng")
                    {
                        bdsCTDDH.RemoveCurrent();
                    }


                    this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dONDHTableAdapter.Update(this.DS.DONDH);

                    this.cT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_DONDHTableAdapter.Update(this.DS.CT_DONDH);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dONDHTableAdapter.Update(this.DS.DONDH);

                    this.cT_DONDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_DONDHTableAdapter.Update(this.DS.CT_DONDH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
