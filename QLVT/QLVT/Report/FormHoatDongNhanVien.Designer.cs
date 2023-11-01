
namespace QLVT
{
    partial class FormHoatDongNhanVien
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
            System.Windows.Forms.Label hOTENLabel;
            this.dteToiNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLVT.DS();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.hOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(48, 99);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(66, 19);
            hOTENLabel.TabIndex = 18;
            hOTENLabel.Text = "HỌ TÊN";
            // 
            // dteToiNgay
            // 
            this.dteToiNgay.EditValue = null;
            this.dteToiNgay.Location = new System.Drawing.Point(477, 161);
            this.dteToiNgay.Margin = new System.Windows.Forms.Padding(10);
            this.dteToiNgay.Name = "dteToiNgay";
            this.dteToiNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToiNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToiNgay.Size = new System.Drawing.Size(159, 20);
            this.dteToiNgay.TabIndex = 17;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(626, 24);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 40);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Location = new System.Drawing.Point(149, 161);
            this.dteTuNgay.Margin = new System.Windows.Forms.Padding(10);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Size = new System.Drawing.Size(173, 20);
            this.dteTuNgay.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "DATE TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "DATE FROM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(149, 24);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(408, 27);
            this.cmbChiNhanh.TabIndex = 11;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HOTENNV";
            this.bdsHoTenNV.DataSource = this.dS;
            // 
            // hOTENNVTableAdapter
            // 
            this.hOTENNVTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIHANGHOATableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataSource = this.bdsHoTenNV;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(149, 96);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(408, 27);
            this.cmbHoTen.TabIndex = 20;
            this.cmbHoTen.ValueMember = "MANV";
            // 
            // FormHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 217);
            this.Controls.Add(this.cmbHoTen);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.dteToiNgay);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dteTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHoatDongNhanVien";
            this.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dteToiNgay;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DSTableAdapters.HOTENNVTableAdapter hOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoTen;
    }
}