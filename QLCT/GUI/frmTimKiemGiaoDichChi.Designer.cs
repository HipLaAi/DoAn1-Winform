
namespace QLCT.GUI
{
    partial class frmTimKiemGiaoDichChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemGiaoDichChi));
            this.dgvGiaoDichChi = new System.Windows.Forms.DataGridView();
            this.MaGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lbDanhMuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaoDichChi
            // 
            this.dgvGiaoDichChi.AllowUserToAddRows = false;
            this.dgvGiaoDichChi.AllowUserToDeleteRows = false;
            this.dgvGiaoDichChi.AllowUserToResizeColumns = false;
            this.dgvGiaoDichChi.AllowUserToResizeRows = false;
            this.dgvGiaoDichChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoDichChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDichChi.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoDichChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaoDichChi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoDichChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoDichChi.ColumnHeadersHeight = 50;
            this.dgvGiaoDichChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiaoDichChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoDich,
            this.TenDangNhap,
            this.DanhMuc,
            this.PhuongThucThanhToan,
            this.SoTien,
            this.MoTa,
            this.NgayGiaoDich});
            this.dgvGiaoDichChi.EnableHeadersVisualStyles = false;
            this.dgvGiaoDichChi.Location = new System.Drawing.Point(0, 88);
            this.dgvGiaoDichChi.Name = "dgvGiaoDichChi";
            this.dgvGiaoDichChi.RowHeadersWidth = 30;
            this.dgvGiaoDichChi.RowTemplate.Height = 26;
            this.dgvGiaoDichChi.Size = new System.Drawing.Size(920, 372);
            this.dgvGiaoDichChi.TabIndex = 14;
            this.dgvGiaoDichChi.TabStop = false;
            // 
            // MaGiaoDich
            // 
            this.MaGiaoDich.DataPropertyName = "MaGiaoDich";
            this.MaGiaoDich.HeaderText = "Mã giao dịch";
            this.MaGiaoDich.MinimumWidth = 6;
            this.MaGiaoDich.Name = "MaGiaoDich";
            this.MaGiaoDich.Visible = false;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Visible = false;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "MaDanhMuc";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.MinimumWidth = 6;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhMuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "MaPhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 6;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhuongThucThanhToan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // NgayGiaoDich
            // 
            this.NgayGiaoDich.DataPropertyName = "NgayGiaoDich";
            this.NgayGiaoDich.HeaderText = "Ngày giao dịch";
            this.NgayGiaoDich.MinimumWidth = 6;
            this.NgayGiaoDich.Name = "NgayGiaoDich";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.BackColor = System.Drawing.Color.White;
            this.cboDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.IntegralHeight = false;
            this.cboDanhMuc.ItemHeight = 16;
            this.cboDanhMuc.Location = new System.Drawing.Point(108, 28);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(175, 24);
            this.cboDanhMuc.TabIndex = 17;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.Location = new System.Drawing.Point(30, 31);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(72, 17);
            this.lbDanhMuc.TabIndex = 16;
            this.lbDanhMuc.Text = "Danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Từ ngày";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(405, 32);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(111, 22);
            this.dtpBatDau.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đến ngày";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(687, 32);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(111, 22);
            this.dtpKetThuc.TabIndex = 19;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Image = global::QLCT.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(687, 494);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 51);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::QLCT.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(495, 494);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 51);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Image = global::QLCT.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(300, 494);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(180, 51);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmTimKiemGiaoDichChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGiaoDichChi);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.lbDanhMuc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemGiaoDichChi";
            this.Text = "frmTimKiemGiaoDichChi";
            this.Load += new System.EventHandler(this.frmTimKiemGiaoDichChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiaoDichChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiaoDich;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lbDanhMuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}