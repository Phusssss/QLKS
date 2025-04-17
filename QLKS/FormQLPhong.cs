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
    public partial class FormQLPhong : Form
    {
        private DatabaseConnection db;

        public FormQLPhong()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            LoadLoaiPhong();
            LoadTang();
            LoadPhong();
            cb_status.Items.AddRange(new string[] { "Trống", "Đã đặt", "Đang sử dụng" }); 
            tb_Phong.CellClick += new DataGridViewCellEventHandler(tb_Phong_CellClick);
        }

        private void LoadLoaiPhong()
        {
            string query = "SELECT * FROM RoomType";
            DataTable dt = db.ExecuteQuery(query);
            cb_LoaiPhong.DataSource = dt;
            cb_LoaiPhong.DisplayMember = "TypeName";
            cb_LoaiPhong.ValueMember = "RoomTypeID";
        }

        private void LoadTang()
        {
            string query = "SELECT * FROM Floor";
            DataTable dt = db.ExecuteQuery(query);
            cb_Tang.DataSource = dt;
            cb_Tang.DisplayMember = "FloorNumber";
            cb_Tang.ValueMember = "FloorID";
        }

        private void LoadPhong()
        {
            string query = "SELECT Room.RoomID, Room.RoomNumber, Room.RoomTypeID, Room.Status, Room.FloorID, " +
                          "RoomType.TypeName AS NameTypeRoom " +
                          "FROM Room " +
                          "JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID";
            DataTable dt = db.ExecuteQuery(query);
            tb_Phong.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string roomNumber = txt_NumberRoom.Text;
            int roomTypeID = Convert.ToInt32(cb_LoaiPhong.SelectedValue);
            string status = cb_status.SelectedItem?.ToString() ?? "Trống";
            int floorID = Convert.ToInt32(cb_Tang.SelectedValue);

            string query = "INSERT INTO Room (RoomNumber, RoomTypeID, Status, FloorID) " +
                          "VALUES (N'" + roomNumber + "', " + roomTypeID + ", N'" + status + "', " + floorID + ")";
            db.ExecuteNonQuery(query);
            MessageBox.Show("Thêm phòng thành công!");
            LoadPhong();
            txt_NumberRoom.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_Phong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            int roomID = Convert.ToInt32(tb_Phong.CurrentRow.Cells["RoomID"].Value);
            string roomNumber = txt_NumberRoom.Text;
            int roomTypeID = Convert.ToInt32(cb_LoaiPhong.SelectedValue);
            string status = cb_status.SelectedItem?.ToString() ?? "Trống";
            int floorID = Convert.ToInt32(cb_Tang.SelectedValue);

            string query = "UPDATE Room SET RoomNumber = N'" + roomNumber + "', " +
                          "RoomTypeID = " + roomTypeID + ", " +
                          "Status = N'" + status + "', " +
                          "FloorID = " + floorID + " " +
                          "WHERE RoomID = " + roomID;
            db.ExecuteNonQuery(query);
            MessageBox.Show("Sửa thông tin phòng thành công!");
            LoadPhong();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_Phong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int roomID = Convert.ToInt32(tb_Phong.CurrentRow.Cells["RoomID"].Value);
                string query = "DELETE FROM Room WHERE RoomID = " + roomID;
                db.ExecuteNonQuery(query);
                MessageBox.Show("Xóa phòng thành công!");
                LoadPhong();
            }
        }

        private void tb_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tb_Phong.Rows[e.RowIndex];
                txt_NumberRoom.Text = row.Cells["RoomNumber"].Value?.ToString() ?? "";
                cb_LoaiPhong.SelectedValue = row.Cells["RoomTypeID"].Value;
                cb_status.Text = row.Cells["Status"].Value?.ToString() ?? "";
                cb_Tang.SelectedValue = row.Cells["FloorID"].Value;
            }
        }

        private void txt_NumberRoom_TextChanged(object sender, EventArgs e)
        {
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_Tang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}