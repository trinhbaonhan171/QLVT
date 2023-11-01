
namespace QLVT.Report
{
    partial class FrptChiTietSLTGHangHoaNhapXuat
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
            System.Windows.Forms.Label label5;
            this.dteToiNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 19);
            label5.TabIndex = 28;
            label5.Text = "LOẠI PHIẾU";
            // 
            // dteToiNgay
            // 
            this.dteToiNgay.EditValue = null;
            this.dteToiNgay.Location = new System.Drawing.Point(529, 80);
            this.dteToiNgay.Margin = new System.Windows.Forms.Padding(15);
            this.dteToiNgay.Name = "dteToiNgay";
            this.dteToiNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToiNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteToiNgay.Size = new System.Drawing.Size(238, 20);
            this.dteToiNgay.TabIndex = 27;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(648, 13);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(162, 34);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Location = new System.Drawing.Point(119, 79);
            this.dteTuNgay.Margin = new System.Windows.Forms.Padding(15);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Size = new System.Drawing.Size(260, 20);
            this.dteTuNgay.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "DATE TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "DATE FROM";
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.DisplayMember = "HOTEN";
            this.cmbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(119, 12);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(298, 27);
            this.cmbLoaiPhieu.TabIndex = 29;
            this.cmbLoaiPhieu.ValueMember = "MANV";
            // 
            // FrptChiTietSLTGHangHoaNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 147);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(label5);
            this.Controls.Add(this.dteToiNgay);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dteTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrptChiTietSLTGHangHoaNhapXuat";
            this.Text = "CHI TIẾT SL TRỊ GIÁ HÀNG HÓA NHẬP XUẤT";
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteToiNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dteToiNgay;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
    }
}