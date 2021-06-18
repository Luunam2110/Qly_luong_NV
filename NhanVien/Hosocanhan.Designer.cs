
namespace Qly_luong.NhanVien
{
    partial class Hosocanhan
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
            this.txtQuanly = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.Label();
            this.ht = new System.Windows.Forms.Label();
            this.gt = new System.Windows.Forms.Label();
            this.ngs = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.dc = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbbGt = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.dtgNV = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txtmaPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuanly
            // 
            this.txtQuanly.AutoSize = true;
            this.txtQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanly.ForeColor = System.Drawing.Color.Maroon;
            this.txtQuanly.Location = new System.Drawing.Point(242, 7);
            this.txtQuanly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtQuanly.Name = "txtQuanly";
            this.txtQuanly.Size = new System.Drawing.Size(218, 24);
            this.txtQuanly.TabIndex = 0;
            this.txtQuanly.Text = "QUẢN LÝ NHÂN VIÊN";
            this.txtQuanly.Click += new System.EventHandler(this.label1_Click);
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(57, 57);
            this.ma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(72, 13);
            this.ma.TabIndex = 1;
            this.ma.Text = "Mã nhân viên";
            // 
            // ht
            // 
            this.ht.AutoSize = true;
            this.ht.Location = new System.Drawing.Point(57, 89);
            this.ht.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(46, 13);
            this.ht.TabIndex = 2;
            this.ht.Text = "Họ & Tên";
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(57, 125);
            this.gt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(47, 13);
            this.gt.TabIndex = 3;
            this.gt.Text = "Giới tính";
            // 
            // ngs
            // 
            this.ngs.AutoSize = true;
            this.ngs.Location = new System.Drawing.Point(57, 163);
            this.ngs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngs.Name = "ngs";
            this.ngs.Size = new System.Drawing.Size(54, 13);
            this.ngs.TabIndex = 4;
            this.ngs.Text = "Ngày sinh";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(57, 198);
            this.dt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(29, 13);
            this.dt.TabIndex = 5;
            this.dt.Text = "SĐT";
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Location = new System.Drawing.Point(382, 57);
            this.dc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(40, 13);
            this.dc.TabIndex = 6;
            this.dc.Text = "Địa chỉ";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(382, 89);
            this.cv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(47, 13);
            this.cv.TabIndex = 7;
            this.cv.Text = "Chức vụ";
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(143, 57);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(144, 20);
            this.txtmaNV.TabIndex = 10;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(143, 87);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(144, 20);
            this.txtHoten.TabIndex = 11;
            // 
            // cbbGt
            // 
            this.cbbGt.FormattingEnabled = true;
            this.cbbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGt.Location = new System.Drawing.Point(143, 123);
            this.cbbGt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbGt.Name = "cbbGt";
            this.cbbGt.Size = new System.Drawing.Size(92, 21);
            this.cbbGt.TabIndex = 12;
            this.cbbGt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(143, 194);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 20);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(469, 54);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(216, 20);
            this.txtDiachi.TabIndex = 14;
            // 
            // dtNgS
            // 
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(143, 163);
            this.dtNgS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(112, 20);
            this.dtNgS.TabIndex = 16;
            // 
            // dtgNV
            // 
            this.dtgNV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoten,
            this.gioiTinh,
            this.ngaySinh,
            this.SDT,
            this.diaChi,
            this.chucVu,
            this.tenPB});
            this.dtgNV.Location = new System.Drawing.Point(9, 265);
            this.dtgNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgNV.Name = "dtgNV";
            this.dtgNV.RowHeadersWidth = 51;
            this.dtgNV.RowTemplate.Height = 24;
            this.dtgNV.Size = new System.Drawing.Size(790, 264);
            this.dtgNV.TabIndex = 17;
            this.dtgNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNV_CellClick);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoTen";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 125;
            // 
            // chucVu
            // 
            this.chucVu.DataPropertyName = "tenCV";
            this.chucVu.HeaderText = "Chức Vụ";
            this.chucVu.MinimumWidth = 6;
            this.chucVu.Name = "chucVu";
            this.chucVu.Width = 125;
            // 
            // tenPB
            // 
            this.tenPB.DataPropertyName = "tenPB";
            this.tenPB.HeaderText = "Phòng ban";
            this.tenPB.MinimumWidth = 6;
            this.tenPB.Name = "tenPB";
            this.tenPB.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(289, 231);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 20);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(469, 231);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(62, 21);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntim.Location = new System.Drawing.Point(599, 229);
            this.btntim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(84, 21);
            this.btntim.TabIndex = 23;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtmaPB
            // 
            this.txtmaPB.Location = new System.Drawing.Point(469, 120);
            this.txtmaPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaPB.Name = "txtmaPB";
            this.txtmaPB.Size = new System.Drawing.Size(76, 20);
            this.txtmaPB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Phòng ban";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCyan;
            this.btnReset.Location = new System.Drawing.Point(710, 228);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbCV
            // 
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(469, 82);
            this.cbbCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(92, 21);
            this.cbbCV.TabIndex = 26;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(364, 231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 21);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Hosocanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 531);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbbCV);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtmaPB);
            this.Controls.Add(this.dtgNV);
            this.Controls.Add(this.dtNgS);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cbbGt);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.ngs);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.txtQuanly);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hosocanhan";
            this.Text = "Hosocanhan";
            this.Load += new System.EventHandler(this.Hosocanhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtQuanly;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Label ht;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Label ngs;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Label dc;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cbbGt;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.DataGridView dtgNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtmaPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPB;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.Button btnHuy;
    }
}