
namespace Qly_luong.ChamCong
{
    partial class CheckOut
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
            this.dtpGioRa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.dgvListCheckout = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giờ ra";
            // 
            // dtpGioRa
            // 
            this.dtpGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioRa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpGioRa.Location = new System.Drawing.Point(518, 92);
            this.dtpGioRa.Name = "dtpGioRa";
            this.dtpGioRa.Size = new System.Drawing.Size(200, 20);
            this.dtpGioRa.TabIndex = 1;
            this.dtpGioRa.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(155, 92);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 4;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Location = new System.Drawing.Point(342, 92);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(100, 20);
            this.txtTenNv.TabIndex = 5;
            // 
            // dgvListCheckout
            // 
            this.dgvListCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoTen,
            this.Ngay,
            this.gioDiLam,
            this.gioDiVe,
            this.ngayLe});
            this.dgvListCheckout.Location = new System.Drawing.Point(3, 215);
            this.dgvListCheckout.Name = "dgvListCheckout";
            this.dgvListCheckout.Size = new System.Drawing.Size(728, 223);
            this.dgvListCheckout.TabIndex = 6;
            this.dgvListCheckout.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCheckout_CellClick);
            this.dgvListCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCheckout_CellContentClick);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(575, 152);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            this.maNV.Width = 80;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 150;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 150;
            // 
            // gioDiLam
            // 
            this.gioDiLam.DataPropertyName = "gioDiLam";
            this.gioDiLam.HeaderText = "Giờ đến";
            this.gioDiLam.Name = "gioDiLam";
            // 
            // gioDiVe
            // 
            this.gioDiVe.DataPropertyName = "gioDiVe";
            this.gioDiVe.HeaderText = "Giờ về";
            this.gioDiVe.Name = "gioDiVe";
            // 
            // ngayLe
            // 
            this.ngayLe.DataPropertyName = "ngayLe";
            this.ngayLe.HeaderText = "Ngày lễ";
            this.ngayLe.Name = "ngayLe";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dgvListCheckout);
            this.Controls.Add(this.txtTenNv);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpGioRa);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.DataGridView dgvListCheckout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLe;
    }
}