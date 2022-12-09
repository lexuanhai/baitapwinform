
namespace BaiTap
{
    partial class ChuongTrinhQuanLy
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
            this.tabQuanLiPhieuNhap = new System.Windows.Forms.TabPage();
            this.tabQuanLiChiTietPhieuNhap = new System.Windows.Forms.TabPage();
            this.tabThongke = new System.Windows.Forms.TabPage();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.tabChiTietPhieuXuat = new System.Windows.Forms.TabPage();
            this.tabChuongTrinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChuongTrinh
            // 
            this.tabChuongTrinh.Controls.Add(this.tabQuanLiPhieuNhap);
            this.tabChuongTrinh.Controls.Add(this.tabQuanLiChiTietPhieuNhap);
            this.tabChuongTrinh.Controls.Add(this.tabPhieuXuat);
            this.tabChuongTrinh.Controls.Add(this.tabChiTietPhieuXuat);
            this.tabChuongTrinh.Controls.Add(this.tabThongke);
            this.tabChuongTrinh.Location = new System.Drawing.Point(-1, 16);
            this.tabChuongTrinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabChuongTrinh.Name = "tabChuongTrinh";
            this.tabChuongTrinh.SelectedIndex = 0;
            this.tabChuongTrinh.Size = new System.Drawing.Size(1396, 827);
            this.tabChuongTrinh.TabIndex = 0;
            this.tabChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLiPhieuNhap
            // 
            this.tabQuanLiPhieuNhap.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLiPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiPhieuNhap.Name = "tabQuanLiPhieuNhap";
            this.tabQuanLiPhieuNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiPhieuNhap.Size = new System.Drawing.Size(1388, 798);
            this.tabQuanLiPhieuNhap.TabIndex = 0;
            this.tabQuanLiPhieuNhap.Text = "Quản lý phiếu nhập";
            this.tabQuanLiPhieuNhap.UseVisualStyleBackColor = true;
            this.tabQuanLiPhieuNhap.Click += new System.EventHandler(this.tabQuanLiPhong_Click);
            // 
            // tabQuanLiChiTietPhieuNhap
            // 
            this.tabQuanLiChiTietPhieuNhap.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLiChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiChiTietPhieuNhap.Name = "tabQuanLiChiTietPhieuNhap";
            this.tabQuanLiChiTietPhieuNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiChiTietPhieuNhap.Size = new System.Drawing.Size(1388, 798);
            this.tabQuanLiChiTietPhieuNhap.TabIndex = 1;
            this.tabQuanLiChiTietPhieuNhap.Text = "Quản lý chi tiết phiếu nhập";
            this.tabQuanLiChiTietPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // tabThongke
            // 
            this.tabThongke.Location = new System.Drawing.Point(4, 25);
            this.tabThongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabThongke.Name = "tabThongke";
            this.tabThongke.Size = new System.Drawing.Size(1388, 798);
            this.tabThongke.TabIndex = 2;
            this.tabThongke.Text = "Thống kê";
            this.tabThongke.UseVisualStyleBackColor = true;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 25);
            this.tabPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPhieuXuat.Size = new System.Drawing.Size(1388, 798);
            this.tabPhieuXuat.TabIndex = 3;
            this.tabPhieuXuat.Text = "Quản lý phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // tabChiTietPhieuXuat
            // 
            this.tabChiTietPhieuXuat.Location = new System.Drawing.Point(4, 25);
            this.tabChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChiTietPhieuXuat.Name = "tabChiTietPhieuXuat";
            this.tabChiTietPhieuXuat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChiTietPhieuXuat.Size = new System.Drawing.Size(1388, 798);
            this.tabChiTietPhieuXuat.TabIndex = 4;
            this.tabChiTietPhieuXuat.Text = "Quản lý chi tiết phiếu xuất";
            this.tabChiTietPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // ChuongTrinhQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 848);
            this.Controls.Add(this.tabChuongTrinh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChuongTrinhQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuongTrinhQuanLiKhachSan";
            this.tabChuongTrinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChuongTrinh;
        private System.Windows.Forms.TabPage tabQuanLiPhieuNhap;
        private System.Windows.Forms.TabPage tabQuanLiChiTietPhieuNhap;
        private System.Windows.Forms.TabPage tabThongke;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.TabPage tabChiTietPhieuXuat;
    }
}