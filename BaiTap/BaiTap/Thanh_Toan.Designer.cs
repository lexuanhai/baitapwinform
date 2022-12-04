
namespace BaiTap
{
    partial class Thanh_Toan
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
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaPhongSearch = new System.Windows.Forms.ComboBox();
            this.btnXemTheoMaPhong = new System.Windows.Forms.Button();
            this.btnXemTinhTrang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbSoNgayo = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietKhachThanhToan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabMaKH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKhachThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMaPhongSearch);
            this.groupBox1.Controls.Add(this.btnXemTheoMaPhong);
            this.groupBox1.Controls.Add(this.btnXemTinhTrang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhanh";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(180, 78);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(134, 20);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Họ tên khách";
            // 
            // cmbMaPhongSearch
            // 
            this.cmbMaPhongSearch.FormattingEnabled = true;
            this.cmbMaPhongSearch.Location = new System.Drawing.Point(179, 32);
            this.cmbMaPhongSearch.Name = "cmbMaPhongSearch";
            this.cmbMaPhongSearch.Size = new System.Drawing.Size(134, 21);
            this.cmbMaPhongSearch.TabIndex = 24;
            // 
            // btnXemTheoMaPhong
            // 
            this.btnXemTheoMaPhong.Location = new System.Drawing.Point(383, 30);
            this.btnXemTheoMaPhong.Name = "btnXemTheoMaPhong";
            this.btnXemTheoMaPhong.Size = new System.Drawing.Size(165, 23);
            this.btnXemTheoMaPhong.TabIndex = 21;
            this.btnXemTheoMaPhong.Text = "Tìm kiếm theo mã phòng";
            this.btnXemTheoMaPhong.UseVisualStyleBackColor = true;
            this.btnXemTheoMaPhong.Click += new System.EventHandler(this.btnXemTheoMaPhong_Click);
            // 
            // btnXemTinhTrang
            // 
            this.btnXemTinhTrang.Location = new System.Drawing.Point(383, 77);
            this.btnXemTinhTrang.Name = "btnXemTinhTrang";
            this.btnXemTinhTrang.Size = new System.Drawing.Size(165, 23);
            this.btnXemTinhTrang.TabIndex = 20;
            this.btnXemTinhTrang.Text = "Tìm kiếm theo họ tên";
            this.btnXemTinhTrang.UseVisualStyleBackColor = true;
            this.btnXemTinhTrang.Click += new System.EventHandler(this.btnXemTinhTrang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTongTien);
            this.groupBox2.Controls.Add(this.lbSoNgayo);
            this.groupBox2.Controls.Add(this.lbPhong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTinhTien);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(289, 89);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(91, 17);
            this.lbTongTien.TabIndex = 29;
            this.lbTongTien.Text = "- - - - - - - -";
            // 
            // lbSoNgayo
            // 
            this.lbSoNgayo.AutoSize = true;
            this.lbSoNgayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNgayo.Location = new System.Drawing.Point(289, 58);
            this.lbSoNgayo.Name = "lbSoNgayo";
            this.lbSoNgayo.Size = new System.Drawing.Size(91, 17);
            this.lbSoNgayo.TabIndex = 28;
            this.lbSoNgayo.Text = "- - - - - - - -";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(289, 26);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(91, 17);
            this.lbPhong.TabIndex = 27;
            this.lbPhong.Text = "- - - - - - - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tổng tiền khách phải thanh toán là";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số ngày khách ở";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(465, 49);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(83, 23);
            this.btnTinhTien.TabIndex = 21;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phòng khách ở";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChiTietKhachThanhToan);
            this.groupBox3.Location = new System.Drawing.Point(59, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết khách hàng thanh toán";
            // 
            // dgvChiTietKhachThanhToan
            // 
            this.dgvChiTietKhachThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietKhachThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvChiTietKhachThanhToan.Location = new System.Drawing.Point(15, 28);
            this.dgvChiTietKhachThanhToan.Name = "dgvChiTietKhachThanhToan";
            this.dgvChiTietKhachThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietKhachThanhToan.Size = new System.Drawing.Size(616, 100);
            this.dgvChiTietKhachThanhToan.TabIndex = 1;
            this.dgvChiTietKhachThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietKhachThanhToan_CellClick);
            this.dgvChiTietKhachThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietKhachThanhToan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CMT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày đến";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã Phòng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số ngày ở";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            // 
            // LabMaKH
            // 
            this.LabMaKH.AutoSize = true;
            this.LabMaKH.Location = new System.Drawing.Point(713, 549);
            this.LabMaKH.Name = "LabMaKH";
            this.LabMaKH.Size = new System.Drawing.Size(10, 13);
            this.LabMaKH.TabIndex = 5;
            this.LabMaKH.Text = ".";
            this.LabMaKH.Visible = false;
            // 
            // Thanh_Toan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.LabMaKH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thanh_Toan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh_Toan";
            this.Load += new System.EventHandler(this.Thanh_Toan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKhachThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMaPhongSearch;
        private System.Windows.Forms.Button btnXemTheoMaPhong;
        private System.Windows.Forms.Button btnXemTinhTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbSoNgayo;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiTietKhachThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label LabMaKH;
    }
}