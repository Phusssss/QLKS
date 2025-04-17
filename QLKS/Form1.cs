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
    public partial class Form1 : Form
    {
        private DatabaseConnection db;
        private Panel roomPanel; 
        public Form1()
        {
            InitializeComponent();
            db = new DatabaseConnection();

          
            roomPanel = new Panel();
            roomPanel.Location = new Point(0, 50);
            roomPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 50);
            this.Controls.Add(roomPanel);

            TaoCacPhong(); 
        }

        private void TaoCacPhong()
        {
            roomPanel.Controls.Clear();

            string query = "SELECT Room.RoomID, Room.RoomNumber, Room.Status, Room.FloorID, " +
                          "RoomType.TypeName AS NameTypeRoom " +
                          "FROM Room " +
                          "JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID";
            DataTable dt = db.ExecuteQuery(query);

            int x = 10; 
            int y = 10; 
            int width = 100; 
            int height = 60; 
            int spacing = 10; 
            int roomsPerRow = 5;
            int currentRoom = 0;

            foreach (DataRow row in dt.Rows)
            {
                Button roomButton = new Button();
                roomButton.Width = width;
                roomButton.Height = height;
                roomButton.Location = new Point(x, y);
                roomButton.Text = $"Phòng: {row["RoomNumber"]}\n" +
                                 $"Trạng thái: {row["Status"]}\n" +
                                 $"Loại: {row["NameTypeRoom"]}";

                switch (row["Status"].ToString().ToLower())
                {
                    case "trống":
                        roomButton.BackColor = Color.Green;
                        break;
                    case "đã đặt":
                        roomButton.BackColor = Color.Yellow;
                        break;
                    case "đang sử dụng":
                        roomButton.BackColor = Color.Red;
                        break;
                    default:
                        roomButton.BackColor = Color.Gray;
                        break;
                }

       
                roomButton.Click += (sender, e) =>
                {
                    MessageBox.Show($"Bạn đã nhấp vào Phòng {row["RoomNumber"]}");
                };

                roomPanel.Controls.Add(roomButton);

                currentRoom++;
                if (currentRoom % roomsPerRow == 0)
                {
                    x = 10; 
                    y += height + spacing; 
                }
                else
                {
                    x += width + spacing;
                }
            }
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLLoaiPhong formQLLoaiPhong = new FormQLLoaiPhong();
            formQLLoaiPhong.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLPhong formQLPhong = new FormQLPhong();
            formQLPhong.ShowDialog();
            TaoCacPhong(); 
        }

        private void tầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTang formQLTang = new FormQLTang();
            formQLTang.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLKhachHang formQLKH =new FormQLKhachHang();
            formQLKH.ShowDialog();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDichVu formQLDV = new FormQLDichVu();
            formQLDV.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mứcPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLMucPhat formQLMP = new FormQLMucPhat();
            formQLMP.ShowDialog();
        }

        private void tìmPhòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatPhong  formDP = new FormDatPhong ();
            formDP.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDonDatPhong form = new FormQLDonDatPhong ();
            form.ShowDialog();
        }
    }
}