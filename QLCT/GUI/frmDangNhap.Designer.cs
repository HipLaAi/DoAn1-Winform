
namespace QLCT.GUI
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.cboLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.lbHoi = new System.Windows.Forms.Label();
            this.llbQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnMatKhau = new System.Windows.Forms.Button();
            this.errorTaiKhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.picNen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiTaiKhoan
            // 
            this.cboLoaiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLoaiTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTaiKhoan.FormattingEnabled = true;
            this.cboLoaiTaiKhoan.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.cboLoaiTaiKhoan.Location = new System.Drawing.Point(416, 156);
            this.cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            this.cboLoaiTaiKhoan.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.Location = new System.Drawing.Point(317, 348);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(200, 24);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // llbDangKy
            // 
            this.llbDangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbDangKy.AutoSize = true;
            this.llbDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(221)))), ((int)(((byte)(186)))));
            this.llbDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDangKy.Location = new System.Drawing.Point(492, 520);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(62, 18);
            this.llbDangKy.TabIndex = 4;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng ký";
            this.llbDangKy.Click += new System.EventHandler(this.llbDangKy_Click);
            // 
            // lbHoi
            // 
            this.lbHoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHoi.AutoSize = true;
            this.lbHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(221)))), ((int)(((byte)(186)))));
            this.lbHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoi.Location = new System.Drawing.Point(331, 520);
            this.lbHoi.Name = "lbHoi";
            this.lbHoi.Size = new System.Drawing.Size(163, 18);
            this.lbHoi.TabIndex = 22;
            this.lbHoi.Text = "Bạn chưa có tài khoản?";
            // 
            // llbQuenMatKhau
            // 
            this.llbQuenMatKhau.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.llbQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbQuenMatKhau.AutoSize = true;
            this.llbQuenMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(221)))), ((int)(((byte)(186)))));
            this.llbQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbQuenMatKhau.LinkColor = System.Drawing.Color.Cornsilk;
            this.llbQuenMatKhau.Location = new System.Drawing.Point(294, 398);
            this.llbQuenMatKhau.Name = "llbQuenMatKhau";
            this.llbQuenMatKhau.Size = new System.Drawing.Size(117, 18);
            this.llbQuenMatKhau.TabIndex = 3;
            this.llbQuenMatKhau.TabStop = true;
            this.llbQuenMatKhau.Text = "Quên mật khẩu?";
            this.llbQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbQuenMatKhau.Click += new System.EventHandler(this.llbQuenMatKhau_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Cecefontvn", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(391, 447);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(126, 50);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.Location = new System.Drawing.Point(317, 249);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(200, 24);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.Text = "Nhập tên đăng nhập";
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Location = new System.Drawing.Point(297, 234);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(240, 50);
            this.btnTaiKhoan.TabIndex = 23;
            this.btnTaiKhoan.TabStop = false;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnMatKhau
            // 
            this.btnMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMatKhau.FlatAppearance.BorderSize = 0;
            this.btnMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatKhau.Location = new System.Drawing.Point(297, 333);
            this.btnMatKhau.Name = "btnMatKhau";
            this.btnMatKhau.Size = new System.Drawing.Size(240, 50);
            this.btnMatKhau.TabIndex = 24;
            this.btnMatKhau.TabStop = false;
            this.btnMatKhau.UseVisualStyleBackColor = true;
            // 
            // errorTaiKhoan
            // 
            this.errorTaiKhoan.ContainerControl = this;
            // 
            // errorMatKhau
            // 
            this.errorMatKhau.ContainerControl = this;
            // 
            // btnAn
            // 
            this.btnAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAn.BackgroundImage = global::QLCT.Properties.Resources.Show_Password;
            this.btnAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAn.FlatAppearance.BorderSize = 0;
            this.btnAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAn.Location = new System.Drawing.Point(502, 347);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(27, 23);
            this.btnAn.TabIndex = 26;
            this.btnAn.TabStop = false;
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHienThi.BackgroundImage = global::QLCT.Properties.Resources.Hide_Password;
            this.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Location = new System.Drawing.Point(502, 347);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(27, 23);
            this.btnHienThi.TabIndex = 27;
            this.btnHienThi.TabStop = false;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Font = new System.Drawing.Font("UTM Facebook K&T", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMatKhau.Image = global::QLCT.Properties.Resources.bo_góc_màu_xanh;
            this.lbMatKhau.Location = new System.Drawing.Point(293, 307);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(76, 22);
            this.lbMatKhau.TabIndex = 15;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbLoaiTaiKhoan
            // 
            this.lbLoaiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLoaiTaiKhoan.AutoSize = true;
            this.lbLoaiTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiTaiKhoan.Font = new System.Drawing.Font("UTM Facebook K&T", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLoaiTaiKhoan.Image = global::QLCT.Properties.Resources.bo_góc_màu_xanh;
            this.lbLoaiTaiKhoan.Location = new System.Drawing.Point(293, 156);
            this.lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan";
            this.lbLoaiTaiKhoan.Size = new System.Drawing.Size(111, 22);
            this.lbLoaiTaiKhoan.TabIndex = 16;
            this.lbLoaiTaiKhoan.Text = "Loại tài khoản";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTaiKhoan.Font = new System.Drawing.Font("UTM Facebook K&T", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTaiKhoan.Image = global::QLCT.Properties.Resources.bo_góc_màu_xanh;
            this.lbTaiKhoan.Location = new System.Drawing.Point(293, 208);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(80, 22);
            this.lbTaiKhoan.TabIndex = 17;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbDangNhap.Font = new System.Drawing.Font("UTM Alba Matter", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.LightYellow;
            this.lbDangNhap.Image = global::QLCT.Properties.Resources.bo_góc_màu_xanh;
            this.lbDangNhap.Location = new System.Drawing.Point(347, 31);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(211, 72);
            this.lbDangNhap.TabIndex = 18;
            this.lbDangNhap.Text = "Đăng Nhập";
            // 
            // picGif
            // 
            this.picGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGif.Image = global::QLCT.Properties.Resources.gif_dang_nhap;
            this.picGif.Location = new System.Drawing.Point(557, 156);
            this.picGif.Margin = new System.Windows.Forms.Padding(0);
            this.picGif.MaximumSize = new System.Drawing.Size(230, 225);
            this.picGif.MinimumSize = new System.Drawing.Size(230, 225);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(230, 225);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 13;
            this.picGif.TabStop = false;
            // 
            // picNen
            // 
            this.picNen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNen.Image = global::QLCT.Properties.Resources.bo_góc_màu_xanh;
            this.picNen.Location = new System.Drawing.Point(252, 31);
            this.picNen.Margin = new System.Windows.Forms.Padding(0);
            this.picNen.MaximumSize = new System.Drawing.Size(390, 530);
            this.picNen.MinimumSize = new System.Drawing.Size(390, 530);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(390, 530);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 11;
            this.picNen.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.Controls.Add(this.cboLoaiTaiKhoan);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.llbDangKy);
            this.Controls.Add(this.lbHoi);
            this.Controls.Add(this.llbQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbLoaiTaiKhoan);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnMatKhau);
            this.Controls.Add(this.picNen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiêu";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.SizeChanged += new System.EventHandler(this.frmDangNhap_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiTaiKhoan;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.Label lbHoi;
        private System.Windows.Forms.LinkLabel llbQuenMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbLoaiTaiKhoan;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnMatKhau;
        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.ErrorProvider errorTaiKhoan;
        private System.Windows.Forms.ErrorProvider errorMatKhau;
    }
}