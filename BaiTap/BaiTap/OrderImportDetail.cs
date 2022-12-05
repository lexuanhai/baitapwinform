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

    public partial class OrderImportDetail : Form
    {
        private int OrderDetailImportId = 0;
        SqlConnection con = new SqlConnection("Data Source=G07VNXDFVLTTI15;Initial Catalog=MyPham;Integrated Security=True");
        public OrderImportDetail()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Phong_Load(object sender, EventArgs e)
        {
            LoadFormcustom();
            LoadDataPhieuNhapCombobox();
            LoadDataSanPhamCombobox();
        }
        public void LoadDataPhieuNhapCombobox()
        {
            string query = "select Id, CodeOrder from OrderImport";
            con.Open();
            SqlCommand da = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataReader myReader = da.ExecuteReader();
            dt.Load(myReader);

            cmbMaPhieuNhap.DisplayMember = "CodeOrder";
            cmbMaPhieuNhap.ValueMember = "Id";
            cmbMaPhieuNhap.DataSource = dt;
            con.Close();
        }
        public void LoadDataSanPhamCombobox()
        {
            string query = "select id, name from Products";
            con.Open();
            SqlCommand da = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataReader myReader = da.ExecuteReader();
            dt.Load(myReader);

            cmbSanPham.DisplayMember = "name";
            cmbSanPham.ValueMember = "id";
            cmbSanPham.DataSource = dt;
            con.Close();
        }
        public void LoadFormcustom()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT oid.Id as OrderDetailId,CodeOrder,UserName,CreateDated,pr.id as ProductId,pr.name as ProductName,oid.Quantity as OrderDetailImportQuantity,oid.TotalPrice as OrderDetailImportTotalPrice,oid.Note as OrderDetailImportNote FROM OrderImport oi inner join OrderImportDetail oid on oi.Id = oid.OrderImportId inner join Products pr on oid.ProductId = pr.id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderDetailImport.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dgvOrderDetailImport.Rows.Add();
                dgvOrderDetailImport.Rows[n].Cells[0].Value = dr["OrderDetailId"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[1].Value = dr["CodeOrder"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[2].Value = dr["ProductId"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[3].Value = dr["ProductName"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[4].Value = dr["CreateDated"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[5].Value = dr["OrderDetailImportQuantity"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[6].Value = dr["OrderDetailImportTotalPrice"].ToString();
                dgvOrderDetailImport.Rows[n].Cells[7].Value = dr["OrderDetailImportNote"].ToString();

            }
        }

        public PhieuModel GetOrderImportByCode(string codeOrder)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,CodeOrder from OrderImport where CodeOrder = '" + codeOrder + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderDetailImport.Rows.Clear();
            var phieuModel = new PhieuModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.MaPhieu = dr["CodeOrder"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
            }
            return phieuModel;
        }

        public OrderImportDetailModel GetValue()
        {
            var model = new OrderImportDetailModel();
            model.OrderImportId = Convert.ToInt32(cmbMaPhieuNhap.SelectedValue);
            model.ProductId = Convert.ToInt32(cmbSanPham.SelectedValue);
            model.TotalPrice = Convert.ToInt32(txtPrice.Text);
            model.Total = Convert.ToInt32(txtSoLuong.Text);
            model.Note = txtNote.Text;
            return model;
        }
        public void SetValue(OrderImportDetailModel model)
        {
            txtPrice.Text = Convert.ToString(model.Total);
            cmbMaPhieuNhap.SelectedValue = model.MaPhieu;
            cmbSanPham.SelectedValue = model.MaSanPham;
            txtSoLuong.Text = model.Total.ToString();
            txtNote.Text = model.Note;
        }
        public void SetValueNull()
        {
            txtPrice.Text = "";
            txtNote.Text = "";
            txtSoLuong.Text = "";
            cmbMaPhieuNhap.SelectedItem = "";
            cmbSanPham.SelectedItem = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                var model = GetValue();

                model.NgayNhap = DateTime.Now;
                var qry = "insert into OrderImportDetail values(" + model.ProductId + "," + model.OrderImportId + "," + model.Total + "," + model.TotalPrice + ",'N" + model.Note + "')";
                SqlCommand sc = new SqlCommand(qry, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Thêm mới " + model.MaPhieu + " thành công.");
                    LoadFormcustom();
                    SetValueNull();
                }
                else
                {
                    MessageBox.Show("Thêm mới " + model.MaPhieu + " không thành công.");
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Close();

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }

        private void dgvPhong_MouseClick(object sender, MouseEventArgs e)
        {

            //txtPhong.Text = dgvPhong.SelectedRows[0].Cells[0].Value.ToString();
            //txtGiuong.Text = dgvPhong.SelectedRows[0].Cells[1].Value.ToString();
            //txtDonGia.Text = dgvPhong.SelectedRows[0].Cells[2].Value.ToString();
            //var tinhtrang = dgvPhong.SelectedRows[0].Cells[3].Value.ToString();
            //if (tinhtrang == "chua cho thue")
            //{
            //cmbTinhTrang.SelectedItem = "Trống";
            //}
            //else
            //{
            //cmbTinhTrang.SelectedItem = "Đã có khách";
            //}
        }
        public bool ExistMaKH(string maP)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "";
            if (!string.IsNullOrEmpty(maP))
            {
                query = "select * from OrderImport where CodeOrder = @maP";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.Parameters.AddWithValue("@maP", maP);

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
            }
            return false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderDetailImportId > 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    var model = GetValue();
                    String qry = "update OrderImportDetail set Quantity=" + model.Total + ", TotalPrice = "+ model.TotalPrice + ", Note =N'"+model.Note+"' where Id=" + OrderDetailImportId + "";
                    SqlCommand sc = new SqlCommand(qry, con);
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        LoadFormcustom();
                        SetValueNull();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.");
                    }
                    con.Close();
                    OrderDetailImportId = 0;
                }
                
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (OrderDetailImportId > 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string qry = "delete from OrderImportDetail where Id=" + OrderDetailImportId + "";
                    SqlCommand sc = new SqlCommand(qry, con);
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Xóa thành công thành công.");
                        LoadFormcustom();
                        SetValueNull();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.");
                    }

                    con.Close();
                }
               
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvOrderDetailImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewCell cell in dgvOrderDetailImport.SelectedCells)
            {
                //cell.RowIndex
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Id"].Value != null)
                {
                    OrderDetailImportId = Convert.ToInt32(dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Id"].Value.ToString());
                }
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["CodeOrder"].Value != null)
                {
                    string codeOrder = dgvOrderDetailImport.Rows[cell.RowIndex].Cells["CodeOrder"].Value.ToString();
                    var orderImport = GetOrderImportByCode(codeOrder);
                    if (orderImport != null)
                    {
                        cmbMaPhieuNhap.SelectedValue = orderImport.Id;
                    }
                }
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["MaSanPham"].Value != null)
                {
                    cmbSanPham.SelectedValue = dgvOrderDetailImport.Rows[cell.RowIndex].Cells["MaSanPham"].Value.ToString();
                }
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Total"].Value != null)
                {
                    txtSoLuong.Text = dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Total"].Value.ToString();
                }
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["txtTongGia"].Value != null)
                {
                    txtPrice.Text = dgvOrderDetailImport.Rows[cell.RowIndex].Cells["txtTongGia"].Value.ToString();
                }
                if (dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Note"].Value != null)
                {
                    txtNote.Text = dgvOrderDetailImport.Rows[cell.RowIndex].Cells["Note"].Value.ToString();
                }
                //cmbMaPhieuNhap.Show();
            }
        }
    }
}
