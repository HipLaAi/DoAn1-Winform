
namespace QLCT.GUI
{
    partial class frmCTGiaoDichChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTGiaoDichChi));
            this.dgvGiaoDichChi = new System.Windows.Forms.DataGridView();
            this.MaGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.cboBaoCao = new System.Windows.Forms.ComboBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaoDichChi
            // 
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
            this.dgvGiaoDichChi.TabIndex = 3;
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
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.Location = new System.Drawing.Point(25, 31);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(82, 17);
            this.lbBaoCao.TabIndex = 8;
            this.lbBaoCao.Text = "Báo cáo chi";
            // 
            // cboBaoCao
            // 
            this.cboBaoCao.BackColor = System.Drawing.Color.White;
            this.cboBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaoCao.FormattingEnabled = true;
            this.cboBaoCao.IntegralHeight = false;
            this.cboBaoCao.ItemHeight = 16;
            this.cboBaoCao.Items.AddRange(new object[] {
            "Tháng này",
            "Tuần này"});
            this.cboBaoCao.Location = new System.Drawing.Point(127, 28);
            this.cboBaoCao.Name = "cboBaoCao";
            this.cboBaoCao.Size = new System.Drawing.Size(136, 24);
            this.cboBaoCao.Sorted = true;
            this.cboBaoCao.TabIndex = 9;
            this.cboBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboBaoCao_SelectedIndexChanged);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(595, 27);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(98, 17);
            this.lbTongTien.TabIndex = 10;
            this.lbTongTien.Text = "Số tiền đã chi:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(699, 28);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(128, 24);
            this.txtTongTien.TabIndex = 11;
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
            this.btnLuu.TabIndex = 0;
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
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Image = global::QLCT.Properties.Resources.rotate;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(300, 494);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 51);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmCTGiaoDichChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.cboBaoCao);
            this.Controls.Add(this.lbBaoCao);
            this.Controls.Add(this.dgvGiaoDichChi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTGiaoDichChi";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvGiaoDichChi;
        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cboBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiaoDich;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}