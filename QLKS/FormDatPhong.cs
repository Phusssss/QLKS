using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class FormDatPhong : Form
    {
        private DatabaseConnection db;
        private DataTable selectedRooms; // Lưu danh sách phòng đã chọn

        public FormDatPhong()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            LoadLoaiPhong();
            LoadKhachHang();
            ConfigureDataGridViews(); // Cấu hình cả hai DataGridView

            // Khởi tạo DataTable cho danh sách phòng đã chọn
            selectedRooms = new DataTable();
            selectedRooms.Columns.Add("RoomNumber", typeof(string));
            selectedRooms.Columns.Add("PricePerDay", typeof(decimal));
            selectedRooms.Columns.Add("PricePerHour", typeof(decimal));
            selectedRooms.Columns.Add("RoomID", typeof(int)); // Thêm RoomID để lưu vào BookingRoom

            // Đặt thời gian mặc định: check-in 14:00 hôm nay, check-out 12:00 ngày mai
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, today.Day, 14, 0, 0); // 14:00
            dateTimePicker2.Value = new DateTime(today.Year, today.Month, today.Day, 12, 0, 0).AddDays(1); // 12:00 ngày mai
        }

        private void ConfigureDataGridViews()
        {
            // Cấu hình dgvdsphongtrong
            dgvdsphongtrong.AutoGenerateColumns = false;
            dgvdsphongtrong.Columns.Clear();
            dgvdsphongtrong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "Tên Phòng",
                Width = 100
            });
            dgvdsphongtrong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PricePerDay",
                HeaderText = "Giá Theo Đêm",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
            dgvdsphongtrong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PricePerHour",
                HeaderText = "Giá Theo Giờ",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            // Cấu hình dgvdsdatphong
            dgvdsdatphong.AutoGenerateColumns = false;
            dgvdsdatphong.Columns.Clear();
            dgvdsdatphong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "Tên Phòng",
                Width = 100
            });
            dgvdsdatphong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PricePerDay",
                HeaderText = "Giá Theo Đêm",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
            dgvdsdatphong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PricePerHour",
                HeaderText = "Giá Theo Giờ",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            // Gán DataSource cho dgvdsdatphong
            dgvdsdatphong.DataSource = selectedRooms;
        }

        private void LoadLoaiPhong()
        {
            string query = "SELECT RoomTypeID, TypeName FROM RoomType";
            DataTable dt = db.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có loại phòng nào trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cb_LoaiPhong.DataSource = dt;
            cb_LoaiPhong.DisplayMember = "TypeName";
            cb_LoaiPhong.ValueMember = "RoomTypeID";
        }

        private void LoadKhachHang()
        {
            string query = "SELECT CustomerID, FullName FROM Customer";
            DataTable dt = db.ExecuteQuery(query);
            cbkh.DataSource = dt;
            cbkh.DisplayMember = "FullName";
            cbkh.ValueMember = "CustomerID";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value.Date.AddDays(1).AddHours(12); // Check-out 12:00 ngày hôm sau
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value.Date.AddHours(14); // Check-in 14:00 cùng ngày hoặc trước đó
            }
        }

        private void btntimphong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị đầu vào
                if (cb_LoaiPhong.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dateTimePicker1.Value >= dateTimePicker2.Value)
                {
                    MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị từ các control
                int roomTypeID;
                if (!int.TryParse(cb_LoaiPhong.SelectedValue.ToString(), out roomTypeID))
                {
                    MessageBox.Show("Loại phòng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime checkInTime = dateTimePicker1.Value;
                DateTime checkOutTime = dateTimePicker2.Value;

                // Câu query tìm phòng trống
                string query = @"
                    SELECT 
                        r.RoomID,
                        r.RoomNumber,
                        rt.PricePerDay,
                        rt.PricePerHour
                    FROM 
                        Room r
                        INNER JOIN RoomType rt ON r.RoomTypeID = rt.RoomTypeID
                        INNER JOIN Floor f ON r.FloorID = f.FloorID
                    WHERE 
                        r.RoomTypeID = @RoomTypeID
                        AND NOT EXISTS (
                            SELECT 1 
                            FROM BookingRoom br
                            INNER JOIN Booking b ON br.BookingID = b.BookingID
                            WHERE 
                                br.RoomID = r.RoomID
                                AND (b.CheckInTime <= @CheckOutTime AND b.CheckOutTime >= @CheckInTime)
                        )";

                // Thêm parameters
                var parameters = new Dictionary<string, object>
                {
                    { "@RoomTypeID", roomTypeID },
                    { "@CheckInTime", checkInTime },
                    { "@CheckOutTime", checkOutTime }
                };

                // Thực thi query
                DataTable dt = db.ExecuteQuery(query, parameters);

                // Debug: Kiểm tra tên cột
                string columnNames = string.Join(", ", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                MessageBox.Show($"Column names: {columnNames}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kiểm tra kết quả
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phòng trống phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Gán dữ liệu vào dgvdsphongtrong
                dgvdsphongtrong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvdsphongtrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng được chọn không
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvdsphongtrong.Rows[e.RowIndex];

                    // Lấy DataRow từ DataTable gốc
                    DataRowView dataRowView = row.DataBoundItem as DataRowView;
                    if (dataRowView == null)
                    {
                        MessageBox.Show("Không thể lấy dữ liệu phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRow dataRow = dataRowView.Row;

                    // Lấy thông tin phòng từ DataRow
                    int roomID = Convert.ToInt32(dataRow["RoomID"]);
                    string roomNumber = dataRow["RoomNumber"].ToString();
                    decimal pricePerDay = Convert.ToDecimal(dataRow["PricePerDay"]);
                    decimal pricePerHour = Convert.ToDecimal(dataRow["PricePerHour"]);

                    // Debug: Hiển thị giá trị
                    string debugMessage = $"RoomID: {roomID}, RoomNumber: {roomNumber}, PricePerDay: {pricePerDay}, PricePerHour: {pricePerHour}";
                    MessageBox.Show(debugMessage, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Thêm vào danh sách phòng đã chọn
                    DataRow newRow = selectedRooms.NewRow();
                    newRow["RoomNumber"] = roomNumber;
                    newRow["PricePerDay"] = pricePerDay;
                    newRow["PricePerHour"] = pricePerHour;
                    newRow["RoomID"] = roomID;
                    selectedRooms.Rows.Add(newRow);

                    // Xóa phòng khỏi dgvdsphongtrong
                    dgvdsphongtrong.Rows.RemoveAt(e.RowIndex);

                    // Cập nhật lại dgvdsdatphong
                    dgvdsdatphong.DataSource = null;
                    dgvdsdatphong.DataSource = selectedRooms;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn phòng: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvdsdatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng được chọn không
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvdsdatphong.Rows[e.RowIndex];

                    // Lấy DataRow từ DataTable gốc (selectedRooms)
                    DataRowView dataRowView = row.DataBoundItem as DataRowView;
                    if (dataRowView == null)
                    {
                        MessageBox.Show("Không thể lấy dữ liệu phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRow dataRow = dataRowView.Row;

                    // Lấy thông tin phòng từ DataRow
                    int roomID = Convert.ToInt32(dataRow["RoomID"]);
                    string roomNumber = dataRow["RoomNumber"].ToString();
                    decimal pricePerDay = Convert.ToDecimal(dataRow["PricePerDay"]);
                    decimal pricePerHour = Convert.ToDecimal(dataRow["PricePerHour"]);

                    // Debug: Hiển thị giá trị
                    string debugMessage = $"RoomID: {roomID}, RoomNumber: {roomNumber}, PricePerDay: {pricePerDay}, PricePerHour: {pricePerHour}";
                    MessageBox.Show(debugMessage, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lấy DataTable của dgvdsphongtrong
                    DataTable availableRooms = dgvdsphongtrong.DataSource as DataTable;
                    if (availableRooms == null)
                    {
                        // Nếu dgvdsphongtrong chưa có DataTable, tạo mới
                        availableRooms = new DataTable();
                        availableRooms.Columns.Add("RoomID", typeof(int));
                        availableRooms.Columns.Add("RoomNumber", typeof(string));
                        availableRooms.Columns.Add("PricePerDay", typeof(decimal));
                        availableRooms.Columns.Add("PricePerHour", typeof(decimal));
                    }

                    // Thêm phòng vào DataTable của dgvdsphongtrong
                    DataRow newRow = availableRooms.NewRow();
                    newRow["RoomID"] = roomID;
                    newRow["RoomNumber"] = roomNumber;
                    newRow["PricePerDay"] = pricePerDay;
                    newRow["PricePerHour"] = pricePerHour;
                    availableRooms.Rows.Add(newRow);

                    // Xóa phòng khỏi selectedRooms
                    selectedRooms.Rows.Remove(dataRow);

                    // Cập nhật lại DataSource cho cả hai DataGridView
                    dgvdsphongtrong.DataSource = null;
                    dgvdsphongtrong.DataSource = availableRooms;
                    dgvdsdatphong.DataSource = null;
                    dgvdsdatphong.DataSource = selectedRooms;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (cbkh.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedRooms.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một phòng để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerID = Convert.ToInt32(cbkh.SelectedValue);
                DateTime checkInTime = dateTimePicker1.Value;
                DateTime checkOutTime = dateTimePicker2.Value;

                // Tính TotalRoomCost (dựa trên PricePerDay và số ngày)
                TimeSpan duration = checkOutTime - checkInTime;
                double totalDays = duration.TotalDays;
                decimal totalRoomCost = 0;
                foreach (DataRow row in selectedRooms.Rows)
                {
                    decimal pricePerDay = Convert.ToDecimal(row["PricePerDay"]);
                    totalRoomCost += pricePerDay * (decimal)totalDays;
                }

                // Thêm vào bảng Booking
                string insertBookingQuery = @"
                    INSERT INTO Booking (CustomerID, CheckInTime, CheckOutTime, TotalRoomCost, Status)
                    OUTPUT INSERTED.BookingID
                    VALUES (@CustomerID, @CheckInTime, @CheckOutTime, @TotalRoomCost, 'Active')";

                var bookingParameters = new Dictionary<string, object>
                {
                    { "@CustomerID", customerID },
                    { "@CheckInTime", checkInTime },
                    { "@CheckOutTime", checkOutTime },
                    { "@TotalRoomCost", totalRoomCost }
                };

                // Thực thi câu INSERT và lấy BookingID
                int bookingID = db.ExecuteScalar(insertBookingQuery, bookingParameters);

                // Thêm vào bảng BookingRoom
                string insertBookingRoomQuery = @"
                    INSERT INTO BookingRoom (BookingID, RoomID)
                    VALUES (@BookingID, @RoomID)";

                foreach (DataRow row in selectedRooms.Rows)
                {
                    int roomID = Convert.ToInt32(row["RoomID"]);
                    var bookingRoomParameters = new Dictionary<string, object>
                    {
                        { "@BookingID", bookingID },
                        { "@RoomID", roomID }
                    };
                    db.ExecuteNonQuery(insertBookingRoomQuery, bookingRoomParameters);
                }

                // Xóa danh sách phòng đã chọn
                selectedRooms.Clear();
                dgvdsdatphong.DataSource = null;
                dgvdsdatphong.DataSource = selectedRooms;

                // Cập nhật lại danh sách phòng trống
                btntimphong_Click(sender, e);

                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt phòng: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}