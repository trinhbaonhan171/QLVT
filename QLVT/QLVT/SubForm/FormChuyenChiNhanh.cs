using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLVT
{
    public partial class FormChuyenChiNhanh : Form
    {
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            BindingSource bds_chuyenChiNhanh = new BindingSource();
            bds_chuyenChiNhanh.DataSource = Program.bds_dspm.DataSource;
            bds_chuyenChiNhanh.DataMember = Program.bds_dspm.DataMember;


            cmbChuyenChiNhanh.DataSource = bds_chuyenChiNhanh;
            /*sao chep bingding source tu form dang nhap*/
            cmbChuyenChiNhanh.DisplayMember = "TENCN";
            cmbChuyenChiNhanh.ValueMember = "TENSERVER";
            cmbChuyenChiNhanh.SelectedIndex = Program.mChiNhanh;
            if(Program.mChiNhanh_cnn != Program.mChiNhanh)
            {
                cmbChuyenChiNhanh.SelectedIndex = Program.mChiNhanh_cnn;
            }    
            for (int i = 0; i < cmbChuyenChiNhanh.Items.Count; i++)
            {
                if (i == cmbChuyenChiNhanh.SelectedIndex)
                {
                    // Đặt mặc định hiển thị của ComboBox thành giá trị còn lại
                    cmbChuyenChiNhanh.SelectedIndex = 1 - i;
                    break; 
                }
            }
            cmbChuyenChiNhanh.Enabled = false;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate branchTransfer;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbChuyenChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbChuyenChiNhanh.SelectedValue.ToString());
            }
            this.Dispose();
        }
    }
}
