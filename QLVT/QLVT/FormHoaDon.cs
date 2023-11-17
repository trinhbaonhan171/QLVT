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
    public partial class FormHoaDon : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        bool dangxoa = false;
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
        public FormHoaDon()
        {
            InitializeComponent();
          
        }
        private void BdsHD_CurrentChanged(object sender, EventArgs e)
        {
            // Lấy giá trị  từ dòng hiện tại của bdsDDH
            DataRowView currentRow = (DataRowView)bdsHoaDon.Current;
            if (currentRow != null)
            {
                string makho = currentRow["MAKHO"].ToString().Trim();
                string makh = currentRow["MAKH"].ToString().Trim();
                // Tìm kiếm MAKHO trong bdsKho
                int index_kho = bdsKho.Find("MAKHO", makho);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbKho
                if (index_kho != -1)
                {
                    cmbKho.SelectedValue = makho;
                }
                int index_kh = bdsKH.Find("MAKH", makh);

                if (index_kh != -1)
                {

                    cmbKhachHang.SelectedValue = makh;
                }
            }

        }
        private void BdsCTHD_CurrentChanged(object sender, EventArgs e)
        {

            // Lấy giá trị  từ dòng hiện tại của bdsCTDDH
            DataRowView currentRow = (DataRowView)bdsCT_HoaDon.Current;
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
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
           
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DONDH' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOADONTableAdapter.Fill(this.DS.HOADON);

            this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);

            this.kHO_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHO_SLTableAdapter.Fill(this.DS.KHO_SL);

            this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

            this.hANGHOA_SLTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANGHOA_SLTableAdapter.Fill(this.DS.HANGHOA_SL);

            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            /*kho*/
            cmbKho.DataSource = bdsKho;
            cmbKho.DisplayMember = "TENKHO";
            cmbKho.ValueMember = "MAKHO";
            /*khach hang*/
            cmbKhachHang.DataSource = bdsKH;
            cmbKhachHang.DisplayMember = "TENKH";
            cmbKhachHang.ValueMember = "MAKH";

            /*hanghoa*/
            cmbHH.DataSource = bdsHangHoa;
            cmbHH.DisplayMember = "TENHH";
            cmbHH.ValueMember = "MAHH";




            bdsHoaDon.CurrentChanged += BdsHD_CurrentChanged;
            bdsCT_HoaDon.CurrentChanged += BdsCTHD_CurrentChanged;
            BdsHD_CurrentChanged(sender, e);
            BdsCTHD_CurrentChanged(sender, e);

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

                this.gbHD.Enabled = false;
                this.gbCTHD.Enabled = false;
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

                this.gbHD.Enabled = false;
                this.gbCTHD.Enabled = false;
            }
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoaDon.EndEdit();
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
                this.hOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOADONTableAdapter.Fill(this.DS.HOADON);

                this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);

                this.kHO_SLTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHO_SLTableAdapter.Fill(this.DS.KHO_SL);
            }
        }

        private void btnCheDoHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Hóa Đơn";

            /*Step 1*/
            bds = bdsHoaDon;
            gc = gcHD;

            /*Step 2*/
            /*Bat chuc nang cua hoa don*/
            txtSoHD.Enabled = true;
            dteNGAY.Enabled = false;

            cmbKho.Enabled = true;
            txtMaNhanVien.Enabled = false;

            cmbKhachHang.Enabled = true;
            gcHD.Enabled = true;
            /* btnChonKhoHang.Enabled = true;*/

            /*Tat chuc nang cua chi tiet hoa don*/
            cmbHH.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            /*Bat cac grid control len*/
            gcHD.Enabled = true;
            gcCTHD.Enabled = true;
            gbHD.Enabled = true;
            gbCTHD.Enabled = true;

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

                this.gbHD.Enabled = false;
                this.gbCTHD.Enabled = false;

            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsHoaDon.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.txtSoHD.Enabled = true;

            }
        }

        private void btnCheDoChiTietHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Chi Tiết Hóa Đơn";

            /*Step 1*/
            bds = bdsCT_HoaDon;
            gc = gcCTHD;
            //MessageBox.Show("Chế Độ Làm Việc Chi Tiết Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtSoHD.Enabled = false;
            dteNGAY.Enabled = false;

            cmbKhachHang.Enabled = false;
            txtMaNhanVien.Enabled = false;

            cmbKho.Enabled = false;

            /*Bat chuc nang cua chi tiet don hang*/
            cmbHH.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;


            /*Bat cac grid control len*/
            gcHD.Enabled = true;
            gcCTHD.Enabled = true;
            gbHD.Enabled = true;
            gbCTHD.Enabled = true;

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

                this.gbHD.Enabled = false;
                this.gbCTHD.Enabled = false;

            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.btnTHEM.Enabled = true;
                bool turnOn = (bdsCT_HoaDon.Count > 0) ? true : false;
                this.btnXOA.Enabled = turnOn;
                this.btnGHI.Enabled = true;

                this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.txtSoHD.Enabled = false;

            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bds.Position;
            dangThemMoi = true;
            cmbHH.Enabled = true;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Hóa Đơn")
            {
                this.txtSoHD.Enabled = true;
                //this.txtMaKho.Text = "";
                this.dteNGAY.DateTime = DateTime.Now;
                this.dteNGAY.Enabled = false;
                this.cmbKhachHang.Enabled = true;
                this.txtMaNhanVien.Text = Program.username;
                this.cmbKho.Enabled = true;

                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsHoaDon.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsHoaDon.Current))["NGAYLAP"] = DateTime.Now;
            }

            if (btnMENU.Links[0].Caption == "Chi Tiết Hóa Đơn")
            {
                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết hóa đơn trên hóa đơn không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCT_HoaDon.RemoveCurrent();
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

        private bool kiemTraDuLieuDauVao(string cheDo)
        {
            if (cheDo == "Hóa Đơn")
            {
                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtSoHD.Text.Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống số hóa đơn !", "Thông báo", MessageBoxButtons.OK);
                    txtSoHD.Focus();
                    return false;
                }

                if (txtSoHD.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Số hóa đơn không thể quá 10 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtSoHD.Focus();
                    return false;
                }

                if (cmbKhachHang.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống khách hàng!", "Thông báo", MessageBoxButtons.OK);
                    cmbKhachHang.Focus();
                    return false;
                }

                

                if (cmbKho.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho!", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

            }

            if (cheDo == "Chi Tiết Hóa Đơn")
            {
                DataRowView drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm chi tiết hóa đơn với hóa đơn do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsCT_HoaDon.RemoveCurrent();
                    return false;
                }

                if (txtSoHD.Text.Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống số hóa đơn !", "Thông báo", MessageBoxButtons.OK);
                    txtSoHD.Focus();
                    return false;
                }

                if (txtSoHD.Text.Length > 10)
                {
                    MessageBox.Show("Số hóa đơn không thể quá 10 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtSoHD.Focus();
                    return false;
                }

                if (cmbHH.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Thiếu mã hàng hóa!", "Thông báo", MessageBoxButtons.OK);
                    cmbHH.Focus();
                    return false;
                }

                if (txtSoLuong.Value < 1)
                {
                    MessageBox.Show("Số lượng hàng hóa không thể bé hơn 1 !", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuong.Focus();
                    return false;
                }

                if (txtDonGia.Value < 1)
                {
                    MessageBox.Show("Đơn giá không thể bé hơn 1 VND !", "Thông báo", MessageBoxButtons.OK);
                    txtDonGia.Focus();
                    return false;
                }
            }

            return true;
        }
        private void capNhatSoLuongVatTu(string maVatTu, int soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'EXPORT','" + maVatTu + "', " + soLuong;


            int n = Program.ExecSqlNonQuery(cauTruyVan);
          
        }
        private string taoCauTruyVanHoanTac(string cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*TH1: dang sua phieu xuat*/
            if (cheDo == "Hóa Đơn" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsHoaDon.Current));
                DateTime ngay = (DateTime)drv["NGAYLAP"];


                cauTruyVan = "UPDATE DBO.HOADON " +
                    "SET " +
                    "NGAYLAP = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "MAKH = '" + drv["MAKH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE SOHD = '" + drv["SOHD"].ToString().Trim() + "' ";
            }

            /*TH4: dang sua chi tiet phieu nhap*/
            if (cheDo == "Chi Tiết Hóa Đơn" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsCT_HoaDon.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuXuat = drv["SOHD"].ToString().Trim();
                String maVatTu = drv["MAHH"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CT_HOADON " +
                    "SET " +
                    "SOLUONG = " + soLuong + " " +
                    "DOGIA = " + donGia + " " +
                    "WHERE SOHD = '" + maPhieuXuat + "' " +
                    "AND MAHH = '" + maVatTu + "' ";
            }

            return cauTruyVan;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            String cheDo = (btnMENU.Links[0].Caption == "Hóa Đơn") ? "Hóa Đơn" : "Chi Tiết Hóa Đơn";

            /*Step 2*/
            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;



            /*Step 3*/
            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);
           


            /*Step 4*/
            String maPhieuXuat = txtSoHD.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraSoHD '" +
                    maPhieuXuat + "' " +
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

            /*Step 5*/
            int viTriConTro = bdsHoaDon.Position;
            int viTriMaPhieuXuat = bdsHoaDon.Find("SOHD", maPhieuXuat);

            if (cheDo == "Chi Tiết Hóa Đơn")
            {
                String mahh_add = cmbHH.SelectedValue.ToString().Trim();
                String kiemtraMahhMaDDH =
                        "DECLARE	@result int " +
                        "EXEC @result = sp_KiemTraMaHangHoaVaMaHoaDon '" + mahh_add + "', " + maPhieuXuat + "; " +
                        "SELECT @result AS 'Value';";
                SqlCommand ktramahhmaddh = new SqlCommand(kiemtraMahhMaDDH, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(kiemtraMahhMaDDH);
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
                int check = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Mã hàng hóa này đã được sử dụng cho hóa đơn này !\n\n", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            /*Dang them moi phieu nhap*/
            if (result == 1 && cheDo == "Hóa Đơn" && viTriMaPhieuXuat != viTriConTro)
            {
                MessageBox.Show("Mã hóa đơn đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtSoHD.Focus();
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
                            /*TH1: them moi phieu nhap*/
                            if (cheDo == "Hóa Đơn")
                            {
                                if (dangThemMoi == true)
                                {
                                    cauTruyVanHoanTac =
                                   "DELETE FROM DBO.HOADON " +
                                   "WHERE SOHD = '" + maPhieuXuat + "'";
                                }
                                ((DataRowView)(bdsHoaDon.Current))["SOHD"] = txtSoHD.Text.ToString().Trim();
                                ((DataRowView)(bdsHoaDon.Current))["MAKH"] = cmbKhachHang.SelectedValue.ToString().Trim();
                                ((DataRowView)(bdsHoaDon.Current))["MAKHO"] = cmbKho.SelectedValue.ToString().Trim();
                            }

                            /*TH2: them moi chi tiet don hang*/
                            if (cheDo == "Chi Tiết Hóa Đơn")
                            {
                                if(dangThemMoi == true)
                                {
                                    cauTruyVanHoanTac =
                                     "DELETE FROM DBO.CT_HOADON " +
                                     "WHERE SOHD = '" + maPhieuXuat + "' " +
                                     "AND MAHH = '" + cmbHH.SelectedValue.ToString().Trim() + "'";
                                    string maVatTu = cmbHH.SelectedValue.ToString().Trim();
                                    int soLuong = (int)txtSoLuong.Value;
                                    string kiemtraslton = "DECLARE @result int; " +
                                              "EXEC @result = sp_KiemtraSLton '" + maVatTu + "', " + soLuong + "; " +
                                              "SELECT @result AS 'Value';";
                                    SqlCommand sqlkiemtra = new SqlCommand(kiemtraslton, Program.conn);
                                    SqlDataReader reader_ktra = Program.ExecSqlDataReader(kiemtraslton);
                                    /*khong co ket qua tra ve thi ket thuc luon*/
                                    if (Program.myReader == null)
                                    {
                                        MessageBox.Show("Kiem tra số lượng tồn không có kết quả trả về !\n\n", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    reader_ktra.Read();
                                    int kq = int.Parse(reader_ktra.GetValue(0).ToString());
                                    reader_ktra.Close();
                                    if (kq == 1)
                                    {
                                        MessageBox.Show("Số lượng tồn không đủ!\n\n", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    capNhatSoLuongVatTu(maVatTu, soLuong);
                                }    
                                ((DataRowView)(bdsCT_HoaDon.Current))["SOHD"] = ((DataRowView)(bdsHoaDon.Current))["SOHD"];
                                ((DataRowView)(bdsCT_HoaDon.Current))["MAHH"] = cmbHH.SelectedValue.ToString().Trim();
                                ((DataRowView)(bdsCT_HoaDon.Current))["SOLUONG"] =
                                    (int)txtSoLuong.Value;
                                ((DataRowView)(bdsCT_HoaDon.Current))["DONGIA"] =
                                    (float)txtDonGia.Value;
                            }


                            undoList.Push(cauTruyVanHoanTac);

                            this.bdsHoaDon.EndEdit();
                            this.bdsCT_HoaDon.EndEdit();
                            this.hOADONTableAdapter.Update(this.DS.HOADON);
                            this.cT_HOADONTableAdapter.Update(this.DS.CT_HOADON);

                            this.txtSoHD.Enabled = false;

                            this.btnTHEM.Enabled = true;
                            this.btnXOA.Enabled = true;
                            this.btnGHI.Enabled = true;

                            this.btnHOANTAC.Enabled = true;
                            this.btnLAMMOI.Enabled = true;
                            this.btnMENU.Enabled = true;
                            this.btnTHOAT.Enabled = true;



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
                this.hOADONTableAdapter.Fill(this.DS.HOADON);
                this.cT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi lam moi \n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Phiếu Nhập*/
                if (btnMENU.Links[0].Caption == "Hóa Đơn")
                {
                    this.txtSoHD.Enabled = false;
                    this.dteNGAY.Enabled = false;
                    this.cmbKhachHang.Enabled = true;

                    this.txtMaNhanVien.Enabled = false;

                    this.cmbKho.Enabled = true;
                }
                /*dang o che do Chi Tiết Phiếu Nhập*/
                if (btnMENU.Links[0].Caption == "Chi Tiết Hóa Đơn")
                {
                    this.txtSoHD.Enabled = false;
                    this.cmbHH.Enabled = true;

                    this.txtSoLuong.Enabled = true;
                    this.txtDonGia.Enabled = true;
                }

                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnGHI.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.gcHD.Enabled = true;
                this.gcCTHD.Enabled = true;

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

            this.hOADONTableAdapter.Fill(this.DS.HOADON);
            this.cT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);

            bdsHoaDon.Position = viTri;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
            string cheDo = (btnMENU.Links[0].Caption == "Hóa Đơn") ? "Hóa Đơn" : "Chi Tiết Hóa Đơn";

            if (cheDo == "Hóa Đơn")
            {
                drv = ((DataRowView)bdsHoaDon[bdsHoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString().Trim();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không xóa hóa đơn không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsCT_HoaDon.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì có chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                DateTime ngay = ((DateTime)drv["NGAYLAP"]);

                cauTruyVanHoanTac = "INSERT INTO DBO.HOADON(SOHD, NGAYLAP, MAKH, MANV, MAKHO) " +
                    "VALUES( '" + drv["SOHD"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MAKH"].ToString() + "', '" +
                    drv["MANV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "')";
            }

            if (cheDo == "Chi Tiết Phiếu Xuất")
            {
                drv = ((DataRowView)bdsCT_HoaDon[bdsCT_HoaDon.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bdsCT_HoaDon[bdsCT_HoaDon.Position]);
                cauTruyVanHoanTac = "INSERT INTO DBO.CT_HOADON(SOHD, MAHH, SOLUONG, DONGIA) " +
                    "VALUES('" + drv["SOHD"].ToString().Trim() + "', '" +
                    drv["MAHH"].ToString().Trim() + "', " +
                    drv["SOLUONG"].ToString().Trim() + ", " +
                    drv["DONGIA"].ToString().Trim() + ")";
            }

            undoList.Push(cauTruyVanHoanTac);
           


            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if (cheDo == "Phiếu Xuất")
                    {
                        bdsHoaDon.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Phiếu Nhập")
                    {
                        bdsCT_HoaDon.RemoveCurrent();
                    }


                    this.hOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOADONTableAdapter.Update(this.DS.HOADON);

                    this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_HOADONTableAdapter.Update(this.DS.CT_HOADON);

                    //bdsPhieuNhap.Position = viTri;
                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.hOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOADONTableAdapter.Update(this.DS.HOADON);

                    this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_HOADONTableAdapter.Update(this.DS.CT_HOADON);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }
    }
}
