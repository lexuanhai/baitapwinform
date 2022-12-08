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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DDVHBI0;Initial Catalog=MyPham;Integrated Security=True");
        public OrderImportDetail()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void Phong_Load(object sender, EventArgs e)
        //{
        //    LoadFormcustom();
        //    LoadDataPhieuNhapCombobox();
        //    LoadDataSanPhamCombobox();
        //}
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
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT oid.Id as OrderDetailId,CodeOrder,UserName,CreateDated,pr.id as ProductId,pr.name as ProductName,oid.Quantity as OrderDetailImportQuantity,oid.TotalPrice as OrderDetailImportTotalPrice,oid.Note as OrderDetailImportNote FROM OrderImport oi inner join OrderImportDetail oid on oi.Id = oid.OrderImportId inner join Products pr on oid.ProductId = pr.id", con);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT oid.Id as OrderDetailId, CodeOrder, MaNV, CreateDated, pr.id as ProductId, pr.name as ProductName, oid.Quantity as OrderDetailImportQuantity,oid.Price as Price ,oid.TotalPrice as OrderDetailImportTotalPrice, oid.Note as OrderDetailImportNote FROM OrderImport oi inner join OrderImportDetail oid on oi.Id = oid.OrderImportId inner join Products pr on oid.ProductId = pr.id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrdersDetailImport.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dgvOrdersDetailImport.Rows.Add();
                dgvOrdersDetailImport.Rows[n].Cells[0].Value = dr["OrderDetailId"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[1].Value = dr["CodeOrder"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[2].Value = dr["ProductId"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[3].Value = dr["ProductName"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[4].Value = dr["CreateDated"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[5].Value = dr["OrderDetailImportQuantity"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[6].Value = dr["Price"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[7].Value = dr["OrderDetailImportTotalPrice"].ToString();
                dgvOrdersDetailImport.Rows[n].Cells[8].Value = dr["OrderDetailImportNote"].ToString();

            }
        }

        public PhieuModel GetOrderImportByCode(string codeOrder)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,CodeOrder,CreateDated,MaNV from OrderImport where CodeOrder = '" + codeOrder + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var phieuModel = new PhieuModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.MaPhieu = dr["CodeOrder"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
                phieuModel.NgayNhap = Convert.ToDateTime(dr["CodeOrder"]);
                phieuModel.UserName = dr["MaNV"].ToString();
                phieuModel.Total = Convert.ToInt32(dr["Total"].ToString());
            }
            return phieuModel;
        }

        public OrderImportDetailExportModel GetDetailOrderDetailProduct(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var orderImportDetailExportModel = new OrderImportDetailExportModel();
                var phieuNhap = GetOrderImportByCode(code);
                if (phieuNhap != null)
                {
                    orderImportDetailExportModel.PhieuNhap = phieuNhap;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM OrderImport oi inner join Staff st on oi.MaNV = st.MaNV " +
                        "inner join OrderImportDetail oid on oi.Id = oid.OrderImportId " +
                        "inner join Products pr on oid.ProductId = pr.id " +
                        "where oi.CodeOrder =" + code + "", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    var phieuModel = new PhieuModel();
                    if (dt.Rows != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            phieuModel.MaPhieu = dr["CodeOrder"].ToString();
                            phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
                        }
                    }
                    
                }
            }
            
            return null;
        }


        public OrderImportDetailModel GetValue()
        {
            var model = new OrderImportDetailModel();
            model.OrderImportId = Convert.ToInt32(cmbMaPhieuNhap.SelectedValue);
            model.ProductId = Convert.ToInt32(cmbSanPham.SelectedValue);
            model.Price = Convert.ToDecimal(txtPrice.Text);
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
                if (model != null)
                {
                    decimal totalPrice = 0;
                    if (model.Total > 0 && model.Price > 0)
                    {
                        totalPrice = model.Total * model.Price;
                    }
                    model.NgayNhap = DateTime.Now;
                    var qry = "insert into OrderImportDetail(ProductId,OrderImportId,Quantity,Price,TotalPrice,Note) values(" + model.ProductId + "," + model.OrderImportId + "," + model.Total + "," + model.Price + "," + totalPrice + ",N'" + model.Note + "')";
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
                }

                con.Close();

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }
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
                    String qry = "update OrderImportDetail set Quantity=" + model.Total + ", TotalPrice = "+ model.Price + ", Note =N'"+model.Note+"' where Id=" + OrderDetailImportId + "";
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

        //private void dgvOrderDetailImport_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    foreach (DataGridViewCell cell in dgvOrdersDetailImport.SelectedCells)
        //    {
        //        //cell.RowIndex
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Id"].Value != null)
        //        {
        //            OrderDetailImportId = Convert.ToInt32(dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Id"].Value.ToString());
        //        }
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["CodeOrder"].Value != null)
        //        {
        //            string codeOrder = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["CodeOrder"].Value.ToString();
        //            var orderImport = GetOrderImportByCode(codeOrder);
        //            if (orderImport != null)
        //            {
        //                cmbMaPhieuNhap.SelectedValue = orderImport.Id;
        //            }
        //        }
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["MaSP"].Value != null)
        //        {
        //            cmbSanPham.SelectedValue = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["MaSP"].Value.ToString();
        //        }
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Total"].Value != null)
        //        {
        //            txtSoLuong.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Total"].Value.ToString();
        //        }
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["txtTongGia"].Value != null)
        //        {
        //            txtPrice.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["txtTongGia"].Value.ToString();
        //        }
        //        if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Note"].Value != null)
        //        {
        //            txtNote.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["Note"].Value.ToString();
        //        }
        //        //cmbMaPhieuNhap.Show();
        //    }
        //}

        private void OrderImportDetail_Load(object sender, EventArgs e)
        {
            LoadFormcustom();
            LoadDataPhieuNhapCombobox();
            LoadDataSanPhamCombobox();
        }
        public ProductModel GetProductById(int productId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,name,priceCustom from Products where Id = '" + productId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var product = new ProductModel();
            foreach (DataRow dr in dt.Rows)
            {
                product.Id = Convert.ToInt32(dr["Id"]);
                product.Name = dr["name"].ToString();
                if (dr["priceCustom"] != null)
                {
                    product.Price = Convert.ToDecimal(dr["priceCustom"]);
                }
            }
            return product;
        }

        private void dgvOrdersDetailImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrdersDetailImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvOrdersDetailImport.SelectedCells)
            {
                //cell.RowIndex
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdId"].Value != null)
                {
                    OrderDetailImportId = Convert.ToInt32(dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdId"].Value.ToString());
                }
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdCode"].Value != null)
                {
                    string codeOrder = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdCode"].Value.ToString();
                    var orderImport = GetOrderImportByCode(codeOrder);
                    if (orderImport != null)
                    {
                        cmbMaPhieuNhap.SelectedValue = orderImport.Id;
                    }
                }
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdProductId"].Value != null)
                {
                    var productId = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdProductId"].Value.ToString();
                    cmbSanPham.SelectedValue = productId;
                    //if (!string.IsNullOrEmpty(productId))
                    //{
                    //    cmbSanPham.SelectedValue = productId;
                    //    int _productId = Convert.ToInt32(productId);
                    //    var product = GetProductById(_productId);
                    //    if (product != null)
                    //    {

                    //    }
                    //}

                }
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdQuantity"].Value != null)
                {
                    txtSoLuong.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdQuantity"].Value.ToString();
                }
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdPrice"].Value != null)
                {
                    txtPrice.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdPrice"].Value.ToString();
                }
                if (dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdNote"].Value != null)
                {
                    txtNote.Text = dgvOrdersDetailImport.Rows[cell.RowIndex].Cells["tdNote"].Value.ToString();
                }
                //cmbMaPhieuNhap.Show();
            }
        }

        private void btnInHoaDonNhap_Click(object sender, EventArgs e)
        {
            string code = cmbMaPhieuNhap.SelectedText;
            if (!string.IsNullOrEmpty(code))
            {
                var phieuNhap = GetOrderImportByCode(code);
                if (phieuNhap != null)
                {

                }
            }
            
        }
    }
}
