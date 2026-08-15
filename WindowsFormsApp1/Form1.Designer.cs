namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel6 = new System.Windows.Forms.Panel();
            this.lVTimKiem = new System.Windows.Forms.ListView();
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongdiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lVLichSu = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.txtDiemCong = new System.Windows.Forms.TextBox();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lVTimKiem);
            this.panel6.Controls.Add(this.txtTimKiem);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Location = new System.Drawing.Point(12, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(538, 403);
            this.panel6.TabIndex = 1;
            // 
            // lVTimKiem
            // 
            this.lVTimKiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sdt,
            this.ten,
            this.tongdiem});
            this.lVTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVTimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lVTimKiem.FullRowSelect = true;
            this.lVTimKiem.GridLines = true;
            this.lVTimKiem.HideSelection = false;
            this.lVTimKiem.Location = new System.Drawing.Point(3, 113);
            this.lVTimKiem.Name = "lVTimKiem";
            this.lVTimKiem.Size = new System.Drawing.Size(530, 264);
            this.lVTimKiem.TabIndex = 4;
            this.lVTimKiem.UseCompatibleStateImageBehavior = false;
            this.lVTimKiem.View = System.Windows.Forms.View.Details;
            // 
            // sdt
            // 
            this.sdt.Text = "Số điện thoại";
            this.sdt.Width = 115;
            // 
            // ten
            // 
            this.ten.Text = "Tên khách hàng";
            this.ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ten.Width = 187;
            // 
            // tongdiem
            // 
            this.tongdiem.Text = "Tổng điểm tích lũy";
            this.tongdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tongdiem.Width = 224;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTimKiem.Location = new System.Drawing.Point(31, 59);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(468, 27);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(134, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm kiếm khách hàng";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lVLichSu);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(578, 280);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(657, 403);
            this.panel7.TabIndex = 2;
            // 
            // lVLichSu
            // 
            this.lVLichSu.GridLines = true;
            this.lVLichSu.HideSelection = false;
            this.lVLichSu.Location = new System.Drawing.Point(55, 59);
            this.lVLichSu.Name = "lVLichSu";
            this.lVLichSu.Size = new System.Drawing.Size(559, 318);
            this.lVLichSu.TabIndex = 5;
            this.lVLichSu.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(223, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lịch sử giao dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(478, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin tích điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Trị giá hóa đơn (đ):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm cộng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(938, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tổng điểm hiện có:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtDiemTichLuy);
            this.panel5.Controls.Add(this.btnLamMoi);
            this.panel5.Controls.Add(this.btnLuuThongTin);
            this.panel5.Controls.Add(this.txtDiemCong);
            this.panel5.Controls.Add(this.txtHoaDon);
            this.panel5.Controls.Add(this.txtSDTKhachHang);
            this.panel5.Controls.Add(this.txtTenKH);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1223, 244);
            this.panel5.TabIndex = 0;
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemTichLuy.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTichLuy.ForeColor = System.Drawing.Color.Firebrick;
            this.txtDiemTichLuy.Location = new System.Drawing.Point(942, 94);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(146, 62);
            this.txtDiemTichLuy.TabIndex = 12;
            this.txtDiemTichLuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(536, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(240, 36);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThongTin.Image")));
            this.btnLuuThongTin.Location = new System.Drawing.Point(287, 170);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(240, 36);
            this.btnLuuThongTin.TabIndex = 3;
            this.btnLuuThongTin.Text = "Lưu thông tin ";
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // txtDiemCong
            // 
            this.txtDiemCong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDiemCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemCong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemCong.Location = new System.Drawing.Point(651, 83);
            this.txtDiemCong.Name = "txtDiemCong";
            this.txtDiemCong.Size = new System.Drawing.Size(125, 27);
            this.txtDiemCong.TabIndex = 9;
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDon.Location = new System.Drawing.Point(466, 83);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(159, 27);
            this.txtHoaDon.TabIndex = 2;
            this.txtHoaDon.TextChanged += new System.EventHandler(this.txtHoaDon_TextChanged);
            this.txtHoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoaDon_KeyDown);
            this.txtHoaDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoaDon_KeyPress);
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDTKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKhachHang.Location = new System.Drawing.Point(31, 83);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(162, 27);
            this.txtSDTKhachHang.TabIndex = 0;
            this.txtSDTKhachHang.TextChanged += new System.EventHandler(this.txtSDTKhachHang_TextChanged);
            this.txtSDTKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKhachHang_KeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(217, 83);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(231, 27);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên khách hàng:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1247, 695);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "MainForm";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDiemCong;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lVLichSu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.ListView lVTimKiem;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader tongdiem;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
    }
}

