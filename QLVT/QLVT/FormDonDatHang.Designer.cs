
namespace QLVT
{
    partial class FormDonDatHang
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
            System.Windows.Forms.Label mADDHLabel;
            System.Windows.Forms.Label mANCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsHOTENNV = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.dONDHTableAdapter = new QLVT.DSTableAdapters.DONDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gbCTDH = new System.Windows.Forms.GroupBox();
            this.cmbHH = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbDH = new System.Windows.Forms.GroupBox();
            this.cmbNhaCC = new System.Windows.Forms.ComboBox();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDonDatHang = new DevExpress.XtraEditors.TextEdit();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPTableAdapter = new QLVT.DSTableAdapters.PHIEUNHAPTableAdapter();
            this.bdsHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.kHO_SLTableAdapter = new QLVT.DSTableAdapters.KHO_SLTableAdapter();
            this.bdsNhaCC = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOA_SLTableAdapter = new QLVT.DSTableAdapters.HANGHOA_SLTableAdapter();
            this.nHACC_SLTableAdapter = new QLVT.DSTableAdapters.NHACC_SLTableAdapter();
            this.hOTENNV_SUBFORMTableAdapter = new QLVT.DSTableAdapters.HOTENNV_SUBFORMTableAdapter();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cT_DONDHTableAdapter = new QLVT.DSTableAdapters.CT_DONDHTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            mADDHLabel = new System.Windows.Forms.Label();
            mANCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            mAHHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.gbCTDH.SuspendLayout();
            this.gbDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mADDHLabel
            // 
            mADDHLabel.AutoSize = true;
            mADDHLabel.Location = new System.Drawing.Point(43, 25);
            mADDHLabel.Name = "mADDHLabel";
            mADDHLabel.Size = new System.Drawing.Size(83, 22);
            mADDHLabel.TabIndex = 3;
            mADDHLabel.Text = "Mã DDH";
            // 
            // mANCCLabel
            // 
            mANCCLabel.AutoSize = true;
            mANCCLabel.Location = new System.Drawing.Point(-1, 112);
            mANCCLabel.Name = "mANCCLabel";
            mANCCLabel.Size = new System.Drawing.Size(124, 22);
            mANCCLabel.TabIndex = 4;
            mANCCLabel.Text = "Nhà Cung Cấp";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(25, 162);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(92, 22);
            mANVLabel.TabIndex = 3;
            mANVLabel.Text = "Nhân Viên";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(71, 205);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(43, 22);
            mAKHOLabel.TabIndex = 3;
            mAKHOLabel.Text = "Kho";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Location = new System.Drawing.Point(37, 71);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(86, 22);
            nGAYLAPLabel.TabIndex = 3;
            nGAYLAPLabel.Text = "Ngày Lập";
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(25, 40);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(89, 22);
            mAHHLabel.TabIndex = 3;
            mAHHLabel.Text = "Hàng Hóa";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(28, 99);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(87, 22);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(37, 157);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(78, 22);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn Giá";
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
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnTHOAT,
            this.btnMENU,
            this.btnCheDoDonDatHang,
            this.btnCheDoChiTietDonDatHang});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnXOA
            // 
            this.btnXOA.Caption = "Xóa";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.Image")));
            this.btnXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.LargeImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Hoàn tác";
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.Image")));
            this.btnHOANTAC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHOANTAC.ImageOptions.LargeImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheDoDonDatHang, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietDonDatHang)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoDonDatHang
            // 
            this.btnCheDoDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnCheDoDonDatHang.Id = 8;
            this.btnCheDoDonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.Image")));
            this.btnCheDoDonDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoDonDatHang.Name = "btnCheDoDonDatHang";
            this.btnCheDoDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoDonDatHang_ItemClick);
            // 
            // btnCheDoChiTietDonDatHang
            // 
            this.btnCheDoChiTietDonDatHang.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCheDoChiTietDonDatHang.Id = 9;
            this.btnCheDoChiTietDonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.Image")));
            this.btnCheDoChiTietDonDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoChiTietDonDatHang.Name = "btnCheDoChiTietDonDatHang";
            this.btnCheDoChiTietDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoChiTietDonDatHang_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 5;
            this.btnTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHOAT.ImageOptions.Image")));
            this.btnTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHOAT.ImageOptions.LargeImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1543, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 804);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1543, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 753);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1543, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 753);
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
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 76);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(158, 17);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(420, 30);
            this.cmbChiNhanh.TabIndex = 2;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // bdsHOTENNV
            // 
            this.bdsHOTENNV.DataMember = "HOTENNV_SUBFORM";
            this.bdsHOTENNV.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DONDH";
            this.bdsDDH.DataSource = this.DS;
            // 
            // dONDHTableAdapter
            // 
            this.dONDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = this.dONDHTableAdapter;
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
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.bdsDDH;
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDDH.Location = new System.Drawing.Point(0, 127);
            this.gcDDH.MainView = this.gridView1;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1543, 185);
            this.gcDDH.TabIndex = 6;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH,
            this.colMANCC,
            this.colMANV,
            this.colNGAYLAP,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDDH;
            this.gridView1.Name = "gridView1";
            // 
            // colMADDH
            // 
            this.colMADDH.Caption = "MÃ DDH";
            this.colMADDH.FieldName = "MADDH";
            this.colMADDH.MinWidth = 25;
            this.colMADDH.Name = "colMADDH";
            this.colMADDH.OptionsColumn.AllowEdit = false;
            this.colMADDH.Visible = true;
            this.colMADDH.VisibleIndex = 0;
            this.colMADDH.Width = 94;
            // 
            // colMANCC
            // 
            this.colMANCC.Caption = "MÃ NCC";
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.MinWidth = 25;
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.OptionsColumn.AllowEdit = false;
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 1;
            this.colMANCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            this.colMANV.Width = 94;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.Caption = "NGÀY LẬP";
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.MinWidth = 25;
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.OptionsColumn.AllowEdit = false;
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 3;
            this.colNGAYLAP.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "MÃ KHO";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1543, 11213);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.panelControl2);
            this.gcThongTin.Controls.Add(this.panelControl1);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(3, 26);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(1537, 11184);
            this.gcThongTin.TabIndex = 0;
            this.gcThongTin.Text = "Thông tin";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcCTDDH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(551, 28);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(984, 758);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gbCTDH);
            this.panelControl1.Controls.Add(this.gbDH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(549, 11154);
            this.panelControl1.TabIndex = 0;
            // 
            // gbCTDH
            // 
            this.gbCTDH.Controls.Add(this.cmbHH);
            this.gbCTDH.Controls.Add(this.comboBox2);
            this.gbCTDH.Controls.Add(this.comboBox1);
            this.gbCTDH.Controls.Add(dONGIALabel);
            this.gbCTDH.Controls.Add(this.txtDonGia);
            this.gbCTDH.Controls.Add(mAHHLabel);
            this.gbCTDH.Controls.Add(sOLUONGLabel);
            this.gbCTDH.Controls.Add(this.txtSoLuong);
            this.gbCTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTDH.Location = new System.Drawing.Point(2, 248);
            this.gbCTDH.Name = "gbCTDH";
            this.gbCTDH.Size = new System.Drawing.Size(545, 10904);
            this.gbCTDH.TabIndex = 1;
            this.gbCTDH.TabStop = false;
            this.gbCTDH.Text = "Chi Tiết Đơn Hàng";
            // 
            // cmbHH
            // 
            this.cmbHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.Location = new System.Drawing.Point(166, 37);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(207, 30);
            this.cmbHH.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 1308);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 30);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 1300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 30);
            this.comboBox1.TabIndex = 8;
            // 
            // gbDH
            // 
            this.gbDH.Controls.Add(this.cmbNhaCC);
            this.gbDH.Controls.Add(this.cmbKho);
            this.gbDH.Controls.Add(this.txtMaNhanVien);
            this.gbDH.Controls.Add(nGAYLAPLabel);
            this.gbDH.Controls.Add(mAKHOLabel);
            this.gbDH.Controls.Add(this.dteNGAY);
            this.gbDH.Controls.Add(mANVLabel);
            this.gbDH.Controls.Add(mANCCLabel);
            this.gbDH.Controls.Add(this.txtMaDonDatHang);
            this.gbDH.Controls.Add(mADDHLabel);
            this.gbDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDH.Location = new System.Drawing.Point(2, 2);
            this.gbDH.Name = "gbDH";
            this.gbDH.Size = new System.Drawing.Size(545, 246);
            this.gbDH.TabIndex = 0;
            this.gbDH.TabStop = false;
            this.gbDH.Text = "Đơn Hàng";
            // 
            // cmbNhaCC
            // 
            this.cmbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCC.FormattingEnabled = true;
            this.cmbNhaCC.Location = new System.Drawing.Point(169, 108);
            this.cmbNhaCC.Name = "cmbNhaCC";
            this.cmbNhaCC.Size = new System.Drawing.Size(207, 30);
            this.cmbNhaCC.TabIndex = 10;
            // 
            // cmbKho
            // 
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(169, 205);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(207, 30);
            this.cmbKho.TabIndex = 4;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MANV", true));
            this.txtMaNhanVien.Location = new System.Drawing.Point(169, 159);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(207, 28);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // dteNGAY
            // 
            this.dteNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAYLAP", true));
            this.dteNGAY.EditValue = null;
            this.dteNGAY.Location = new System.Drawing.Point(169, 68);
            this.dteNGAY.MenuManager = this.barManager1;
            this.dteNGAY.Name = "dteNGAY";
            this.dteNGAY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAY.Properties.Appearance.Options.UseFont = true;
            this.dteNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Size = new System.Drawing.Size(207, 28);
            this.dteNGAY.TabIndex = 4;
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MADDH", true));
            this.txtMaDonDatHang.Location = new System.Drawing.Point(169, 22);
            this.txtMaDonDatHang.MenuManager = this.barManager1;
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonDatHang.Properties.Appearance.Options.UseFont = true;
            this.txtMaDonDatHang.Size = new System.Drawing.Size(207, 28);
            this.txtMaDonDatHang.TabIndex = 4;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PHIEUNHAP";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHangHoa
            // 
            this.bdsHangHoa.DataMember = "HANGHOA_SL";
            this.bdsHangHoa.DataSource = this.DS;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "KHO_SL";
            this.bdsKho.DataSource = this.DS;
            // 
            // kHO_SLTableAdapter
            // 
            this.kHO_SLTableAdapter.ClearBeforeFill = true;
            // 
            // bdsNhaCC
            // 
            this.bdsNhaCC.DataMember = "NHACC_SL";
            this.bdsNhaCC.DataSource = this.DS;
            // 
            // hANGHOA_SLTableAdapter
            // 
            this.hANGHOA_SLTableAdapter.ClearBeforeFill = true;
            // 
            // nHACC_SLTableAdapter
            // 
            this.nHACC_SLTableAdapter.ClearBeforeFill = true;
            // 
            // hOTENNV_SUBFORMTableAdapter
            // 
            this.hOTENNV_SUBFORMTableAdapter.ClearBeforeFill = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(166, 148);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(207, 28);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(166, 90);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(207, 28);
            this.txtSoLuong.TabIndex = 5;
            // 
            // cT_DONDHTableAdapter
            // 
            this.cT_DONDHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK__CT_DONDH__MADDH__48CFD27E";
            this.bdsCTDDH.DataSource = this.bdsDDH;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH1,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTDDH;
            this.gridView2.Name = "gridView2";
            // 
            // colMADDH1
            // 
            this.colMADDH1.Caption = "Mã DDH";
            this.colMADDH1.FieldName = "MADDH";
            this.colMADDH1.MinWidth = 25;
            this.colMADDH1.Name = "colMADDH1";
            this.colMADDH1.OptionsColumn.AllowEdit = false;
            this.colMADDH1.Visible = true;
            this.colMADDH1.VisibleIndex = 0;
            this.colMADDH1.Width = 333;
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "MÃ HH";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.MinWidth = 25;
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.OptionsColumn.AllowEdit = false;
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 1;
            this.colMAHH.Width = 333;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "SỐ LƯỢNG";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 191;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "ĐƠN GIÁ";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 478;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.bdsCTDDH;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcCTDDH.Location = new System.Drawing.Point(2, 2);
            this.gcCTDDH.MainView = this.gridView2;
            this.gcCTDDH.MenuManager = this.barManager1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(980, 754);
            this.gcCTDDH.TabIndex = 0;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 824);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDonDatHang";
            this.Text = "FormDonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.gbCTDH.ResumeLayout(false);
            this.gbCTDH.PerformLayout();
            this.gbDH.ResumeLayout(false);
            this.gbDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonDatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsDDH;
        private DS DS;
        private DSTableAdapters.DONDHTableAdapter dONDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox gbCTDH;
        private System.Windows.Forms.GroupBox gbDH;
        private DevExpress.XtraEditors.DateEdit dteNGAY;
        private DevExpress.XtraEditors.TextEdit txtMaDonDatHang;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private System.Windows.Forms.BindingSource bdsHangHoa;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KHO_SLTableAdapter kHO_SLTableAdapter;
        private System.Windows.Forms.BindingSource bdsNhaCC;
        private DSTableAdapters.HANGHOA_SLTableAdapter hANGHOA_SLTableAdapter;
        private DSTableAdapters.NHACC_SLTableAdapter nHACC_SLTableAdapter;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.ComboBox cmbNhaCC;
        private System.Windows.Forms.ComboBox cmbHH;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bdsHOTENNV;
        private DSTableAdapters.HOTENNV_SUBFORMTableAdapter hOTENNV_SUBFORMTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietDonDatHang;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DSTableAdapters.CT_DONDHTableAdapter cT_DONDHTableAdapter;
    }
}