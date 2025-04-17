namespace QLKS
{
    partial class FormQLTang
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
            this.txt_numberFloor = new System.Windows.Forms.TextBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.tb_Tang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả";
            // 
            // txt_numberFloor
            // 
            this.txt_numberFloor.Location = new System.Drawing.Point(541, 39);
            this.txt_numberFloor.Name = "txt_numberFloor";
            this.txt_numberFloor.Size = new System.Drawing.Size(227, 22);
            this.txt_numberFloor.TabIndex = 2;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(541, 72);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(227, 22);
            this.txt_Mota.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(505, 126);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 45);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Location = new System.Drawing.Point(604, 126);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(93, 45);
            this.Btn_Sua.TabIndex = 6;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Location = new System.Drawing.Point(703, 126);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(93, 45);
            this.Btn_Xoa.TabIndex = 7;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // tb_Tang
            // 
            this.tb_Tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_Tang.Location = new System.Drawing.Point(31, 45);
            this.tb_Tang.Name = "tb_Tang";
            this.tb_Tang.RowHeadersWidth = 51;
            this.tb_Tang.RowTemplate.Height = 24;
            this.tb_Tang.Size = new System.Drawing.Size(421, 378);
            this.tb_Tang.TabIndex = 8;
            // 
            // FormQLTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Tang);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.txt_numberFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLTang";
            this.Text = "FormQLTang";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numberFloor;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.DataGridView tb_Tang;
    }
}