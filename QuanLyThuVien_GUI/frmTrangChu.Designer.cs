namespace QuanLyThuVien
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mnuDanhSach = new System.Windows.Forms.MenuStrip();
            this.mniTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.minDangyTT = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDoiMatKhauDG = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLyDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.picHinhTaikhoan = new System.Windows.Forms.PictureBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.mcdNgayThangNam = new System.Windows.Forms.MonthCalendar();
            this.tolTrangChu = new System.Windows.Forms.ToolTip(this.components);
            this.mnuDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Yellow;
            this.lblTieuDe.Location = new System.Drawing.Point(308, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1152, 40);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Quản Lý Thư Viện Sách";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuDanhSach
            // 
            this.mnuDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mnuDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuDanhSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhSach.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuDanhSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTaiKhoan,
            this.mniDanhMuc,
            this.mniThongKe,
            this.mniMuonTra,
            this.mniDangXuat});
            this.mnuDanhSach.Location = new System.Drawing.Point(0, 0);
            this.mnuDanhSach.Name = "mnuDanhSach";
            this.mnuDanhSach.Size = new System.Drawing.Size(308, 670);
            this.mnuDanhSach.TabIndex = 2;
            // 
            // mniTaiKhoan
            // 
            this.mniTaiKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minDangyTT,
            this.mniDoiMatKhauDG});
            this.mniTaiKhoan.Image = global::QuanLyThuVien.Properties.Resources.login1;
            this.mniTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniTaiKhoan.Name = "mniTaiKhoan";
            this.mniTaiKhoan.Size = new System.Drawing.Size(295, 36);
            this.mniTaiKhoan.Text = "Tài Khoản";
            // 
            // minDangyTT
            // 
            this.minDangyTT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.minDangyTT.Image = global::QuanLyThuVien.Properties.Resources.add_icon;
            this.minDangyTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minDangyTT.Name = "minDangyTT";
            this.minDangyTT.Size = new System.Drawing.Size(276, 36);
            this.minDangyTT.Text = "Đăng Ký";
            // 
            // mniDoiMatKhauDG
            // 
            this.mniDoiMatKhauDG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniDoiMatKhauDG.Image = global::QuanLyThuVien.Properties.Resources.Update_icon;
            this.mniDoiMatKhauDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniDoiMatKhauDG.Name = "mniDoiMatKhauDG";
            this.mniDoiMatKhauDG.Size = new System.Drawing.Size(276, 36);
            this.mniDoiMatKhauDG.Text = "Đổi Mật Khẩu";
            // 
            // mniDanhMuc
            // 
            this.mniDanhMuc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniQuanLySach,
            this.mniQuanLyDocGia});
            this.mniDanhMuc.Image = global::QuanLyThuVien.Properties.Resources.Management;
            this.mniDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniDanhMuc.Name = "mniDanhMuc";
            this.mniDanhMuc.Size = new System.Drawing.Size(295, 36);
            this.mniDanhMuc.Text = " Quản Lý Danh Mục";
            // 
            // mniQuanLySach
            // 
            this.mniQuanLySach.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniQuanLySach.Image = global::QuanLyThuVien.Properties.Resources.download;
            this.mniQuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniQuanLySach.Name = "mniQuanLySach";
            this.mniQuanLySach.Size = new System.Drawing.Size(314, 36);
            this.mniQuanLySach.Text = "Quản Lý Sách";
            // 
            // mniQuanLyDocGia
            // 
            this.mniQuanLyDocGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniQuanLyDocGia.Image = global::QuanLyThuVien.Properties.Resources.docgia;
            this.mniQuanLyDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniQuanLyDocGia.Name = "mniQuanLyDocGia";
            this.mniQuanLyDocGia.Size = new System.Drawing.Size(314, 36);
            this.mniQuanLyDocGia.Text = "Quản Lý Độc Giả";
            // 
            // mniThongKe
            // 
            this.mniThongKe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniThongKe.Image = global::QuanLyThuVien.Properties.Resources.HDNhap;
            this.mniThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniThongKe.Name = "mniThongKe";
            this.mniThongKe.Size = new System.Drawing.Size(295, 36);
            this.mniThongKe.Text = "Báo Cáo - Thống Kê";
            // 
            // mniMuonTra
            // 
            this.mniMuonTra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniMuonTra.Image = global::QuanLyThuVien.Properties.Resources.LoaiSua;
            this.mniMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniMuonTra.Name = "mniMuonTra";
            this.mniMuonTra.Size = new System.Drawing.Size(295, 36);
            this.mniMuonTra.Text = "Quản Lý Mượn - Trả";
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mniDangXuat.Image = global::QuanLyThuVien.Properties.Resources.DangXuat;
            this.mniDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(295, 36);
            this.mniDangXuat.Text = "Đăng Xuất";
            // 
            // picHinhTaikhoan
            // 
            this.picHinhTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinhTaikhoan.Location = new System.Drawing.Point(36, 251);
            this.picHinhTaikhoan.Name = "picHinhTaikhoan";
            this.picHinhTaikhoan.Size = new System.Drawing.Size(184, 134);
            this.picHinhTaikhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhTaikhoan.TabIndex = 3;
            this.picHinhTaikhoan.TabStop = false;
            this.tolTrangChu.SetToolTip(this.picHinhTaikhoan, "Hình ảnh tài khoản");
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.ForeColor = System.Drawing.Color.Red;
            this.lblMSSV.Location = new System.Drawing.Point(74, 403);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(99, 20);
            this.lblMSSV.TabIndex = 4;
            this.lblMSSV.Text = "1234567890";
            this.tolTrangChu.SetToolTip(this.lblMSSV, "MSSV của tài khoản");
            // 
            // mcdNgayThangNam
            // 
            this.mcdNgayThangNam.Location = new System.Drawing.Point(0, 461);
            this.mcdNgayThangNam.Name = "mcdNgayThangNam";
            this.mcdNgayThangNam.TabIndex = 5;
            this.tolTrangChu.SetToolTip(this.mcdNgayThangNam, "Lịch ");
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.books_927394_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 670);
            this.Controls.Add(this.mcdNgayThangNam);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.picHinhTaikhoan);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.mnuDanhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Phần Mềm Quản Lý Thư Viện Sách";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.mnuDanhSach.ResumeLayout(false);
            this.mnuDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhTaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.MenuStrip mnuDanhSach;
        private System.Windows.Forms.ToolStripMenuItem mniTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem minDangyTT;
        private System.Windows.Forms.ToolStripMenuItem mniDoiMatKhauDG;
        private System.Windows.Forms.ToolStripMenuItem mniDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem mniMuonTra;
        private System.Windows.Forms.ToolStripMenuItem mniThongKe;
        private System.Windows.Forms.ToolStripMenuItem mniDangXuat;
        private System.Windows.Forms.PictureBox picHinhTaikhoan;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.MonthCalendar mcdNgayThangNam;
        private System.Windows.Forms.ToolTip tolTrangChu;
    }
}