namespace QLKS
{
    partial class FormQLMucPhat
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtmamucphat = new System.Windows.Forms.TextBox();
            this.txttenmucphat = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.dgvmucphat = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmucphat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mức Phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mức phạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // txtmamucphat
            // 
            this.txtmamucphat.Location = new System.Drawing.Point(201, 55);
            this.txtmamucphat.Name = "txtmamucphat";
            this.txtmamucphat.Size = new System.Drawing.Size(185, 22);
            this.txtmamucphat.TabIndex = 4;
            // 
            // txttenmucphat
            // 
            this.txttenmucphat.Location = new System.Drawing.Point(201, 120);
            this.txttenmucphat.Name = "txttenmucphat";
            this.txttenmucphat.Size = new System.Drawing.Size(185, 22);
            this.txttenmucphat.TabIndex = 5;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(201, 172);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(185, 22);
            this.txtgiatien.TabIndex = 6;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(201, 236);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(185, 22);
            this.txtmota.TabIndex = 7;
            // 
            // dgvmucphat
            // 
            this.dgvmucphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmucphat.Location = new System.Drawing.Point(67, 301);
            this.dgvmucphat.Name = "dgvmucphat";
            this.dgvmucphat.RowHeadersWidth = 51;
            this.dgvmucphat.RowTemplate.Height = 24;
            this.dgvmucphat.Size = new System.Drawing.Size(691, 175);
            this.dgvmucphat.TabIndex = 8;
            this.dgvmucphat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmucphat_CellClick);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(517, 120);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(110, 41);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(517, 58);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(110, 40);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(517, 188);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(110, 44);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // FormQLMucPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.dgvmucphat);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtgiatien);
            this.Controls.Add(this.txttenmucphat);
            this.Controls.Add(this.txtmamucphat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLMucPhat";
            this.Text = "FormQLMucPhat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmucphat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmamucphat;
        private System.Windows.Forms.TextBox txttenmucphat;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.DataGridView dgvmucphat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
    }
}