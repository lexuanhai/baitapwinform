using BaiTap.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class OrderExport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=G07VNXDFVLTTI15;Initial Catalog=MyPham;Integrated Security=True");
        private int OrderExportId = 0;
        public OrderExport()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
        private void Phong_Load(object sender, EventArgs e)
        {
            //LoadFormcustom();
            //LoadDataCombobox();
            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;

            //var _cmbTinhTrang = new List<CmbTinhTrang>() {
            //    new CmbTinhTrang(){Name="Da cho thue",Text="Có khách"},
            //    new CmbTinhTrang(){Name="Chua cho thue",Text="Trống"},
            //};
            //cmbNhanVien.DataSource = _cmbTinhTrang;
            //cmbNhanVien.DisplayMember = "Text";
            //cmbNhanVien.ValueMember = "Name";
        }
        public void LoadDataCombobox()
        {
            string query = "select MaNV, Name from Staff";
            con.Open();
            SqlCommand da = new SqlCommand(query, con);
            DataTable dt = new DataTable();
           
            SqlDataReader myReader = da.ExecuteReader();
            dt.Load(myReader);
                      
            cmbNhanVien.DisplayMember = "Name";
            cmbNhanVien.ValueMember = "MaNV";
            cmbNhanVien.DataSource = dt;
            con.Close();
        }
        public void LoadFormcustom()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter("SELECT OE.[Id] as Id, [Code] ,[CreatedDate] ,AC.[name] AS [Name] ,OE.[UserName] AS UserName,OE.[Address] AS Address ,[AgentName] ,OE.[Phone] As Phone ,OE.[Email] AS [Email] ,[Total] ,[TypePayment] ,[Status] FROM OrderExport OE inner join Staff AC on OE.UserName = AC.MaNV", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPhieuXuat.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dgvPhieuXuat.Rows.Add();
                dgvPhieuXuat.Rows[n].Cells[0].Value = dr["Id"].ToString();
                dgvPhieuXuat.Rows[n].Cells[1].Value = dr["Code"].ToString();
                dgvPhieuXuat.Rows[n].Cells[2].Value = dr["UserName"].ToString();
                dgvPhieuXuat.Rows[n].Cells[3].Value = dr["Name"].ToString();
                dgvPhieuXuat.Rows[n].Cells[4].Value = dr["AgentName"].ToString();
                dgvPhieuXuat.Rows[n].Cells[5].Value = dr["Phone"].ToString();
                dgvPhieuXuat.Rows[n].Cells[6].Value = dr["Email"].ToString();
                dgvPhieuXuat.Rows[n].Cells[7].Value = dr["Address"].ToString();
                dgvPhieuXuat.Rows[n].Cells[8].Value = Convert.ToDateTime(dr["CreatedDate"]).ToString("dd/MM/yyyy");
                dgvPhieuXuat.Rows[n].Cells[9].Value = dr["TypePayment"].ToString();
                dgvPhieuXuat.Rows[n].Cells[10].Value = dr["Status"].ToString();

            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        
        public OrderExportModel GetValue()
        {
            var model = new OrderExportModel();            
            model.Code = txsMaPhieu.Text;
            model.UserName = cmbNhanVien.SelectedValue.ToString();
            model.AgentName = txtTenDaiLy.Text;
            model.Phone = txtPhone.Text;
            model.Email = txtEmail.Text;
            model.Address = txtAddress.Text;           
            model.TypePayment = cmbPuongThucThanhToan.SelectedItem.ToString();
            model.Status = cmbTinhTrang.SelectedItem.ToString();
            model.CreatedDate = datetimpiceNgayNhap.Value;
            return model;
        }
        public void SetValue(OrderExportModel model)
        {
            txsMaPhieu.Text = model.Code;
            cmbNhanVien.SelectedValue = model.UserName;
            txtTenDaiLy.Text = model.AgentName;
            txtPhone.Text = model.Phone;
            txtEmail.Text = model.Email;
            txtAddress.Text = model.Address;
            cmbPuongThucThanhToan.SelectedItem = model.TypePayment;
            cmbTinhTrang.SelectedItem = model.Status;
        }
        public void SetValueNull()
        {
            txsMaPhieu.Text = "";
            cmbNhanVien.SelectedValue = "";
            txtTenDaiLy.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cmbPuongThucThanhToan.SelectedItem = "";
            cmbTinhTrang.SelectedItem = "";
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

                if (ExistMaKH(model.Code))
                {
                    MessageBox.Show("Mã phiếu " + model.Code + " đã tồn tại vui lòng nhập mã khác");
                }
                else
                {
                    //model.NgayNhap = DateTime.Now;
                    //var qry = "insert into OrderImport values('" + model.MaPhieu + "','" + model.UserName + "','" + model.NgayNhap + "'," + model.Total + ",'N" + model.Note + "')";
                    var qry = "Insert into OrderExport(Code, UserName, AgentName, Phone, Email, Address, TypePayment, Status,CreatedDate) values('" + model.Code + "','" + model.UserName + "','" + model.AgentName + "','" + model.Phone + "','" + model.Email + "',N'" + model.Address + "',N'" + model.TypePayment + "',N'" + model.Status + "','" + model.CreatedDate + "')";
                        //"values('" + model.Code + "','"+model.UserName+"','"+model.AgentName+"','"+model.Phone+"','"+model.Email+"',N'"+model.Address+"',N'"+model.TypePayment+"',N'"+model.Status+"')";
                    SqlCommand sc = new SqlCommand(qry, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        MessageBox.Show("Thêm mới " + model.Code + " thành công.");
                        LoadFormcustom();
                        SetValueNull();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới " + model.Code + " không thành công.");
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
                query = "select * from OrderExport where Code = @maP";
            }
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

            return false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                var model = GetValue();
                String qry = "Update OrderExport set " +
                    "CreatedDate ='"+ model.CreatedDate + "'," +
                    "AgentName =N'"+model.AgentName+"', " +
                    "Phone ='"+model.Phone+"', " +
                    "Email ='"+model.Email+"', " +
                    "Address =N'"+model.Address+"', " +
                    "Total ='"+model.Total+"', " +
                    "TypePayment =N'"+model.TypePayment+"', " +
                    "Status =N'" + model.Status+"'" +
                    "Where Id='"+ OrderExportId + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Cập nhật thành công " + model.Code + " thành công.");
                    LoadFormcustom();
                    SetValueNull();
                }
                else
                {
                    MessageBox.Show("Cập nhật " + model.Code + " không thành công.");
                }
                con.Close();
                OrderExportId = 0;
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());
                OrderExportId = 0;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn mã  "+ txsMaPhieu.Text.ToString() + " xóa?","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                string map = txsMaPhieu.Text.ToString();
                string qry = "delete from OrderExport where Id='" + OrderExportId + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Xóa thành công " + map + " thành công.");
                    LoadFormcustom();
                    SetValueNull();
                }
                else
                {
                    MessageBox.Show("Xóa " + map + " không thành công.");
                }
                OrderExportId = 0;
                con.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            OrderExportId = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public  string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[2], elements[1], elements[0]);
            return dt;
        }
        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvPhieuXuat.SelectedCells)
            {
                //cell.RowIndex
               
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdId"].Value != null)
                {
                    string id = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdId"].Value.ToString();
                    if (!string.IsNullOrEmpty(id))
                    {
                        OrderExportId = Convert.ToInt32(id);
                    }
                }

                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdMaPhieu"].Value != null)
                {
                    txsMaPhieu.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdMaPhieu"].Value.ToString();
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdMaNV"].Value != null)
                {
                    cmbNhanVien.SelectedValue = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdMaNV"].Value.ToString();
                }               
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdTenDaiLy"].Value != null)
                {
                    txtTenDaiLy.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdTenDaiLy"].Value.ToString();
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdPhone"].Value != null)
                {
                    txtPhone.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdPhone"].Value.ToString();
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdEmail"].Value != null)
                {
                    txtEmail.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdEmail"].Value.ToString();
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdDiaChi"].Value != null)
                {
                    txtAddress.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdDiaChi"].Value.ToString();                   
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdNgayXuat"].Value != null)
                {
                    datetimpiceNgayNhap.Value = Convert.ToDateTime(ConvertDateTime(dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdNgayXuat"].Value.ToString()));
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdPhuongThucThanhToan"].Value != null)
                {
                    cmbPuongThucThanhToan.SelectedItem = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdPhuongThucThanhToan"].Value.ToString();
                }
                if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdTinhTrang"].Value != null)
                {
                    cmbTinhTrang.SelectedItem = dgvPhieuXuat.Rows[cell.RowIndex].Cells["tdTinhTrang"].Value.ToString();
                }
            }
        }

        private void OrderExport_Load(object sender, EventArgs e)
        {
            LoadFormcustom();
            LoadDataCombobox();
        }

        //private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txsMaPhieu.ReadOnly = true;
        //    foreach (DataGridViewCell cell in dgvPhieuXuat.SelectedCells)
        //    {
        //        //cell.RowIndex

        //        if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["CodeOrder"].Value != null)
        //        {
        //            txsMaPhieu.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["CodeOrder"].Value.ToString();
        //        }
        //        if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["MaNV"].Value != null)
        //        {
        //            cmbNhanVien.SelectedValue = dgvPhieuXuat.Rows[cell.RowIndex].Cells["MaNV"].Value.ToString();                   
        //        }
        //        if (dgvPhieuXuat.Rows[cell.RowIndex].Cells["Total"].Value != null)
        //        {
        //            txtTongSanPham.Text = dgvPhieuXuat.Rows[cell.RowIndex].Cells["Total"].Value.ToString();
        //        }
        //        cmbNhanVien.Show();
        //    }
        //}
    }
}
