namespace QuanLyThuVien
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.btnTHOAT6 = new System.Windows.Forms.Button();
            this.btnDMKDG6 = new System.Windows.Forms.Button();
            this.grpTKS6 = new System.Windows.Forms.GroupBox();
            this.grpTK6 = new System.Windows.Forms.GroupBox();
            this.txtThongtinDG6 = new System.Windows.Forms.TextBox();
            this.grpTT6 = new System.Windows.Forms.GroupBox();
            this.radTenChuDe6 = new System.Windows.Forms.RadioButton();
            this.radTG6 = new System.Windows.Forms.RadioButton();
            this.radTS6 = new System.Windows.Forms.RadioButton();
            this.radMS6 = new System.Windows.Forms.RadioButton();
            this.grbTTS = new System.Windows.Forms.GroupBox();
            this.dgvThongtinsach6 = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTKS6.SuspendLayout();
            this.grpTK6.SuspendLayout();
            this.grpTT6.SuspendLayout();
            this.grbTTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinsach6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTHOAT6
            // 
            this.btnTHOAT6.BackColor = System.Drawing.Color.Silver;
            this.btnTHOAT6.Image = global::QuanLyThuVien.Properties.Resources.DangXuat;
            this.btnTHOAT6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTHOAT6.Location = new System.Drawing.Point(218, 13);
            this.btnTHOAT6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTHOAT6.Name = "btnTHOAT6";
            this.btnTHOAT6.Size = new System.Drawing.Size(122, 47);
            this.btnTHOAT6.TabIndex = 9;
            this.btnTHOAT6.Text = "Thoát";
            this.btnTHOAT6.UseVisualStyleBackColor = false;
            // 
            // btnDMKDG6
            // 
            this.btnDMKDG6.BackColor = System.Drawing.Color.Silver;
            this.btnDMKDG6.Image = global::QuanLyThuVien.Properties.Resources.Update_icon;
            this.btnDMKDG6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMKDG6.Location = new System.Drawing.Point(22, 13);
            this.btnDMKDG6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDMKDG6.Name = "btnDMKDG6";
            this.btnDMKDG6.Size = new System.Drawing.Size(169, 47);
            this.btnDMKDG6.TabIndex = 8;
            this.btnDMKDG6.Text = "Đổi Mật Khẩu";
            this.btnDMKDG6.UseVisualStyleBackColor = false;
            // 
            // grpTKS6
            // 
            this.grpTKS6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpTKS6.Controls.Add(this.grpTK6);
            this.grpTKS6.Controls.Add(this.grpTT6);
            this.grpTKS6.Location = new System.Drawing.Point(20, 68);
            this.grpTKS6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTKS6.Name = "grpTKS6";
            this.grpTKS6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTKS6.Size = new System.Drawing.Size(1191, 133);
            this.grpTKS6.TabIndex = 10;
            this.grpTKS6.TabStop = false;
            this.grpTKS6.Text = "Tìm Kiếm Sách";
            // 
            // grpTK6
            // 
            this.grpTK6.Controls.Add(this.txtThongtinDG6);
            this.grpTK6.Location = new System.Drawing.Point(600, 28);
            this.grpTK6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTK6.Name = "grpTK6";
            this.grpTK6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTK6.Size = new System.Drawing.Size(576, 72);
            this.grpTK6.TabIndex = 1;
            this.grpTK6.TabStop = false;
            this.grpTK6.Text = "Nhập Thông Tin Cần Tìm Kiếm";
            // 
            // txtThongtinDG6
            // 
            this.txtThongtinDG6.Location = new System.Drawing.Point(21, 28);
            this.txtThongtinDG6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThongtinDG6.Name = "txtThongtinDG6";
            this.txtThongtinDG6.Size = new System.Drawing.Size(425, 27);
            this.txtThongtinDG6.TabIndex = 6;
            // 
            // grpTT6
            // 
            this.grpTT6.Controls.Add(this.radTenChuDe6);
            this.grpTT6.Controls.Add(this.radTG6);
            this.grpTT6.Controls.Add(this.radTS6);
            this.grpTT6.Controls.Add(this.radMS6);
            this.grpTT6.Location = new System.Drawing.Point(14, 28);
            this.grpTT6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTT6.Name = "grpTT6";
            this.grpTT6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTT6.Size = new System.Drawing.Size(541, 72);
            this.grpTT6.TabIndex = 0;
            this.grpTT6.TabStop = false;
            this.grpTT6.Text = "Tìm Theo";
            // 
            // radTenChuDe6
            // 
            this.radTenChuDe6.AutoSize = true;
            this.radTenChuDe6.Location = new System.Drawing.Point(379, 29);
            this.radTenChuDe6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTenChuDe6.Name = "radTenChuDe6";
            this.radTenChuDe6.Size = new System.Drawing.Size(82, 23);
            this.radTenChuDe6.TabIndex = 5;
            this.radTenChuDe6.TabStop = true;
            this.radTenChuDe6.Text = "Tên CĐ";
            this.radTenChuDe6.UseVisualStyleBackColor = true;
            // 
            // radTG6
            // 
            this.radTG6.AutoSize = true;
            this.radTG6.Location = new System.Drawing.Point(255, 29);
            this.radTG6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTG6.Name = "radTG6";
            this.radTG6.Size = new System.Drawing.Size(80, 23);
            this.radTG6.TabIndex = 4;
            this.radTG6.TabStop = true;
            this.radTG6.Text = "Tên TG";
            this.radTG6.UseVisualStyleBackColor = true;
            // 
            // radTS6
            // 
            this.radTS6.AutoSize = true;
            this.radTS6.Location = new System.Drawing.Point(132, 29);
            this.radTS6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTS6.Name = "radTS6";
            this.radTS6.Size = new System.Drawing.Size(91, 23);
            this.radTS6.TabIndex = 3;
            this.radTS6.TabStop = true;
            this.radTS6.Text = "Tên Sách";
            this.radTS6.UseVisualStyleBackColor = true;
            // 
            // radMS6
            // 
            this.radMS6.AutoSize = true;
            this.radMS6.Location = new System.Drawing.Point(8, 29);
            this.radMS6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radMS6.Name = "radMS6";
            this.radMS6.Size = new System.Drawing.Size(88, 23);
            this.radMS6.TabIndex = 2;
            this.radMS6.TabStop = true;
            this.radMS6.Text = "Mã Sách";
            this.radMS6.UseVisualStyleBackColor = true;
            // 
            // grbTTS
            // 
            this.grbTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTS.Controls.Add(this.dgvThongtinsach6);
            this.grbTTS.Location = new System.Drawing.Point(22, 220);
            this.grbTTS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTS.Name = "grbTTS";
            this.grbTTS.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTS.Size = new System.Drawing.Size(1194, 367);
            this.grbTTS.TabIndex = 11;
            this.grbTTS.TabStop = false;
            this.grbTTS.Text = "Thông tin Sách";
            // 
            // dgvThongtinsach6
            // 
            this.dgvThongtinsach6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinsach6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colChuDe,
            this.colTacGia,
            this.colNXB,
            this.colNamXB,
            this.colDonGia,
            this.colTinhTrang,
            this.colGhiChu});
            this.dgvThongtinsach6.Location = new System.Drawing.Point(7, 21);
            this.dgvThongtinsach6.Name = "dgvThongtinsach6";
            this.dgvThongtinsach6.RowHeadersWidth = 51;
            this.dgvThongtinsach6.RowTemplate.Height = 24;
            this.dgvThongtinsach6.Size = new System.Drawing.Size(1172, 333);
            this.dgvThongtinsach6.TabIndex = 7;
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "Mã Sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Width = 125;
            // 
            // colTenSach
            // 
            this.colTenSach.HeaderText = "Tên Sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Width = 125;
            // 
            // colChuDe
            // 
            this.colChuDe.HeaderText = "Chủ Đề";
            this.colChuDe.MinimumWidth = 6;
            this.colChuDe.Name = "colChuDe";
            this.colChuDe.Width = 125;
            // 
            // colTacGia
            // 
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.MinimumWidth = 6;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 125;
            // 
            // colNXB
            // 
            this.colNXB.HeaderText = "NXB";
            this.colNXB.MinimumWidth = 6;
            this.colNXB.Name = "colNXB";
            this.colNXB.Width = 125;
            // 
            // colNamXB
            // 
            this.colNamXB.HeaderText = "Năm XB";
            this.colNamXB.MinimumWidth = 6;
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Width = 125;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 125;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Controls.Add(this.btnTHOAT6);
            this.Controls.Add(this.btnDMKDG6);
            this.Controls.Add(this.grpTKS6);
            this.Controls.Add(this.grbTTS);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Độc Giả";
            this.grpTKS6.ResumeLayout(false);
            this.grpTK6.ResumeLayout(false);
            this.grpTK6.PerformLayout();
            this.grpTT6.ResumeLayout(false);
            this.grpTT6.PerformLayout();
            this.grbTTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinsach6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTHOAT6;
        private System.Windows.Forms.Button btnDMKDG6;
        private System.Windows.Forms.GroupBox grpTKS6;
        private System.Windows.Forms.GroupBox grpTK6;
        private System.Windows.Forms.TextBox txtThongtinDG6;
        private System.Windows.Forms.GroupBox grpTT6;
        private System.Windows.Forms.RadioButton radTenChuDe6;
        private System.Windows.Forms.RadioButton radTG6;
        private System.Windows.Forms.RadioButton radTS6;
        private System.Windows.Forms.RadioButton radMS6;
        private System.Windows.Forms.GroupBox grbTTS;
        private System.Windows.Forms.DataGridView dgvThongtinsach6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}