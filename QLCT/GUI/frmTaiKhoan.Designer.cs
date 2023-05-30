
namespace QLCT.GUI
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnGioiTinh = new System.Windows.Forms.Button();
            this.btnDiaChi = new System.Windows.Forms.Button();
            this.btnSDT = new System.Windows.Forms.Button();
            this.btnNgaySinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.cboHuyen = new System.Windows.Forms.ComboBox();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThayDoiMatKhau = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Purple;
            this.lbHoTen.Location = new System.Drawing.Point(139, 124);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(162, 20);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên người dùng";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Purple;
            this.lbGioiTinh.Location = new System.Drawing.Point(217, 174);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(80, 20);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Purple;
            this.lbDiaChi.Location = new System.Drawing.Point(229, 231);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(68, 20);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(178, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(209, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // btnHoTen
            // 
            this.btnHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoTen.FlatAppearance.BorderSize = 0;
            this.btnHoTen.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHoTen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoTen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoTen.Image = ((System.Drawing.Image)(resources.GetObject("btnHoTen.Image")));
            this.btnHoTen.Location = new System.Drawing.Point(595, 117);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(37, 37);
            this.btnHoTen.TabIndex = 9;
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnGioiTinh
            // 
            this.btnGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioiTinh.FlatAppearance.BorderSize = 0;
            this.btnGioiTinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGioiTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGioiTinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioiTinh.Image = ((System.Drawing.Image)(resources.GetObject("btnGioiTinh.Image")));
            this.btnGioiTinh.Location = new System.Drawing.Point(595, 165);
            this.btnGioiTinh.Name = "btnGioiTinh";
            this.btnGioiTinh.Size = new System.Drawing.Size(37, 37);
            this.btnGioiTinh.TabIndex = 9;
            this.btnGioiTinh.UseVisualStyleBackColor = true;
            this.btnGioiTinh.Click += new System.EventHandler(this.btnGioiTinh_Click);
            // 
            // btnDiaChi
            // 
            this.btnDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiaChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiaChi.FlatAppearance.BorderSize = 0;
            this.btnDiaChi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDiaChi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDiaChi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaChi.Image = ((System.Drawing.Image)(resources.GetObject("btnDiaChi.Image")));
            this.btnDiaChi.Location = new System.Drawing.Point(595, 221);
            this.btnDiaChi.Name = "btnDiaChi";
            this.btnDiaChi.Size = new System.Drawing.Size(37, 37);
            this.btnDiaChi.TabIndex = 9;
            this.btnDiaChi.UseVisualStyleBackColor = true;
            this.btnDiaChi.Click += new System.EventHandler(this.btnDiaChi_Click);
            // 
            // btnSDT
            // 
            this.btnSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDT.FlatAppearance.BorderSize = 0;
            this.btnSDT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSDT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSDT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDT.Image = ((System.Drawing.Image)(resources.GetObject("btnSDT.Image")));
            this.btnSDT.Location = new System.Drawing.Point(595, 284);
            this.btnSDT.Name = "btnSDT";
            this.btnSDT.Size = new System.Drawing.Size(37, 37);
            this.btnSDT.TabIndex = 9;
            this.btnSDT.UseVisualStyleBackColor = true;
            this.btnSDT.Click += new System.EventHandler(this.btnSDT_Click);
            // 
            // btnNgaySinh
            // 
            this.btnNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNgaySinh.FlatAppearance.BorderSize = 0;
            this.btnNgaySinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNgaySinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNgaySinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNgaySinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgaySinh.Image = ((System.Drawing.Image)(resources.GetObject("btnNgaySinh.Image")));
            this.btnNgaySinh.Location = new System.Drawing.Point(595, 359);
            this.btnNgaySinh.Name = "btnNgaySinh";
            this.btnNgaySinh.Size = new System.Drawing.Size(37, 37);
            this.btnNgaySinh.TabIndex = 9;
            this.btnNgaySinh.UseVisualStyleBackColor = true;
            this.btnNgaySinh.Click += new System.EventHandler(this.btnNgaySinh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(351, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin người dùng";
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtSDT.Enabled = false;
            this.mtxtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mtxtSDT.Location = new System.Drawing.Point(314, 294);
            this.mtxtSDT.Mask = "0000-000-XXX";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(236, 17);
            this.mtxtSDT.TabIndex = 12;
            this.mtxtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(311, 122);
            this.txtHoTen.MaxLength = 20;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 17);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // rdbNu
            // 
            this.rdbNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbNu.AutoSize = true;
            this.rdbNu.BackColor = System.Drawing.Color.White;
            this.rdbNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNu.Enabled = false;
            this.rdbNu.Location = new System.Drawing.Point(500, 173);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = false;
            // 
            // rdbNam
            // 
            this.rdbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbNam.AutoSize = true;
            this.rdbNam.BackColor = System.Drawing.Color.White;
            this.rdbNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNam.Enabled = false;
            this.rdbNam.Location = new System.Drawing.Point(314, 173);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = false;
            // 
            // cboHuyen
            // 
            this.cboHuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboHuyen.BackColor = System.Drawing.Color.White;
            this.cboHuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHuyen.Enabled = false;
            this.cboHuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHuyen.ForeColor = System.Drawing.Color.DeepPink;
            this.cboHuyen.FormattingEnabled = true;
            this.cboHuyen.Location = new System.Drawing.Point(311, 229);
            this.cboHuyen.Name = "cboHuyen";
            this.cboHuyen.Size = new System.Drawing.Size(115, 26);
            this.cboHuyen.TabIndex = 59;
            // 
            // cboTinh
            // 
            this.cboTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTinh.BackColor = System.Drawing.Color.White;
            this.cboTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.Enabled = false;
            this.cboTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinh.ForeColor = System.Drawing.Color.DeepPink;
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(435, 229);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(115, 26);
            this.cboTinh.TabIndex = 58;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.Color.DeepPink;
            this.dtpNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.LavenderBlush;
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(311, 366);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(236, 23);
            this.dtpNgaySinh.TabIndex = 56;
            // 
            // btnThayDoiMatKhau
            // 
            this.btnThayDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThayDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThayDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoiMatKhau.Image = global::QLCT.Properties.Resources.edit;
            this.btnThayDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiMatKhau.Location = new System.Drawing.Point(227, 510);
            this.btnThayDoiMatKhau.Name = "btnThayDoiMatKhau";
            this.btnThayDoiMatKhau.Size = new System.Drawing.Size(186, 42);
            this.btnThayDoiMatKhau.TabIndex = 8;
            this.btnThayDoiMatKhau.Text = "Thay đổi mật khẩu";
            this.btnThayDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThayDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnThayDoiMatKhau.Click += new System.EventHandler(this.btnThayDoiMatKhau_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QLCT.Properties.Resources.confirm;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(493, 510);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(30, 0, 45, 0);
            this.btnLuu.Size = new System.Drawing.Size(186, 42);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QLCT.Properties.Resources.Account_50px;
            this.pictureBox1.Location = new System.Drawing.Point(254, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.cboHuyen);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.btnNgaySinh);
            this.Controls.Add(this.btnSDT);
            this.Controls.Add(this.btnDiaChi);
            this.Controls.Add(this.btnGioiTinh);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnThayDoiMatKhau);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbHoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThayDoiMatKhau;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnGioiTinh;
        private System.Windows.Forms.Button btnDiaChi;
        private System.Windows.Forms.Button btnSDT;
        private System.Windows.Forms.Button btnNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.ComboBox cboHuyen;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}