using BaiTap.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Thanh_Toan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=G07VNXDFVLTTI15;Initial Catalog=MyPham;Integrated Security=True");
        public Thanh_Toan()
        {
            InitializeComponent();
        }

        private void Thanh_Toan_Load(object sender, EventArgs e)
        {
            
            GetMaPhongCombox();
        }
        public void GetMaPhongCombox()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select * from Phong", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            cmbMaPhongSearch.DataSource = dt;
            cmbMaPhongSearch.DisplayMember = "MaP";
            cmbMaPhongSearch.ValueMember = "MaP";
            con.Close();
        }

        private void btnXemTheoMaPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(cmbMaPhongSearch.SelectedValue)))
            {
                MessageBox.Show("Vui lòng chọn mã phòng.");
            }
            else
            {
                GetDataForQuery("", Convert.ToString(cmbMaPhongSearch.SelectedValue),"");
            }
        }
        public void LoadChiTietKhachHang(DataTable data)
        {
            dgvChiTietKhachThanhToan.Rows.Clear();
            foreach (DataRow dr in data.Rows)
            {
                int n = dgvChiTietKhachThanhToan.Rows.Add();
                dgvChiTietKhachThanhToan.Rows[n].Cells[0].Value = dr[0].ToString();
                dgvChiTietKhachThanhToan.Rows[n].Cells[1].Value = dr[1].ToString();
                dgvChiTietKhachThanhToan.Rows[n].Cells[2].Value = dr[2].ToString();
                dgvChiTietKhachThanhToan.Rows[n].Cells[3].Value = Convert.ToDateTime(dr[3]).ToString("dd/MM/yyyy hh:mm");
                dgvChiTietKhachThanhToan.Rows[n].Cells[4].Value = dr[4].ToString();
                dgvChiTietKhachThanhToan.Rows[n].Cells[5].Value = dr[5].ToString();
                dgvChiTietKhachThanhToan.Rows[n].Cells[6].Value = dr[6].ToString();

            }           
        }
        public void GetDataForQuery(string tenKhach, string maPhong,string maKH)
        {
            string query = ""; //"select * from Employee where maPhong = @maPhong";
            if (!string.IsNullOrEmpty(maPhong))
            {
                query = "select MaKH,HoTen,CMND,NgayDen,MaP,SoNgayO,ThanhTien from KhachHang where maP = @maPhong";
            }

            if (!string.IsNullOrEmpty(tenKhach))
            {
                query = "select MaKH,HoTen,CMND,NgayDen,MaP,SoNgayO,ThanhTien from KhachHang where HoTen like '%' +@tenKhach +'%'";
            }
            if (!string.IsNullOrEmpty(maKH))
            {
                query = "select MaKH,HoTen,CMND,NgayDen,MaP,SoNgayO,ThanhTien from KhachHang where MaKH = @maKH";
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            if (!string.IsNullOrEmpty(maPhong))
            {
                sda.SelectCommand.Parameters.AddWithValue("@maPhong", maPhong);
            }
            if (!string.IsNullOrEmpty(tenKhach))
            {
                sda.SelectCommand.Parameters.AddWithValue("@tenKhach", tenKhach);
            }
            if (!string.IsNullOrEmpty(maKH))
            {
                sda.SelectCommand.Parameters.AddWithValue("@maKH", maKH);
            }
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                LoadChiTietKhachHang(data);

            }
            else
            {
                MessageBox.Show("Không có dữ liệu !!!");
                //dgvChiTietPhong.DataSource = null;
            }
        }

        private void btnXemTinhTrang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(txtTenKhachHang.Text)))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng.");
            }
            else
            {
                GetDataForQuery(Convert.ToString(txtTenKhachHang.Text),"","");
            }
        }

        private void dgvChiTietKhachThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvChiTietKhachThanhToan.SelectedCells)
            {
                //cell.RowIndex
                if (dgvChiTietKhachThanhToan.Rows[cell.RowIndex].Cells[4].Value != null && dgvChiTietKhachThanhToan.Rows[cell.RowIndex].Cells[0].Value != null)
                {
                    lbPhong.Text = dgvChiTietKhachThanhToan.Rows[cell.RowIndex].Cells[4].Value.ToString();
                    string maKH = dgvChiTietKhachThanhToan.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    LabMaKH.Text = maKH;
                    var khachhangView = GetKhach(maKH);
                    var PhongView = GetPhong(lbPhong.Text);
                    khachhangView.ThanhTien = khachhangView.SoNgayO * PhongView.DonGia;
                    lbSoNgayo.Text = khachhangView.SoNgayO.ToString();
                    lbTongTien.Text = khachhangView.ThanhTien.ToString();
                }
              
            }
        }
        public KhachHangModel GetKhach(string maKH)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            var khachhang = new KhachHangModel();
            using (var command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandText = "SELECT * FROM KhachHang where MaKH = '"+ maKH + "'";
                using (var reader = command.ExecuteReader())
                {                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            khachhang.MaKh = reader["MaKH"].ToString();
                            khachhang.HoTen = reader["HoTen"].ToString();
                            khachhang.SoCMND = reader["CMND"].ToString();
                            khachhang.MaPhong = reader["MaP"].ToString();
                            khachhang.SoNgayO = (int)DateTime.Now.Subtract(Convert.ToDateTime(reader["NgayDen"])).TotalDays;
                        }
                    }
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            };
            return khachhang;
        }

        public PhongModel GetPhong(string maPhong)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            var khachhang = new PhongModel();
            using (var command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandText = "SELECT * FROM Phong where Map = '" + maPhong + "'";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            khachhang.MaPhong = reader["Map"].ToString();
                            khachhang.DonGia = Convert.ToDecimal(reader["DonGia"]);
                        }
                    }
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            };
            return khachhang;
        }

        private void dgvChiTietKhachThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
               
                string qry = "update KhachHang set SoNgayO="+ Convert.ToInt32(lbSoNgayo.Text) + ", ThanhTien=" + Convert.ToDecimal(lbTongTien.Text) + " where MaKH='" + LabMaKH.Text + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Thanh toán thành công.");
                    dgvChiTietKhachThanhToan.Rows.Clear();
                    GetDataForQuery("", "", LabMaKH.Text);
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công.");
                }
                con.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
