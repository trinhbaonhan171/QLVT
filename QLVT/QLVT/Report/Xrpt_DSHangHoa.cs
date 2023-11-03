using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Report
{
    public partial class Xrpt_DSHangHoa : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSHangHoa()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
