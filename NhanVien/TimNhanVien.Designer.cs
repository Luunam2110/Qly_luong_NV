
namespace Qly_luong.NhanVien
{
    partial class TimNhanVien
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
            this.cbgt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsdt = new System.Windows.Forms.CheckBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbdiachi = new System.Windows.Forms.CheckBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbngaysinh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbten = new System.Windows.Forms.CheckBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbma = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApDung = new System.Windows.Forms.Button();
            this.cbbGt = new System.Windows.Forms.ComboBox();
            this.dtNgS = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbgt
            // 
            this.cbgt.AutoSize = true;
            this.cbgt.Location = new System.Drawing.Point(397, 220);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(110, 17);
            this.cbgt.TabIndex = 42;
            this.cbgt.Text = "Tìm theo Giới tính";
            this.cbgt.UseVisualStyleBackColor = true;
            this.cbgt.CheckedChanged += new System.EventHandler(this.cbgt_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giới tính";
            // 
            // cbsdt
            // 
            this.cbsdt.AutoSize = true;
            this.cbsdt.Location = new System.Drawing.Point(397, 146);
            this.cbsdt.Name = "cbsdt";
            this.cbsdt.Size = new System.Drawing.Size(131, 17);
            this.cbsdt.TabIndex = 39;
            this.cbsdt.Text = "Tìm theo số điện thoại";
            this.cbsdt.UseVisualStyleBackColor = true;
            this.cbsdt.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(465, 176);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(154, 20);
            this.txtsdt.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "SĐT";
            // 
            // cbdiachi
            // 
            this.cbdiachi.AutoSize = true;
            this.cbdiachi.Location = new System.Drawing.Point(397, 81);
            this.cbdiachi.Name = "cbdiachi";
            this.cbdiachi.Size = new System.Drawing.Size(102, 17);
            this.cbdiachi.TabIndex = 36;
            this.cbdiachi.Text = "Tìm theo địa chỉ";
            this.cbdiachi.UseVisualStyleBackColor = true;
            this.cbdiachi.CheckedChanged += new System.EventHandler(this.cbdiachi_CheckedChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Location = new System.Drawing.Point(465, 106);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(154, 20);
            this.txtdiachi.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Địa chỉ";
            // 
            // cbngaysinh
            // 
            this.cbngaysinh.AutoSize = true;
            this.cbngaysinh.Location = new System.Drawing.Point(65, 220);
            this.cbngaysinh.Name = "cbngaysinh";
            this.cbngaysinh.Size = new System.Drawing.Size(115, 17);
            this.cbngaysinh.TabIndex = 33;
            this.cbngaysinh.Text = "Tìm theo ngày sinh";
            this.cbngaysinh.UseVisualStyleBackColor = true;
            this.cbngaysinh.CheckedChanged += new System.EventHandler(this.cbngaysinh_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ngày sinh";
            // 
            // cbten
            // 
            this.cbten.AutoSize = true;
            this.cbten.Location = new System.Drawing.Point(65, 148);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(100, 17);
            this.cbten.TabIndex = 30;
            this.cbten.Text = "Tìm theo họ tên";
            this.cbten.UseVisualStyleBackColor = true;
            this.cbten.CheckedChanged += new System.EventHandler(this.cbten_CheckedChanged);
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(139, 173);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(136, 20);
            this.txtten.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên nhân viên";
            // 
            // cbma
            // 
            this.cbma.AutoSize = true;
            this.cbma.Location = new System.Drawing.Point(65, 81);
            this.cbma.Name = "cbma";
            this.cbma.Size = new System.Drawing.Size(134, 17);
            this.cbma.TabIndex = 27;
            this.cbma.Text = "Tìm theo mã nhân viên";
            this.cbma.UseVisualStyleBackColor = true;
            this.cbma.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(139, 106);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(136, 20);
            this.txtMaNV.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã NV";
            // 
            // btnApDung
            // 
            this.btnApDung.Location = new System.Drawing.Point(397, 319);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(75, 23);
            this.btnApDung.TabIndex = 43;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // cbbGt
            // 
            this.cbbGt.Enabled = false;
            this.cbbGt.FormattingEnabled = true;
            this.cbbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGt.Location = new System.Drawing.Point(465, 245);
            this.cbbGt.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGt.Name = "cbbGt";
            this.cbbGt.Size = new System.Drawing.Size(154, 21);
            this.cbbGt.TabIndex = 44;
            // 
            // dtNgS
            // 
            this.dtNgS.Enabled = false;
            this.dtNgS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgS.Location = new System.Drawing.Point(139, 248);
            this.dtNgS.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgS.Name = "dtNgS";
            this.dtNgS.Size = new System.Drawing.Size(136, 20);
            this.dtNgS.TabIndex = 45;
            this.dtNgS.ValueChanged += new System.EventHandler(this.dtNgS_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(258, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Lọc nhân viên";
            // 
            // TimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 370);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgS);
            this.Controls.Add(this.cbbGt);
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.cbgt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbsdt);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbdiachi);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbngaysinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbten);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbma);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Name = "TimNhanVien";
            this.Text = "TimNhanVien";
            this.Load += new System.EventHandler(this.TimNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbgt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbsdt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbdiachi;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbten;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbma;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.ComboBox cbbGt;
        private System.Windows.Forms.DateTimePicker dtNgS;
        private System.Windows.Forms.Label label7;
    }
}