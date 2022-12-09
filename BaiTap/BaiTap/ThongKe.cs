﻿using BaiTap.data;
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
    public partial class ThongKe : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DDVHBI0;Initial Catalog=MyPham;Integrated Security=True");     
        public ThongKe()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }                   
        public void LoadFormcustom()
        {

            
        }
        public void LoadDataForDatetime(string queryWhere)
        {
            if (!string.IsNullOrEmpty(queryWhere))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "select name," +
                    "pr.price," +
                    "oid.Quantity as QuantityImport," +
                    "eid.Quantity," +
                    "oi.CreateDated," +
                    "ei.CreatedDate," +
                    "eid.TotalPrice " +
                    "from Products pr " +
                    "left join OrderImportDetail oid on pr.id = oid.ProductId" +
                    " left join OrderImport oi on oi.Id = oid.OrderImportId " +
                    "left join OrderExportDetail eid on eid.ProductId = pr.id " +
                    "left join OrderExport ei on ei.Id = eid.OrderExportId ";
                query += queryWhere;
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvThongTinThongKe.Rows.Clear();
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    i++;
                    int n = dgvThongTinThongKe.Rows.Add();
                    dgvThongTinThongKe.Rows[n].Cells[0].Value = i.ToString();
                    dgvThongTinThongKe.Rows[n].Cells[1].Value = dr["name"].ToString();
                    dgvThongTinThongKe.Rows[n].Cells[2].Value = dr["price"].ToString();
                    dgvThongTinThongKe.Rows[n].Cells[3].Value = dr["QuantityImport"].ToString();
                    dgvThongTinThongKe.Rows[n].Cells[4].Value = dr["Quantity"].ToString();
                    dgvThongTinThongKe.Rows[n].Cells[5].Value = Convert.ToDecimal(dr["TotalPrice"]).ToString("#,###");
                    dgvThongTinThongKe.Rows[n].Cells[6].Value = Convert.ToDateTime(dr["CreateDated"]).ToString("dd/MM/yyyy");
                    dgvThongTinThongKe.Rows[n].Cells[7].Value = Convert.ToDateTime(dr["CreatedDate"]).ToString("dd/MM/yyyy");
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }       
        private void OrderExport_Load(object sender, EventArgs e)
        {
            LoadFormcustom();
        }
        public string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}-{1}-{2}", elements[2], elements[1], elements[0]);
            return dt;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var ngaybatdau = datetimpiceNgayBatDau.Value;
            var ngayketthuc = datetimpickeNgayKetThuc.Value;
            
            if (ngaybatdau != null && ngayketthuc != null)
            {
                string strngaybatdau = ConvertDateTime(ngaybatdau.ToString("dd/MM/yyyy"));
                string strngayketthuc = ConvertDateTime(ngayketthuc.ToString("dd/MM/yyyy"));
                var query = "where oi.CreateDated >= '"+ strngaybatdau + "' and ei.CreatedDate <= '"+ strngayketthuc + "'";
                LoadDataForDatetime(query);
            }else if (ngaybatdau != null)
            {
                string strngaybatdau = ConvertDateTime(ngaybatdau.ToString("dd/MM/yyyy"));
                var query = "where oi.CreateDated >= '" + strngaybatdau + "'";
                LoadDataForDatetime(query);
            }else if (ngayketthuc != null)
            {
                string strngayketthuc = ConvertDateTime(ngayketthuc.ToString("dd/MM/yyyy"));
                var query = "where ei.CreatedDate <= '" + strngayketthuc + "'";
                LoadDataForDatetime(query);
            }
        }
    }
}
