﻿namespace RentHouse.DashBoardBody.ManagerAllListForm.HOPDONG
{
    partial class frmQLHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbHienThiHD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDate = new Guna.UI2.WinForms.Guna2Button();
            this.dgvQLHopDong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemHD = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHienThiHD
            // 
            this.cbHienThiHD.AutoSize = true;
            this.cbHienThiHD.Location = new System.Drawing.Point(260, 107);
            this.cbHienThiHD.Name = "cbHienThiHD";
            this.cbHienThiHD.Size = new System.Drawing.Size(200, 20);
            this.cbHienThiHD.TabIndex = 36;
            this.cbHienThiHD.Text = "Hiển thị hợp đồng đã kết thúc";
            this.cbHienThiHD.UseVisualStyleBackColor = true;
            this.cbHienThiHD.CheckedChanged += new System.EventHandler(this.cbHienThiHD_CheckedChanged);
            this.cbHienThiHD.TextChanged += new System.EventHandler(this.cbHienThiHD_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(107)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 51);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.DefaultAutoSize = true;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.btnXoa.FocusedColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1000, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PressedColor = System.Drawing.Color.Transparent;
            this.btnXoa.PressedDepth = 20;
            this.btnXoa.Size = new System.Drawing.Size(63, 31);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Animated = true;
            this.btnUpDate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpDate.BorderRadius = 5;
            this.btnUpDate.BorderThickness = 1;
            this.btnUpDate.DefaultAutoSize = true;
            this.btnUpDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.btnUpDate.FocusedColor = System.Drawing.Color.Transparent;
            this.btnUpDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpDate.ForeColor = System.Drawing.Color.White;
            this.btnUpDate.Location = new System.Drawing.Point(855, 96);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.PressedColor = System.Drawing.Color.Transparent;
            this.btnUpDate.PressedDepth = 20;
            this.btnUpDate.Size = new System.Drawing.Size(106, 31);
            this.btnUpDate.TabIndex = 31;
            this.btnUpDate.Text = "Cập nhật";
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // dgvQLHopDong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvQLHopDong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLHopDong.ColumnHeadersHeight = 40;
            this.dgvQLHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoHopDong,
            this.colKhachThue,
            this.colIDPhong,
            this.colGiaThue,
            this.colTienCoc,
            this.colNgayLap,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTinhTrang,
            this.colGhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLHopDong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLHopDong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLHopDong.Location = new System.Drawing.Point(3, 141);
            this.dgvQLHopDong.Name = "dgvQLHopDong";
            this.dgvQLHopDong.RowHeadersVisible = false;
            this.dgvQLHopDong.RowHeadersWidth = 51;
            this.dgvQLHopDong.RowTemplate.Height = 24;
            this.dgvQLHopDong.Size = new System.Drawing.Size(1085, 533);
            this.dgvQLHopDong.TabIndex = 29;
            this.dgvQLHopDong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLHopDong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLHopDong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLHopDong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLHopDong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLHopDong.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.dgvQLHopDong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLHopDong.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvQLHopDong.ThemeStyle.ReadOnly = false;
            this.dgvQLHopDong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLHopDong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLHopDong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLHopDong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvQLHopDong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvQLHopDong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLHopDong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colSoHopDong
            // 
            this.colSoHopDong.HeaderText = "Số Hợp Đồng";
            this.colSoHopDong.MinimumWidth = 6;
            this.colSoHopDong.Name = "colSoHopDong";
            this.colSoHopDong.Width = 125;
            // 
            // colKhachThue
            // 
            this.colKhachThue.HeaderText = "Khách Thuê";
            this.colKhachThue.MinimumWidth = 6;
            this.colKhachThue.Name = "colKhachThue";
            this.colKhachThue.Width = 114;
            // 
            // colIDPhong
            // 
            this.colIDPhong.HeaderText = "Phòng";
            this.colIDPhong.MinimumWidth = 6;
            this.colIDPhong.Name = "colIDPhong";
            this.colIDPhong.Width = 83;
            // 
            // colGiaThue
            // 
            this.colGiaThue.HeaderText = "Giá Thuê";
            this.colGiaThue.MinimumWidth = 6;
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.Width = 94;
            // 
            // colTienCoc
            // 
            this.colTienCoc.HeaderText = "Tiền Cọc";
            this.colTienCoc.MinimumWidth = 6;
            this.colTienCoc.Name = "colTienCoc";
            this.colTienCoc.Width = 66;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Width = 98;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Width = 99;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Width = 132;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình Trang";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Width = 105;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 89;
            // 
            // txtTimKiemHD
            // 
            this.txtTimKiemHD.BorderRadius = 5;
            this.txtTimKiemHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemHD.DefaultText = "";
            this.txtTimKiemHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemHD.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemHD.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.txtTimKiemHD.Location = new System.Drawing.Point(7, 96);
            this.txtTimKiemHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemHD.Name = "txtTimKiemHD";
            this.txtTimKiemHD.PasswordChar = '\0';
            this.txtTimKiemHD.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemHD.PlaceholderText = "Tìm kiếm.....";
            this.txtTimKiemHD.SelectedText = "";
            this.txtTimKiemHD.Size = new System.Drawing.Size(227, 31);
            this.txtTimKiemHD.TabIndex = 35;
            this.txtTimKiemHD.TextOffset = new System.Drawing.Point(0, 1);
            this.txtTimKiemHD.TextChanged += new System.EventHandler(this.txtTimKiemHD_TextChanged);
            // 
            // frmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 674);
            this.Controls.Add(this.cbHienThiHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.dgvQLHopDong);
            this.Controls.Add(this.txtTimKiemHD);
            this.Name = "frmQLHD";
            this.Text = "frmQLHD";
            this.Load += new System.EventHandler(this.frmQLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHienThiHD;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnUpDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLHopDong;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}