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
            Application.Run(new Phong());
        }
        public void LoadIndexForm()
        {
            Form frm = new Form();


            if (tabControl1.SelectedTab == tabControl1.TabPages["tabQuanLiPhong"])
            {
                frm = new Phong();
                FormatForm(frm);
                tabControl1.TabPages["tabQuanLiPhong"].Controls.Add(frm);
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabQuanLyKhachHang"])
            {
                frm = new QuanLyKhachSan();
                FormatForm(frm);
                tabControl1.TabPages["tabQuanLyKhachHang"].Controls.Add(frm);
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabThanhToan"])
            {
                frm = new Thanh_Toan();
                FormatForm(frm);
                tabControl1.TabPages["tabThanhToan"].Controls.Add(frm);
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
