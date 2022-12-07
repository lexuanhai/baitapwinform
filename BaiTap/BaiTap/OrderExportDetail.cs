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
        private int OrderDetailImportId = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DDVHBI0;Initial Catalog=MyPham;Integrated Security=True");
        public OrderExportDetail()
        {
            txtTenDaiLy.ReadOnly = true;
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT oid.Id as OrderExportId, oi.Code As Code,oid.Status as Status, ,UserName, oi.AgentName, pr.id as ProductId,pr.price, pr.name as ProductName, oid.Quantity as OrderDetailExportQuantity, oid.TotalPrice as OrderDetailExportTotalPrice, oid.Note as OrderDetailExportNote FROM OrderExport oi inner join OrderExportDetail oid on oi.Id = oid.OrderExportId inner join Products pr on oid.ProductId = pr.id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderExportDetail.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dgvOrderExportDetail.Rows.Add();
                dgvOrderExportDetail.Rows[n].Cells[0].Value = dr["Id"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[1].Value = dr["Code"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[2].Value = dr["ProductId"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[3].Value = dr["ProductName"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[4].Value = dr["AgentName"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[5].Value = dr["price"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[6].Value = dr["OrderDetailExportQuantity"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[7].Value = dr["OrderDetailExportNote"].ToString();
                dgvOrderExportDetail.Rows[n].Cells[8].Value = dr["Status"].ToString();
                //dgvOrderExportDetail.Rows[n].Cells[7].Value = dr["OrderDetailImportNote"].ToString();

            }
        }

        public PhieuModel GetOrderImportByCode(string codeOrder)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,Code from OrderExport where Code = '" + codeOrder + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderExportDetail.Rows.Clear();
            var phieuModel = new PhieuModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.MaPhieu = dr["Code"].ToString();
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
            dgvOrderExportDetail.Rows.Clear();
            var phieuModel = new OrderExportModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.Code = dr["Code"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
                phieuModel.AgentName = dr["AgentName"].ToString();
            }
            return phieuModel;
        }

        public OrderExportModel GetProductById(int productId)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("select Id,Code,AgentName from OrderExport where Id = '" + productId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvOrderExportDetail.Rows.Clear();
            var phieuModel = new OrderExportModel();
            foreach (DataRow dr in dt.Rows)
            {
                phieuModel.Code = dr["Code"].ToString();
                phieuModel.Id = Convert.ToInt32(dr["Id"].ToString());
                phieuModel.AgentName = dr["AgentName"].ToString();
            }
            return phieuModel;
        }

        public OrderExportDetailModel GetValue()
        {
            var model = new OrderExportDetailModel();
            model.OrderExportId = Convert.ToInt32(cmbMaPhieu.SelectedValue);
            model.ProductId = Convert.ToInt32(cmbSanPham.SelectedValue);            
            model.Quantity = Convert.ToInt32(txtSoLuong.Text);
            model.Note = txtNote.Text;
            model.Status = cmbTinhTrang.SelectedItem.ToString();
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
                decimal totalPrice = 0;
                if (model.TotalPrice > 0 && model.Quantity > 0)
                {
                    totalPrice = model.TotalPrice
                }

                var qry = "insert into OrderExportDetail(ProductId,OrderExportId,Quantity,TotalPrice,Status,Note) values(" + model.ProductId + "," + model.OrderExportId + "," + model.Quantity + "," + model.TotalPrice + ",'N" + model.Note + "')";
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
                //if (OrderDetailImportId > 0)
                //{
                //    if (con.State == ConnectionState.Closed)
                //    {
                //        con.Open();
                //    }
                //    var model = GetValue();
                //    String qry = "update OrderImportDetail set Quantity=" + model.Total + ", TotalPrice = "+ model.TotalPrice + ", Note =N'"+model.Note+"' where Id=" + OrderDetailImportId + "";
                //    SqlCommand sc = new SqlCommand(qry, con);
                //    int i = sc.ExecuteNonQuery();
                //    if (i >= 1)
                //    {
                //        MessageBox.Show("Cập nhật thành công.");
                //        LoadFormcustom();
                //        SetValueNull();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Cập nhật không thành công.");
                //    }
                //    con.Close();
                //    OrderDetailImportId = 0;
                //}
                
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

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderExportDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
