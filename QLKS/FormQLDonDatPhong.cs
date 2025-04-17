using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormQLDonDatPhong : Form
    {
        private DatabaseConnection db;

        public FormQLDonDatPhong()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            LoadBookings();
        }


        private void LoadBookings()
        {
            try
            {
                string query = @"
                    SELECT 
                        b.BookingID,
                        c.FullName,
                        c.PhoneNumber,
                        b.CheckInTime,
                        b.CheckOutTime,
                        b.TotalRoomCost,
                        b.Status
                    FROM 
                        Booking b
                        INNER JOIN Customer c ON b.CustomerID = c.CustomerID";
                DataTable dt = db.ExecuteQuery(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách đơn đặt phòng: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Chọn toàn bộ dòng
                    dataGridView1.Rows[e.RowIndex].Selected = true;

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int bookingID = Convert.ToInt32(row.Cells["BookingID"].Value);

                    // Lấy thông tin chi tiết đơn đặt phòng
                    string query = @"
                        SELECT 
                            b.BookingID,
                            c.FullName,
                            c.PhoneNumber,
                            c.IDNumber,
                            b.CheckInTime,
                            b.CheckOutTime,
                            b.TotalRoomCost,
                            b.Status
                        FROM 
                            Booking b
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                        WHERE 
                            b.BookingID = @BookingID";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@BookingID", bookingID }
                    };
                    DataTable dt = db.ExecuteQuery(query, parameters);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow dataRow = dt.Rows[0];
                        txt_MaDatPhong.Text = dataRow["BookingID"].ToString();
                        txt_TenKhachHang.Text = dataRow["FullName"].ToString();
                        txt_SDT.Text = dataRow["PhoneNumber"].ToString();
                        txt_CCCD.Text = dataRow["IDNumber"].ToString();
                        
                    }

                    // Lấy danh sách phòng của đơn đặt phòng
                    string roomQuery = @"
                      SELECT 
    r.RoomNumber,
    rt.TypeName
FROM 
    BookingRoom br
    INNER JOIN Room r ON br.RoomID = r.RoomID
    INNER JOIN RoomType rt ON r.RoomTypeID = rt.RoomTypeID
WHERE 
    br.BookingID = @BookingID";
                    DataTable roomDt = db.ExecuteQuery(roomQuery, parameters);
                    dataGridView2.DataSource = roomDt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị chi tiết đơn đặt phòng: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maDatPhong = textBox1.Text.Trim();

                // Validate maDatPhong to ensure it's a valid integer
                if (string.IsNullOrEmpty(maDatPhong) || maDatPhong == "Nhập mã đặt phòng")
                {
                    MessageBox.Show("Vui lòng nhập mã đặt phòng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

              

                string query = @"
            SELECT 
                b.BookingID,
                c.FullName,
                c.PhoneNumber,
                b.CheckInTime,
                b.CheckOutTime,
                b.TotalRoomCost,
                b.Status
            FROM 
                Booking b
                INNER JOIN Customer c ON b.CustomerID = c.CustomerID
            WHERE 
                b.BookingID = @MaDatPhong";

                var parameters = new Dictionary<string, object>
        {
            { "@MaDatPhong", textBox1.Text.Trim() }
        };

                DataTable dt = db.ExecuteQuery(query, parameters);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn đặt phòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TenKhachHang_Click(object sender, EventArgs e)
        {
            if (txt_TenKhachHang.Text == "Nhập tên khách hàng")
            {
                txt_TenKhachHang.Text = "";
            }
        }

        private void txt_SDT_Click(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "Nhập số điện thoại")
            {
                txt_SDT.Text = "";
            }
        }

        private void txt_MaDatPhong_Click(object sender, EventArgs e)
        {
            if (txt_MaDatPhong.Text == "Nhập mã đặt phòng")
            {
                txt_MaDatPhong.Text = "";
            }
        }

        private void txt_CCCD_Click(object sender, EventArgs e)
        {
            if (txt_CCCD.Text == "Nhập CCCD")
            {
                txt_CCCD.Text = "";
            }
        }
    }
}