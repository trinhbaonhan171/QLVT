
namespace QLVT
{
    partial class FormThemPhieuNhap
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nGAYLAPLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCheDoDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gbCTPN = new System.Windows.Forms.GroupBox();
            this.gcCTPN = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbPN = new System.Windows.Forms.GroupBox();
            this.cmbDonDatHang = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.dateNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtSoPn = new DevExpress.XtraEditors.TextEdit();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            mADDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            nGAYLAPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            this.gbPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPn.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mADDHLabel
            // 
            mADDHLabel.AutoSize = true;
            mADDHLabel.Location = new System.Drawing.Point(95, 32);
            mADDHLabel.Name = "mADDHLabel";
            mADDHLabel.Size = new System.Drawing.Size(101, 19);
            mADDHLabel.TabIndex = 3;
            mADDHLabel.Text = "Số Phiếu Nhập";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(125, 159);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(73, 19);
            mANVLabel.TabIndex = 3;
            mANVLabel.Text = "Nhân Viên";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(165, 220);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(36, 19);
            mAKHOLabel.TabIndex = 3;
            mAKHOLabel.Text = "Kho";
            // 
            // nGAYLAPLabel
            // 
            nGAYLAPLabel.AutoSize = true;
            nGAYLAPLabel.Location = new System.Drawing.Point(136, 100);
            nGAYLAPLabel.Name = "nGAYLAPLabel";
            nGAYLAPLabel.Size = new System.Drawing.Size(70, 19);
            nGAYLAPLabel.TabIndex = 3;
            nGAYLAPLabel.Text = "Ngày Lập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(64, 288);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 19);
            label2.TabIndex = 5;
            label2.Text = "Chọn Đơn Đặt Hàng";
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
            this.btnGHI,
            this.btnTHOAT,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1362, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1362, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1362, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
            // 
            // btnCheDoDonDatHang
            // 
            this.btnCheDoDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnCheDoDonDatHang.Id = 8;
            this.btnCheDoDonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.Image")));
            this.btnCheDoDonDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoDonDatHang.Name = "btnCheDoDonDatHang";
            // 
            // btnCheDoChiTietDonDatHang
            // 
            this.btnCheDoChiTietDonDatHang.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCheDoChiTietDonDatHang.Id = 9;
            this.btnCheDoChiTietDonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.Image")));
            this.btnCheDoChiTietDonDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.LargeImage")));
            this.btnCheDoChiTietDonDatHang.Name = "btnCheDoChiTietDonDatHang";
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
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.panelControl1);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(3, 22);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(1356, 17523);
            this.gcThongTin.TabIndex = 1;
            this.gcThongTin.Text = "Thông tin";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gbCTPN);
            this.panelControl1.Controls.Add(this.gbPN);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1554, 17498);
            this.panelControl1.TabIndex = 0;
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(this.gcCTPN);
            this.gbCTPN.Controls.Add(this.comboBox2);
            this.gbCTPN.Controls.Add(this.comboBox1);
            this.gbCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTPN.Location = new System.Drawing.Point(724, 2);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(828, 17494);
            this.gbCTPN.TabIndex = 1;
            this.gbCTPN.TabStop = false;
            this.gbCTPN.Text = "Chi Tiết Phiếu Nhập";
            // 
            // gcCTPN
            // 
            this.gcCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.SOLUONG,
            this.DONGIA});
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.Location = new System.Drawing.Point(3, 22);
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.RowHeadersWidth = 51;
            this.gcCTPN.Size = new System.Drawing.Size(822, 17469);
            this.gcCTPN.TabIndex = 10;
            // 
            // MAHH
            // 
            this.MAHH.HeaderText = "Mã Hàng Hóa";
            this.MAHH.MinimumWidth = 6;
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 200;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 200;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 200;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 1300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // gbPN
            // 
            this.gbPN.Controls.Add(this.cmbDonDatHang);
            this.gbPN.Controls.Add(label2);
            this.gbPN.Controls.Add(this.txtNhanVien);
            this.gbPN.Controls.Add(this.dateNgayLap);
            this.gbPN.Controls.Add(this.txtSoPn);
            this.gbPN.Controls.Add(this.cmbKho);
            this.gbPN.Controls.Add(nGAYLAPLabel);
            this.gbPN.Controls.Add(mAKHOLabel);
            this.gbPN.Controls.Add(mANVLabel);
            this.gbPN.Controls.Add(mADDHLabel);
            this.gbPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPN.Location = new System.Drawing.Point(2, 2);
            this.gbPN.Name = "gbPN";
            this.gbPN.Size = new System.Drawing.Size(722, 17494);
            this.gbPN.TabIndex = 0;
            this.gbPN.TabStop = false;
            this.gbPN.Text = "Phiếu Nhập";
            // 
            // cmbDonDatHang
            // 
            this.cmbDonDatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonDatHang.FormattingEnabled = true;
            this.cmbDonDatHang.Location = new System.Drawing.Point(248, 288);
            this.cmbDonDatHang.Name = "cmbDonDatHang";
            this.cmbDonDatHang.Size = new System.Drawing.Size(233, 27);
            this.cmbDonDatHang.TabIndex = 6;
            this.cmbDonDatHang.SelectedIndexChanged += new System.EventHandler(this.cmbDonDatHang_SelectedIndexChanged);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(248, 156);
            this.txtNhanVien.MenuManager = this.barManager1;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtNhanVien.Size = new System.Drawing.Size(233, 26);
            this.txtNhanVien.TabIndex = 4;
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.EditValue = null;
            this.dateNgayLap.Location = new System.Drawing.Point(248, 97);
            this.dateNgayLap.MenuManager = this.barManager1;
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dateNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLap.Size = new System.Drawing.Size(233, 26);
            this.dateNgayLap.TabIndex = 4;
            // 
            // txtSoPn
            // 
            this.txtSoPn.Location = new System.Drawing.Point(248, 29);
            this.txtSoPn.MenuManager = this.barManager1;
            this.txtSoPn.Name = "txtSoPn";
            this.txtSoPn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPn.Properties.Appearance.Options.UseFont = true;
            this.txtSoPn.Size = new System.Drawing.Size(233, 26);
            this.txtSoPn.TabIndex = 4;
            // 
            // cmbKho
            // 
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(248, 217);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(233, 27);
            this.cmbKho.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 17548);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // FormThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThemPhieuNhap";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormThemPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.gbCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            this.gbPN.ResumeLayout(false);
            this.gbPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPn.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietDonDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox gbCTPN;
        private System.Windows.Forms.DataGridView gcCTPN;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbPN;
        private System.Windows.Forms.ComboBox cmbDonDatHang;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.DateEdit dateNgayLap;
        private DevExpress.XtraEditors.TextEdit txtSoPn;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}