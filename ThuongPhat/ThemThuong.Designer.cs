
namespace Qly_luong.ThuongPhat
{
    partial class ThemThuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.txtMucthuong = new System.Windows.Forms.TextBox();
            this.DgvThuong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnThem = new System.Windows.Forms.Button();
            this.maThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mức Thưởng";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(129, 65);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 3;
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(328, 65);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(188, 77);
            this.txtNoidung.TabIndex = 4;
            // 
            // txtMucthuong
            // 
            this.txtMucthuong.Location = new System.Drawing.Point(129, 103);
            this.txtMucthuong.Name = "txtMucthuong";
            this.txtMucthuong.Size = new System.Drawing.Size(100, 20);
            this.txtMucthuong.TabIndex = 5;
            this.txtMucthuong.TextChanged += new System.EventHandler(this.txtMucthuong_TextChanged);
            this.txtMucthuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucthuong_KeyPress);
            // 
            // DgvThuong
            // 
            this.DgvThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuong,
            this.noiDung,
            this.mucThuong});
            this.DgvThuong.Location = new System.Drawing.Point(51, 200);
            this.DgvThuong.Name = "DgvThuong";
            this.DgvThuong.Size = new System.Drawing.Size(465, 238);
            this.DgvThuong.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(180, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thêm Thưởng";
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(423, 160);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 9;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // maThuong
            // 
            this.maThuong.DataPropertyName = "maThuong";
            this.maThuong.HeaderText = "Mã Thưởng";
            this.maThuong.Name = "maThuong";
            this.maThuong.Width = 110;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 200;
            // 
            // mucThuong
            // 
            this.mucThuong.DataPropertyName = "mucThuong";
            this.mucThuong.HeaderText = "Mức thưởng";
            this.mucThuong.Name = "mucThuong";
            this.mucThuong.Width = 110;
            // 
            // ThemThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvThuong);
            this.Controls.Add(this.txtMucthuong);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemThuong";
            this.Text = "ThemThuong";
            this.Load += new System.EventHandler(this.ThemThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.TextBox txtMucthuong;
        private System.Windows.Forms.DataGridView DgvThuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucThuong;
    }
}