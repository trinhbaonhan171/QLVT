using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /**********************************************
         * conn: biến để kết nối tới cơ sở dữ liệu
         * connstr: connection String , chuỗi kết nối động
         **********************************************/
        public static SqlConnection conn = new SqlConnection();//conn
        public static String connstr = "";//connstr
        public static SqlDataReader myReader;//myReader
        /**********************************************
           * servername: tên server(phân mảnh) sẽ kết nối tới
           * 
           * username: tên username trong database sẽ kết nối.
           * Ví dụ: LT, TT là username trong mục users của database QLVT_DATHANG
           * 
           * loginName & password: tài khoản & mật khẩu dùng để 
           * đăng nhập vào server(phân mảnh)
           ***********************************************/
        public static string server_name = "";//servername
        public static String serverNameLeft = ""; // chứa phân mảnh còn lại
        public static String username = "";//username

        public static String mlogin = "";//mlogin
        public static String password = "";//password
        /**********************************************
         *database: cơ sở dữ liệu mà ta muốn làm việc
         *
         *remoteLogin & currentLogin: Dùng 2 biến này bởi
         *đi từ server hiện tại sang server 2 => remoteLogin
         *đi từ server 2 về lại server hiện tại => currentLogin
         * 
         *Note: currentLogin & currentPassword chứa loginName & loginPassword 
         *khi từ phân mảnh khác về phân mảnh hiện tại
         *
         *Ví dụ: LT là loginName của server 1 thì qua server 2 dùng HTKN.
         *Quay về server 1 thì dùng mloginDN
         ***********************************************/
        public static String database = "QLVT";

        public static String remoteLogin = "HTKN";//remotelogin
        public static String remotePassword = "123";//remotepassword

        public static String mloginDN = "";//mloginDN
        public static String passwordDN = "";//passwordDN
        public static String mGroup = "";//mGroup
        public static String mHoTen = "";//mHoTen
        public static int mChiNhanh = 0;//mChiNhanh
        public static int mChiNhanh_cnn = 0; // chi nhánh để so sánh khi thực hiện action chuyển chi nhánh
        /*bidSou: BindingSource -> liên kết dữ liệu từ bảng dữ liệu vào chương trình*/
        public static BindingSource bds_dspm = new BindingSource();//bds_dspm


        /*các form của toàn dữ án cũng được coi như 1 một biến toàn cục*/
        public static FormDangNhap formDangNhap;
        public static FormMain formMain;
        /*****************************************************
         * mở kết nối tới server 
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
         *****************************************************/
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.server_name + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }
        /**********************************************
         *  ExecSqlDataReader thực hiện câu lệnh mà dữ liệu trả về chỉ dùng
         *  để xem & không thao tác với nó.
         *  Nhanh
         *  ko cho di ngc
         *  Ví dụ: SELECT * FROM view_DanhSachPhanManh
         **********************************************/
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /**********************************************
         * ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về có thể
         * xem - thêm - xóa - sửa tùy ý
         * 
         * Ví dụ: SELECT * FROM dbo.NHANVIEN
         **********************************************/
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        /**********************************************
         * Cập nhật trên một stored procedure và không trả về giá trị
         **********************************************/
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
