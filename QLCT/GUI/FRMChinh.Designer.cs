
namespace QLCT.GUI
{
    partial class FRMChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMChinh));
            this.pnlTrai = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pnlTren = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.ckbThongBao = new System.Windows.Forms.CheckBox();
            this.pnlThan = new System.Windows.Forms.Panel();
            this.tmThongBao = new System.Windows.Forms.Timer(this.components);
            this.errors = new System.Windows.Forms.NotifyIcon(this.components);
            this.error = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlTrai.SuspendLayout();
            this.pnlTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTrai
            // 
            this.pnlTrai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTrai.BackColor = System.Drawing.Color.LightGreen;
            this.pnlTrai.Controls.Add(this.btnDangXuat);
            this.pnlTrai.Controls.Add(this.btnTaiKhoan);
            this.pnlTrai.Controls.Add(this.btnThongKe);
            this.pnlTrai.Controls.Add(this.btnTimKiem);
            this.pnlTrai.Controls.Add(this.btnTrangChu);
            this.pnlTrai.Location = new System.Drawing.Point(0, 0);
            this.pnlTrai.Name = "pnlTrai";
            this.pnlTrai.Size = new System.Drawing.Size(181, 708);
            this.pnlTrai.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::QLCT.Properties.Resources.exit;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 631);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(181, 65);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Image = global::QLCT.Properties.Resources.folder;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 464);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(181, 65);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightGreen;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::QLCT.Properties.Resources.pie_chart1;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 342);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnThongKe.Size = new System.Drawing.Size(181, 65);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightGreen;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::QLCT.Properties.Resources.seo;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 209);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(181, 74);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::QLCT.Properties.Resources.home__1_;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 100);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(181, 65);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnlTren
            // 
            this.pnlTren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTren.BackColor = System.Drawing.Color.Pink;
            this.pnlTren.Controls.Add(this.label1);
            this.pnlTren.Controls.Add(this.label2);
            this.pnlTren.Controls.Add(this.pictureBox2);
            this.pnlTren.Controls.Add(this.pictureBox1);
            this.pnlTren.Controls.Add(this.dtpThoiGian);
            this.pnlTren.Controls.Add(this.ckbThongBao);
            this.pnlTren.Location = new System.Drawing.Point(181, 0);
            this.pnlTren.Name = "pnlTren";
            this.pnlTren.Size = new System.Drawing.Size(1056, 135);
            this.pnlTren.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("UTM Alba Matter", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(230, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Một xu tiết kiệm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("UTM Alba Matter", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(466, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 65);
            this.label2.TabIndex = 17;
            this.label2.Text = "là một xu kiếm được";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QLCT.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(955, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpThoiGian.Location = new System.Drawing.Point(818, 52);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.ShowUpDown = true;
            this.dtpThoiGian.Size = new System.Drawing.Size(107, 22);
            this.dtpThoiGian.TabIndex = 14;
            this.dtpThoiGian.Value = new System.DateTime(2023, 5, 25, 20, 30, 0, 0);
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // ckbThongBao
            // 
            this.ckbThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbThongBao.AutoSize = true;
            this.ckbThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbThongBao.Location = new System.Drawing.Point(931, 56);
            this.ckbThongBao.Name = "ckbThongBao";
            this.ckbThongBao.Size = new System.Drawing.Size(18, 17);
            this.ckbThongBao.TabIndex = 13;
            this.ckbThongBao.UseVisualStyleBackColor = true;
            // 
            // pnlThan
            // 
            this.pnlThan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThan.BackColor = System.Drawing.Color.White;
            this.pnlThan.Location = new System.Drawing.Point(181, 100);
            this.pnlThan.Name = "pnlThan";
            this.pnlThan.Size = new System.Drawing.Size(1056, 608);
            this.pnlThan.TabIndex = 2;
            // 
            // tmThongBao
            // 
            this.tmThongBao.Enabled = true;
            this.tmThongBao.Interval = 5000;
            this.tmThongBao.Tick += new System.EventHandler(this.tmThongBao_Tick);
            // 
            // errors
            // 
            this.errors.Icon = ((System.Drawing.Icon)(resources.GetObject("errors.Icon")));
            this.errors.Text = "notifyIcon";
            this.errors.Visible = true;
            // 
            // error
            // 
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            this.error.Text = "notifyIcon1";
            this.error.Visible = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon2";
            this.notifyIcon.Visible = true;
            // 
            // FRMChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 708);
            this.Controls.Add(this.pnlThan);
            this.Controls.Add(this.pnlTren);
            this.Controls.Add(this.pnlTrai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "FRMChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiêu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.pnlTrai.ResumeLayout(false);
            this.pnlTren.ResumeLayout(false);
            this.pnlTren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrai;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel pnlTren;
        private System.Windows.Forms.Panel pnlThan;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.CheckBox ckbThongBao;
        private System.Windows.Forms.Timer tmThongBao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon errors;
        private System.Windows.Forms.NotifyIcon error;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}