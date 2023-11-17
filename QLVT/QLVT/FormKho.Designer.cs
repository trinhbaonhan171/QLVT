
namespace QLVT
{
    partial class FormKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.Btn_Them_kho = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Xoa_kho = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Ghi_kho = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_HoanTac_kho = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_LamMoi_kho = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Thoat_kho = new DevExpress.XtraBars.BarButtonItem();
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
            this.bds_Kho = new System.Windows.Forms.BindingSource(this.components);
            this.kHOTableAdapter = new QLVT.DSTableAdapters.KHOTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new System.Windows.Forms.GroupBox();
            this.txt_maCN = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKho = new DevExpress.XtraEditors.TextEdit();
            this.txt_maKho = new DevExpress.XtraEditors.TextEdit();
            tRANGTHAIXOALabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKho.Properties)).BeginInit();
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
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(98, 46);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(61, 19);
            mAKHOLabel.TabIndex = 18;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(403, 46);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(63, 19);
            tENKHOLabel.TabIndex = 19;
            tENKHOLabel.Text = "Tên Kho";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(60, 121);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(99, 19);
            mACNLabel.TabIndex = 20;
            mACNLabel.Text = "Mã Chi Nhánh";
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
            this.Btn_Them_kho,
            this.Btn_Xoa_kho,
            this.Btn_Ghi_kho,
            this.Btn_HoanTac_kho,
            this.Btn_Thoat_kho,
            this.Btn_LamMoi_kho});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Them_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Xoa_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Ghi_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_HoanTac_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_LamMoi_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Thoat_kho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Btn_Them_kho
            // 
            this.Btn_Them_kho.Caption = "Thêm         ";
            this.Btn_Them_kho.Id = 0;
            this.Btn_Them_kho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Them_kho.ImageOptions.SvgImage")));
            this.Btn_Them_kho.Name = "Btn_Them_kho";
            this.Btn_Them_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Them_kho_ItemClick);
            // 
            // Btn_Xoa_kho
            // 
            this.Btn_Xoa_kho.Caption = "Xóa        ";
            this.Btn_Xoa_kho.Id = 1;
            this.Btn_Xoa_kho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Xoa_kho.ImageOptions.Image")));
            this.Btn_Xoa_kho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Xoa_kho.ImageOptions.LargeImage")));
            this.Btn_Xoa_kho.Name = "Btn_Xoa_kho";
            this.Btn_Xoa_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Xoa_kho_ItemClick);
            // 
            // Btn_Ghi_kho
            // 
            this.Btn_Ghi_kho.Caption = "Ghi          ";
            this.Btn_Ghi_kho.Id = 2;
            this.Btn_Ghi_kho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Ghi_kho.ImageOptions.SvgImage")));
            this.Btn_Ghi_kho.Name = "Btn_Ghi_kho";
            this.Btn_Ghi_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Ghi_kho_ItemClick);
            // 
            // Btn_HoanTac_kho
            // 
            this.Btn_HoanTac_kho.Caption = "Hoàn tác          ";
            this.Btn_HoanTac_kho.Id = 3;
            this.Btn_HoanTac_kho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_HoanTac_kho.ImageOptions.Image")));
            this.Btn_HoanTac_kho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_HoanTac_kho.ImageOptions.LargeImage")));
            this.Btn_HoanTac_kho.Name = "Btn_HoanTac_kho";
            this.Btn_HoanTac_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_HoanTac_kho_ItemClick);
            // 
            // Btn_LamMoi_kho
            // 
            this.Btn_LamMoi_kho.Caption = "Làm Mới           ";
            this.Btn_LamMoi_kho.Id = 6;
            this.Btn_LamMoi_kho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LamMoi_kho.ImageOptions.Image")));
            this.Btn_LamMoi_kho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_LamMoi_kho.ImageOptions.LargeImage")));
            this.Btn_LamMoi_kho.Name = "Btn_LamMoi_kho";
            this.Btn_LamMoi_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_LamMoi_kho_ItemClick);
            // 
            // Btn_Thoat_kho
            // 
            this.Btn_Thoat_kho.Caption = "Thoát";
            this.Btn_Thoat_kho.Id = 5;
            this.Btn_Thoat_kho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Thoat_kho.ImageOptions.SvgImage")));
            this.Btn_Thoat_kho.Name = "Btn_Thoat_kho";
            this.Btn_Thoat_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Thoat_kho_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(961, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(961, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(961, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 40);
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
            // bds_Kho
            // 
            this.bds_Kho.DataMember = "KHO";
            this.bds_Kho.DataSource = this.dS;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOTableAdapter = this.kHOTableAdapter;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACC_SLTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.bds_Kho;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKho.Location = new System.Drawing.Point(0, 85);
            this.gcKho.MainView = this.gridView1;
            this.gcKho.MenuManager = this.barManager1;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(961, 205);
            this.gcKho.TabIndex = 14;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colMACN});
            this.gridView1.GridControl = this.gcKho;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên Kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 2;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(mACNLabel);
            this.panelNhapLieu.Controls.Add(this.txt_maCN);
            this.panelNhapLieu.Controls.Add(tENKHOLabel);
            this.panelNhapLieu.Controls.Add(this.txt_TenKho);
            this.panelNhapLieu.Controls.Add(mAKHOLabel);
            this.panelNhapLieu.Controls.Add(this.txt_maKho);
            this.panelNhapLieu.Controls.Add(tRANGTHAIXOALabel);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 290);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(961, 184);
            this.panelNhapLieu.TabIndex = 15;
            this.panelNhapLieu.TabStop = false;
            // 
            // txt_maCN
            // 
            this.txt_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "MACN", true));
            this.txt_maCN.Location = new System.Drawing.Point(206, 118);
            this.txt_maCN.MenuManager = this.barManager1;
            this.txt_maCN.Name = "txt_maCN";
            this.txt_maCN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCN.Properties.Appearance.Options.UseFont = true;
            this.txt_maCN.Size = new System.Drawing.Size(153, 26);
            this.txt_maCN.TabIndex = 21;
            // 
            // txt_TenKho
            // 
            this.txt_TenKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "TENKHO", true));
            this.txt_TenKho.Location = new System.Drawing.Point(497, 43);
            this.txt_TenKho.MenuManager = this.barManager1;
            this.txt_TenKho.Name = "txt_TenKho";
            this.txt_TenKho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKho.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKho.Size = new System.Drawing.Size(153, 26);
            this.txt_TenKho.TabIndex = 20;
            // 
            // txt_maKho
            // 
            this.txt_maKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_Kho, "MAKHO", true));
            this.txt_maKho.Location = new System.Drawing.Point(206, 43);
            this.txt_maKho.MenuManager = this.barManager1;
            this.txt_maKho.Name = "txt_maKho";
            this.txt_maKho.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKho.Properties.Appearance.Options.UseFont = true;
            this.txt_maKho.Size = new System.Drawing.Size(153, 26);
            this.txt_maKho.TabIndex = 19;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 494);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcKho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKho";
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKho.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem Btn_Them_kho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem Btn_Xoa_kho;
        private DevExpress.XtraBars.BarButtonItem Btn_Ghi_kho;
        private DevExpress.XtraBars.BarButtonItem Btn_HoanTac_kho;
        private DevExpress.XtraBars.BarButtonItem Btn_Thoat_kho;
        private DevExpress.XtraBars.BarButtonItem Btn_LamMoi_kho;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DS dS;
        private System.Windows.Forms.BindingSource bds_Kho;
        private DSTableAdapters.KHOTableAdapter kHOTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox panelNhapLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.TextEdit txt_maCN;
        private DevExpress.XtraEditors.TextEdit txt_TenKho;
        private DevExpress.XtraEditors.TextEdit txt_maKho;
    }
}