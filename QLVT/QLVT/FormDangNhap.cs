using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter1.Fill(this.dS.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tENCNComboBox.SelectedValue != null)
            {
                Program.server_name = tENCNComboBox.SelectedValue.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản or mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            if (Program.KetNoi() == 0) return;

           
            Program.mChiNhanh = tENCNComboBox.SelectedIndex;
            Program.bds_dspm = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();/*doc 1 dong, neu co nhieu dong thi dung while(myReader.Read()==true)*/

            Program.username = Program.myReader.GetString(0);
            if(Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.formMain.MANV.Text = "MÃ NHÂN VIÊN : " + Program.username;
            Program.formMain.HOTEN.Text = "HỌ TÊN : " + Program.mHoTen;
            Program.formMain.NHOM.Text = "NHÓM : " + Program.mGroup;
            this.Visible = false;
            Program.formMain.enableButtons();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
