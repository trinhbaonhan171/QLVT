using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Report
{

    public partial class XrptChiTietSLTGHangHoaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptChiTietSLTGHangHoaNhapXuat(string role, string type, DateTime FromDateTime, DateTime ToDateTime)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            string fromDate = FromDateTime.ToString("MM-dd-yyyy");
            string toDate = ToDateTime.ToString("MM-dd-yyyy");

            this.sqlDataSource1.Queries[0].Parameters[0].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = toDate;
            this.sqlDataSource1.Fill();

        }
    }
}
