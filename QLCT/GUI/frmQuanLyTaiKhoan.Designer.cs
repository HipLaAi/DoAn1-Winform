
namespace QLCT.GUI
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CausesValidation = false;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeight = 50;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.SoDienThoai,
            this.DiaChi,
            this.LoaiTaiKhoan,
            this.MatKhau});
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 116);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 30;
            this.dgvTaiKhoan.RowTemplate.Height = 26;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(920, 372);
            this.dgvTaiKhoan.TabIndex = 14;
            this.dgvTaiKhoan.TabStop = false;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SDT";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.LoaiTaiKhoan.MinimumWidth = 6;
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.ReadOnly = true;
            this.LoaiTaiKhoan.Visible = false;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Visible = false;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.White;
            this.cboGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGioiTinh.DropDownHeight = 130;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.ForeColor = System.Drawing.Color.DeepPink;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.IntegralHeight = false;
            this.cboGioiTinh.Location = new System.Drawing.Point(457, 52);
            this.cboGioiTinh.MaxDropDownItems = 10;
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(104, 26);
            this.cboGioiTinh.TabIndex = 15;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // cboTinh
            // 
            this.cboTinh.BackColor = System.Drawing.Color.White;
            this.cboTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTinh.DropDownHeight = 130;
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinh.ForeColor = System.Drawing.Color.DeepPink;
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.IntegralHeight = false;
            this.cboTinh.Location = new System.Drawing.Point(708, 52);
            this.cboTinh.MaxDropDownItems = 10;
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(121, 26);
            this.cboTinh.TabIndex = 16;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(132, 53);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(151, 24);
            this.txtTenDangNhap.TabIndex = 17;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên đăng nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCT.Properties.Resources.home1;
            this.pictureBox2.Location = new System.Drawing.Point(670, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCT.Properties.Resources.genders;
            this.pictureBox1.Location = new System.Drawing.Point(419, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Image = global::QLCT.Properties.Resources.rotate;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(191, 527);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 51);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::QLCT.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(468, 527);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 51);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLCT.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(289, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(835, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}