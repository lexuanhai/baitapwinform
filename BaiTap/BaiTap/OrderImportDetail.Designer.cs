﻿
namespace BaiTap
{
    partial class OrderImportDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbSanPham1 = new System.Windows.Forms.Label();
            this.cmbSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrdersDetailImport = new System.Windows.Forms.DataGridView();
            this.tdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInHoaDonNhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersDetailImport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cmbSanPham1);
            this.groupBox1.Controls.Add(this.cmbSanPham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Location = new System.Drawing.Point(52, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(512, 36);
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
            // cmbMaPhieuNhap
            // 
            this.cmbMaPhieuNhap.FormattingEnabled = true;
            this.cmbMaPhieuNhap.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.cmbMaPhieuNhap.Location = new System.Drawing.Point(107, 36);
            this.cmbMaPhieuNhap.Name = "cmbMaPhieuNhap";
            this.cmbMaPhieuNhap.Size = new System.Drawing.Size(117, 21);
            this.cmbMaPhieuNhap.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đơn giá";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(310, 37);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(117, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(310, 79);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(117, 20);
            this.txtNote.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInHoaDonNhap);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(52, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(522, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(281, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(159, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrdersDetailImport);
            this.groupBox2.Location = new System.Drawing.Point(25, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 230);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvOrdersDetailImport
            // 
            this.dgvOrdersDetailImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersDetailImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdId,
            this.tdCode,
            this.tdProductId,
            this.tdTenSanPham,
            this.tdCreated,
            this.tdQuantity,
            this.tdPrice,
            this.tdTotalPrice,
            this.tdNote});
            this.dgvOrdersDetailImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersDetailImport.Location = new System.Drawing.Point(3, 16);
            this.dgvOrdersDetailImport.Name = "dgvOrdersDetailImport";
            this.dgvOrdersDetailImport.Size = new System.Drawing.Size(698, 211);
            this.dgvOrdersDetailImport.TabIndex = 0;
            this.dgvOrdersDetailImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersDetailImport_CellClick);
            // 
            // tdId
            // 
            this.tdId.HeaderText = "Id";
            this.tdId.Name = "tdId";
            this.tdId.Width = 50;
            // 
            // tdCode
            // 
            this.tdCode.HeaderText = "Mã Phiếu";
            this.tdCode.Name = "tdCode";
            // 
            // tdProductId
            // 
            this.tdProductId.HeaderText = "Mã sản phẩm";
            this.tdProductId.Name = "tdProductId";
            // 
            // tdTenSanPham
            // 
            this.tdTenSanPham.HeaderText = "Tên sản phẩm";
            this.tdTenSanPham.Name = "tdTenSanPham";
            // 
            // tdCreated
            // 
            this.tdCreated.HeaderText = "Ngày nhập";
            this.tdCreated.Name = "tdCreated";
            // 
            // tdQuantity
            // 
            this.tdQuantity.HeaderText = "Số lượng nhập";
            this.tdQuantity.Name = "tdQuantity";
            // 
            // tdPrice
            // 
            this.tdPrice.HeaderText = "Đơn giá";
            this.tdPrice.Name = "tdPrice";
            // 
            // tdTotalPrice
            // 
            this.tdTotalPrice.HeaderText = "Tổng giá";
            this.tdTotalPrice.Name = "tdTotalPrice";
            // 
            // tdNote
            // 
            this.tdNote.HeaderText = "Ghi chú";
            this.tdNote.Name = "tdNote";
            // 
            // btnInHoaDonNhap
            // 
            this.btnInHoaDonNhap.Location = new System.Drawing.Point(399, 8);
            this.btnInHoaDonNhap.Name = "btnInHoaDonNhap";
            this.btnInHoaDonNhap.Size = new System.Drawing.Size(84, 42);
            this.btnInHoaDonNhap.TabIndex = 3;
            this.btnInHoaDonNhap.Text = "In hóa đơn";
            this.btnInHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnInHoaDonNhap.Click += new System.EventHandler(this.btnInHoaDonNhap_Click);
            // 
            // OrderImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderImportDetail";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.OrderImportDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersDetailImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cmbSanPham1;
        private System.Windows.Forms.ComboBox cmbSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvOrdersDetailImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdNote;
        private System.Windows.Forms.Button btnInHoaDonNhap;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
    }
}