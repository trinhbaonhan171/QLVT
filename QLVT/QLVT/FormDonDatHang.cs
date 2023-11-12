using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace QLVT
{
    public partial class FormDonDatHang : Form
    {
        BindingSource bds = null;
        
        GridControl gc = null;
        string type = "";
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
                string makho = currentRow["MAKHO"].ToString();
                string manhacc = currentRow["MANCC"].ToString();
                string manv = currentRow["MANV"].ToString();
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

                string mahh = currentRow["MAHH"].ToString();
                // Tìm kiếm MAHH trong bdsHangHoa
                int index_mahh = bdsHangHoa.Find("MAHH", mahh);

                // Nếu tìm thấy, chọn giá trị tương ứng trong cmbNhaCC
                if (index_mahh != -1)
                {
                    cmbHH.SelectedValue = mahh;
                }
            }
        }

        private void bdsDDH_load()
        {
            // Lấy giá trị  từ dòng hiện tại của bdsDDH
            DataRowView currentRow = (DataRowView)bdsDDH.Current;
            if (currentRow != null)
            {
                string makho = currentRow["MAKHO"].ToString();
                string manhacc = currentRow["MANCC"].ToString();
                string manv = currentRow["MANV"].ToString();
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
        private void bdsCTDDH_load()
        {
            // Lấy giá trị  từ dòng hiện tại của bdsCTDDH
            DataRowView currentRow = (DataRowView)bdsCTDDH.Current;
            if (currentRow != null)
            {

                string mahh = currentRow["MAHH"].ToString();
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
            this.bdsDDH_load();
            this.bdsCTDDH_load();

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
    }
}
