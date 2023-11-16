
namespace QLVT
{
    partial class FormHoaDon
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mADDHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietHoaDon = new DevExpress.XtraBars.BarButtonItem();
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
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCT_HoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.bdsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.gcCTHD = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gbCTHD = new System.Windows.Forms.GroupBox();
            this.cmbHH = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbHD = new System.Windows.Forms.GroupBox();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dteNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.gcHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hOADONTableAdapter = new QLVT.DSTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cT_HOADONTableAdapter = new QLVT.DSTableAdapters.CT_HOADONTableAdapter();
            this.hOADONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hOADONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new QLVT.DSTableAdapters.KHACHHANGTableAdapter();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.kHO_SLTableAdapter = new QLVT.DSTableAdapters.KHO_SLTableAdapter();
            this.bdsHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOA_SLTableAdapter = new QLVT.DSTableAdapters.HANGHOA_SLTableAdapter();
            dONGIALabel = new System.Windows.Forms.Label();
            mAHHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mADDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.gbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.gbHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).BeginInit();
            this.hOADONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(37, 157);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(60, 19);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn Giá";
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(25, 40);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(71, 19);
            mAHHLabel.TabIndex = 3;
            mAHHLabel.Text = "Hàng Hóa";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(28, 99);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(70, 19);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 19);
            label2.TabIndex = 5;
            label2.Text = "Khách Hàng";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Location = new System.Drawing.Point(28, 73);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(70, 19);
            nGAYLAPLabel.TabIndex = 3;
            nGAYLAPLabel.Text = "Ngày Lập";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(60, 157);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(36, 19);
            mAKHOLabel.TabIndex = 3;
            mAKHOLabel.Text = "Kho";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(24, 113);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(73, 19);
            mANVLabel.TabIndex = 3;
            mANVLabel.Text = "Nhân Viên";
            // 
            // mADDHLabel
            // 
            mADDHLabel.AutoSize = true;
            mADDHLabel.Location = new System.Drawing.Point(11, 28);
            mADDHLabel.Name = "mADDHLabel";
            mADDHLabel.Size = new System.Drawing.Size(86, 19);
            mADDHLabel.TabIndex = 3;
            mADDHLabel.Text = "Số Hóa Đơn";
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
            this.btnCheDoHoaDon,
            this.btnCheDoChiTietHoaDon});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheDoHoaDon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietHoaDon)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoHoaDon
            // 
            this.btnCheDoHoaDon.Caption = "Hóa Đơn";
            this.btnCheDoHoaDon.Id = 8;
            this.btnCheDoHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoHoaDon.ImageOptions.Image")));
            this.btnCheDoHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoHoaDon.ImageOptions.LargeImage")));
            this.btnCheDoHoaDon.Name = "btnCheDoHoaDon";
            this.btnCheDoHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoHoaDon_ItemClick);
            // 
            // btnCheDoChiTietHoaDon
            // 
            this.btnCheDoChiTietHoaDon.Caption = "Chi Tiết Hóa Đơn";
            this.btnCheDoChiTietHoaDon.Id = 9;
            this.btnCheDoChiTietHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietHoaDon.ImageOptions.Image")));
            this.btnCheDoChiTietHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietHoaDon.ImageOptions.LargeImage")));
            this.btnCheDoChiTietHoaDon.Name = "btnCheDoChiTietHoaDon";
            this.btnCheDoChiTietHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheDoChiTietHoaDon_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1560, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 804);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1560, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 759);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1560, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 759);
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
            this.panel1.Size = new System.Drawing.Size(1560, 80);
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
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HoaDon, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(163, 150);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(210, 26);
            this.txtDonGia.TabIndex = 4;
            // 
            // bdsCT_HoaDon
            // 
            this.bdsCT_HoaDon.DataMember = "FK__CT_HOADON__SOHD__5070F446";
            this.bdsCT_HoaDon.DataSource = this.bdsHoaDon;
            // 
            // bdsHoaDon
            // 
            this.bdsHoaDon.DataMember = "HOADON";
            this.bdsHoaDon.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcThongTin);
            this.groupBox1.Controls.Add(this.gcHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1560, 17548);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.gcCTHD);
            this.gcThongTin.Controls.Add(this.panelControl1);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(3, 171);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(1554, 17374);
            this.gcThongTin.TabIndex = 2;
            this.gcThongTin.Text = "Thông tin";
            // 
            // gcCTHD
            // 
            this.gcCTHD.DataSource = this.bdsCT_HoaDon;
            this.gcCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTHD.Location = new System.Drawing.Point(551, 23);
            this.gcCTHD.MainView = this.gridView2;
            this.gcCTHD.MenuManager = this.barManager1;
            this.gcCTHD.Name = "gcCTHD";
            this.gcCTHD.Size = new System.Drawing.Size(1001, 17349);
            this.gcCTHD.TabIndex = 1;
            this.gcCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOHD,
            this.colMAHH,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTHD;
            this.gridView2.Name = "gridView2";
            // 
            // colSOHD
            // 
            this.colSOHD.Caption = "Số Hóa Đơn";
            this.colSOHD.FieldName = "SOHD";
            this.colSOHD.Name = "colSOHD";
            this.colSOHD.OptionsColumn.AllowEdit = false;
            this.colSOHD.Visible = true;
            this.colSOHD.VisibleIndex = 0;
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã Hàng Hóa";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.OptionsColumn.AllowEdit = false;
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gbCTHD);
            this.panelControl1.Controls.Add(this.gbHD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(549, 17349);
            this.panelControl1.TabIndex = 0;
            // 
            // gbCTHD
            // 
            this.gbCTHD.Controls.Add(this.cmbHH);
            this.gbCTHD.Controls.Add(this.txtDonGia);
            this.gbCTHD.Controls.Add(this.comboBox2);
            this.gbCTHD.Controls.Add(this.txtSoLuong);
            this.gbCTHD.Controls.Add(this.comboBox1);
            this.gbCTHD.Controls.Add(dONGIALabel);
            this.gbCTHD.Controls.Add(mAHHLabel);
            this.gbCTHD.Controls.Add(sOLUONGLabel);
            this.gbCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTHD.Location = new System.Drawing.Point(2, 248);
            this.gbCTHD.Name = "gbCTHD";
            this.gbCTHD.Size = new System.Drawing.Size(545, 17099);
            this.gbCTHD.TabIndex = 1;
            this.gbCTHD.TabStop = false;
            this.gbCTHD.Text = "Chi Tiết Hóa Đơn";
            // 
            // cmbHH
            // 
            this.cmbHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.Location = new System.Drawing.Point(163, 40);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(210, 27);
            this.cmbHH.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 1308);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 27);
            this.comboBox2.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT_HoaDon, "SOLUONG", true));
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(163, 96);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(210, 26);
            this.txtSoLuong.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 1300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // gbHD
            // 
            this.gbHD.Controls.Add(this.txtMaNhanVien);
            this.gbHD.Controls.Add(this.dteNGAY);
            this.gbHD.Controls.Add(this.txtSoHD);
            this.gbHD.Controls.Add(this.cmbKhachHang);
            this.gbHD.Controls.Add(label2);
            this.gbHD.Controls.Add(this.cmbKho);
            this.gbHD.Controls.Add(nGAYLAPLabel);
            this.gbHD.Controls.Add(mAKHOLabel);
            this.gbHD.Controls.Add(mANVLabel);
            this.gbHD.Controls.Add(mADDHLabel);
            this.gbHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHD.Location = new System.Drawing.Point(2, 2);
            this.gbHD.Name = "gbHD";
            this.gbHD.Size = new System.Drawing.Size(545, 246);
            this.gbHD.TabIndex = 0;
            this.gbHD.TabStop = false;
            this.gbHD.Text = "Hóa Đơn";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoaDon, "MANV", true));
            this.txtMaNhanVien.Location = new System.Drawing.Point(163, 114);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(210, 26);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // dteNGAY
            // 
            this.dteNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoaDon, "NGAYLAP", true));
            this.dteNGAY.EditValue = null;
            this.dteNGAY.Location = new System.Drawing.Point(163, 74);
            this.dteNGAY.MenuManager = this.barManager1;
            this.dteNGAY.Name = "dteNGAY";
            this.dteNGAY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNGAY.Properties.Appearance.Options.UseFont = true;
            this.dteNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNGAY.Size = new System.Drawing.Size(210, 26);
            this.dteNGAY.TabIndex = 4;
            // 
            // txtSoHD
            // 
            this.txtSoHD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoaDon, "SOHD", true));
            this.txtSoHD.Location = new System.Drawing.Point(163, 29);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Properties.Appearance.Options.UseFont = true;
            this.txtSoHD.Size = new System.Drawing.Size(210, 26);
            this.txtSoHD.TabIndex = 4;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(163, 197);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(210, 27);
            this.cmbKhachHang.TabIndex = 6;
            // 
            // cmbKho
            // 
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(163, 154);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(210, 27);
            this.cmbKho.TabIndex = 4;
            // 
            // gcHD
            // 
            this.gcHD.DataSource = this.bdsHoaDon;
            this.gcHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHD.Location = new System.Drawing.Point(3, 22);
            this.gcHD.MainView = this.gridView1;
            this.gcHD.MenuManager = this.barManager1;
            this.gcHD.Name = "gcHD";
            this.gcHD.Size = new System.Drawing.Size(1554, 149);
            this.gcHD.TabIndex = 0;
            this.gcHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOHD1,
            this.colNGAYLAP,
            this.colMANV,
            this.colMAKHO,
            this.colMAKH});
            this.gridView1.GridControl = this.gcHD;
            this.gridView1.Name = "gridView1";
            // 
            // colSOHD1
            // 
            this.colSOHD1.Caption = "Số Hóa Đơn";
            this.colSOHD1.FieldName = "SOHD";
            this.colSOHD1.Name = "colSOHD1";
            this.colSOHD1.OptionsColumn.AllowEdit = false;
            this.colSOHD1.Visible = true;
            this.colSOHD1.VisibleIndex = 0;
            this.colSOHD1.Width = 82;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.Caption = "Ngày Lập";
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.OptionsColumn.AllowEdit = false;
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 1;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã Khách Hàng";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DONDHTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = this.cT_HOADONTableAdapter;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANGHOA_SLTableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
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
            // cT_HOADONTableAdapter
            // 
            this.cT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONBindingNavigator
            // 
            this.hOADONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hOADONBindingNavigator.BindingSource = this.bdsHoaDon;
            this.hOADONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hOADONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hOADONBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hOADONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hOADONBindingNavigatorSaveItem});
            this.hOADONBindingNavigator.Location = new System.Drawing.Point(0, 17673);
            this.hOADONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hOADONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hOADONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hOADONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hOADONBindingNavigator.Name = "hOADONBindingNavigator";
            this.hOADONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hOADONBindingNavigator.Size = new System.Drawing.Size(1560, 27);
            this.hOADONBindingNavigator.TabIndex = 17;
            this.hOADONBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // hOADONBindingNavigatorSaveItem
            // 
            this.hOADONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hOADONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hOADONBindingNavigatorSaveItem.Image")));
            this.hOADONBindingNavigatorSaveItem.Name = "hOADONBindingNavigatorSaveItem";
            this.hOADONBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.hOADONBindingNavigatorSaveItem.Text = "Save Data";
            this.hOADONBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOADONBindingNavigatorSaveItem_Click);
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHACHHANG";
            this.bdsKH.DataSource = this.DS;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
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
            // bdsHangHoa
            // 
            this.bdsHangHoa.DataMember = "HANGHOA_SL";
            this.bdsHangHoa.DataSource = this.DS;
            // 
            // hANGHOA_SLTableAdapter
            // 
            this.hANGHOA_SLTableAdapter.ClearBeforeFill = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 824);
            this.Controls.Add(this.hOADONBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.gbCTHD.ResumeLayout(false);
            this.gbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.gbHD.ResumeLayout(false);
            this.gbHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).EndInit();
            this.hOADONBindingNavigator.ResumeLayout(false);
            this.hOADONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnCheDoHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietHoaDon;
        private System.Windows.Forms.BindingNavigator hOADONBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource bdsHoaDon;
        private DS DS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hOADONBindingNavigatorSaveItem;
        private DSTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraGrid.GridControl gcCTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox gbCTHD;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbHD;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbKho;
        private DevExpress.XtraGrid.GridControl gcHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CT_HOADONTableAdapter cT_HOADONTableAdapter;
        private System.Windows.Forms.BindingSource bdsCT_HoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.DateEdit dteNGAY;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private System.Windows.Forms.ComboBox cmbHH;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KHO_SLTableAdapter kHO_SLTableAdapter;
        private System.Windows.Forms.BindingSource bdsHangHoa;
        private DSTableAdapters.HANGHOA_SLTableAdapter hANGHOA_SLTableAdapter;
    }
}