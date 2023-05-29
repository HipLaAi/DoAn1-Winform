
namespace QLCT.GUI
{
    partial class frmKiemTraSDT
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(247, 25);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(15, 333);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(232, 25);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(15, 333);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(15, 343);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(217, 15);
            this.pnlBottom.TabIndex = 3;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSDT.Location = new System.Drawing.Point(21, 221);
            this.mtxtSDT.Mask = "0000-000-000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(205, 26);
            this.mtxtSDT.TabIndex = 4;
            this.mtxtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MercuriusScript", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xác nhận lại số điện thoại";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCT.Properties.Resources.cat_happy;
            this.pictureBox1.Location = new System.Drawing.Point(24, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Image = global::QLCT.Properties.Resources.check;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(125, 270);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(103, 42);
            this.btnXacNhan.TabIndex = 5;
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
            this.btnHuy.Location = new System.Drawing.Point(19, 270);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnHuy.Size = new System.Drawing.Size(103, 42);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmKiemTraSDT
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(247, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKiemTraSDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKiemTraSDT";
            this.Load += new System.EventHandler(this.frmKiemTraSDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}