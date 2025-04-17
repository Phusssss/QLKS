namespace QLKS
{
    partial class FormQLDonDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.Label();
            this.txt_MaDatPhong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 670);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.AutoSize = true;
            this.txt_TenKhachHang.Location = new System.Drawing.Point(35, 47);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.txt_TenKhachHang.TabIndex = 2;
            this.txt_TenKhachHang.Text = "Tên khách hàng";
            this.txt_TenKhachHang.Click += new System.EventHandler(this.txt_TenKhachHang_Click);
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.AutoSize = true;
            this.txt_CCCD.Location = new System.Drawing.Point(35, 80);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(44, 16);
            this.txt_CCCD.TabIndex = 3;
            this.txt_CCCD.Text = "CCCD";
            // 
            // txt_SDT
            // 
            this.txt_SDT.AutoSize = true;
            this.txt_SDT.Location = new System.Drawing.Point(35, 116);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(35, 16);
            this.txt_SDT.TabIndex = 4;
            this.txt_SDT.Text = "SDT";
            this.txt_SDT.Click += new System.EventHandler(this.txt_SDT_Click);
            // 
            // txt_MaDatPhong
            // 
            this.txt_MaDatPhong.AutoSize = true;
            this.txt_MaDatPhong.Location = new System.Drawing.Point(35, 153);
            this.txt_MaDatPhong.Name = "txt_MaDatPhong";
            this.txt_MaDatPhong.Size = new System.Drawing.Size(89, 16);
            this.txt_MaDatPhong.TabIndex = 5;
            this.txt_MaDatPhong.Text = "Mã đặt phòng";
            this.txt_MaDatPhong.Click += new System.EventHandler(this.txt_MaDatPhong_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(319, 13);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(327, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(31, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 189);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng đặt";
            // 
            // FormQLDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_MaDatPhong);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQLDonDatPhong";
            this.Text = "FormQLDonDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_TenKhachHang;
        private System.Windows.Forms.Label txt_CCCD;
        private System.Windows.Forms.Label txt_SDT;
        private System.Windows.Forms.Label txt_MaDatPhong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}