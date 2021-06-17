
namespace Qly_luong.Luong
{
    partial class DSPhieuLuong
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
            this.btnTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPhieuLuong = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioHanhChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioLamThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioNgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioNgayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhieuLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1063, 65);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 23);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Áp dụng";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(286, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh sách phiếu lương";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(619, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem của 1 nhân viên";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Tìm theo nhân viên";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(145, 60);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã NV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem theo tháng";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(363, 37);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(121, 20);
            this.txtnam.TabIndex = 3;
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
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
            this.cbbThang.Location = new System.Drawing.Point(93, 36);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // DgvPhieuLuong
            // 
            this.DgvPhieuLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhieuLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoTen,
            this.SDT,
            this.heSoLuong,
            this.phuCap,
            this.luongCB,
            this.soGioHanhChinh,
            this.soGioLamThem,
            this.soGioNgayNghi,
            this.soGioNgayLe,
            this.thuong,
            this.phat,
            this.tongluong});
            this.DgvPhieuLuong.Location = new System.Drawing.Point(12, 196);
            this.DgvPhieuLuong.Name = "DgvPhieuLuong";
            this.DgvPhieuLuong.Size = new System.Drawing.Size(1265, 404);
            this.DgvPhieuLuong.TabIndex = 6;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.Name = "hoTen";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // heSoLuong
            // 
            this.heSoLuong.DataPropertyName = "heSoLuong";
            this.heSoLuong.HeaderText = "Hệ số lương";
            this.heSoLuong.Name = "heSoLuong";
            // 
            // phuCap
            // 
            this.phuCap.DataPropertyName = "phuCap";
            this.phuCap.HeaderText = "Phụ cấp";
            this.phuCap.Name = "phuCap";
            this.phuCap.Width = 70;
            // 
            // luongCB
            // 
            this.luongCB.HeaderText = "Lương cơ bản";
            this.luongCB.Name = "luongCB";
            // 
            // soGioHanhChinh
            // 
            this.soGioHanhChinh.DataPropertyName = "soGioHanhChinh";
            this.soGioHanhChinh.HeaderText = "Giờ làm hành chính";
            this.soGioHanhChinh.Name = "soGioHanhChinh";
            this.soGioHanhChinh.Width = 110;
            // 
            // soGioLamThem
            // 
            this.soGioLamThem.DataPropertyName = "soGioLamThem";
            this.soGioLamThem.HeaderText = "Giờ làm thêm";
            this.soGioLamThem.Name = "soGioLamThem";
            this.soGioLamThem.Width = 110;
            // 
            // soGioNgayNghi
            // 
            this.soGioNgayNghi.DataPropertyName = "soGioNgayNghi";
            this.soGioNgayNghi.HeaderText = "Giờ làm ngày nghỉ";
            this.soGioNgayNghi.Name = "soGioNgayNghi";
            this.soGioNgayNghi.Width = 110;
            // 
            // soGioNgayLe
            // 
            this.soGioNgayLe.DataPropertyName = "soGioNgayLe";
            this.soGioNgayLe.HeaderText = "Giờ làm ngày lễ";
            this.soGioNgayLe.Name = "soGioNgayLe";
            this.soGioNgayLe.Width = 110;
            // 
            // thuong
            // 
            this.thuong.DataPropertyName = "thuong";
            this.thuong.HeaderText = "Thưởng";
            this.thuong.Name = "thuong";
            // 
            // phat
            // 
            this.phat.DataPropertyName = "phat";
            this.phat.HeaderText = "Phạt";
            this.phat.Name = "phat";
            // 
            // tongluong
            // 
            this.tongluong.DataPropertyName = "tongluong";
            this.tongluong.HeaderText = "Tổng Lương";
            this.tongluong.Name = "tongluong";
            this.tongluong.Width = 110;
            // 
            // DSPhieuLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 610);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvPhieuLuong);
            this.Name = "DSPhieuLuong";
            this.Text = "DSPhieuLuong";
            this.Load += new System.EventHandler(this.DSPhieuLuong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhieuLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPhieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioHanhChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioLamThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioNgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioNgayLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
    }
}