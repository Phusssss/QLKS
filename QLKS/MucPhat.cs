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
    public partial class FormQLMucPhat: Form
    {
        private DatabaseConnection connection;
        public FormQLMucPhat()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
            LoadMucPhat();
            dgvmucphat.CellClick += new DataGridViewCellEventHandler(dgvmucphat_CellClick);
        }
        private void LoadMucPhat()
        {
            string query = "SELECT * FROM MucPhat1";
            DataTable dt = connection.ExecuteQuery(query);
            dgvmucphat.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MucPhat1 (TenMucPhat, GiaTien,MoTa) VALUES (N'" +
                          txttenmucphat.Text + "', N'" + txtgiatien.Text + "',N'" + txtmota.Text + "')";
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Thêm mức phạt thành công!");
            LoadMucPhat();
            txttenmucphat .Clear();
            txtgiatien.Clear();
            txtmota.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvmucphat.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mức phạt cần sửa!");
                return;
            }

            int MaMucPhat = Convert.ToInt32(dgvmucphat.CurrentRow.Cells["MaMucPhat"].Value);
            string query = "UPDATE MucPhat1 SET TenMucPhat = N'" + txttenmucphat.Text +
                          "', GiaTien = N'" + txtgiatien.Text +
                          "' ,MoTa = N'"+txtmota.Text+"'WHERE MaMucPhat = " + MaMucPhat;
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Sửa thông tin mức phạt thành công!");
            LoadMucPhat();
        }

        private void dgvmucphat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvmucphat.Rows[e.RowIndex];
                txttenmucphat.Text = row.Cells["TenMucPhat"].Value?.ToString() ?? "";
                txtgiatien.Text = row.Cells["GiaTien"].Value?.ToString() ?? "";
                txtmota.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvmucphat.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mức phạt cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mức phạt này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int MaMucPhat = Convert.ToInt32(dgvmucphat.CurrentRow.Cells["MaMucPhat"].Value);
                string query = "DELETE FROM MucPhat1 WHERE MaMucPhat  = " + MaMucPhat;
                connection.ExecuteNonQuery(query);
                MessageBox.Show("Xóa mức phạt thành công!");
                LoadMucPhat();
            }
        }
    }
}
