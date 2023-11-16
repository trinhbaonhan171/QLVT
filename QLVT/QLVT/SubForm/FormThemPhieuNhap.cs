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
        public BindingSource GetbdsCTPN { get; set; }

        bool flag = false;
        bool edit = false;
        string makho = "";
        string maddh = "";
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

            if(flag == true)
            {
                int index_kho = GetbdsKho.Find("MAKHO", makho);
                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbKho
                if (index_kho != -1)
                {
                    cmbKho.SelectedValue = makho;
                }
                setcmb(maddh);
            }

            cmbDonDatHang.Invoke(new EventHandler(cmbDonDatHang_SelectionChangeCommitted), cmbDonDatHang, EventArgs.Empty);
            
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;
            String maPhieuNhap = txtSoPn.Text.Trim();
            if (edit == false)
            {
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
                    if(soLuongCell.Value != null && !string.IsNullOrWhiteSpace(soLuongCell.Value.ToString()))
                    {
                        int soluong = int.Parse(soLuongCell.Value.ToString().Trim());
                        if(soluong < 0)
                        {
                            MessageBox.Show("Số lượng hàng hóa không thể nhỏ hơn 0 !", "Thông báo", MessageBoxButtons.OK);
                            return false;
                        }    
                    }
                    if (donGiaCell.Value != null && !string.IsNullOrWhiteSpace(donGiaCell.Value.ToString()))
                    {
                        int dongia = int.Parse(donGiaCell.Value.ToString().Trim());
                        if (dongia < 1)
                        {
                            MessageBox.Show("Đơn giá không thể nhỏ hơn 1 !", "Thông báo", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }

            return true;
        }

        public Dictionary<string, string> ListDataPNEdit { get; set; }
        public void SetDictionaryDataPNEdit(Dictionary<string, string> dictionaryData)
        {
            DateTime ngaylap;
            ngaylap = DateTime.Parse(dictionaryData["NGAYLAP"]);
            txtSoPn.Text = dictionaryData["SOPN"];
            txtSoPn.Enabled = false;
            dateNgayLap.DateTime = ngaylap;
            dateNgayLap.Enabled = false;
            txtNhanVien.Text = dictionaryData["MANV"];
            txtNhanVien.Enabled = false;
            cmbDonDatHang.Enabled = false;
            makho = dictionaryData["MAKHO"];
            maddh = dictionaryData["MADDH"];


            gcCTPN.Rows.Clear();
            // Gán dữ liệu từ BindingSource vào DataGridView
            foreach (DataRowView rowView in GetbdsCTPN)
            {
                int rowIndex = gcCTPN.Rows.Add();

                // Gán giá trị từ DataTable vào các cột tương ứng trong DataGridView
                gcCTPN.Rows[rowIndex].Cells["MAHH"].Value = rowView["MAHH"];
                gcCTPN.Rows[rowIndex].Cells["SOLUONG"].Value = rowView["SOLUONG"];
                gcCTPN.Rows[rowIndex].Cells["DONGIA"].Value = rowView["DONGIA"];
            }
            edit = true;
            flag = true;
            gcCTPN.KeyDown += gcCTPN_KeyDown;
        }
        private void setcmb(string maddh)
        {
            int index_maddh = GetbdsDDH.Find("MADDH", maddh);
            if (index_maddh != -1)
            {
                cmbDonDatHang.SelectedValue = maddh;
            }

        }
        private void gcCTPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true; // Ngăn xóa dữ liệu
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void cmbDonDatHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDonDatHang.SelectedValue == null)
                return;

            // Lấy giá trị đã chọn từ ComboBox
            string maDDH = cmbDonDatHang.SelectedValue.ToString().Trim();
            if (gcCTPN.ColumnCount > 0)
            {
                // Truy cập vào cột
                gcCTPN.Columns[0].ReadOnly = true;
            }
            /* gcCTPN.Columns[0].ReadOnly = true;*/
            if (edit == false)
            {
                String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = sp_LayChiTietCuaMotDonDatHang '" +
                   maDDH + "' " +
                   "SELECT 'Value' = @result";
                SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
                try
                {

                    DataTable dt = Program.ExecSqlDataTable(cauTruyVan);
                    gcCTPN.Rows.Clear();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            // Tạo một dòng mới trong DataGridView
                            int rowIndex = gcCTPN.Rows.Add();

                            // Gán giá trị từ DataTable vào các cột tương ứng trong DataGridView
                            gcCTPN.Rows[rowIndex].Cells["MAHH"].Value = row["MAHH"];
                            gcCTPN.Rows[rowIndex].Cells["SOLUONG"].Value = row["SOLUONG"];
                            gcCTPN.Rows[rowIndex].Cells["DONGIA"].Value = row["DONGIA"];
                        }
                        /*gcCTPN.DataSource = dt;*/

                        gcCTPN.Columns["MAHH"].DataPropertyName = "MAHH";
                        gcCTPN.Columns["SOLUONG"].DataPropertyName = "SOLUONG";
                        gcCTPN.Columns["DONGIA"].DataPropertyName = "DONGIA";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
            }


            gcCTPN.AllowUserToAddRows = false;
        }
    }
}
