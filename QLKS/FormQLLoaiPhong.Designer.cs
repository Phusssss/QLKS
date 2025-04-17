namespace QLKS
{
    partial class FormQLLoaiPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenLoaiPhong = new System.Windows.Forms.TextBox();
            this.txt_GiaTheoGio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GiaTheoNgay = new System.Windows.Forms.TextBox();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.txt_Them = new System.Windows.Forms.Button();
            this.txt_Sua = new System.Windows.Forms.Button();
            this.txt_Xoa = new System.Windows.Forms.Button();
            this.idLoaiPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá theo giờ";
            // 
            // txt_TenLoaiPhong
            // 
            this.txt_TenLoaiPhong.Location = new System.Drawing.Point(170, 32);
            this.txt_TenLoaiPhong.Name = "txt_TenLoaiPhong";
            this.txt_TenLoaiPhong.Size = new System.Drawing.Size(258, 20);
            this.txt_TenLoaiPhong.TabIndex = 2;
            // 
            // txt_GiaTheoGio
            // 
            this.txt_GiaTheoGio.Location = new System.Drawing.Point(170, 65);
            this.txt_GiaTheoGio.Name = "txt_GiaTheoGio";
            this.txt_GiaTheoGio.Size = new System.Drawing.Size(258, 20);
            this.txt_GiaTheoGio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá theo ngày";
            // 
            // txt_GiaTheoNgay
            // 
            this.txt_GiaTheoNgay.Location = new System.Drawing.Point(170, 100);
            this.txt_GiaTheoNgay.Name = "txt_GiaTheoNgay";
            this.txt_GiaTheoNgay.Size = new System.Drawing.Size(258, 20);
            this.txt_GiaTheoNgay.TabIndex = 5;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(78, 190);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.Size = new System.Drawing.Size(626, 225);
            this.dgvLoaiPhong.TabIndex = 6;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellClick);
            // 
            // txt_Them
            // 
            this.txt_Them.Location = new System.Drawing.Point(578, 39);
            this.txt_Them.Name = "txt_Them";
            this.txt_Them.Size = new System.Drawing.Size(75, 23);
            this.txt_Them.TabIndex = 7;
            this.txt_Them.Text = "Thêm";
            this.txt_Them.UseVisualStyleBackColor = true;
            this.txt_Them.Click += new System.EventHandler(this.txt_Them_Click);
            // 
            // txt_Sua
            // 
            this.txt_Sua.Location = new System.Drawing.Point(578, 71);
            this.txt_Sua.Name = "txt_Sua";
            this.txt_Sua.Size = new System.Drawing.Size(75, 23);
            this.txt_Sua.TabIndex = 8;
            this.txt_Sua.Text = "Sửa";
            this.txt_Sua.UseVisualStyleBackColor = true;
            this.txt_Sua.Click += new System.EventHandler(this.txt_Sua_Click);
            // 
            // txt_Xoa
            // 
            this.txt_Xoa.Location = new System.Drawing.Point(578, 100);
            this.txt_Xoa.Name = "txt_Xoa";
            this.txt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.txt_Xoa.TabIndex = 9;
            this.txt_Xoa.Text = "Xóa";
            this.txt_Xoa.UseVisualStyleBackColor = true;
            this.txt_Xoa.Click += new System.EventHandler(this.txt_Xoa_Click);
            // 
            // idLoaiPhong
            // 
            this.idLoaiPhong.AutoSize = true;
            this.idLoaiPhong.Location = new System.Drawing.Point(192, 139);
            this.idLoaiPhong.Name = "idLoaiPhong";
            this.idLoaiPhong.Size = new System.Drawing.Size(35, 13);
            this.idLoaiPhong.TabIndex = 10;
            this.idLoaiPhong.Text = "label4";
            // 
            // FormQLLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idLoaiPhong);
            this.Controls.Add(this.txt_Xoa);
            this.Controls.Add(this.txt_Sua);
            this.Controls.Add(this.txt_Them);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.txt_GiaTheoNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_GiaTheoGio);
            this.Controls.Add(this.txt_TenLoaiPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLLoaiPhong";
            this.Text = "FormQLLoaiPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenLoaiPhong;
        private System.Windows.Forms.TextBox txt_GiaTheoGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GiaTheoNgay;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Button txt_Them;
        private System.Windows.Forms.Button txt_Sua;
        private System.Windows.Forms.Button txt_Xoa;
        private System.Windows.Forms.Label idLoaiPhong;
    }
}