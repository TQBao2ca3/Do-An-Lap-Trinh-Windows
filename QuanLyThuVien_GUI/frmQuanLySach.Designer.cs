namespace QuanLyThuVien
{
    partial class frmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            this.txtGC = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.grbDSS = new System.Windows.Forms.GroupBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.grpTimkiemsach = new System.Windows.Forms.GroupBox();
            this.grpTimkiemsach2 = new System.Windows.Forms.GroupBox();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.grpTimtheosach1 = new System.Windows.Forms.GroupBox();
            this.radTCD1 = new System.Windows.Forms.RadioButton();
            this.radTG1 = new System.Windows.Forms.RadioButton();
            this.radTS1 = new System.Windows.Forms.RadioButton();
            this.radMS1 = new System.Windows.Forms.RadioButton();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.lblGC1 = new System.Windows.Forms.Label();
            this.lblTT1 = new System.Windows.Forms.Label();
            this.lblDG1 = new System.Windows.Forms.Label();
            this.lblSLN1 = new System.Windows.Forms.Label();
            this.lblCD1 = new System.Windows.Forms.Label();
            this.grpThongtinS = new System.Windows.Forms.GroupBox();
            this.lblNamXB1 = new System.Windows.Forms.Label();
            this.lblNXB1 = new System.Windows.Forms.Label();
            this.lblTG1 = new System.Windows.Forms.Label();
            this.lblTS1 = new System.Windows.Forms.Label();
            this.lblMS1 = new System.Windows.Forms.Label();
            this.btnLoadS = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnHomeS = new System.Windows.Forms.Button();
            this.grbDSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.grpTimkiemsach.SuspendLayout();
            this.grpTimkiemsach2.SuspendLayout();
            this.grpTimtheosach1.SuspendLayout();
            this.grpThongtinS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(657, 217);
            this.txtGC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(272, 27);
            this.txtGC.TabIndex = 19;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(656, 170);
            this.txtTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(272, 27);
            this.txtTT.TabIndex = 18;
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(656, 123);
            this.txtDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(272, 27);
            this.txtDG.TabIndex = 17;
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(657, 76);
            this.txtSLN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(272, 27);
            this.txtSLN.TabIndex = 16;
            // 
            // grbDSS
            // 
            this.grbDSS.Controls.Add(this.dgvDSSach);
            this.grbDSS.Location = new System.Drawing.Point(28, 471);
            this.grbDSS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDSS.Name = "grbDSS";
            this.grbDSS.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDSS.Size = new System.Drawing.Size(1008, 170);
            this.grbDSS.TabIndex = 17;
            this.grbDSS.TabStop = false;
            this.grbDSS.Text = "Danh sách Sách";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colChuDe,
            this.colTacGia,
            this.colNXB,
            this.colNamXB,
            this.colSLNhap,
            this.colDonGia,
            this.colTinhTrang,
            this.colGhiChu});
            this.dgvDSSach.Location = new System.Drawing.Point(16, 21);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.RowHeadersWidth = 51;
            this.dgvDSSach.RowTemplate.Height = 24;
            this.dgvDSSach.Size = new System.Drawing.Size(979, 140);
            this.dgvDSSach.TabIndex = 0;
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
            // colSLNhap
            // 
            this.colSLNhap.HeaderText = "SL Nhập";
            this.colSLNhap.MinimumWidth = 6;
            this.colSLNhap.Name = "colSLNhap";
            this.colSLNhap.Width = 125;
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
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(153, 123);
            this.txtCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(272, 27);
            this.txtCD.TabIndex = 12;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(153, 217);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(272, 27);
            this.txtNXB.TabIndex = 14;
            // 
            // grpTimkiemsach
            // 
            this.grpTimkiemsach.Controls.Add(this.grpTimkiemsach2);
            this.grpTimkiemsach.Controls.Add(this.grpTimtheosach1);
            this.grpTimkiemsach.Location = new System.Drawing.Point(35, 1);
            this.grpTimkiemsach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimkiemsach.Name = "grpTimkiemsach";
            this.grpTimkiemsach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimkiemsach.Size = new System.Drawing.Size(1001, 106);
            this.grpTimkiemsach.TabIndex = 9;
            this.grpTimkiemsach.TabStop = false;
            this.grpTimkiemsach.Text = "Tìm Kiếm Sách";
            // 
            // grpTimkiemsach2
            // 
            this.grpTimkiemsach2.Controls.Add(this.txtTimSach);
            this.grpTimkiemsach2.Location = new System.Drawing.Point(589, 26);
            this.grpTimkiemsach2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimkiemsach2.Name = "grpTimkiemsach2";
            this.grpTimkiemsach2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimkiemsach2.Size = new System.Drawing.Size(399, 66);
            this.grpTimkiemsach2.TabIndex = 1;
            this.grpTimkiemsach2.TabStop = false;
            this.grpTimkiemsach2.Text = "Nhập Thông Tin Tìm Kiếm";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(8, 26);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(385, 27);
            this.txtTimSach.TabIndex = 0;
            // 
            // grpTimtheosach1
            // 
            this.grpTimtheosach1.Controls.Add(this.radTCD1);
            this.grpTimtheosach1.Controls.Add(this.radTG1);
            this.grpTimtheosach1.Controls.Add(this.radTS1);
            this.grpTimtheosach1.Controls.Add(this.radMS1);
            this.grpTimtheosach1.Location = new System.Drawing.Point(53, 26);
            this.grpTimtheosach1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimtheosach1.Name = "grpTimtheosach1";
            this.grpTimtheosach1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTimtheosach1.Size = new System.Drawing.Size(486, 66);
            this.grpTimtheosach1.TabIndex = 0;
            this.grpTimtheosach1.TabStop = false;
            this.grpTimtheosach1.Text = "Tìm Theo";
            // 
            // radTCD1
            // 
            this.radTCD1.AutoSize = true;
            this.radTCD1.Location = new System.Drawing.Point(376, 26);
            this.radTCD1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTCD1.Name = "radTCD1";
            this.radTCD1.Size = new System.Drawing.Size(82, 23);
            this.radTCD1.TabIndex = 3;
            this.radTCD1.TabStop = true;
            this.radTCD1.Text = "Tên CĐ";
            this.radTCD1.UseVisualStyleBackColor = true;
            // 
            // radTG1
            // 
            this.radTG1.AutoSize = true;
            this.radTG1.Location = new System.Drawing.Point(253, 26);
            this.radTG1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTG1.Name = "radTG1";
            this.radTG1.Size = new System.Drawing.Size(80, 23);
            this.radTG1.TabIndex = 2;
            this.radTG1.TabStop = true;
            this.radTG1.Text = "Tên TG";
            this.radTG1.UseVisualStyleBackColor = true;
            // 
            // radTS1
            // 
            this.radTS1.AutoSize = true;
            this.radTS1.Location = new System.Drawing.Point(130, 26);
            this.radTS1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTS1.Name = "radTS1";
            this.radTS1.Size = new System.Drawing.Size(91, 23);
            this.radTS1.TabIndex = 1;
            this.radTS1.TabStop = true;
            this.radTS1.Text = "Tên Sách";
            this.radTS1.UseVisualStyleBackColor = true;
            // 
            // radMS1
            // 
            this.radMS1.AutoSize = true;
            this.radMS1.Location = new System.Drawing.Point(8, 26);
            this.radMS1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radMS1.Name = "radMS1";
            this.radMS1.Size = new System.Drawing.Size(88, 23);
            this.radMS1.TabIndex = 0;
            this.radMS1.TabStop = true;
            this.radMS1.Text = "Mã Sách";
            this.radMS1.UseVisualStyleBackColor = true;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(657, 29);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(272, 27);
            this.txtNamXB.TabIndex = 15;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(153, 170);
            this.txtTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(272, 27);
            this.txtTG.TabIndex = 13;
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(153, 76);
            this.txtTS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(272, 27);
            this.txtTS.TabIndex = 11;
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(153, 29);
            this.txtMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(272, 27);
            this.txtMS.TabIndex = 10;
            // 
            // lblGC1
            // 
            this.lblGC1.AutoSize = true;
            this.lblGC1.Location = new System.Drawing.Point(540, 221);
            this.lblGC1.Name = "lblGC1";
            this.lblGC1.Size = new System.Drawing.Size(70, 19);
            this.lblGC1.TabIndex = 9;
            this.lblGC1.Text = "Ghi Chú:";
            // 
            // lblTT1
            // 
            this.lblTT1.AutoSize = true;
            this.lblTT1.Location = new System.Drawing.Point(540, 175);
            this.lblTT1.Name = "lblTT1";
            this.lblTT1.Size = new System.Drawing.Size(85, 19);
            this.lblTT1.TabIndex = 8;
            this.lblTT1.Text = "Tình Trạng:";
            // 
            // lblDG1
            // 
            this.lblDG1.AutoSize = true;
            this.lblDG1.Location = new System.Drawing.Point(540, 129);
            this.lblDG1.Name = "lblDG1";
            this.lblDG1.Size = new System.Drawing.Size(71, 19);
            this.lblDG1.TabIndex = 7;
            this.lblDG1.Text = "Đơn Giá:";
            // 
            // lblSLN1
            // 
            this.lblSLN1.AutoSize = true;
            this.lblSLN1.Location = new System.Drawing.Point(540, 83);
            this.lblSLN1.Name = "lblSLN1";
            this.lblSLN1.Size = new System.Drawing.Size(71, 19);
            this.lblSLN1.TabIndex = 6;
            this.lblSLN1.Text = "SL Nhập:";
            this.lblSLN1.Click += new System.EventHandler(this.lblSLN_Click);
            // 
            // lblCD1
            // 
            this.lblCD1.AutoSize = true;
            this.lblCD1.Location = new System.Drawing.Point(56, 129);
            this.lblCD1.Name = "lblCD1";
            this.lblCD1.Size = new System.Drawing.Size(65, 19);
            this.lblCD1.TabIndex = 5;
            this.lblCD1.Text = "Chủ Đề:";
            // 
            // grpThongtinS
            // 
            this.grpThongtinS.Controls.Add(this.txtGC);
            this.grpThongtinS.Controls.Add(this.txtTT);
            this.grpThongtinS.Controls.Add(this.txtDG);
            this.grpThongtinS.Controls.Add(this.txtSLN);
            this.grpThongtinS.Controls.Add(this.txtCD);
            this.grpThongtinS.Controls.Add(this.txtNamXB);
            this.grpThongtinS.Controls.Add(this.txtNXB);
            this.grpThongtinS.Controls.Add(this.txtTG);
            this.grpThongtinS.Controls.Add(this.txtTS);
            this.grpThongtinS.Controls.Add(this.txtMS);
            this.grpThongtinS.Controls.Add(this.lblGC1);
            this.grpThongtinS.Controls.Add(this.lblTT1);
            this.grpThongtinS.Controls.Add(this.lblDG1);
            this.grpThongtinS.Controls.Add(this.lblSLN1);
            this.grpThongtinS.Controls.Add(this.lblCD1);
            this.grpThongtinS.Controls.Add(this.lblNamXB1);
            this.grpThongtinS.Controls.Add(this.lblNXB1);
            this.grpThongtinS.Controls.Add(this.lblTG1);
            this.grpThongtinS.Controls.Add(this.lblTS1);
            this.grpThongtinS.Controls.Add(this.lblMS1);
            this.grpThongtinS.Location = new System.Drawing.Point(28, 159);
            this.grpThongtinS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongtinS.Name = "grpThongtinS";
            this.grpThongtinS.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongtinS.Size = new System.Drawing.Size(1008, 254);
            this.grpThongtinS.TabIndex = 12;
            this.grpThongtinS.TabStop = false;
            this.grpThongtinS.Text = "Thông Tin Sách";
            // 
            // lblNamXB1
            // 
            this.lblNamXB1.AutoSize = true;
            this.lblNamXB1.Location = new System.Drawing.Point(540, 37);
            this.lblNamXB1.Name = "lblNamXB1";
            this.lblNamXB1.Size = new System.Drawing.Size(73, 19);
            this.lblNamXB1.TabIndex = 4;
            this.lblNamXB1.Text = "Năm XB:";
            // 
            // lblNXB1
            // 
            this.lblNXB1.AutoSize = true;
            this.lblNXB1.Location = new System.Drawing.Point(56, 221);
            this.lblNXB1.Name = "lblNXB1";
            this.lblNXB1.Size = new System.Drawing.Size(49, 19);
            this.lblNXB1.TabIndex = 3;
            this.lblNXB1.Text = "NXB:";
            // 
            // lblTG1
            // 
            this.lblTG1.AutoSize = true;
            this.lblTG1.Location = new System.Drawing.Point(56, 175);
            this.lblTG1.Name = "lblTG1";
            this.lblTG1.Size = new System.Drawing.Size(66, 19);
            this.lblTG1.TabIndex = 2;
            this.lblTG1.Text = "Tác Giả:";
            // 
            // lblTS1
            // 
            this.lblTS1.AutoSize = true;
            this.lblTS1.Location = new System.Drawing.Point(56, 83);
            this.lblTS1.Name = "lblTS1";
            this.lblTS1.Size = new System.Drawing.Size(75, 19);
            this.lblTS1.TabIndex = 1;
            this.lblTS1.Text = "Tên Sách:";
            // 
            // lblMS1
            // 
            this.lblMS1.AutoSize = true;
            this.lblMS1.Location = new System.Drawing.Point(56, 37);
            this.lblMS1.Name = "lblMS1";
            this.lblMS1.Size = new System.Drawing.Size(72, 19);
            this.lblMS1.TabIndex = 0;
            this.lblMS1.Text = "Mã Sách:";
            // 
            // btnLoadS
            // 
            this.btnLoadS.BackColor = System.Drawing.Color.Silver;
            this.btnLoadS.ForeColor = System.Drawing.Color.Black;
            this.btnLoadS.Image = global::QuanLyThuVien.Properties.Resources.reset;
            this.btnLoadS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadS.Location = new System.Drawing.Point(591, 115);
            this.btnLoadS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadS.Name = "btnLoadS";
            this.btnLoadS.Size = new System.Drawing.Size(163, 42);
            this.btnLoadS.TabIndex = 11;
            this.btnLoadS.Text = "Load Danh Sách";
            this.btnLoadS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadS.UseVisualStyleBackColor = false;
            // 
            // btnLUU
            // 
            this.btnLUU.BackColor = System.Drawing.Color.Silver;
            this.btnLUU.Image = global::QuanLyThuVien.Properties.Resources.Save_icon;
            this.btnLUU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLUU.Location = new System.Drawing.Point(703, 421);
            this.btnLUU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(90, 42);
            this.btnLUU.TabIndex = 16;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLUU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLUU.UseVisualStyleBackColor = false;
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.Silver;
            this.btnXOA.Image = global::QuanLyThuVien.Properties.Resources.delete;
            this.btnXOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXOA.Location = new System.Drawing.Point(572, 421);
            this.btnXOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(90, 42);
            this.btnXOA.TabIndex = 15;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXOA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXOA.UseVisualStyleBackColor = false;
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.Silver;
            this.btnSUA.Image = global::QuanLyThuVien.Properties.Resources.edit;
            this.btnSUA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSUA.Location = new System.Drawing.Point(441, 421);
            this.btnSUA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(90, 42);
            this.btnSUA.TabIndex = 14;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSUA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSUA.UseVisualStyleBackColor = false;
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.Silver;
            this.btnTHEM.Image = global::QuanLyThuVien.Properties.Resources.add;
            this.btnTHEM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTHEM.Location = new System.Drawing.Point(310, 421);
            this.btnTHEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(90, 42);
            this.btnTHEM.TabIndex = 13;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTHEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTHEM.UseVisualStyleBackColor = false;
            // 
            // btnHomeS
            // 
            this.btnHomeS.BackColor = System.Drawing.Color.Silver;
            this.btnHomeS.Image = global::QuanLyThuVien.Properties.Resources.OIP;
            this.btnHomeS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeS.Location = new System.Drawing.Point(453, 115);
            this.btnHomeS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomeS.Name = "btnHomeS";
            this.btnHomeS.Size = new System.Drawing.Size(93, 42);
            this.btnHomeS.TabIndex = 10;
            this.btnHomeS.Text = "Home";
            this.btnHomeS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomeS.UseVisualStyleBackColor = false;
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 670);
            this.Controls.Add(this.btnLoadS);
            this.Controls.Add(this.grbDSS);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnHomeS);
            this.Controls.Add(this.grpTimkiemsach);
            this.Controls.Add(this.grpThongtinS);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.grbDSS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.grpTimkiemsach.ResumeLayout(false);
            this.grpTimkiemsach2.ResumeLayout(false);
            this.grpTimkiemsach2.PerformLayout();
            this.grpTimtheosach1.ResumeLayout(false);
            this.grpTimtheosach1.PerformLayout();
            this.grpThongtinS.ResumeLayout(false);
            this.grpThongtinS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadS;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSLN;
        private System.Windows.Forms.GroupBox grbDSS;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnHomeS;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.GroupBox grpTimkiemsach;
        private System.Windows.Forms.GroupBox grpTimkiemsach2;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.GroupBox grpTimtheosach1;
        private System.Windows.Forms.RadioButton radTCD1;
        private System.Windows.Forms.RadioButton radTG1;
        private System.Windows.Forms.RadioButton radTS1;
        private System.Windows.Forms.RadioButton radMS1;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label lblGC1;
        private System.Windows.Forms.Label lblTT1;
        private System.Windows.Forms.Label lblDG1;
        private System.Windows.Forms.Label lblSLN1;
        private System.Windows.Forms.Label lblCD1;
        private System.Windows.Forms.GroupBox grpThongtinS;
        private System.Windows.Forms.Label lblNamXB1;
        private System.Windows.Forms.Label lblNXB1;
        private System.Windows.Forms.Label lblTG1;
        private System.Windows.Forms.Label lblTS1;
        private System.Windows.Forms.Label lblMS1;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}