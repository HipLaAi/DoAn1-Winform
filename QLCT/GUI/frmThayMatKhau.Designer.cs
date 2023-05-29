
namespace QLCT.GUI
{
    partial class frmThayMatKhau
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
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnMatKhauMoi = new System.Windows.Forms.Button();
            this.btnXacNhanMatKhau = new System.Windows.Forms.Button();
            this.errorMatKhauMoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorXacNhanMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.lbXacNhanMatKhau = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.lbText1 = new System.Windows.Forms.Label();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.picNen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhauMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXacNhanMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(349, 423);
            this.txtXacNhanMatKhau.Multiline = true;
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(200, 24);
            this.txtXacNhanMatKhau.TabIndex = 2;
            this.txtXacNhanMatKhau.Text = "Xác nhận lại mật khẩu";
            this.txtXacNhanMatKhau.Enter += new System.EventHandler(this.txtXacNhanMatKhau_Enter);
            this.txtXacNhanMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXacNhanMatKhau_KeyPress);
            this.txtXacNhanMatKhau.Leave += new System.EventHandler(this.txtXacNhanMatKhau_Leave);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BackColor = System.Drawing.Color.Brown;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnXacNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Cecefontvn", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(376, 493);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(140, 38);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Silver;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(349, 323);
            this.txtMatKhauMoi.Multiline = true;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(200, 24);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.Text = "Nhập mật khẩu";
            this.txtMatKhauMoi.Enter += new System.EventHandler(this.txtMatKhauMoi_Enter);
            this.txtMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi_KeyPress);
            this.txtMatKhauMoi.Leave += new System.EventHandler(this.txtMatKhauMoi_Leave);
            // 
            // btnMatKhauMoi
            // 
            this.btnMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatKhauMoi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMatKhauMoi.FlatAppearance.BorderSize = 0;
            this.btnMatKhauMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMatKhauMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMatKhauMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatKhauMoi.Location = new System.Drawing.Point(329, 307);
            this.btnMatKhauMoi.Name = "btnMatKhauMoi";
            this.btnMatKhauMoi.Size = new System.Drawing.Size(240, 51);
            this.btnMatKhauMoi.TabIndex = 32;
            this.btnMatKhauMoi.TabStop = false;
            this.btnMatKhauMoi.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanMatKhau
            // 
            this.btnXacNhanMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhanMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXacNhanMatKhau.FlatAppearance.BorderSize = 0;
            this.btnXacNhanMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXacNhanMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXacNhanMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanMatKhau.Location = new System.Drawing.Point(329, 408);
            this.btnXacNhanMatKhau.Name = "btnXacNhanMatKhau";
            this.btnXacNhanMatKhau.Size = new System.Drawing.Size(240, 50);
            this.btnXacNhanMatKhau.TabIndex = 33;
            this.btnXacNhanMatKhau.TabStop = false;
            this.btnXacNhanMatKhau.UseVisualStyleBackColor = true;
            // 
            // errorMatKhauMoi
            // 
            this.errorMatKhauMoi.ContainerControl = this;
            // 
            // errorXacNhanMatKhau
            // 
            this.errorXacNhanMatKhau.ContainerControl = this;
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
            this.btnHienThi.Location = new System.Drawing.Point(536, 322);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(27, 23);
            this.btnHienThi.TabIndex = 35;
            this.btnHienThi.TabStop = false;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
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
            this.btnAn.Location = new System.Drawing.Point(536, 322);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(27, 23);
            this.btnAn.TabIndex = 34;
            this.btnAn.TabStop = false;
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // lbXacNhanMatKhau
            // 
            this.lbXacNhanMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbXacNhanMatKhau.AutoSize = true;
            this.lbXacNhanMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbXacNhanMatKhau.Font = new System.Drawing.Font("UTM Facebook K&T", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbXacNhanMatKhau.Image = global::QLCT.Properties.Resources.bo_góc_màu_đỏ;
            this.lbXacNhanMatKhau.Location = new System.Drawing.Point(325, 382);
            this.lbXacNhanMatKhau.Name = "lbXacNhanMatKhau";
            this.lbXacNhanMatKhau.Size = new System.Drawing.Size(145, 22);
            this.lbXacNhanMatKhau.TabIndex = 28;
            this.lbXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("UTM Facebook K&T", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMatKhauMoi.Image = global::QLCT.Properties.Resources.bo_góc_màu_đỏ;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(325, 282);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(108, 22);
            this.lbMatKhauMoi.TabIndex = 29;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbText2
            // 
            this.lbText2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbText2.AutoSize = true;
            this.lbText2.BackColor = System.Drawing.Color.Transparent;
            this.lbText2.Font = new System.Drawing.Font("UTM Alba Matter", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText2.ForeColor = System.Drawing.Color.LightYellow;
            this.lbText2.Image = global::QLCT.Properties.Resources.bo_góc_màu_đỏ;
            this.lbText2.Location = new System.Drawing.Point(389, 89);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(254, 72);
            this.lbText2.TabIndex = 30;
            this.lbText2.Text = "quên nữa nha";
            // 
            // lbText1
            // 
            this.lbText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbText1.AutoSize = true;
            this.lbText1.BackColor = System.Drawing.Color.Transparent;
            this.lbText1.Font = new System.Drawing.Font("UTM Alba Matter", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText1.ForeColor = System.Drawing.Color.LightYellow;
            this.lbText1.Image = global::QLCT.Properties.Resources.bo_góc_màu_đỏ;
            this.lbText1.Location = new System.Drawing.Point(286, 31);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(163, 72);
            this.lbText1.TabIndex = 31;
            this.lbText1.Text = "Đừng có";
            // 
            // picGif
            // 
            this.picGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGif.Image = global::QLCT.Properties.Resources.gif_cat;
            this.picGif.Location = new System.Drawing.Point(253, 66);
            this.picGif.Margin = new System.Windows.Forms.Padding(0);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(390, 270);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 27;
            this.picGif.TabStop = false;
            // 
            // picNen
            // 
            this.picNen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNen.Image = global::QLCT.Properties.Resources.bo_góc_màu_đỏ;
            this.picNen.Location = new System.Drawing.Point(253, 31);
            this.picNen.Margin = new System.Windows.Forms.Padding(0);
            this.picNen.MaximumSize = new System.Drawing.Size(390, 530);
            this.picNen.MinimumSize = new System.Drawing.Size(390, 530);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(390, 530);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 26;
            this.picNen.TabStop = false;
            // 
            // frmThayMatKhau
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lbXacNhanMatKhau);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.btnMatKhauMoi);
            this.Controls.Add(this.btnXacNhanMatKhau);
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.lbText1);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThayMatKhau";
            this.Text = "frmThayMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.errorMatKhauMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorXacNhanMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lbXacNhanMatKhau;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Button btnMatKhauMoi;
        private System.Windows.Forms.Button btnXacNhanMatKhau;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.ErrorProvider errorMatKhauMoi;
        private System.Windows.Forms.ErrorProvider errorXacNhanMatKhau;
    }
}