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
    public partial class FormVatTu : Form
    {
        /* vị trí của con trỏ trên grid view*/
        int viTri = 0;
        Stack undoList = new Stack();
        /********************************************
         * đang thêm mới -> true -> đang dùng btnTHEM
         *              -> false -> có thể là btnGHI( chỉnh sửa) hoặc btnXOA
         *              
         * Mục đích: dùng biến này để phân biệt giữa btnTHEM - thêm mới hoàn toàn
         * và việc chỉnh sửa nhân viên( do mình ko dùng thêm btnXOA )
         * Trạng thái true or false sẽ được sử dụng 
         * trong btnGHI - việc này để phục vụ cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;
        String maChiNhanh = "";


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormVatTu()
        {
            InitializeComponent();
          
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            this.v_DS_MALHHTableAdapter.Fill(this.qLVT_DataSet.V_DS_MALHH);

            dS.EnforceConstraints = false;
            this.hANGHOATableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.dS.HANGHOA);

            //      maChiNhanh = ((DataRowView)dS[0])["MACN"].ToString();

            CB_MaLHH.DataSource = v_DS_MALHHBindingSource;
            CB_MaLHH.DisplayMember = "TENLHH";
            CB_MaLHH.ValueMember = "MALHH";

            /*Step 2*/
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            /*Step 3 */
            /*CONG TY chi xem du lieu*/
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.Btn_Them_VT.Enabled = false;
                this.Btn_XoaVT.Enabled = false;
                this.Btn_Ghi_VT.Enabled = false;

                this.Btn_HoanTac_VT.Enabled = false;
                this.Btn_LamMoi_VT.Enabled = true;
                this.Btn_Thoat_VT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;

                this.Btn_Them_VT.Enabled = true;
                this.Btn_XoaVT.Enabled = true;
                this.Btn_Ghi_VT.Enabled = true;

                this.Btn_HoanTac_VT.Enabled = false;
                this.Btn_LamMoi_VT.Enabled = true;
                this.Btn_Thoat_VT.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txt_mahh.Enabled = false;
            }

        }

        private void Btn_Them_VT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //---------------- button them vat tu---------------------------

            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = Bds_VatTu.Position;
            this.panelNhapLieu.Enabled = true;

            dangThemMoi = true;
            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            Bds_VatTu.AddNew();
            CB_MaLHH.SelectedIndex = 0;


            /*Step 3*/
            Btn_Ghi_VT.Enabled = true;
            Btn_Them_VT.Enabled = false;
            Btn_XoaVT.Enabled = false;
            Btn_HoanTac_VT.Enabled = true;
            Btn_LamMoi_VT.Enabled = false;
            txt_mahh.Enabled = true;

            this.Btn_Thoat_VT.Enabled = false;
        }

        private void Btn_XoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maHangHoa = ((DataRowView)Bds_VatTu[Bds_VatTu.Position])["MAHH"].ToString();

            //Khong cho xoa hang hoa co Don Dat Hang, Phieu Nhap, Phieu Xuat
            //
            // Step 1
            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraHangHoaCoPhieuNhapXuat] '" +
                   maHangHoa + "' " +
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
            int viTriConTro = Bds_VatTu.Position;
            int viTriMaHangHoa = Bds_VatTu.Find("MAHH", txt_mahh.Text);
            if (result == 1 && viTriConTro != viTriMaHangHoa)
            {
                MessageBox.Show("Hàng hóa bạn muốn xóa có trong phiếu nhập/phiếu xuất/đơn đặt hàng nên không thể xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Bds_VatTu.Count == 0)
            {
                Btn_XoaVT.Enabled = true;
            }

            // tinh nang hoan tac
            String maLHH = CB_MaLHH.GetItemText(CB_MaLHH.SelectedItem); ;
            string cauTruyVanHoanTac =
                string.Format("INSERT INTO DBO.HANGHOA( MAHH,TENHH,DVT,MALHH)" +
            "VALUES('{0}','{1}','{2}','{3}')", txt_mahh.Text.Trim(), txt_TenHH.Text.Trim(), txt_DVT.Text.Trim(), maLHH);

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            // STEP 3
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = Bds_VatTu.Position;
                    Bds_VatTu.RemoveCurrent();

                    this.hANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hANGHOATableAdapter.Update(this.dS.HANGHOA);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.Btn_HoanTac_VT.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa hàng hóa này. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.hANGHOATableAdapter.Fill(this.dS.HANGHOA);
                    // tro ve vi tri cua nhan vien dang bi loi
                    Bds_VatTu.Position = viTri;
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
            /*kiem tra txtMAHH*/
            if (txt_mahh.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã hàng hóa", "Thông báo", MessageBoxButtons.OK);
                txt_mahh.Focus();
                return false;
            }
            /*Kiểm tra chuỗi nhập có chứa kí tự đặc biệt không*/
            if (Regex.IsMatch(txt_mahh.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã hàng hóa chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txt_mahh.Focus();
                return false;
            }
            if (txt_mahh.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã hàng hóa không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txt_mahh.Focus();
                return false;
            }

            /*kiem tra txtTenHH*/
            if (txt_TenHH.Text == "")
            {
                MessageBox.Show("Không bỏ trống Tên hàng hóa", "Thông báo", MessageBoxButtons.OK);
                txt_TenHH.Focus();
                return false;
            }

            /*kiem tra txt_DVT */
            if (txt_DVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn vị tính", "Thông báo", MessageBoxButtons.OK);
                txt_DVT.Focus();
                return false;
            }
            if (txt_DVT.Text.Trim().Length > 50)
            {
                MessageBox.Show("Đơn vị tính không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txt_DVT.Focus();
                return false;
            }

            return true;
        }
        private void Btn_Ghi_VT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ////////////////-------------Button Ghi du lieu ---------------///////////////////////////////

            /* Step 0 */
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            /*Step 1*/
            /*Lay du lieu truoc khi chon btnGHI - phuc vu btnHOANTAC - sau khi OK thi da la du lieu moi*/
            String maHangHoa = txt_mahh.Text.Trim();
            DataRowView drv1 = ((DataRowView)Bds_VatTu[Bds_VatTu.Position]);
            String tenHangHoa = drv1["TENHH"].ToString();
            String DVT = drv1["DVT"].ToString();
            String maLHH = drv1["MALHH"].ToString();

            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_KiemTraMaHangHoa] '" +
                   maHangHoa + "' " +
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
            int viTriConTro = Bds_VatTu.Position;
            int viTriMaHangHoa = Bds_VatTu.Find("MAHH", txt_mahh.Text);

            if (result == 1 && viTriConTro != viTriMaHangHoa)
            {
                MessageBox.Show("Mã hàng hóa này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else/*them moi | sua hang hoa*/
            {
                DialogResult ok = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ok == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        Btn_Them_VT.Enabled = true;
                        Btn_XoaVT.Enabled = true;
                        Btn_Ghi_VT.Enabled = true;
                        Btn_HoanTac_VT.Enabled = true;

                        Btn_LamMoi_VT.Enabled = true;
                        Btn_Thoat_VT.Enabled = true;

                        this.txt_mahh.Enabled = false;
                        ((DataRowView)(Bds_VatTu.Current))["MALHH"] = CB_MaLHH.SelectedValue.ToString().Trim();
                        this.Bds_VatTu.EndEdit();
                        this.hANGHOATableAdapter.Update(this.dS.HANGHOA);
                        this.gcVatTu.Enabled = true;

                        /*lưu 1 câu truy vấn để hoàn tác yêu cầu*/
                        String cauTruyVanHoanTac = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.HANGHOA " +
                                "WHERE MAHH = " + "'" + txt_mahh.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {


                            cauTruyVanHoanTac =
                                "UPDATE DBO.HANGHOA " +
                                "SET " +
                                "TENHH = '" + tenHangHoa + "'," +
                                "DVT = '" + DVT + "'," +
                                "MALHH = '" + maLHH + "'," +
                                "WHERE MAHH = '" + maHangHoa + "'";
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

                        Bds_VatTu.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_HoanTac_VT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.Btn_Them_VT.Enabled == false)
            {
                dangThemMoi = false;

                this.txt_mahh.Enabled = false;
                this.Btn_Them_VT.Enabled = true;
                this.Btn_XoaVT.Enabled = true;
                this.Btn_Ghi_VT.Enabled = true;

                this.Btn_HoanTac_VT.Enabled = false;
                this.Btn_LamMoi_VT.Enabled = true;
                this.Btn_Thoat_VT.Enabled = true;

                this.gcVatTu.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                Bds_VatTu.CancelEdit();
                /*xoa dong hien tai*/
                Bds_VatTu.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                Bds_VatTu.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                Btn_HoanTac_VT.Enabled = false;
                return;
            }

            /*Step 2*/
            Bds_VatTu.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            //Console.WriteLine(cauTruyVanHoanTac);

            /*Step 2.2*/

            if (Program.KetNoi() == 0)
            {
                return;
            }
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);


            this.hANGHOATableAdapter.Fill(this.dS.HANGHOA);
        }

        private void Btn_LamMoi_VT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.hANGHOATableAdapter.Fill(this.dS.HANGHOA);
                this.gcVatTu.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void Btn_Thoat_VT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
