
namespace Qly_luong.ThuongPhat
{
    partial class PhatNV
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCtphat = new System.Windows.Forms.DataGridView();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMucPhat = new System.Windows.Forms.ComboBox();
            this.txtMucPhat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCtphat)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(295, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thêm Phạt NV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(118, 117);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 20);
            this.txtTenNV.TabIndex = 20;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(118, 86);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(166, 20);
            this.txtMaNV.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(637, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Phạt";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Danh sách nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Danh sách Phạt của nhân viên trong tháng";
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanvien,
            this.tenNV,
            this.ngaySinh});
            this.DgvNhanVien.Location = new System.Drawing.Point(12, 271);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(367, 246);
            this.DgvNhanVien.TabIndex = 28;
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
            // DgvCtphat
            // 
            this.DgvCtphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCtphat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDung,
            this.mucPhat,
            this.soLan});
            this.DgvCtphat.Location = new System.Drawing.Point(445, 271);
            this.DgvCtphat.Name = "DgvCtphat";
            this.DgvCtphat.Size = new System.Drawing.Size(395, 246);
            this.DgvCtphat.TabIndex = 29;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung phạt";
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 150;
            // 
            // mucPhat
            // 
            this.mucPhat.DataPropertyName = "mucPhat";
            this.mucPhat.HeaderText = "Mức Phạt";
            this.mucPhat.Name = "mucPhat";
            // 
            // soLan
            // 
            this.soLan.DataPropertyName = "soLan";
            this.soLan.HeaderText = "số Lần";
            this.soLan.Name = "soLan";
            // 
            // cbbMucPhat
            // 
            this.cbbMucPhat.FormattingEnabled = true;
            this.cbbMucPhat.Location = new System.Drawing.Point(547, 89);
            this.cbbMucPhat.Name = "cbbMucPhat";
            this.cbbMucPhat.Size = new System.Drawing.Size(186, 21);
            this.cbbMucPhat.TabIndex = 31;
            this.cbbMucPhat.SelectedValueChanged += new System.EventHandler(this.CbbNoidungPhat_SelectedValueChanged);
            // 
            // txtMucPhat
            // 
            this.txtMucPhat.Enabled = false;
            this.txtMucPhat.Location = new System.Drawing.Point(547, 121);
            this.txtMucPhat.Name = "txtMucPhat";
            this.txtMucPhat.Size = new System.Drawing.Size(186, 20);
            this.txtMucPhat.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mức phạt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nội dung phạt";
            // 
            // PhatNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbMucPhat);
            this.Controls.Add(this.txtMucPhat);
            this.Controls.Add(this.DgvCtphat);
            this.Controls.Add(this.DgvNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "PhatNV";
            this.Text = "PhatNV";
            this.Load += new System.EventHandler(this.PhatNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCtphat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridView DgvCtphat;
        private System.Windows.Forms.ComboBox cbbMucPhat;
        private System.Windows.Forms.TextBox txtMucPhat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLan;
    }
}