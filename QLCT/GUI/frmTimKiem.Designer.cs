
namespace QLCT.GUI
{
    partial class frmTimKiem
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
            this.pnlThan = new System.Windows.Forms.Panel();
            this.btnGiaoDichThu = new System.Windows.Forms.Button();
            this.btnGiaoDichChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlThan
            // 
            this.pnlThan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThan.BackColor = System.Drawing.Color.White;
            this.pnlThan.Location = new System.Drawing.Point(0, 41);
            this.pnlThan.Name = "pnlThan";
            this.pnlThan.Size = new System.Drawing.Size(920, 523);
            this.pnlThan.TabIndex = 10;
            // 
            // btnGiaoDichThu
            // 
            this.btnGiaoDichThu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiaoDichThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoDichThu.FlatAppearance.BorderSize = 0;
            this.btnGiaoDichThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiaoDichThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaoDichThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDichThu.Image = global::QLCT.Properties.Resources.money_bag;
            this.btnGiaoDichThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDichThu.Location = new System.Drawing.Point(184, 0);
            this.btnGiaoDichThu.Name = "btnGiaoDichThu";
            this.btnGiaoDichThu.Size = new System.Drawing.Size(184, 41);
            this.btnGiaoDichThu.TabIndex = 12;
            this.btnGiaoDichThu.Text = "Giao dịch thu";
            this.btnGiaoDichThu.UseVisualStyleBackColor = false;
            this.btnGiaoDichThu.Click += new System.EventHandler(this.btnGiaoDichThu_Click);
            // 
            // btnGiaoDichChi
            // 
            this.btnGiaoDichChi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiaoDichChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoDichChi.FlatAppearance.BorderSize = 0;
            this.btnGiaoDichChi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiaoDichChi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaoDichChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDichChi.Image = global::QLCT.Properties.Resources.money;
            this.btnGiaoDichChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDichChi.Location = new System.Drawing.Point(0, 0);
            this.btnGiaoDichChi.Name = "btnGiaoDichChi";
            this.btnGiaoDichChi.Size = new System.Drawing.Size(184, 41);
            this.btnGiaoDichChi.TabIndex = 11;
            this.btnGiaoDichChi.Text = "Giao dịch chi";
            this.btnGiaoDichChi.UseVisualStyleBackColor = false;
            this.btnGiaoDichChi.Click += new System.EventHandler(this.btnGiaoDichChi_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(920, 564);
            this.Controls.Add(this.btnGiaoDichThu);
            this.Controls.Add(this.btnGiaoDichChi);
            this.Controls.Add(this.pnlThan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGiaoDichThu;
        private System.Windows.Forms.Button btnGiaoDichChi;
        private System.Windows.Forms.Panel pnlThan;
    }
}