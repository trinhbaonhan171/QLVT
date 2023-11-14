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
    public partial class FormThemPhieuNhap : Form
    {

        public BindingSource GetbdsDDH { get; set; }
        public BindingSource GetbdsHangHoa { get; set; }
        public BindingSource GetbdsKho { get; set; }

        public FormThemPhieuNhap()
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
        public MyDelegate branchTransfer;

        

        public delegate void MyDelegate(Dictionary<string, string> listData, DataGridView dataCTPN);

        

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = Program.username;
            txtNhanVien.Enabled = false;
            dateNgayLap.DateTime = DateTime.Now;
            dateNgayLap.Enabled = false;

            cmbDonDatHang.DataSource = GetbdsDDH;
            cmbDonDatHang.DisplayMember = "MADDH";
            cmbDonDatHang.ValueMember = "MADDH";

            cmbKho.DataSource = GetbdsKho;
            cmbKho.DisplayMember = "TENKHO";
            cmbKho.ValueMember = "MAKHO";

            cmbDonDatHang.Invoke(new EventHandler(cmbDonDatHang_SelectedIndexChanged), cmbDonDatHang, EventArgs.Empty);
        }

        private void cmbDonDatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonDatHang.SelectedValue == null)
                return;
            // Lấy giá trị đã chọn từ ComboBox
            string maDDH = cmbDonDatHang.SelectedValue.ToString().Trim();

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_LayChiTietCuaMotDonDatHang '" +
                    maDDH + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                DataTable dt = Program.ExecSqlDataTable(cauTruyVan);

                gcCTPN.DataSource = dt;

                gcCTPN.Columns["MAHH"].DataPropertyName = "MAHH";
                gcCTPN.Columns["SOLUONG"].DataPropertyName = "SOLUONG";
                gcCTPN.Columns["DONGIA"].DataPropertyName = "DONGIA";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            foreach (DataGridViewRow row in gcCTPN.Rows)
            {
                // Tạo một ComboBoxCell mới
                DataGridViewComboBoxCell cmbHangHoa = new DataGridViewComboBoxCell();

                // Đổ DataSource vào ComboBoxCell
                cmbHangHoa.DataSource = GetbdsHangHoa;
                cmbHangHoa.DisplayMember = "TENHH";
                cmbHangHoa.ValueMember = "MAHH";

                // Gán ComboBoxCell vào cột MAHH của dòng hiện tại
                row.Cells["MAHH"] = cmbHangHoa;
            }
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            /*Step 4*/
            String maPhieuNhap = txtSoPn.Text.Trim();
            //Console.WriteLine(maPhieuNhap);
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuNhap '" +
                    maPhieuNhap + "' " +
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

            /*Dang them moi phieu nhap*/
            if (result == 1)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtSoPn.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Dictionary<string, string> listData = new Dictionary<string, string>();

                listData["SOPN"] = maPhieuNhap;
                listData["NGAYLAP"] = dateNgayLap.Text.Trim();
                listData["MAKHO"] = cmbKho.SelectedValue.ToString().Trim();
                listData["MADDH"] = cmbDonDatHang.SelectedValue.ToString().Trim();


                branchTransfer(listData, gcCTPN);
            }
        }
        
        private bool kiemTraDuLieuDauVao()
        {
                if (txtSoPn.Text.Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtSoPn.Focus();
                    return false;
                }


                if (cmbKho.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (cmbDonDatHang.SelectedValue.ToString().Trim() == "")
                {
                    MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                foreach (DataGridViewRow row in gcCTPN.Rows)
                {
                    DataGridViewCell maHHCell = row.Cells["MAHH"];
                    DataGridViewCell soLuongCell = row.Cells["SOLUONG"];
                    DataGridViewCell donGiaCell = row.Cells["DONGIA"];

                    if (maHHCell.EditedFormattedValue == null ||
                        soLuongCell.Value == null || string.IsNullOrWhiteSpace(soLuongCell.Value.ToString()) ||
                        donGiaCell.Value == null || string.IsNullOrWhiteSpace(donGiaCell.Value.ToString()))
                    {
                        MessageBox.Show("Chi tiết Phiếu nhập đảm bảo phải có ít nhất 1 hàng hóa !", "Thông báo", MessageBoxButtons.OK);
                        return false;
                    }
                    return true;
                }

            return true;
        }

    }
}
