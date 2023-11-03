
namespace QLVT
{
    partial class FormChuyenChiNhanh
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChuyenChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tENCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(66, 145);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(97, 19);
            tENCNLabel.TabIndex = 9;
            tENCNLabel.Text = "CHI NHÁNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChuyenChiNhanh);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(tENCNLabel);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbChuyenChiNhanh
            // 
            this.cmbChuyenChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChuyenChiNhanh.FormattingEnabled = true;
            this.cmbChuyenChiNhanh.Location = new System.Drawing.Point(185, 142);
            this.cmbChuyenChiNhanh.Name = "cmbChuyenChiNhanh";
            this.cmbChuyenChiNhanh.Size = new System.Drawing.Size(361, 27);
            this.cmbChuyenChiNhanh.TabIndex = 19;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Location = new System.Drawing.Point(185, 224);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(146, 39);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "CHUYỂN CHI NHÁNH";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(377, 224);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 39);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 326);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChuyenChiNhanh";
            this.Text = "Chuyển Chi Nhánh";
            this.Load += new System.EventHandler(this.FormChuyenChiNhanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cmbChuyenChiNhanh;
    }
}