
namespace QLVT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label tRANGTHAIXOALabel;
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label tENHHLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label mALHHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.Btn_Them_VT = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_XoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Ghi_VT = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_HoanTac_VT = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_LamMoi_VT = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Thoat_VT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT.DS();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.Bds_VatTu = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new QLVT.DSTableAdapters.HANGHOATableAdapter();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new System.Windows.Forms.GroupBox();
            this.CB_MaLHH = new System.Windows.Forms.ComboBox();
            this.txt_DVT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenHH = new DevExpress.XtraEditors.TextEdit();
            this.txt_mahh = new DevExpress.XtraEditors.TextEdit();
            this.v_DS_MALHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DataSet = new QLVT.QLVT_DataSet();
            this.v_DS_MALHHTableAdapter = new QLVT.QLVT_DataSetTableAdapters.V_DS_MALHHTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVT_DataSetTableAdapters.TableAdapterManager();
            tRANGTHAIXOALabel = new System.Windows.Forms.Label();
            mAHHLabel = new System.Windows.Forms.Label();
            tENHHLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            mALHHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_MALHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tRANGTHAIXOALabel
            // 
            tRANGTHAIXOALabel.AutoSize = true;
            tRANGTHAIXOALabel.Location = new System.Drawing.Point(761, 153);
            tRANGTHAIXOALabel.Name = "tRANGTHAIXOALabel";
            tRANGTHAIXOALabel.Size = new System.Drawing.Size(0, 19);
            tRANGTHAIXOALabel.TabIndex = 18;
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(51, 39);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(96, 19);
            mAHHLabel.TabIndex = 18;
            mAHHLabel.Text = "Mã Hàng Hóa";
            // 
            // tENHHLabel
            // 
            tENHHLabel.AutoSize = true;
            tENHHLabel.Location = new System.Drawing.Point(387, 43);
            tENHHLabel.Name = "tENHHLabel";
            tENHHLabel.Size = new System.Drawing.Size(98, 19);
            tENHHLabel.TabIndex = 19;
            tENHHLabel.Text = "Tên Hàng Hóa";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(59, 126);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(83, 19);
            dVTLabel.TabIndex = 20;
            dVTLabel.Text = "Đơn Vị Tính";
            // 
            // mALHHLabel
            // 
            mALHHLabel.AutoSize = true;
            mALHHLabel.Location = new System.Drawing.Point(373, 126);
            mALHHLabel.Name = "mALHHLabel";
            mALHHLabel.Size = new System.Drawing.Size(127, 19);
            mALHHLabel.TabIndex = 21;
            mALHHLabel.Text = "Mã Loại Hàng Hóa";
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
            this.Btn_Them_VT,
            this.Btn_XoaVT,
            this.Btn_Ghi_VT,
            this.Btn_HoanTac_VT,
            this.Btn_Thoat_VT,
            this.Btn_LamMoi_VT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Them_VT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_XoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Ghi_VT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_HoanTac_VT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_LamMoi_VT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Thoat_VT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Btn_Them_VT
            // 
            this.Btn_Them_VT.Caption = "Thêm         ";
            this.Btn_Them_VT.Id = 0;
            this.Btn_Them_VT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Them_VT.ImageOptions.SvgImage")));
            this.Btn_Them_VT.Name = "Btn_Them_VT";
            this.Btn_Them_VT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Them_VT_ItemClick);
            // 
            // Btn_XoaVT
            // 
            this.Btn_XoaVT.Caption = "Xóa        ";
            this.Btn_XoaVT.Id = 1;
            this.Btn_XoaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_XoaVT.ImageOptions.Image")));
            this.Btn_XoaVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_XoaVT.ImageOptions.LargeImage")));
            this.Btn_XoaVT.Name = "Btn_XoaVT";
            this.Btn_XoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_XoaVT_ItemClick);
            // 
            // Btn_Ghi_VT
            // 
            this.Btn_Ghi_VT.Caption = "Ghi          ";
            this.Btn_Ghi_VT.Id = 2;
            this.Btn_Ghi_VT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Ghi_VT.ImageOptions.SvgImage")));
            this.Btn_Ghi_VT.Name = "Btn_Ghi_VT";
            this.Btn_Ghi_VT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Ghi_VT_ItemClick);
            // 
            // Btn_HoanTac_VT
            // 
            this.Btn_HoanTac_VT.Caption = "Hoàn tác          ";
            this.Btn_HoanTac_VT.Id = 3;
            this.Btn_HoanTac_VT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_HoanTac_VT.ImageOptions.Image")));
            this.Btn_HoanTac_VT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_HoanTac_VT.ImageOptions.LargeImage")));
            this.Btn_HoanTac_VT.Name = "Btn_HoanTac_VT";
            this.Btn_HoanTac_VT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_HoanTac_VT_ItemClick);
            // 
            // Btn_LamMoi_VT
            // 
            this.Btn_LamMoi_VT.Caption = "Làm Mới           ";
            this.Btn_LamMoi_VT.Id = 6;
            this.Btn_LamMoi_VT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LamMoi_VT.ImageOptions.Image")));
            this.Btn_LamMoi_VT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_LamMoi_VT.ImageOptions.LargeImage")));
            this.Btn_LamMoi_VT.Name = "Btn_LamMoi_VT";
            this.Btn_LamMoi_VT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_LamMoi_VT_ItemClick);
            // 
            // Btn_Thoat_VT
            // 
            this.Btn_Thoat_VT.Caption = "Thoát";
            this.Btn_Thoat_VT.Id = 5;
            this.Btn_Thoat_VT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Thoat_VT.ImageOptions.SvgImage")));
            this.Btn_Thoat_VT.Name = "Btn_Thoat_VT";
            this.Btn_Thoat_VT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Thoat_VT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(981, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(981, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(981, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 40);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(166, 6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(420, 27);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Bds_VatTu
            // 
            this.Bds_VatTu.DataMember = "HANGHOA";
            this.Bds_VatTu.DataSource = this.dS;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.Bds_VatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 85);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(981, 220);
            this.gcVatTu.TabIndex = 19;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTENHH,
            this.colDVT,
            this.colMALHH});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHH
            // 
            this.colMAHH.Caption = "Mã Hàng Hóa";
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.OptionsColumn.AllowEdit = false;
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            // 
            // colTENHH
            // 
            this.colTENHH.Caption = "Tên Hàng Hóa";
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.OptionsColumn.AllowEdit = false;
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn Vị Tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colMALHH
            // 
            this.colMALHH.Caption = "Mã Loại Hàng Hóa";
            this.colMALHH.FieldName = "MALHH";
            this.colMALHH.Name = "colMALHH";
            this.colMALHH.OptionsColumn.AllowEdit = false;
            this.colMALHH.Visible = true;
            this.colMALHH.VisibleIndex = 3;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.CB_MaLHH);
            this.panelNhapLieu.Controls.Add(mALHHLabel);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txt_DVT);
            this.panelNhapLieu.Controls.Add(tENHHLabel);
            this.panelNhapLieu.Controls.Add(this.txt_TenHH);
            this.panelNhapLieu.Controls.Add(mAHHLabel);
            this.panelNhapLieu.Controls.Add(this.txt_mahh);
            this.panelNhapLieu.Controls.Add(tRANGTHAIXOALabel);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 305);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(981, 192);
            this.panelNhapLieu.TabIndex = 20;
            this.panelNhapLieu.TabStop = false;
            // 
            // CB_MaLHH
            // 
            this.CB_MaLHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MaLHH.FormattingEnabled = true;
            this.CB_MaLHH.Location = new System.Drawing.Point(517, 123);
            this.CB_MaLHH.Name = "CB_MaLHH";
            this.CB_MaLHH.Size = new System.Drawing.Size(164, 27);
            this.CB_MaLHH.TabIndex = 22;
            // 
            // txt_DVT
            // 
            this.txt_DVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.Bds_VatTu, "DVT", true));
            this.txt_DVT.Location = new System.Drawing.Point(166, 123);
            this.txt_DVT.MenuManager = this.barManager1;
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVT.Properties.Appearance.Options.UseFont = true;
            this.txt_DVT.Size = new System.Drawing.Size(140, 26);
            this.txt_DVT.TabIndex = 21;
            // 
            // txt_TenHH
            // 
            this.txt_TenHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.Bds_VatTu, "TENHH", true));
            this.txt_TenHH.Location = new System.Drawing.Point(517, 40);
            this.txt_TenHH.MenuManager = this.barManager1;
            this.txt_TenHH.Name = "txt_TenHH";
            this.txt_TenHH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenHH.Size = new System.Drawing.Size(164, 26);
            this.txt_TenHH.TabIndex = 20;
            // 
            // txt_mahh
            // 
            this.txt_mahh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.Bds_VatTu, "MAHH", true));
            this.txt_mahh.Location = new System.Drawing.Point(166, 36);
            this.txt_mahh.MenuManager = this.barManager1;
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahh.Properties.Appearance.Options.UseFont = true;
            this.txt_mahh.Size = new System.Drawing.Size(140, 26);
            this.txt_mahh.TabIndex = 19;
            // 
            // v_DS_MALHHBindingSource
            // 
            this.v_DS_MALHHBindingSource.DataMember = "V_DS_MALHH";
            this.v_DS_MALHHBindingSource.DataSource = this.qLVT_DataSet;
            // 
            // qLVT_DataSet
            // 
            this.qLVT_DataSet.DataSetName = "QLVT_DataSet";
            this.qLVT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_MALHHTableAdapter
            // 
            this.v_DS_MALHHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVT_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 517);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_MALHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DataSet)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem Btn_Them_VT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem Btn_XoaVT;
        private DevExpress.XtraBars.BarButtonItem Btn_Ghi_VT;
        private DevExpress.XtraBars.BarButtonItem Btn_HoanTac_VT;
        private DevExpress.XtraBars.BarButtonItem Btn_Thoat_VT;
        private DevExpress.XtraBars.BarButtonItem Btn_LamMoi_VT;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource Bds_VatTu;
        private DSTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.GroupBox panelNhapLieu;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraEditors.TextEdit txt_DVT;
        private DevExpress.XtraEditors.TextEdit txt_TenHH;
        private DevExpress.XtraEditors.TextEdit txt_mahh;
        private QLVT_DataSet qLVT_DataSet;
        private System.Windows.Forms.BindingSource v_DS_MALHHBindingSource;
        private QLVT_DataSetTableAdapters.V_DS_MALHHTableAdapter v_DS_MALHHTableAdapter;
        private QLVT_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox CB_MaLHH;
    }
}