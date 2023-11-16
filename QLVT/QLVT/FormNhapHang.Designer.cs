
namespace QLVT
{
    partial class FormNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDonPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.bdsDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.bds_CTPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gvPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.pHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.PHIEUNHAPTableAdapter();
            this.kHOTableAdapter = new QLVT.DSTableAdapters.KHOTableAdapter();
            this.bdsHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new QLVT.DSTableAdapters.HANGHOATableAdapter();
            this.dONDHTableAdapter = new QLVT.DSTableAdapters.DONDHTableAdapter();
            this.cT_PHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.CT_PHIEUNHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnSua,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnTHOAT,
            this.btnMENU,
            this.btnCheDoDonPhieuNhap,
            this.btnCheDoChiTietPhieuNhap});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMENU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xóa";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.Image")));
            this.btnXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.LargeImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn tác";
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.Image")));
            this.btnHOANTAC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.LargeImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Làm mới";
            this.btnLAMMOI.Id = 4;
            this.btnLAMMOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.Image")));
            this.btnLAMMOI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLAMMOI.ImageOptions.LargeImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Chọn thao tác ";
            this.btnMENU.Id = 6;
            this.btnMENU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMENU.ImageOptions.Image")));
            this.btnMENU.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMENU.ImageOptions.LargeImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheDoDonPhieuNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietPhieuNhap)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoDonPhieuNhap
            // 
            this.btnCheDoDonPhieuNhap.Caption = "Phiếu Nhập";
            this.btnCheDoDonPhieuNhap.Id = 8;
            this.btnCheDoDonPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.Image")));
            this.btnCheDoDonPhieuNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoDonPhieuNhap.Name = "btnCheDoDonPhieuNhap";
            this.btnCheDoDonPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoPhieuNhap_ItemClick);
            // 
            // btnCheDoChiTietPhieuNhap
            // 
            this.btnCheDoChiTietPhieuNhap.Caption = "Chi Tiết Phiếu Nhập";
            this.btnCheDoChiTietPhieuNhap.Id = 9;
            this.btnCheDoChiTietPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.Image")));
            this.btnCheDoChiTietPhieuNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoChiTietPhieuNhap.Name = "btnCheDoChiTietPhieuNhap";
            this.btnCheDoChiTietPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoChiTietPhieuNhap_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 5;
            this.btnTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHOAT.ImageOptions.Image")));
            this.btnTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHOAT.ImageOptions.LargeImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1560, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 652);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1560, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 607);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1560, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 607);
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(158, 17);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(420, 27);
            this.cmbChiNhanh.TabIndex = 2;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // bdsDonDatHang
            // 
            this.bdsDonDatHang.DataMember = "DONDH";
            this.bdsDonDatHang.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "KHO";
            this.bdsKho.DataSource = this.DS;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcThongTin);
            this.groupBox1.Controls.Add(this.gcPN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1560, 7187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.gcCTPN);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThongTin.Location = new System.Drawing.Point(3, 196);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(1554, 10647);
            this.gcThongTin.TabIndex = 1;
            this.gcThongTin.Text = "Chi Tiết Phiếu Nhập";
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bds_CTPhieuNhap;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.Location = new System.Drawing.Point(2, 23);
            this.gcCTPN.MainView = this.gridView2;
            this.gcCTPN.MenuManager = this.barManager1;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(1550, 10622);
            this.gcCTPN.TabIndex = 1;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bds_CTPhieuNhap
            // 
            this.bds_CTPhieuNhap.DataMember = "FK__CT_PHIEUNH__SOPN__4CA06362";
            this.bds_CTPhieuNhap.DataSource = this.bdsPhieuNhap;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PHIEUNHAP";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colSOPN,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTPN;
            this.gridView2.Name = "gridView2";
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã Hàng Hóa";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.MinWidth = 25;
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.OptionsColumn.AllowEdit = false;
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            this.colMAHH.Width = 94;
            // 
            // colSOPN
            // 
            this.colSOPN.Caption = "Số Phiếu Nhập";
            this.colSOPN.FieldName = "SOPN";
            this.colSOPN.MinWidth = 25;
            this.colSOPN.Name = "colSOPN";
            this.colSOPN.OptionsColumn.AllowEdit = false;
            this.colSOPN.Visible = true;
            this.colSOPN.VisibleIndex = 1;
            this.colSOPN.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPhieuNhap;
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPN.Location = new System.Drawing.Point(3, 22);
            this.gcPN.MainView = this.gvPN;
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(1554, 174);
            this.gcPN.TabIndex = 0;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPN});
            // 
            // gvPN
            // 
            this.gvPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOPN,
            this.NGAYLAP,
            this.MANV,
            this.MAKHO,
            this.MADDH});
            this.gvPN.GridControl = this.gcPN;
            this.gvPN.Name = "gvPN";
            // 
            // SOPN
            // 
            this.SOPN.Caption = "Số Phiếu Nhập";
            this.SOPN.FieldName = "SOPN";
            this.SOPN.Name = "SOPN";
            this.SOPN.OptionsColumn.AllowEdit = false;
            this.SOPN.Visible = true;
            this.SOPN.VisibleIndex = 0;
            this.SOPN.Width = 82;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày Lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.OptionsColumn.AllowEdit = false;
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 1;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.OptionsColumn.AllowEdit = false;
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 2;
            // 
            // MAKHO
            // 
            this.MAKHO.Caption = "Mã Kho";
            this.MAKHO.FieldName = "MAKHO";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.OptionsColumn.AllowEdit = false;
            this.MAKHO.Visible = true;
            this.MAKHO.VisibleIndex = 3;
            // 
            // MADDH
            // 
            this.MADDH.Caption = "Mã Đơn Đặt Hàng";
            this.MADDH.FieldName = "MADDH";
            this.MADDH.Name = "MADDH";
            this.MADDH.OptionsColumn.AllowEdit = false;
            this.MADDH.Visible = true;
            this.MADDH.VisibleIndex = 4;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOA_SLTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.HOTENNV_SUBFORMTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHO_SLTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACC_SLTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = this.pHIEUNHAPTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHangHoa
            // 
            this.bdsHangHoa.DataMember = "HANGHOA";
            this.bdsHangHoa.DataSource = this.DS;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // dONDHTableAdapter
            // 
            this.dONDHTableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHIEUNHAPTableAdapter
            // 
            this.cT_PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietPhieuNhap;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPN;
        private DevExpress.XtraGrid.Columns.GridColumn SOPN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn MAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn MADDH;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KHOTableAdapter kHOTableAdapter;
        private System.Windows.Forms.BindingSource bdsHangHoa;
        private DSTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsDonDatHang;
        private DSTableAdapters.DONDHTableAdapter dONDHTableAdapter;
        private System.Windows.Forms.BindingSource bds_CTPhieuNhap;
        private DSTableAdapters.CT_PHIEUNHAPTableAdapter cT_PHIEUNHAPTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}