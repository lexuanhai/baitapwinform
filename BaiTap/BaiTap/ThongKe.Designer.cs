
namespace BaiTap
{
    partial class ThongKe
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
            this.datetimpickeNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimpiceNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tdSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdTongSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdSoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.datetimpickeNgayKetThuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datetimpiceNgayBatDau);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(137, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(921, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datetimpickeNgayKetThuc
            // 
            this.datetimpickeNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.datetimpickeNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimpickeNgayKetThuc.Location = new System.Drawing.Point(479, 39);
            this.datetimpickeNgayKetThuc.Name = "datetimpickeNgayKetThuc";
            this.datetimpickeNgayKetThuc.Size = new System.Drawing.Size(156, 22);
            this.datetimpickeNgayKetThuc.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ngày kết thúc";
            // 
            // datetimpiceNgayBatDau
            // 
            this.datetimpiceNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.datetimpiceNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimpiceNgayBatDau.Location = new System.Drawing.Point(140, 39);
            this.datetimpiceNgayBatDau.Name = "datetimpiceNgayBatDau";
            this.datetimpiceNgayBatDau.Size = new System.Drawing.Size(156, 22);
            this.datetimpiceNgayBatDau.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ngày bắt đầu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.comboBox1.Location = new System.Drawing.Point(564, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuXuat);
            this.groupBox2.Location = new System.Drawing.Point(92, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1013, 461);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdSTT,
            this.tdTenSanPham,
            this.tdDonGia,
            this.tdTongSanPham,
            this.tdSoLuongBan,
            this.tdThanhTien,
            this.tdNgayNhap,
            this.tdDiaChi});
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(4, 19);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowHeadersWidth = 51;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(1005, 438);
            this.dgvPhieuXuat.TabIndex = 16;
            this.dgvPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thống kê";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(733, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 52);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // tdSTT
            // 
            this.tdSTT.HeaderText = "STT";
            this.tdSTT.MinimumWidth = 6;
            this.tdSTT.Name = "tdSTT";
            this.tdSTT.Width = 50;
            // 
            // tdTenSanPham
            // 
            this.tdTenSanPham.HeaderText = "Tên sản phẩm";
            this.tdTenSanPham.MinimumWidth = 6;
            this.tdTenSanPham.Name = "tdTenSanPham";
            this.tdTenSanPham.Width = 125;
            // 
            // tdDonGia
            // 
            this.tdDonGia.HeaderText = "Đơn giá";
            this.tdDonGia.MinimumWidth = 6;
            this.tdDonGia.Name = "tdDonGia";
            this.tdDonGia.Width = 125;
            // 
            // tdTongSanPham
            // 
            this.tdTongSanPham.HeaderText = "Tổng sản phẩm";
            this.tdTongSanPham.MinimumWidth = 6;
            this.tdTongSanPham.Name = "tdTongSanPham";
            this.tdTongSanPham.Width = 150;
            // 
            // tdSoLuongBan
            // 
            this.tdSoLuongBan.HeaderText = "Số lượng bán";
            this.tdSoLuongBan.MinimumWidth = 6;
            this.tdSoLuongBan.Name = "tdSoLuongBan";
            this.tdSoLuongBan.Width = 125;
            // 
            // tdThanhTien
            // 
            this.tdThanhTien.HeaderText = "Thành tiền";
            this.tdThanhTien.MinimumWidth = 6;
            this.tdThanhTien.Name = "tdThanhTien";
            this.tdThanhTien.Width = 125;
            // 
            // tdNgayNhap
            // 
            this.tdNgayNhap.HeaderText = "Ngày nhập";
            this.tdNgayNhap.MinimumWidth = 6;
            this.tdNgayNhap.Name = "tdNgayNhap";
            this.tdNgayNhap.Width = 125;
            // 
            // tdDiaChi
            // 
            this.tdDiaChi.HeaderText = "Ngày xuất";
            this.tdDiaChi.MinimumWidth = 6;
            this.tdDiaChi.Name = "tdDiaChi";
            this.tdDiaChi.Width = 125;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 821);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKe";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.OrderExport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker datetimpiceNgayBatDau;
        private System.Windows.Forms.DateTimePicker datetimpickeNgayKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdTongSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdSoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdDiaChi;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
    }
}