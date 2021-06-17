
namespace Qly_luong.ThuongPhat
{
    partial class ThuongPhatCaNhan
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
            this.DgvPhat = new System.Windows.Forms.DataGridView();
            this.DgvThuong = new System.Windows.Forms.DataGridView();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnXem = new System.Windows.Forms.Button();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPhat
            // 
            this.DgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDung,
            this.mucPhat,
            this.soLan});
            this.DgvPhat.Location = new System.Drawing.Point(6, 19);
            this.DgvPhat.Name = "DgvPhat";
            this.DgvPhat.Size = new System.Drawing.Size(371, 279);
            this.DgvPhat.TabIndex = 0;
            // 
            // DgvThuong
            // 
            this.DgvThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noidungthuong,
            this.mucThuong,
            this.soLanthuong});
            this.DgvThuong.Location = new System.Drawing.Point(6, 19);
            this.DgvThuong.Name = "DgvThuong";
            this.DgvThuong.Size = new System.Drawing.Size(371, 279);
            this.DgvThuong.TabIndex = 1;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(286, 31);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(121, 20);
            this.txtnam.TabIndex = 24;
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(233, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 23;
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
            this.cbbThang.Location = new System.Drawing.Point(68, 31);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(274, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thưởng phạt cá nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.DgvPhat);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 304);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phạt";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.DgvThuong);
            this.groupBox3.Location = new System.Drawing.Point(422, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 304);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thưởng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.txtnam);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cbbThang);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(42, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 81);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // BtnXem
            // 
            this.BtnXem.Location = new System.Drawing.Point(517, 85);
            this.BtnXem.Name = "BtnXem";
            this.BtnXem.Size = new System.Drawing.Size(75, 46);
            this.BtnXem.TabIndex = 30;
            this.BtnXem.Text = "Xem";
            this.BtnXem.UseVisualStyleBackColor = true;
            this.BtnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung phạt";
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 120;
            // 
            // mucPhat
            // 
            this.mucPhat.DataPropertyName = "mucPhat";
            this.mucPhat.HeaderText = "Mức phạt";
            this.mucPhat.Name = "mucPhat";
            // 
            // soLan
            // 
            this.soLan.DataPropertyName = "soLan";
            this.soLan.HeaderText = "Số lần vi phạm";
            this.soLan.Name = "soLan";
            // 
            // noidungthuong
            // 
            this.noidungthuong.DataPropertyName = "noiDung";
            this.noidungthuong.HeaderText = "Nội dung thưởng";
            this.noidungthuong.Name = "noidungthuong";
            this.noidungthuong.Width = 120;
            // 
            // mucThuong
            // 
            this.mucThuong.DataPropertyName = "mucThuong";
            this.mucThuong.HeaderText = "Mức thưởng";
            this.mucThuong.Name = "mucThuong";
            // 
            // soLanthuong
            // 
            this.soLanthuong.DataPropertyName = "soLan";
            this.soLanthuong.HeaderText = "Số lần nhận thưởng";
            this.soLanthuong.Name = "soLanthuong";
            // 
            // ThuongPhatCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.BtnXem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "ThuongPhatCaNhan";
            this.Text = "ThuongPhatCaNhan";
            this.Load += new System.EventHandler(this.ThuongPhatCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvThuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPhat;
        private System.Windows.Forms.DataGridView DgvThuong;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLan;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanthuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnXem;
    }
}