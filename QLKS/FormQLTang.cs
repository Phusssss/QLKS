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
    public partial class FormQLTang : Form
    {
        private DatabaseConnection connection;

        public FormQLTang()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
            LoadTang();
            tb_Tang.CellClick += new DataGridViewCellEventHandler(tb_Tang_CellClick); 
        }

        private void LoadTang()
        {
            string query = "SELECT * FROM Floor";
            DataTable dt = connection.ExecuteQuery(query);
            tb_Tang.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Floor (FloorNumber, Description) VALUES (N'" +
                          txt_numberFloor.Text + "', N'" + txt_Mota.Text + "')";
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Thêm tầng thành công!");
            LoadTang();
            txt_numberFloor.Clear();
            txt_Mota.Clear();
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_Tang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tầng cần sửa!");
                return;
            }

            int floorID = Convert.ToInt32(tb_Tang.CurrentRow.Cells["FloorID"].Value);
            string query = "UPDATE Floor SET FloorNumber = N'" + txt_numberFloor.Text +
                          "', Description = N'" + txt_Mota.Text +
                          "' WHERE FloorID = " + floorID;
            connection.ExecuteNonQuery(query);
            MessageBox.Show("Sửa thông tin tầng thành công!");
            LoadTang();
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_Tang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tầng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tầng này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int floorID = Convert.ToInt32(tb_Tang.CurrentRow.Cells["FloorID"].Value);
                string query = "DELETE FROM Floor WHERE FloorID = " + floorID;
                connection.ExecuteNonQuery(query);
                MessageBox.Show("Xóa tầng thành công!");
                LoadTang();
            }
        }

        private void tb_Tang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tb_Tang.Rows[e.RowIndex];
                txt_numberFloor.Text = row.Cells["FloorNumber"].Value?.ToString() ?? "";
                txt_Mota.Text = row.Cells["Description"].Value?.ToString() ?? "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}