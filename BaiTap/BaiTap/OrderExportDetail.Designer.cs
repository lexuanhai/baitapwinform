
namespace BaiTap
{
    partial class OrderExportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderExportDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbSanPham1 = new System.Windows.Forms.Label();
            this.cmbSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaPhieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrderExportDetail = new System.Windows.Forms.DataGridView();
            this.tdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdNamSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pdHoaDonXuat = new System.Drawing.Printing.PrintDocument();
            this.prviewInHoaDonXuat = new System.Windows.Forms.PrintPreviewDialog();
            this.btnInHoaDonXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderExportDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbTinhTrang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cmbSanPham1);
            this.groupBox1.Controls.Add(this.cmbSanPham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbMaPhieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenDaiLy);
            this.groupBox1.Location = new System.Drawing.Point(52, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tình Trạng";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "Đã giao",
            "Đổi trả",
            "Hủy"});
            this.cmbTinhTrang.Location = new System.Drawing.Point(522, 34);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(117, 21);
            this.cmbTinhTrang.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(314, 80);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(117, 20);
            this.txtSoLuong.TabIndex = 20;
            // 
            // cmbSanPham1
            // 
            this.cmbSanPham1.AutoSize = true;
            this.cmbSanPham1.Location = new System.Drawing.Point(27, 82);
            this.cmbSanPham1.Name = "cmbSanPham1";
            this.cmbSanPham1.Size = new System.Drawing.Size(74, 13);
            this.cmbSanPham1.TabIndex = 19;
            this.cmbSanPham1.Text = "Mã Sản Phẩm";
            // 
            // cmbSanPham
            // 
            this.cmbSanPham.FormattingEnabled = true;
            this.cmbSanPham.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.cmbSanPham.Location = new System.Drawing.Point(107, 79);
            this.cmbSanPham.Name = "cmbSanPham";
            this.cmbSanPham.Size = new System.Drawing.Size(117, 21);
            this.cmbSanPham.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã Phiếu";
            // 
            // cmbMaPhieu
            // 
            this.cmbMaPhieu.FormattingEnabled = true;
            this.cmbMaPhieu.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.cmbMaPhieu.Location = new System.Drawing.Point(107, 36);
            this.cmbMaPhieu.Name = "cmbMaPhieu";
            this.cmbMaPhieu.Size = new System.Drawing.Size(117, 21);
            this.cmbMaPhieu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(523, 80);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(117, 20);
            this.txtNote.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Đại Lý";
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(314, 38);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(117, 20);
            this.txtTenDaiLy.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInHoaDonXuat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(52, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(535, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(293, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrderExportDetail);
            this.groupBox2.Location = new System.Drawing.Point(25, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgvOrderExportDetail
            // 
            this.dgvOrderExportDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderExportDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdId,
            this.tdCode,
            this.tdMaSanPham,
            this.tdNamSanPham,
            this.tdTenDaiLy,
            this.tdDonGia,
            this.tdTotal,
            this.tdTongGia,
            this.tdNote,
            this.tdTrangThai});
            this.dgvOrderExportDetail.Location = new System.Drawing.Point(6, 35);
            this.dgvOrderExportDetail.Name = "dgvOrderExportDetail";
            this.dgvOrderExportDetail.RowHeadersWidth = 51;
            this.dgvOrderExportDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderExportDetail.Size = new System.Drawing.Size(692, 112);
            this.dgvOrderExportDetail.TabIndex = 19;
            this.dgvOrderExportDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderExportDetail_CellClick);
            this.dgvOrderExportDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhong_MouseClick);
            // 
            // tdId
            // 
            this.tdId.HeaderText = "Id";
            this.tdId.MinimumWidth = 6;
            this.tdId.Name = "tdId";
            this.tdId.Width = 50;
            // 
            // tdCode
            // 
            this.tdCode.HeaderText = "Mã Phiếu";
            this.tdCode.MinimumWidth = 6;
            this.tdCode.Name = "tdCode";
            this.tdCode.Width = 125;
            // 
            // tdMaSanPham
            // 
            this.tdMaSanPham.HeaderText = "Mã sản phẩm";
            this.tdMaSanPham.MinimumWidth = 6;
            this.tdMaSanPham.Name = "tdMaSanPham";
            this.tdMaSanPham.Width = 125;
            // 
            // tdNamSanPham
            // 
            this.tdNamSanPham.HeaderText = "Tên sản phẩm";
            this.tdNamSanPham.MinimumWidth = 6;
            this.tdNamSanPham.Name = "tdNamSanPham";
            this.tdNamSanPham.Width = 125;
            // 
            // tdTenDaiLy
            // 
            this.tdTenDaiLy.HeaderText = "Tên đại lý";
            this.tdTenDaiLy.Name = "tdTenDaiLy";
            // 
            // tdDonGia
            // 
            this.tdDonGia.HeaderText = "Đơn giá";
            this.tdDonGia.Name = "tdDonGia";
            // 
            // tdTotal
            // 
            this.tdTotal.HeaderText = "Số lượng nhập";
            this.tdTotal.MinimumWidth = 6;
            this.tdTotal.Name = "tdTotal";
            this.tdTotal.Width = 125;
            // 
            // tdTongGia
            // 
            this.tdTongGia.HeaderText = "Tổng giá";
            this.tdTongGia.MinimumWidth = 6;
            this.tdTongGia.Name = "tdTongGia";
            this.tdTongGia.Width = 125;
            // 
            // tdNote
            // 
            this.tdNote.HeaderText = "Ghi chú";
            this.tdNote.MinimumWidth = 6;
            this.tdNote.Name = "tdNote";
            this.tdNote.Width = 125;
            // 
            // tdTrangThai
            // 
            this.tdTrangThai.HeaderText = "Trạng thái";
            this.tdTrangThai.Name = "tdTrangThai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi Tiết Phiếu Xuất";
            // 
            // pdHoaDonXuat
            // 
            this.pdHoaDonXuat.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdHoaDonXuat_PrintPage);
            // 
            // prviewInHoaDonXuat
            // 
            this.prviewInHoaDonXuat.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prviewInHoaDonXuat.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prviewInHoaDonXuat.ClientSize = new System.Drawing.Size(400, 300);
            this.prviewInHoaDonXuat.Enabled = true;
            this.prviewInHoaDonXuat.Icon = ((System.Drawing.Icon)(resources.GetObject("prviewInHoaDonXuat.Icon")));
            this.prviewInHoaDonXuat.Name = "prviewInHoaDonXuat";
            this.prviewInHoaDonXuat.Visible = false;
            // 
            // btnInHoaDonXuat
            // 
            this.btnInHoaDonXuat.Location = new System.Drawing.Point(409, 8);
            this.btnInHoaDonXuat.Name = "btnInHoaDonXuat";
            this.btnInHoaDonXuat.Size = new System.Drawing.Size(75, 42);
            this.btnInHoaDonXuat.TabIndex = 13;
            this.btnInHoaDonXuat.Text = "In hóa đơn";
            this.btnInHoaDonXuat.UseVisualStyleBackColor = true;
            this.btnInHoaDonXuat.Click += new System.EventHandler(this.btnInHoaDonXuat_Click);
            // 
            // OrderExportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderExportDetail";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.OrderExportDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderExportDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderExportDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cmbSanPham1;
        private System.Windows.Forms.ComboBox cmbSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdNamSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTongGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTrangThai;
        private System.Drawing.Printing.PrintDocument pdHoaDonXuat;
        private System.Windows.Forms.PrintPreviewDialog prviewInHoaDonXuat;
        private System.Windows.Forms.Button btnInHoaDonXuat;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
    }
}