
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLiPhong = new System.Windows.Forms.TabPage();
            this.tabQuanLyKhachHang = new System.Windows.Forms.TabPage();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLiPhong);
            this.tabControl1.Controls.Add(this.tabQuanLyKhachHang);
            this.tabControl1.Controls.Add(this.tabThanhToan);
            this.tabControl1.Location = new System.Drawing.Point(-1, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 827);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLiPhong
            // 
            this.tabQuanLiPhong.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiPhong.Name = "tabQuanLiPhong";
            this.tabQuanLiPhong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLiPhong.Size = new System.Drawing.Size(1388, 798);
            this.tabQuanLiPhong.TabIndex = 0;
            this.tabQuanLiPhong.Text = "Quản lý phiếu nhập";
            this.tabQuanLiPhong.UseVisualStyleBackColor = true;
            this.tabQuanLiPhong.Click += new System.EventHandler(this.tabQuanLiPhong_Click);
            // 
            // tabQuanLyKhachHang
            // 
            this.tabQuanLyKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLyKhachHang.Name = "tabQuanLyKhachHang";
            this.tabQuanLyKhachHang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabQuanLyKhachHang.Size = new System.Drawing.Size(1388, 798);
            this.tabQuanLyKhachHang.TabIndex = 1;
            this.tabQuanLyKhachHang.Text = "Quản lý chi tiết phiếu nhập";
            this.tabQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Location = new System.Drawing.Point(4, 25);
            this.tabThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Size = new System.Drawing.Size(1388, 798);
            this.tabThanhToan.TabIndex = 2;
            this.tabThanhToan.Text = "Thanh toán";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // ChuongTrinhQuanLiKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 848);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChuongTrinhQuanLiKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuongTrinhQuanLiKhachSan";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLiPhong;
        private System.Windows.Forms.TabPage tabQuanLyKhachHang;
        private System.Windows.Forms.TabPage tabThanhToan;
    }
}