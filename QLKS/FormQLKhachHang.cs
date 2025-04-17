using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{

    public partial class FormQLKhachHang: Form
    {
        private DatabaseConnection connection;
        public FormQLKhachHang()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
            LoadKhachHang();
            dgvkh.CellClick += new DataGridViewCellEventHandler(dgvkh_CellClick);
        }
        private void LoadKhachHang()
        {
            string query = "SELECT *FROM Customer";
            DataTable dt = connection.ExecuteQuery(query);
            dgvkh.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query =" INSERT INTO Customer( FullName,PhoneNumber,IDNumber,Address) VALUES(N'"+txttenkh.Text+"', '"+txtsdt.Text+"','"+txtcccd.Text+"',N'"+txtdc.Text+"')";
            connection.ExecuteQuery(query);
            MessageBox.Show("Thêm khách hàng thành công !");
            LoadKhachHang();
            txttenkh.Clear();
            txtsdt.Clear();
            txtdc.Clear();
            txtcccd.Clear();
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                DataGridViewRow row =dgvkh.Rows[e.RowIndex];
                txttenkh.Text=row.Cells["FullName"].Value?.ToString()?? "";
                txtsdt.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtcccd.Text = row.Cells["IDNumber"].Value?.ToString() ?? "";
                txtdc .Text = row.Cells["Address"].Value?.ToString() ?? "";
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvkh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            int CustomerID = Convert.ToInt32(dgvkh.CurrentRow.Cells["CustomerID"].Value);
            string query = "UPDATE Customer SET FullName = N'" + txttenkh.Text +
                          "', PhoneNumber ='" + txtsdt.Text +
                          "',IDNumber ='" + txtcccd.Text +
                          "',Address = N'" + txtdc.Text +
                          "'WHERE CustomerID = " + CustomerID;
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Sửa thông tin khách hàng  thành công!");
            LoadKhachHang();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvkh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tầng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng  này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int CustomerID = Convert.ToInt32(dgvkh.CurrentRow.Cells["CustomerID"].Value);
                string query = "DELETE FROM Customer WHERE CustomerID = " + CustomerID;
                connection.ExecuteNonQuery(query);
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadKhachHang();
            }
        }
    }
}
