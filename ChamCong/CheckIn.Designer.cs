
namespace Qly_luong.ChamCong
{
    partial class CheckIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBNgayLe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListCheckout = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpIn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 93);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(357, 93);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Location = new System.Drawing.Point(711, 137);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckIn.TabIndex = 4;
            this.BtnCheckIn.Text = "Check in";
            this.BtnCheckIn.UseVisualStyleBackColor = true;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanvien,
            this.tenNV,
            this.ngaySinh});
            this.DgvNhanVien.Location = new System.Drawing.Point(14, 173);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(367, 364);
            this.DgvNhanVien.TabIndex = 5;
            this.DgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellClick);
            // 
            // maNhanvien
            // 
            this.maNhanvien.DataPropertyName = "maNV";
            this.maNhanvien.HeaderText = "Mã NV";
            this.maNhanvien.Name = "maNhanvien";
            this.maNhanvien.Width = 80;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "hoTen";
            this.tenNV.HeaderText = "Họ Tên";
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 120;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 120;
            // 
            // CBNgayLe
            // 
            this.CBNgayLe.AutoSize = true;
            this.CBNgayLe.Location = new System.Drawing.Point(51, 61);
            this.CBNgayLe.Name = "CBNgayLe";
            this.CBNgayLe.Size = new System.Drawing.Size(62, 17);
            this.CBNgayLe.TabIndex = 7;
            this.CBNgayLe.Text = "Ngày lễ";
            this.CBNgayLe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(322, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Check In";
            // 
            // dgvListCheckout
            // 
            this.dgvListCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoTen,
            this.Ngay,
            this.gioDiLam,
            this.ngayLe});
            this.dgvListCheckout.Location = new System.Drawing.Point(387, 173);
            this.dgvListCheckout.Name = "dgvListCheckout";
            this.dgvListCheckout.Size = new System.Drawing.Size(525, 364);
            this.dgvListCheckout.TabIndex = 9;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            this.maNV.Width = 70;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 130;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 120;
            // 
            // gioDiLam
            // 
            this.gioDiLam.DataPropertyName = "gioDiLam";
            this.gioDiLam.HeaderText = "Giờ đến";
            this.gioDiLam.Name = "gioDiLam";
            this.gioDiLam.Width = 80;
            // 
            // ngayLe
            // 
            this.ngayLe.DataPropertyName = "ngayLe";
            this.ngayLe.HeaderText = "Ngày lễ";
            this.ngayLe.Name = "ngayLe";
            this.ngayLe.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhân viên đã check in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ vào";
            // 
            // DtpIn
            // 
            this.DtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpIn.Location = new System.Drawing.Point(636, 96);
            this.DtpIn.Name = "DtpIn";
            this.DtpIn.Size = new System.Drawing.Size(94, 20);
            this.DtpIn.TabIndex = 13;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 549);
            this.Controls.Add(this.DtpIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListCheckout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBNgayLe);
            this.Controls.Add(this.DgvNhanVien);
            this.Controls.Add(this.BtnCheckIn);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.Text = "7";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button BtnCheckIn;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.CheckBox CBNgayLe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
    }
}