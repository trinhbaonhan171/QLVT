using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormTaoTaiKhoan : Form
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void hOTENNV_SUBFORMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoTenNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            this.hOTENNV_SUBFORMTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.hOTENNV_SUBFORMTableAdapter.Fill(this.dS.HOTENNV_SUBFORM);
            rdChiNhanh.Enabled = true;
            rdUser.Enabled = true;
            if (Program.mGroup == "CONGTY")
            {
                vaiTro = "CONGTY";
                rdChiNhanh.Enabled = false;
                rdUser.Enabled = false;
            }
            
            cmbNhanVien.DataSource = bdsHoTenNV;
            cmbNhanVien.DisplayMember = "HOTEN";
            cmbNhanVien.ValueMember = "MANV";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (cmbNhanVien.SelectedValue.ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(vaiTro != "CONGTY")
            {
                bool radioButton1Checked = rdChiNhanh.Checked;
                bool radioButton2Checked = rdUser.Checked;

                if (!radioButton1Checked && !radioButton2Checked)
                {
                    MessageBox.Show("Bạn phải chọn vai trò của nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }    

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            DataRowView selectedRow = (DataRowView)cmbNhanVien.SelectedItem;

            string hoten = selectedRow["HOTEN"].ToString().Trim();
            taiKhoan = hoten.Replace(" ", "");
            matKhau = txtMatKhau.Text;
            maNhanVien = cmbNhanVien.SelectedValue.ToString().Trim();
            if (vaiTro != "CONGTY")
            {
                vaiTro = (rdChiNhanh.Checked == true) ? "CHINHANH" : "USER";
            }
            

           
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + taiKhoan + "' , '" + matKhau + "', '"
                    + maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }
       
    }
}
