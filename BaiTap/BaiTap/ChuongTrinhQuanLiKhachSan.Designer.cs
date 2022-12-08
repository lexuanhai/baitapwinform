
namespace BaiTap
{
    partial class ChuongTrinhQuanLiKhachSan
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
            this.tabChuongTrinh = new System.Windows.Forms.TabControl();
            this.tabQuanLiPhong = new System.Windows.Forms.TabPage();
            this.tabQuanLyKhachHang = new System.Windows.Forms.TabPage();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.tabChiTietPhieuXuat = new System.Windows.Forms.TabPage();
            this.tabChuongTrinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChuongTrinh
            // 
            this.tabChuongTrinh.Controls.Add(this.tabQuanLiPhong);
            this.tabChuongTrinh.Controls.Add(this.tabQuanLyKhachHang);
            this.tabChuongTrinh.Controls.Add(this.tabThanhToan);
            this.tabChuongTrinh.Controls.Add(this.tabPhieuXuat);
            this.tabChuongTrinh.Controls.Add(this.tabChiTietPhieuXuat);
            this.tabChuongTrinh.Location = new System.Drawing.Point(-1, 13);
            this.tabChuongTrinh.Name = "tabChuongTrinh";
            this.tabChuongTrinh.SelectedIndex = 0;
            this.tabChuongTrinh.Size = new System.Drawing.Size(1047, 672);
            this.tabChuongTrinh.TabIndex = 0;
            this.tabChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLiPhong
            // 
            this.tabQuanLiPhong.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLiPhong.Name = "tabQuanLiPhong";
            this.tabQuanLiPhong.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabQuanLiPhong.Size = new System.Drawing.Size(1039, 646);
            this.tabQuanLiPhong.TabIndex = 0;
            this.tabQuanLiPhong.Text = "Quản lý phiếu nhập";
            this.tabQuanLiPhong.UseVisualStyleBackColor = true;
            this.tabQuanLiPhong.Click += new System.EventHandler(this.tabQuanLiPhong_Click);
            // 
            // tabQuanLyKhachHang
            // 
            this.tabQuanLyKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyKhachHang.Name = "tabQuanLyKhachHang";
            this.tabQuanLyKhachHang.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabQuanLyKhachHang.Size = new System.Drawing.Size(1039, 646);
            this.tabQuanLyKhachHang.TabIndex = 1;
            this.tabQuanLyKhachHang.Text = "Quản lý chi tiết phiếu nhập";
            this.tabQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Location = new System.Drawing.Point(4, 22);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Size = new System.Drawing.Size(1039, 646);
            this.tabThanhToan.TabIndex = 2;
            this.tabThanhToan.Text = "Thanh toán";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(1039, 646);
            this.tabPhieuXuat.TabIndex = 3;
            this.tabPhieuXuat.Text = "Quản lý phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // tabChiTietPhieuXuat
            // 
            this.tabChiTietPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabChiTietPhieuXuat.Name = "tabChiTietPhieuXuat";
            this.tabChiTietPhieuXuat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabChiTietPhieuXuat.Size = new System.Drawing.Size(1039, 646);
            this.tabChiTietPhieuXuat.TabIndex = 4;
            this.tabChiTietPhieuXuat.Text = "Quản lý chi tiết phiếu xuất";
            this.tabChiTietPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // ChuongTrinhQuanLiKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 689);
            this.Controls.Add(this.tabChuongTrinh);
            this.Name = "ChuongTrinhQuanLiKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuongTrinhQuanLiKhachSan";
            this.tabChuongTrinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChuongTrinh;
        private System.Windows.Forms.TabPage tabQuanLiPhong;
        private System.Windows.Forms.TabPage tabQuanLyKhachHang;
        private System.Windows.Forms.TabPage tabThanhToan;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.TabPage tabChiTietPhieuXuat;
    }
}