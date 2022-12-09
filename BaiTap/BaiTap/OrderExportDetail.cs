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

    public partial class OrderExportDetail : Form
    {
        private int OrderExportDetailId = 0;
        SqlConnection con = new SqlConnection("Data Source=G07VNXDFVLTTI15;Initial Catalog=MyPham;Integrated Security=True");
        public OrderExportDetail()
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
            string query = "select Id, Code from OrderExport";
            con.Open();
            SqlCommand da = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataReader myReader = da.ExecuteReader();
            dt.Load(myReader);

            cmbMaPhieu.DisplayMember = "Code";
            cmbMaPhieu.ValueMember = "Id";
            cmbMaPhieu.DataSource = dt;
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT oid.Id as OrderExportId, " +
                "oi.Code As Code," +
                "oid.Status as [Status] ," +
                "UserName, oi.AgentName," +
                " pr.id as ProductId," +
                "pr.price, " +
                "pr.name as ProductName," +
                " oid.Quantity as OrderDetailExportQuantity," +
                " oid.TotalPrice as OrderDetailExportTotalPrice, " +
                "oid.Note as OrderDetailExportNote" +
                " FROM OrderExport oi " +
                "inner join OrderExportDetail oid on oi.Id = oid.OrderExportId " +
                " inner join Products pr on oid.ProductId = pr.id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderExportDetail.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dgvOrderExportDetail.Rows.Add();
                dgvOrderExportDetail.Rows[n].Cells[0].Value = dr["OrderExportId"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[1].Value = dr["Code"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[2].Value = dr["ProductId"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[3].Value = dr["ProductName"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[4].Value = dr["AgentName"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[5].Value = dr["price"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[6].Value = dr["OrderDetailExportQuantity"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[7].Value = dr["OrderDetailExportTotalPrice"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[8].Value = dr["OrderDetailExportNote"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[9].Value = dr["Status"].ToString();
                //dgvOrderExportDetail.Rows[n].Cells[7].Value = dr["OrderDetailImportNote"].ToString();

            }
        }

        public OrderExportModel GetOrderExportByCode(string codeOrder)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,Code from OrderExport where Code = '" + codeOrder + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var phieuModel = new OrderExportModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.Code = dr["Code"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
            }
            return phieuModel;
        }
        public OrderExportModel GetOrderImportById(int orderExportId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,Code,AgentName from OrderExport where Id = '" + orderExportId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var phieuModel = new OrderExportModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.Code = dr["Code"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
                phieuModel.AgentName = dr["AgentName"].ToString();
            }
            return phieuModel;
        }

        public ProductModel GetProductById(int productId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,name,price from Products where Id = '" + productId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var product = new ProductModel();
            foreach (DataRow dr in dt.Rows)
            {
                product.Id = Convert.ToInt32(dr["Id"]);
                product.Name = dr["name"].ToString();
                if (dr["price"] != null)
                {
                    product.Price = Convert.ToDecimal(dr["price"]);
                }
            }
            return product;
        }

        public OrderExportDetailModel GetValue()
        {
            var model = new OrderExportDetailModel();
            model.OrderExportId = Convert.ToInt32(cmbMaPhieu.SelectedValue);
            model.ProductId = Convert.ToInt32(cmbSanPham.SelectedValue);            
            model.Quantity = Convert.ToInt32(txtSoLuong.Text);
            model.Note = txtNote.Text;
            model.Status = (cmbTinhTrang.SelectedItem != null ? cmbTinhTrang.SelectedItem.ToString() : "");
            return model;
        }
        public void SetValue(OrderExportDetailModel model)
        {
            cmbMaPhieu.SelectedValue = model.OrderExportId;
            cmbSanPham.SelectedValue = model.ProductId;
            txtSoLuong.Text = model.Quantity.ToString();
            cmbTinhTrang.SelectedItem = model.Status;
            txtNote.Text = model.Note;
            if (model.OrderExportId > 0)
            {
                var orderExport = GetOrderImportById(model.OrderExportId);
                if (orderExport != null)
                {
                    txtTenDaiLy.Text = orderExport.AgentName;
                }
            }
           // txtTenDaiLy.Text = model.Note;
        }
        public void SetValueNull()
        {
            txtNote.Text = "";
            txtTenDaiLy.Text = "";
            txtSoLuong.Text = "";
            cmbMaPhieu.SelectedItem = "";
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
                    var product = new ProductModel();
                    if (model.ProductId > 0)
                    {
                        product = GetProductById(model.ProductId);
                    }
                    if (product != null)
                    {
                        decimal totalPrice = 0;
                        if (model.Quantity > 0 && product.Price > 0)
                        {
                            model.TotalPrice = model.Quantity * product.Price;
                        }
                    }
                   
                    var qry = "insert into OrderExportDetail(ProductId,OrderExportId,Quantity,TotalPrice,Status,Note)" +
                    "values(" + model.ProductId + "," + model.OrderExportId + "," + model.Quantity + "," + model.TotalPrice + ",N'" + model.Status + "',N'" + model.Note + "')";
                    SqlCommand sc = new SqlCommand(qry, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Thêm mới  thành công.");
                        LoadFormcustom();
                        SetValueNull();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới không thành công.");
                    }
                }
                
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}

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
                if (OrderExportDetailId > 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    var model = GetValue();
                    if (model != null)
                    {
                        var product = new ProductModel();
                        if (model.ProductId > 0)
                        {
                            product = GetProductById(model.ProductId);
                        }
                        if (product != null)
                        {
                            if (model.Quantity > 0 && product.Price > 0)
                            {
                                model.TotalPrice = model.Quantity * product.Price;
                            }
                        }
                        String qry = "update OrderExportDetail set Quantity=" + model.Quantity + ", TotalPrice = " + model.TotalPrice + ", Note=N'" + model.Note + "',Status=N'" + model.Status + "' where Id=" + OrderExportDetailId + "";
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
                    }
                   
                    OrderExportDetailId = 0;
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
                if (OrderExportDetailId > 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string qry = "delete from OrderExportDetail where Id=" + OrderExportDetailId + "";
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

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderExportDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvOrderExportDetail.SelectedCells)
            {
                //cell.RowIndex
                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdId"].Value != null)
                {
                    OrderExportDetailId = Convert.ToInt32(dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdId"].Value.ToString());
                }
                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdCode"].Value != null)
                {
                    var orderImport = GetOrderExportByCode(dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdCode"].Value.ToString());
                    cmbMaPhieu.SelectedValue = orderImport.Id;
                }

                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdMaSanPham"].Value != null)
                {
                    cmbSanPham.SelectedValue = dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdMaSanPham"].Value.ToString();
                }
                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTenDaiLy"].Value != null)
                {
                    txtTenDaiLy.Text = dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTenDaiLy"].Value.ToString();
                }
                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTotal"].Value != null)
                {
                    txtSoLuong.Text = dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTotal"].Value.ToString();
                }

                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTrangThai"].Value != null)
                {
                    cmbTinhTrang.SelectedItem = dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdTrangThai"].Value.ToString();
                }
                if (dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdNote"].Value != null)
                {
                    txtNote.Text = dgvOrderExportDetail.Rows[cell.RowIndex].Cells["tdNote"].Value.ToString();
                }
            }
        }

        private void OrderExportDetail_Load(object sender, EventArgs e)
        {
            LoadFormcustom();
            LoadDataPhieuNhapCombobox();
            LoadDataSanPhamCombobox();
        }

        public OrderExportDetailPDFModel GetDetailOrderDetailProduct(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var orderExportDetailPDFModel = new OrderExportDetailPDFModel();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Code," +
                    "oi.CreatedDate as CreatedDateOi," +
                    "AgentName," +
                    "Phone," +
                    "Email," +
                    "Address," +
                    "Total," +
                    "TypePayment," +
                    "oi.Status as StatusOi," +
                    "st.MaNV as MaNV," +
                    "st.Name as Name," +
                    "pr.name as ProductName," +
                    "pr.price as ProductPrice," +
                    "oid.Quantity as Quantity," +
                    "oid.TotalPrice as TotalPrice," +
                    "oid.Status as StatusOID," +
                    "oid.Note as NoteOID " +
                    "FROM OrderExport oi " +
                    "inner join Staff st on oi.UserName = st.MaNV  " +
                    "inner join OrderExportDetail oid on oi.Id = oid.OrderExportId  " +
                    "inner join Products pr on oid.ProductId = pr.id " +
                    "where oi.Code ='"+ code + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    orderExportDetailPDFModel.CodeOrder = Convert.ToString(dt.Rows[0]["Code"]);
                    if (dt.Rows[0]["CreatedDateOi"] != null)
                    {
                        orderExportDetailPDFModel.CreatedDateStr = Convert.ToDateTime(dt.Rows[0]["CreatedDateOi"]).ToString("dd/MM/yyyy HH:mm");
                        orderExportDetailPDFModel.CreatedDate = Convert.ToDateTime(dt.Rows[0]["CreatedDateOi"]);
                    }
                    orderExportDetailPDFModel.MaNV = Convert.ToString(dt.Rows[0]["MaNV"]);
                    orderExportDetailPDFModel.Name = Convert.ToString(dt.Rows[0]["Name"]);
                    // tên đại lý
                    orderExportDetailPDFModel.AgentName = Convert.ToString(dt.Rows[0]["AgentName"]);
                    orderExportDetailPDFModel.Phone = Convert.ToString(dt.Rows[0]["Phone"]);
                    orderExportDetailPDFModel.Email = Convert.ToString(dt.Rows[0]["Email"]);
                    orderExportDetailPDFModel.Address = Convert.ToString(dt.Rows[0]["Address"]);
                    // hóa đơn xuất
                    orderExportDetailPDFModel.TypePayment = Convert.ToString(dt.Rows[0]["TypePayment"]);
                    orderExportDetailPDFModel.Status  = Convert.ToString(dt.Rows[0]["StatusOi"]);

                    orderExportDetailPDFModel.Note = Convert.ToString(dt.Rows[0]["NoteOID"]);
                    var listProducts = new List<ProductModel>();
                    int i = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        var product = new ProductModel();
                        product.Name = Convert.ToString(dt.Rows[i]["ProductName"]);
                        product.Price = Convert.ToDecimal(dt.Rows[i]["ProductPrice"]);
                        product.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"]);

                        product.TotalPriceView = Convert.ToDecimal(dt.Rows[i]["TotalPrice"]);
                        listProducts.Add(product);
                        i++;
                    }
                    orderExportDetailPDFModel.Products = listProducts;
                }
                return orderExportDetailPDFModel;
            }

            return null;
        }


        private void pdHoaDonXuat_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string code = cmbMaPhieu.Text;
            if (!string.IsNullOrEmpty(code))
            {
                //var phieu =  GetOrderImportByCode(string codeOrder);
                var detailOrderDetailProduct = GetDetailOrderDetailProduct(code);
                if (detailOrderDetailProduct != null)
                {
                    string day = DateTime.Now.Day > 10 ? DateTime.Now.Day.ToString() : "0" + DateTime.Now.Day.ToString();
                    string month = DateTime.Now.Month > 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString();
                    var w = pdHoaDonXuat.DefaultPageSettings.PaperSize.Width;
                    string date = "Ngày " + day + " tháng " + month + " năm " + DateTime.Now.Year;
                    e.Graphics.DrawString("PHIẾU XUẤT HÀNG", new Font("Courier New", 25, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 140, 40));
                    e.Graphics.DrawString(date, new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(w / 2 - 120, 90));
                    int y = 150;
                    int x = 20;
                    e.Graphics.DrawString("Mã phiếu       : " + detailOrderDetailProduct.CodeOrder, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Mã nhân viên   : " + detailOrderDetailProduct.MaNV, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Tên nhân viên  : " + detailOrderDetailProduct.Name, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Phương thực thanh toán  : " + detailOrderDetailProduct.TypePayment, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));                    
                    y += 40;
                    e.Graphics.DrawString("Tình trạng  : " + detailOrderDetailProduct.Status, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Thông tin khách hàng : ", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Tên khách hàng       : " + detailOrderDetailProduct.AgentName, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Số điện thoại        : " + detailOrderDetailProduct.Phone, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 40;
                    e.Graphics.DrawString("Địa chỉ              : " + detailOrderDetailProduct.Address, new Font("Courier New", 13, FontStyle.Regular), Brushes.Black, new Point(x, y));
                    y += 30;

                    e.Graphics.DrawString("STT", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    x += 50;
                    e.Graphics.DrawString("Tên sản phẩm", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    x += 170;
                    e.Graphics.DrawString("Giá ", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    x += 100;
                    e.Graphics.DrawString("Số lượng", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    x += 130;
                    e.Graphics.DrawString("Thành tiền", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    x += 140;
                    e.Graphics.DrawString("Ghi chú", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    //x += 70;
                    //e.Graphics.DrawString("Ghi chú", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(x, y));
                    decimal totalPrice = 0;
                    if (detailOrderDetailProduct.Products != null && detailOrderDetailProduct.Products.Count > 0)
                    {
                        int i = 0;
                        foreach (var item in detailOrderDetailProduct.Products)
                        {
                            i++;
                            y += 30;
                            int ix = 20;
                            decimal total = item.Price * item.Quantity;
                            totalPrice += total;
                            e.Graphics.DrawString(i.ToString(), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                            ix += 50;
                            e.Graphics.DrawString(item.Name, new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                            ix += 170;
                            e.Graphics.DrawString(item.Price.ToString(), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                            ix += 100;
                            e.Graphics.DrawString(item.Quantity.ToString(), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                            ix += 130;
                            e.Graphics.DrawString(item.TotalPriceView.ToString(), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                            ix += 140;
                            e.Graphics.DrawString(item.Note, new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(ix, y));
                        }
                    }
                    y += 40;
                    Pen blackpen = new Pen(Color.Black, 1);
                    Point p1 = new Point(10, y);
                    Point p2 = new Point(w - 10, y);
                    e.Graphics.DrawLine(blackpen, p1, p2);
                    y += 10;
                    e.Graphics.DrawString("Tổng tiền ", new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(20, y));
                    e.Graphics.DrawString(totalPrice.ToString("#,###"), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(470, y));
                }

            }
        }

        private void btnInHoaDonXuat_Click(object sender, EventArgs e)
        {
            prviewInHoaDonXuat.Document = pdHoaDonXuat;
            prviewInHoaDonXuat.ShowDialog();
        }
    }
}
