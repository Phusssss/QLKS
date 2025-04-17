namespace QLKS
{
    partial class FormQLPhong
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
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumberRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.cb_Tang = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tb_Phong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Trống",
            "Chưa dọn",
            "Có khách"});
            this.cb_status.Location = new System.Drawing.Point(858, 105);
            this.cb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(160, 24);
            this.cb_status.TabIndex = 0;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái";
            // 
            // txt_NumberRoom
            // 
            this.txt_NumberRoom.Location = new System.Drawing.Point(858, 65);
            this.txt_NumberRoom.Name = "txt_NumberRoom";
            this.txt_NumberRoom.Size = new System.Drawing.Size(160, 22);
            this.txt_NumberRoom.TabIndex = 3;
            this.txt_NumberRoom.TextChanged += new System.EventHandler(this.txt_NumberRoom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tầng";
            // 
            // cb_LoaiPhong
            // 
            this.cb_LoaiPhong.FormattingEnabled = true;
            this.cb_LoaiPhong.Location = new System.Drawing.Point(858, 147);
            this.cb_LoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LoaiPhong.Name = "cb_LoaiPhong";
            this.cb_LoaiPhong.Size = new System.Drawing.Size(160, 24);
            this.cb_LoaiPhong.TabIndex = 6;
            this.cb_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiPhong_SelectedIndexChanged);
            // 
            // cb_Tang
            // 
            this.cb_Tang.FormattingEnabled = true;
            this.cb_Tang.Location = new System.Drawing.Point(858, 185);
            this.cb_Tang.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Tang.Name = "cb_Tang";
            this.cb_Tang.Size = new System.Drawing.Size(160, 24);
            this.cb_Tang.TabIndex = 7;
            this.cb_Tang.SelectedIndexChanged += new System.EventHandler(this.cb_Tang_SelectedIndexChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(763, 244);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(255, 42);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(763, 305);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(255, 42);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(763, 366);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(255, 42);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tb_Phong
            // 
            this.tb_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_Phong.Location = new System.Drawing.Point(12, 24);
            this.tb_Phong.Name = "tb_Phong";
            this.tb_Phong.RowHeadersWidth = 51;
            this.tb_Phong.RowTemplate.Height = 24;
            this.tb_Phong.Size = new System.Drawing.Size(660, 457);
            this.tb_Phong.TabIndex = 11;
            // 
            // FormQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tb_Phong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_Tang);
            this.Controls.Add(this.cb_LoaiPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NumberRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLPhong";
            this.Text = "FormQLPhong";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NumberRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_LoaiPhong;
        private System.Windows.Forms.ComboBox cb_Tang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView tb_Phong;
    }
}