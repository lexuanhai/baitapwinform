using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class ChuongTrinhQuanLiKhachSan : Form
    {
        public ChuongTrinhQuanLiKhachSan()
        {
            InitializeComponent();
            LoadIndexForm();
            //Application.Run(new Phong1());
        }

        private void tabQuanLiPhong_Click(object sender, EventArgs e)
        {
            Application.Run(new OrderExport());
        }
        public void LoadIndexForm()
        {
            Form frm = new Form();


            if (tabChuongTrinh.SelectedTab == tabChuongTrinh.TabPages["tabQuanLiPhong"])
            {
                frm = new OrderImport();
                FormatForm(frm);
                tabChuongTrinh.TabPages["tabQuanLiPhong"].Controls.Add(frm);
            }

            if (tabChuongTrinh.SelectedTab == tabChuongTrinh.TabPages["tabQuanLyKhachHang"])
            {
                frm = new OrderImportDetail();
                FormatForm(frm);
                tabChuongTrinh.TabPages["tabQuanLyKhachHang"].Controls.Add(frm);
            }
            if (tabChuongTrinh.SelectedTab == tabChuongTrinh.TabPages["tabPhieuXuat"])
            {
                frm = new OrderExport();
                FormatForm(frm);
                tabChuongTrinh.TabPages["tabPhieuXuat"].Controls.Add(frm);
            }


            if (tabChuongTrinh.SelectedTab == tabChuongTrinh.TabPages["tabThanhToan"])
            {
                frm = new Thanh_Toan();
                FormatForm(frm);
                tabChuongTrinh.TabPages["tabThanhToan"].Controls.Add(frm);
            }


        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIndexForm();


        }
        public void FormatForm(Form frm)
        {
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
        }
        private void OpenChildForm(Form childForm)
        {

        }
    }
}
