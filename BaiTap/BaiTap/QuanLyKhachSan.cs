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
    public partial class QuanLyKhachSan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DDVHBI0;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
        public QuanLyKhachSan()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachSan_Load(object sender, EventArgs e)
        {
            LoadPhong();
            GetMaPhongCombox();
            CreateCmboxTinhTrang();
            LoadFormcustom();
        }

        public void LoadFormcustom()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select MaKH,HoTen,CMND,NgayDen,MaP from KhachHang", con);            
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int n = dgvChiTietKhach.Rows.Add();
                dgvChiTietKhach.Rows[n].Cells[0].Value = dr[0].ToString();
                dgvChiTietKhach.Rows[n].Cells[1].Value = dr[1].ToString();
                dgvChiTietKhach.Rows[n].Cells[2].Value = dr[2].ToString();
                dgvChiTietKhach.Rows[n].Cells[3].Value = Convert.ToDateTime(dr[3]).ToString("dd/MM/yyyy hh:mm");
                dgvChiTietKhach.Rows[n].Cells[4].Value = dr[4].ToString();

            }
            con.Close();
        }

        public KhachHangModel GetValue()
        {
            var model = new KhachHangModel();
            model.MaKh =     txtMaKH.Text;
            model.HoTen =    txtHoTen.Text;
            model.SoCMND =   txtCMND.Text;
            model.MaPhong = cmbMaPhong.SelectedValue.ToString();
            return model;
        }
        public void SetValue(KhachHangModel model)
        {
            txtMaKH.Text = model.MaKh;
            txtHoTen.Text = model.HoTen;
            txtCMND.Text = model.SoCMND;
            cmbTinhTrangSearch.SelectedItem = model.MaPhong;
        }
        public void SetValueNull()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            cmbTinhTrangSearch.SelectedItem = "";
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
            var cmboboxSearch = new List<CmbMaPhongSearch>();
            foreach (DataRow item in dt.Rows)
            {
                
                if (item.ItemArray.Count() > 0)
                {
                    string _maPhong = item[0].ToString();
                    var _cmbMaPhongSearch = new CmbMaPhongSearch()
                    {
                        MaPhongName = _maPhong,
                        MaPhongText = _maPhong,
                    };
                    cmboboxSearch.Add(_cmbMaPhongSearch);
                }
            }

            if (cmboboxSearch != null && cmboboxSearch.Count() > 0)
            {
                cmbCustomMaPhongSearch.DataSource = cmboboxSearch;
                cmbCustomMaPhongSearch.DisplayMember = "MaPhongName";
                cmbCustomMaPhongSearch.ValueMember = "MaPhongName";
            }
            cmbMaPhong.DataSource = dt;
            cmbMaPhong.DisplayMember = "MaP";
            cmbMaPhong.ValueMember = "MaP";
            con.Close();
        }
        public void CreateCmboxTinhTrang()
        {

            var cmbTinhTrang = new List<CmbTinhTrang>() {
                new CmbTinhTrang(){Name="Da cho thue",Text="Có khách"},
                new CmbTinhTrang(){Name="Chua cho thue",Text="Trống"},
            };
            cmbTinhTrangSearch.DataSource = cmbTinhTrang;
            cmbTinhTrangSearch.DisplayMember = "Text";
            cmbTinhTrangSearch.ValueMember = "Name";
        }
        public void GetPhongQuery(string tinhTrang, string maPhong)
        {
            string query = ""; //"select * from Employee where maPhong = @maPhong";
            if (!string.IsNullOrEmpty(maPhong))
            {
                query = "select * from Phong where maP = @maPhong";
            }

            if (!string.IsNullOrEmpty(tinhTrang))
            {
                query = "select * from Phong where TinhTrang = @tinhtrang";
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            if (!string.IsNullOrEmpty(maPhong))
            {
                sda.SelectCommand.Parameters.AddWithValue("@maPhong", maPhong);
            }
            if (!string.IsNullOrEmpty(tinhTrang))
            {
                sda.SelectCommand.Parameters.AddWithValue("@tinhtrang", tinhTrang);
            }
                
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                dgvChiTietPhong.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu !!!");
                //dgvChiTietPhong.DataSource = null;
            }
        }

        private void btnXemTinhTrang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(cmbTinhTrangSearch.SelectedValue)))
            {
                MessageBox.Show("Vui lòng chọn tình trạng.");
            }
            else
            {
                GetPhongQuery(Convert.ToString(cmbTinhTrangSearch.SelectedValue), "");
            }
        }

        private void btnXemTheoMaPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(cmbCustomMaPhongSearch.SelectedValue)))
            {
                MessageBox.Show("Vui lòng chọn mã phòng.");
            }
            else
            {
                GetPhongQuery("", Convert.ToString(cmbCustomMaPhongSearch.SelectedValue));
            }
        }

        public void LoadPhong()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select * from Phong", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvChiTietPhong.DataSource = dt;
            //dgvChiTietPhong.Rows.Clear();
            //foreach (DataRow dr in dt.Rows)
            //{

            //    int n = dgvChiTietPhong.Rows.Add();
            //    dgvChiTietPhong.Rows[n].Cells[0].Value = dr[0].ToString();
            //    dgvChiTietPhong.Rows[n].Cells[1].Value = dr[1].ToString();
            //    dgvChiTietPhong.Rows[n].Cells[2].Value = dr[2].ToString();
            //    dgvChiTietPhong.Rows[n].Cells[3].Value = dr[3].ToString();

            //}
        }
        public bool ExistMaKH(string makh)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = ""; //"select * from Employee where maPhong = @maPhong";
            if (!string.IsNullOrEmpty(makh))
            {
                query = "select * from KhachHang where MaKH = @makh";
            }
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.Parameters.AddWithValue("@makh", makh);

            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
           
            return false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var model = GetValue();
                if (ExistMaKH(model.MaKh))
                {
                    MessageBox.Show("Mã khách hàng "+ model.MaKh + " đã tồn tại vui lòng nhập mã khác");
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //var ngayDen = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    var qry = "insert into KhachHang(MaKH,HoTen,CMND,MaP,NgayDen) values('" + model.MaKh + "',N'" + model.HoTen + "','" + model.SoCMND + "','" + model.MaPhong + "','" + DateTime.Now + "')";
                    SqlCommand sc = new SqlCommand(qry, con);
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Thêm mới " + model.MaPhong + " thành công.");
                        LoadFormcustom();
                        SetValueNull();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới " + model.MaPhong + " không thành công.");
                    }
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var model = GetValue();
                String qry = "update KhachHang set MaKH='" + model.MaKh + "', HoTen=N'" + model.HoTen + "', CMND='" + model.SoCMND + "', MaP='" + model.MaPhong + "' where MaKH='" + model.MaKh + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Cập nhật thành công " + model.HoTen + " thành công.");
                    LoadFormcustom();
                    SetValueNull();
                }
                else
                {
                    MessageBox.Show("Cập nhật " + model.HoTen + " không thành công.");
                }
                con.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }

        //private void dgvChiTietKhach_MouseClick(object sender, MouseEventArgs e)
        //{
        //    foreach (DataGridViewRow row in dgvChiTietKhach.SelectedRows)
        //    {


        //        txtMaKH.Text = row.Cells[0].Value.ToString();
        //        txtHoTen.Text = row.Cells[1].Value.ToString();
        //        txtCMND.Text = row.Cells[2].Value.ToString();
        //        //...
        //    }
        //    //foreach (DataGridViewCell cell in dgvChiTietKhach.SelectedCells)
        //    //{
        //    //    //cell.RowIndex

        //    //    txtMaKH.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[0].Value.ToString();
        //    //    txtHoTen.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[1].Value.ToString();
        //    //    txtCMND.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[2].Value.ToString();

        //    //}
        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn khách hàng " + txtHoTen.Text.ToString() + " xóa?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string maKH = txtMaKH.Text.ToString();
                string qry = "delete from KhachHang where MaKH='" + maKH + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Xóa thành công " + maKH + " thành công.");
                    LoadFormcustom();
                    SetValueNull();
                }
                else
                {
                    MessageBox.Show("Xóa " + maKH + " không thành công.");
                }

                con.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        //private void dgvChiTietKhach_SelectionChanged(object sender, EventArgs e)
        //{
        //    //foreach (DataGridViewRow row in dgvChiTietKhach.SelectedRows)
        //    //{
                

        //    //    txtMaKH.Text = row.Cells[0].Value.ToString();
        //    //    txtHoTen.Text =row.Cells[1].Value.ToString();
        //    //    txtCMND.Text = row.Cells[2].Value.ToString();
        //    //    //...
        //    //}
        //    //foreach (DataGridViewCell cell in dgvChiTietKhach.SelectedCells)
        //    //{
        //    //    //cell.RowIndex

        //    //    txtMaKH.Text= dgvChiTietKhach.Rows[cell.RowIndex].Cells[0].Value.ToString();
        //    //    txtHoTen.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[1].Value.ToString();
        //    //    txtCMND.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[2].Value.ToString();
                
        //    //}
        //}

        //private void dgvChiTietKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    foreach (DataGridViewCell cell in dgvChiTietKhach.SelectedCells)
        //    {
        //        //cell.RowIndex

        //        txtMaKH.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[0].Value.ToString();
        //        txtHoTen.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[1].Value.ToString();
        //        txtCMND.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[2].Value.ToString();

        //    }
        //}

        private void dgvChiTietKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvChiTietKhach.SelectedCells)
            {
                //cell.RowIndex
                if (dgvChiTietKhach.Rows[cell.RowIndex].Cells[0].Value != null)
                {
                    txtMaKH.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[0].Value.ToString();
                }
                if (dgvChiTietKhach.Rows[cell.RowIndex].Cells[1].Value != null)
                {
                    txtHoTen.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[1].Value.ToString();
                }
                if (dgvChiTietKhach.Rows[cell.RowIndex].Cells[2].Value != null)
                {
                    txtCMND.Text = dgvChiTietKhach.Rows[cell.RowIndex].Cells[2].Value.ToString();
                }

                if (dgvChiTietKhach.Rows[cell.RowIndex].Cells[4].Value != null)
                {
                    cmbMaPhong.SelectedValue = dgvChiTietKhach.Rows[cell.RowIndex].Cells[4].Value.ToString();
                    cmbMaPhong.Show();
                }
                
             
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
