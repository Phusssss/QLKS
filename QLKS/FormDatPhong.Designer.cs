namespace QLKS
{
    partial class FormDatPhong
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
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.dgvdsphongtrong = new System.Windows.Forms.DataGridView();
            this.dgvdsdatphong = new System.Windows.Forms.DataGridView();
            this.btntimphong = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphongtrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdatphong)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Location = new System.Drawing.Point(183, 33);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(200, 24);
            this.cb_LoaiPhong.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 162);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lọai Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày nhận phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày trả phòng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách Hàng ";
            // 
            // cbkh
            // 
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(183, 218);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(200, 24);
            this.cbkh.TabIndex = 7;
            // 
            // dgvdsphongtrong
            // 
            this.dgvdsphongtrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsphongtrong.Location = new System.Drawing.Point(41, 269);
            this.dgvdsphongtrong.Name = "dgvdsphongtrong";
            this.dgvdsphongtrong.RowHeadersWidth = 51;
            this.dgvdsphongtrong.RowTemplate.Height = 24;
            this.dgvdsphongtrong.Size = new System.Drawing.Size(296, 272);
            this.dgvdsphongtrong.TabIndex = 8;
            this.dgvdsphongtrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsphongtrong_CellClick);
            this.dgvdsphongtrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsphongtrong_CellClick);
            // 
            // dgvdsdatphong
            // 
            this.dgvdsdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsdatphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomNumber,
            this.PricePerDay,
            this.PricePerHour});
            this.dgvdsdatphong.Location = new System.Drawing.Point(343, 269);
            this.dgvdsdatphong.Name = "dgvdsdatphong";
            this.dgvdsdatphong.RowHeadersWidth = 51;
            this.dgvdsdatphong.RowTemplate.Height = 24;
            this.dgvdsdatphong.Size = new System.Drawing.Size(445, 272);
            this.dgvdsdatphong.TabIndex = 9;
            this.dgvdsdatphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsphongtrong_CellClick);
            // 
            // btntimphong
            // 
            this.btntimphong.Location = new System.Drawing.Point(507, 122);
            this.btntimphong.Name = "btntimphong";
            this.btntimphong.Size = new System.Drawing.Size(137, 42);
            this.btntimphong.TabIndex = 10;
            this.btntimphong.Text = "Tìm Phòng";
            this.btntimphong.UseVisualStyleBackColor = true;
            this.btntimphong.Click += new System.EventHandler(this.btntimphong_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Location = new System.Drawing.Point(507, 188);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(137, 46);
            this.btn_DatPhong.TabIndex = 11;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // RoomID
            // 
            this.RoomID.HeaderText = "RoomID";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // PricePerDay
            // 
            this.PricePerDay.HeaderText = "PricePerDay";
            this.PricePerDay.MinimumWidth = 6;
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.Width = 125;
            // 
            // PricePerHour
            // 
            this.PricePerHour.HeaderText = "PricePerHour";
            this.PricePerHour.MinimumWidth = 6;
            this.PricePerHour.Name = "PricePerHour";
            this.PricePerHour.Width = 125;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.btntimphong);
            this.Controls.Add(this.dgvdsdatphong);
            this.Controls.Add(this.dgvdsphongtrong);
            this.Controls.Add(this.cbkh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_LoaiPhong);
            this.Name = "FormDatPhong";
            this.Text = "FormDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphongtrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdatphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_LoaiPhong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.DataGridView dgvdsphongtrong;
        private System.Windows.Forms.DataGridView dgvdsdatphong;
        private System.Windows.Forms.Button btntimphong;
        private System.Windows.Forms.Button btn_DatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerHour;
    }
}