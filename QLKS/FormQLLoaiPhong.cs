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
    public partial class FormQLLoaiPhong : Form
    {
        private DatabaseConnection db;

        public FormQLLoaiPhong()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            LoadLoaiPhong();
        }
        private void LoadLoaiPhong()
        {
            string query = "select * from RoomType";
            DataTable dt = db.ExecuteQuery(query);
            dgvLoaiPhong.DataSource = dt;
        }
        private void txt_Them_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO RoomType (TypeName, PricePerHour, PricePerDay) VALUES (N'"+txt_TenLoaiPhong.Text+"',"+txt_GiaTheoGio.Text+","+txt_GiaTheoNgay.Text+")";
            db.ExecuteNonQuery(query);
            MessageBox.Show("Thêm loại phòng thành công!");
            LoadLoaiPhong(); // Tải lại danh sách
            txt_TenLoaiPhong.Clear();
            txt_GiaTheoGio.Clear();
            txt_GiaTheoNgay.Clear();
        }
        private void txt_Sua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null) 
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa!");
                return;
            }
            int roomTypeID = Convert.ToInt32(dgvLoaiPhong.CurrentRow.Cells["RoomTypeID"].Value); 
            string query = "update RoomType set TypeName = N'" + txt_TenLoaiPhong.Text + "', PricePerHour = '" + txt_GiaTheoGio.Text + "', PricePerDay = '" + txt_GiaTheoNgay.Text + "' where RoomTypeID = '" + idLoaiPhong.Text + "'";
            db.ExecuteNonQuery(query);
            LoadLoaiPhong() ;
        }
        private void txt_Xoa_Click(object sender, EventArgs e)
        {

        }
    private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex]; 
                txt_TenLoaiPhong.Text = row.Cells["TypeName"].Value.ToString();
                txt_GiaTheoGio.Text = row.Cells["PricePerHour"].Value.ToString();
                txt_GiaTheoNgay.Text = row.Cells["PricePerDay"].Value.ToString();
                idLoaiPhong.Text = row.Cells["RoomTypeID"].Value.ToString();
            }
        }
    }
}
