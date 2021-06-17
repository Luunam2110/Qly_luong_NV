
namespace Qly_luong.ThuongPhat
{
    partial class ThemPhat
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtnThem = new System.Windows.Forms.Button();
            this.DgvPhat = new System.Windows.Forms.DataGridView();
            this.txtMucphat = new System.Windows.Forms.TextBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(198, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thêm Phạt";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(433, 163);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 17;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // DgvPhat
            // 
            this.DgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhat,
            this.noiDung,
            this.mucPhat});
            this.DgvPhat.Location = new System.Drawing.Point(43, 200);
            this.DgvPhat.Name = "DgvPhat";
            this.DgvPhat.Size = new System.Drawing.Size(465, 238);
            this.DgvPhat.TabIndex = 16;
            this.DgvPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhat_CellContentClick);
            // 
            // txtMucphat
            // 
            this.txtMucphat.Location = new System.Drawing.Point(139, 106);
            this.txtMucphat.Name = "txtMucphat";
            this.txtMucphat.Size = new System.Drawing.Size(100, 20);
            this.txtMucphat.TabIndex = 15;
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(338, 68);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(188, 77);
            this.txtNoidung.TabIndex = 14;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(139, 68);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mức Phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nội dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phạt";
            // 
            // maPhat
            // 
            this.maPhat.DataPropertyName = "maPhat";
            this.maPhat.HeaderText = "Mã phạt";
            this.maPhat.Name = "maPhat";
            this.maPhat.Width = 110;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 200;
            // 
            // mucPhat
            // 
            this.mucPhat.DataPropertyName = "mucPhat";
            this.mucPhat.HeaderText = "Mức phạt";
            this.mucPhat.Name = "mucPhat";
            this.mucPhat.Width = 110;
            // 
            // ThemPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.DgvPhat);
            this.Controls.Add(this.txtMucphat);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "ThemPhat";
            this.Text = "ThemPhat";
            this.Load += new System.EventHandler(this.ThemPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DataGridView DgvPhat;
        private System.Windows.Forms.TextBox txtMucphat;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucPhat;
    }
}