using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormKho : Form
    {
        /* vị trí của con trỏ trên grid view*/
        int viTri = 0;
        Stack undoList = new Stack();

        /********************************************/
        bool dangThemMoi = false;
        String maChiNhanh = "";

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormKho()
        {
            InitializeComponent();
          
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            /*Step 1*/
            /*không kiểm tra khóa ngoại nữa*/
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.

            dS.EnforceConstraints = false;
            this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.dS.KHO);

            maChiNhanh = ((DataRowView)bds_Kho[0])["MACN"].ToString();


            /*Step 2*/
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            txt_maCN.Enabled = false;
            /*Step 3 */
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.Btn_Them_kho.Enabled = false;
                this.Btn_Xoa_kho.Enabled = false;
                this.Btn_Ghi_kho.Enabled = false;

                this.Btn_HoanTac_kho.Enabled = false;
                this.Btn_LamMoi_kho.Enabled = true;
                this.Btn_Thoat_kho.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.Btn_Them_kho.Enabled = true;
                this.Btn_Xoa_kho.Enabled = true;
                this.Btn_Ghi_kho.Enabled = true;

                this.Btn_HoanTac_kho.Enabled = false;
                this.Btn_LamMoi_kho.Enabled = true;
                this.Btn_Thoat_kho.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txt_maKho.Enabled = false;
            }
        }

        private void Btn_Them_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bds_Kho.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;
            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bds_Kho.AddNew();
            txt_maCN.Text = maChiNhanh;
            txt_maCN.Enabled = false;
            txt_maKho.Enabled = true;
            this.Btn_Them_kho.Enabled = false;
            this.Btn_Xoa_kho.Enabled = false;
            this.Btn_Ghi_kho.Enabled = true;

            this.Btn_HoanTac_kho.Enabled = true;
            this.Btn_LamMoi_kho.Enabled = false;
            this.Btn_Thoat_kho.Enabled = false;

            this.gcKho.Enabled = false;
            this.panelNhapLieu.Enabled = true;
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
            else
            {
                /*Do du lieu tu dataSet vao grid Control*/
                this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOTableAdapter.Fill(this.dS.KHO);

                /*this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);*/
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                maChiNhanh = ((DataRowView)bds_Kho[0])["MACN"].ToString().Trim();
            }
        }

        private void Btn_Xoa_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Step 1
            String MaKho = ((DataRowView)bds_Kho[bds_Kho.Position])["MAKHO"].ToString();

            if (bds_Kho.Count == 0)
            {
                Btn_Xoa_kho.Enabled = false;
            }


            //-------------truong hop kho co phieu nhap, don dat hang----------
            //****************************************************************
            String maKho = txt_maKho.Text.Trim();

            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraKhoCoPhieuNhap_DDH] '" +
                   maKho + "' " +
                   "SELECT 'Value' = @result"; ;
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

            int viTriConTro = bds_Kho.Position;
            int viTriMaKho = bds_Kho.Find("MAKHO", txt_maKho.Text);

            if (result == 1 && viTriConTro != viTriMaKho)
            {
                MessageBox.Show("Kho này đang có phiếu nhập/Đơn đặt hàng. Không thể xóa !", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Phần này phục vụ tính năng hoàn tác
                    * Đưa câu truy vấn hoàn tác vào undoList*/
            string cauTruyVanHoanTac =
                string.Format("INSERT INTO DBO.KHO( MAKHO,TENKHO,MACN)" +
            "VALUES('{0}','{1}','{2}')", txt_maKho.Text.Trim(), txt_TenKho.Text, txt_maCN.Text.Trim());

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);


            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa kho này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds_Kho.Position;
                    bds_Kho.RemoveCurrent();

                    this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOTableAdapter.Update(this.dS.KHO);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.Btn_HoanTac_kho.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa kho. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.kHOTableAdapter.Fill(this.dS.KHO);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds_Kho.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }
        private bool kiemTraDuLieuDauVao()
        {
            /*kiem tra txt_maKho*/
            if (txt_maKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                txt_maKho.Focus();
                return false;
            }
            /*Kiểm tra chuỗi nhập có chứa kí tự đặc biệt không*/
            if (Regex.IsMatch(txt_maKho.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txt_maKho.Focus();
                return false;
            }
            if (txt_maKho.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txt_maKho.Focus();
                return false;
            }

            /*kiem tra txt_tenKho*/
            if (txt_TenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho", "Thông báo", MessageBoxButtons.OK);
                txt_maKho.Focus();
                return false;
            }

            /*kiem tra txt_diaChi*/
            /*
            if (txt_DiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho", "Thông báo", MessageBoxButtons.OK);
                txt_DiaChi.Focus();
                return false;
            }
            */

            return true;
        }
        private void Btn_Ghi_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC - sau khi OK thi da la du lieu moi*/
            String maKho = txt_maKho.Text.Trim();
            DataRowView drv = ((DataRowView)bds_Kho[bds_Kho.Position]);
            String tenKho = drv["TENKHO"].ToString();

            // String diaChi = drv["DIACHI"].ToString();

            String maChiNhanh = drv["MACN"].ToString();

            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraMaKho] '" +
                   maKho + "' " +
                   "SELECT 'Value' = @result"; ;
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

            /*Step 2*/
            int viTriConTro = bds_Kho.Position;
            int viTriMaKho = bds_Kho.Find("MAKHO", txt_maKho.Text);

            if (result == 1 && viTriConTro != viTriMaKho)
            {
                MessageBox.Show("Mã Kho này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else/*them moi | sua kho */
            {
                DialogResult ok = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ok == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        Btn_Them_kho.Enabled = true;
                        Btn_Xoa_kho.Enabled = true;
                        Btn_Ghi_kho.Enabled = true;
                        Btn_HoanTac_kho.Enabled = true;

                        Btn_LamMoi_kho.Enabled = true;
                        Btn_Thoat_kho.Enabled = true;

                        this.txt_maKho.Enabled = false;
                        this.bds_Kho.EndEdit();
                        this.kHOTableAdapter.Update(this.dS.KHO);
                        this.gcKho.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.KHO " +
                                "WHERE MAKHO = '" + txt_maKho.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.KHO " +
                                "SET " +
                                "TENKHO = '" + tenKho + "'" +
                                "WHERE MAKHO = '" + maKho + "'";
                        }
                        Console.WriteLine(cauTruyVanHoanTac);

                        /*Đưa câu truy vấn hoàn tác vào undoList 
                         * để nếu chẳng may người dùng ấn hoàn tác thì quất luôn*/
                        undoList.Push(cauTruyVanHoanTac);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bds_Kho.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_HoanTac_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.Btn_Them_kho.Enabled == false)
            {
                dangThemMoi = false;

                this.txt_maKho.Enabled = false;
                this.Btn_Them_kho.Enabled = true;
                this.Btn_Xoa_kho.Enabled = true;
                this.Btn_Ghi_kho.Enabled = true;

                this.Btn_HoanTac_kho.Enabled = false;
                this.Btn_LamMoi_kho.Enabled = true;
                this.Btn_Thoat_kho.Enabled = true;

                this.gcKho.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bds_Kho.CancelEdit();
                /*xoa dong hien tai*/
                bds_Kho.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bds_Kho.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                Btn_HoanTac_kho.Enabled = false;
                return;
            }

            /*Step 2*/
            bds_Kho.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            //Console.WriteLine(cauTruyVanHoanTac);
            if (Program.KetNoi() == 0)
            {
                return;
            }
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.kHOTableAdapter.Fill(this.dS.KHO);
        }

        private void Btn_LamMoi_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.kHOTableAdapter.Fill(this.dS.KHO);
                this.gcKho.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void Btn_Thoat_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
