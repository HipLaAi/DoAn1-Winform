
namespace QLCT.GUI
{
    partial class frmCapNhatMatKhau
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MercuriusScript", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mật khẩu mới";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(15, 343);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(217, 15);
            this.pnlBottom.TabIndex = 11;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(232, 25);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(15, 333);
            this.pnlRight.TabIndex = 10;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(15, 333);
            this.pnlLeft.TabIndex = 9;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(247, 25);
            this.pnlTop.TabIndex = 8;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCT.Properties.Resources.gif_dang_nhap_vui_nhon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Image = global::QLCT.Properties.Resources.check;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(125, 298);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(103, 42);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::QLCT.Properties.Resources.close;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(19, 298);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnHuy.Size = new System.Drawing.Size(103, 42);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MercuriusScript", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Xác nhận lại mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.Location = new System.Drawing.Point(24, 181);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatKhau.Size = new System.Drawing.Size(202, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(24, 254);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(202, 27);
            this.txtXacNhanMatKhau.TabIndex = 2;
            this.txtXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            this.txtXacNhanMatKhau.Enter += new System.EventHandler(this.txtXacNhanMatKhau_Enter);
            this.txtXacNhanMatKhau.Leave += new System.EventHandler(this.txtXacNhanMatKhau_Leave);
            // 
            // btnAn
            // 
            this.btnAn.BackgroundImage = global::QLCT.Properties.Resources.Show_Password;
            this.btnAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAn.FlatAppearance.BorderSize = 0;
            this.btnAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAn.Location = new System.Drawing.Point(192, 183);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(26, 23);
            this.btnAn.TabIndex = 17;
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackgroundImage = global::QLCT.Properties.Resources.Hide_Password;
            this.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Location = new System.Drawing.Point(192, 183);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(26, 23);
            this.btnHienThi.TabIndex = 18;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // frmCapNhatMatKhau
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(247, 358);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnHienThi;
    }
}