
namespace Qly_luong.Luong
{
    partial class LapPhieuLuong
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
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongluong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtphat = new System.Windows.Forms.TextBox();
            this.txtthuong = new System.Windows.Forms.TextBox();
            this.txtgionghile = new System.Windows.Forms.TextBox();
            this.txtgiongaynghi = new System.Windows.Forms.TextBox();
            this.txtgiolamthem = new System.Windows.Forms.TextBox();
            this.txtgiohanhchinh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmaMV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh sách nhân viên";
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanvien,
            this.tenNV,
            this.ngaySinh});
            this.DgvNhanVien.Location = new System.Drawing.Point(12, 232);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(367, 364);
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
            this.txtTenNV.Location = new System.Drawing.Point(313, 43);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 20);
            this.txtTenNV.TabIndex = 16;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(98, 43);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(271, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lập Phiếu Lương";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(1029, 106);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 64);
            this.btnLap.TabIndex = 18;
            this.btnLap.Text = "Lập Phiếu";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(49, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.txtTongluong);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtphat);
            this.groupBox2.Controls.Add(this.txtthuong);
            this.groupBox2.Controls.Add(this.txtgionghile);
            this.groupBox2.Controls.Add(this.txtgiongaynghi);
            this.groupBox2.Controls.Add(this.txtgiolamthem);
            this.groupBox2.Controls.Add(this.txtgiohanhchinh);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txthsl);
            this.groupBox2.Controls.Add(this.txtlcb);
            this.groupBox2.Controls.Add(this.txtphucap);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.txtmaMV);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(431, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 352);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Lương";
            // 
            // txtTongluong
            // 
            this.txtTongluong.Enabled = false;
            this.txtTongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongluong.Location = new System.Drawing.Point(357, 273);
            this.txtTongluong.Name = "txtTongluong";
            this.txtTongluong.Size = new System.Drawing.Size(216, 29);
            this.txtTongluong.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(215, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 24);
            this.label16.TabIndex = 57;
            this.label16.Text = "Thực Lĩnh";
            // 
            // txtphat
            // 
            this.txtphat.Enabled = false;
            this.txtphat.Location = new System.Drawing.Point(452, 218);
            this.txtphat.Name = "txtphat";
            this.txtphat.Size = new System.Drawing.Size(142, 20);
            this.txtphat.TabIndex = 56;
            // 
            // txtthuong
            // 
            this.txtthuong.Enabled = false;
            this.txtthuong.Location = new System.Drawing.Point(452, 177);
            this.txtthuong.Name = "txtthuong";
            this.txtthuong.Size = new System.Drawing.Size(142, 20);
            this.txtthuong.TabIndex = 55;
            // 
            // txtgionghile
            // 
            this.txtgionghile.Enabled = false;
            this.txtgionghile.Location = new System.Drawing.Point(452, 140);
            this.txtgionghile.Name = "txtgionghile";
            this.txtgionghile.Size = new System.Drawing.Size(142, 20);
            this.txtgionghile.TabIndex = 54;
            // 
            // txtgiongaynghi
            // 
            this.txtgiongaynghi.Enabled = false;
            this.txtgiongaynghi.Location = new System.Drawing.Point(452, 101);
            this.txtgiongaynghi.Name = "txtgiongaynghi";
            this.txtgiongaynghi.Size = new System.Drawing.Size(142, 20);
            this.txtgiongaynghi.TabIndex = 53;
            // 
            // txtgiolamthem
            // 
            this.txtgiolamthem.Enabled = false;
            this.txtgiolamthem.Location = new System.Drawing.Point(452, 62);
            this.txtgiolamthem.Name = "txtgiolamthem";
            this.txtgiolamthem.Size = new System.Drawing.Size(142, 20);
            this.txtgiolamthem.TabIndex = 52;
            // 
            // txtgiohanhchinh
            // 
            this.txtgiohanhchinh.Enabled = false;
            this.txtgiohanhchinh.Location = new System.Drawing.Point(452, 19);
            this.txtgiohanhchinh.Name = "txtgiohanhchinh";
            this.txtgiohanhchinh.Size = new System.Drawing.Size(142, 20);
            this.txtgiohanhchinh.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(337, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Thưởng";
            // 
            // txthsl
            // 
            this.txthsl.Enabled = false;
            this.txthsl.Location = new System.Drawing.Point(135, 218);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(136, 20);
            this.txthsl.TabIndex = 48;
            // 
            // txtlcb
            // 
            this.txtlcb.Enabled = false;
            this.txtlcb.Location = new System.Drawing.Point(135, 177);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(136, 20);
            this.txtlcb.TabIndex = 47;
            // 
            // txtphucap
            // 
            this.txtphucap.Enabled = false;
            this.txtphucap.Location = new System.Drawing.Point(135, 140);
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.Size = new System.Drawing.Size(136, 20);
            this.txtphucap.TabIndex = 46;
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(135, 97);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(136, 20);
            this.txtsdt.TabIndex = 45;
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(135, 58);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(136, 20);
            this.txtten.TabIndex = 44;
            // 
            // txtmaMV
            // 
            this.txtmaMV.Enabled = false;
            this.txtmaMV.Location = new System.Drawing.Point(135, 19);
            this.txtmaMV.Name = "txtmaMV";
            this.txtmaMV.Size = new System.Drawing.Size(136, 20);
            this.txtmaMV.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Giờ làm thêm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Giờ làm hành chính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Hệ số lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Giờ làm ngày nghỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Giờ làm ngày lễ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lương cơ bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Phụ cấp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Số điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Tên";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Mã NV";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(789, 43);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(121, 20);
            this.txtnam.TabIndex = 20;
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(736, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Năm";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(571, 43);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(509, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Tháng";
            // 
            // LapPhieuLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvNhanVien);
            this.Name = "LapPhieuLuong";
            this.Text = "LapPhieuLuong";
            this.Load += new System.EventHandler(this.LapPhieuLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongluong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtphat;
        private System.Windows.Forms.TextBox txtthuong;
        private System.Windows.Forms.TextBox txtgionghile;
        private System.Windows.Forms.TextBox txtgiongaynghi;
        private System.Windows.Forms.TextBox txtgiolamthem;
        private System.Windows.Forms.TextBox txtgiohanhchinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmaMV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label19;
    }
}