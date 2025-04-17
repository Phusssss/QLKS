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

namespace QLKS
{
    public partial class FormQLDichVu: Form
    {
        private DatabaseConnection connection;

        public FormQLDichVu()
        {
            InitializeComponent(); connection = new DatabaseConnection();
            LoadDichVu();
            dgvdichvu.CellClick += new DataGridViewCellEventHandler(dgvdichvu_CellClick);
        }
        private void LoadDichVu()
        {
            string query = "SELECT * FROM Service";
            DataTable dt = connection.ExecuteQuery(query);
            dgvdichvu.DataSource = dt;
        }
        private void FormQLDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Service (ServiceName, Price) VALUES (N'" +
                          txttendv.Text + "', N'" + txtgt.Text + "')";
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Thêm dịch vụ thành công!");
            LoadDichVu();
            txttendv.Clear();
            txtgt.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvdichvu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!");
                return;
            }

            int serviceID = Convert.ToInt32(dgvdichvu.CurrentRow.Cells["ServiceID"].Value);
            string query = "UPDATE Service SET ServiceName = N'" + txttendv.Text +
                          "', Price = N'" + txtgt.Text +
                          "' WHERE serviceID = " + serviceID;
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Sửa thông tin dịch vụ thành công!");
            LoadDichVu();
        }

        private void dgvdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvdichvu.Rows[e.RowIndex];
                txttendv.Text = row.Cells["ServiceName"].Value?.ToString() ?? "";
                txtgt.Text = row.Cells["Price"].Value?.ToString() ?? "";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvdichvu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int ServiceID = Convert.ToInt32(dgvdichvu.CurrentRow.Cells["ServiceID"].Value);
                string query = "DELETE FROM Service WHERE ServiceID = " + ServiceID;
                connection.ExecuteNonQuery(query);
                MessageBox.Show("Xóa dịch vụ thành công!");
                LoadDichVu();
            }
        }
    }
}
