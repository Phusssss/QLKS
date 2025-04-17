namespace QLKS
{
    partial class FormQLDichVu
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtmdv = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.dgvdichvu = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Tiền";
            // 
            // txtmdv
            // 
            this.txtmdv.Location = new System.Drawing.Point(174, 54);
            this.txtmdv.Name = "txtmdv";
            this.txtmdv.Size = new System.Drawing.Size(265, 22);
            this.txtmdv.TabIndex = 3;
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(174, 115);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(265, 22);
            this.txttendv.TabIndex = 4;
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(174, 199);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(265, 22);
            this.txtgt.TabIndex = 5;
            // 
            // dgvdichvu
            // 
            this.dgvdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdichvu.Location = new System.Drawing.Point(12, 249);
            this.dgvdichvu.Name = "dgvdichvu";
            this.dgvdichvu.RowHeadersWidth = 51;
            this.dgvdichvu.RowTemplate.Height = 24;
            this.dgvdichvu.Size = new System.Drawing.Size(755, 189);
            this.dgvdichvu.TabIndex = 6;
            this.dgvdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdichvu_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(542, 54);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 41);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(542, 115);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 42);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(542, 181);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 40);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // FormQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdichvu);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.txtmdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLDichVu";
            this.Text = "FormQLDichVu";
            this.Load += new System.EventHandler(this.FormQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmdv;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.DataGridView dgvdichvu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
    }
}