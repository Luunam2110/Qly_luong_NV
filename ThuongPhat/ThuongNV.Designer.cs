
namespace Qly_luong.ThuongPhat
{
    partial class ThuongNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMucThuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.DgvCtthuong = new System.Windows.Forms.DataGridView();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMucThuong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCtthuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(296, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thêm Thưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanvien,
            this.tenNV,
            this.ngaySinh});
            this.DgvNhanVien.Location = new System.Drawing.Point(11, 192);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(367, 246);
            this.DgvNhanVien.TabIndex = 11;
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
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(117, 94);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 20);
            this.txtTenNV.TabIndex = 16;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(117, 63);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(166, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nội dung thưởng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mức thưởng";
            // 
            // txtMucThuong
            // 
            this.txtMucThuong.Enabled = false;
            this.txtMucThuong.Location = new System.Drawing.Point(538, 90);
            this.txtMucThuong.Name = "txtMucThuong";
            this.txtMucThuong.Size = new System.Drawing.Size(186, 20);
            this.txtMucThuong.TabIndex = 20;
            this.txtMucThuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(549, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thưởng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DgvCtthuong
            // 
            this.DgvCtthuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCtthuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDung,
            this.mucThuong,
            this.soLan});
            this.DgvCtthuong.Location = new System.Drawing.Point(393, 192);
            this.DgvCtthuong.Name = "DgvCtthuong";
            this.DgvCtthuong.Size = new System.Drawing.Size(395, 246);
            this.DgvCtthuong.TabIndex = 22;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung thưởng";
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 150;
            // 
            // mucThuong
            // 
            this.mucThuong.DataPropertyName = "mucThuong";
            this.mucThuong.HeaderText = "Mức Thưởng";
            this.mucThuong.Name = "mucThuong";
            // 
            // soLan
            // 
            this.soLan.DataPropertyName = "soLan";
            this.soLan.HeaderText = "số Lần";
            this.soLan.Name = "soLan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Danh sách Thưởng của nhân viên trong tháng";
            // 
            // cbbMucThuong
            // 
            this.cbbMucThuong.FormattingEnabled = true;
            this.cbbMucThuong.Location = new System.Drawing.Point(538, 58);
            this.cbbMucThuong.Name = "cbbMucThuong";
            this.cbbMucThuong.Size = new System.Drawing.Size(186, 21);
            this.cbbMucThuong.TabIndex = 24;
            this.cbbMucThuong.SelectedValueChanged += new System.EventHandler(this.CbbNoidungThuong_SelectedValueChanged);
            // 
            // ThuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbMucThuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvCtthuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMucThuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvNhanVien);
            this.Controls.Add(this.label4);
            this.Name = "ThuongNV";
            this.Text = "ThuongNV";
            this.Load += new System.EventHandler(this.ThuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCtthuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMucThuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DgvCtthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMucThuong;
    }
}