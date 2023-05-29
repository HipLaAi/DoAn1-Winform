
namespace QLCT.GUI
{
    partial class frmThongKeTaiKhoan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeTaiKhoan));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSoLuongTheoDoTuoi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSoLuongNguoiTheoTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongTheoDoTuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongNguoiTheoTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Biểu đồ thống kê số lượng người dùng theo nhóm độ tuổi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Biểu đồ thống kê số lượng người dùng theo tỉnh thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng người dùng";
            // 
            // chartSoLuongTheoDoTuoi
            // 
            this.chartSoLuongTheoDoTuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartSoLuongTheoDoTuoi.ChartAreas.Add(chartArea1);
            this.chartSoLuongTheoDoTuoi.Enabled = false;
            legend1.Name = "Legend1";
            this.chartSoLuongTheoDoTuoi.Legends.Add(legend1);
            this.chartSoLuongTheoDoTuoi.Location = new System.Drawing.Point(565, 210);
            this.chartSoLuongTheoDoTuoi.Name = "chartSoLuongTheoDoTuoi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.Legend = "Legend1";
            series1.Name = "Độ tuổi";
            this.chartSoLuongTheoDoTuoi.Series.Add(series1);
            this.chartSoLuongTheoDoTuoi.Size = new System.Drawing.Size(342, 304);
            this.chartSoLuongTheoDoTuoi.TabIndex = 11;
            this.chartSoLuongTheoDoTuoi.Text = "chart1";
            // 
            // chartSoLuongNguoiTheoTinh
            // 
            this.chartSoLuongNguoiTheoTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartSoLuongNguoiTheoTinh.ChartAreas.Add(chartArea2);
            this.chartSoLuongNguoiTheoTinh.Enabled = false;
            legend2.Name = "Legend1";
            this.chartSoLuongNguoiTheoTinh.Legends.Add(legend2);
            this.chartSoLuongNguoiTheoTinh.Location = new System.Drawing.Point(11, 27);
            this.chartSoLuongNguoiTheoTinh.Name = "chartSoLuongNguoiTheoTinh";
            this.chartSoLuongNguoiTheoTinh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số lượng người dùng";
            this.chartSoLuongNguoiTheoTinh.Series.Add(series2);
            this.chartSoLuongNguoiTheoTinh.Size = new System.Drawing.Size(688, 487);
            this.chartSoLuongNguoiTheoTinh.TabIndex = 9;
            this.chartSoLuongNguoiTheoTinh.Text = "chart1";
            // 
            // cboTinh
            // 
            this.cboTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.ForeColor = System.Drawing.Color.Purple;
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(787, 176);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(121, 24);
            this.cboTinh.TabIndex = 20;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tỉnh thành";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tỉnh thành";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmThongKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartSoLuongTheoDoTuoi);
            this.Controls.Add(this.chartSoLuongNguoiTheoTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeTaiKhoan";
            this.Text = "frmThongKeTaiKhoan";
            this.Load += new System.EventHandler(this.frmThongKeTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongTheoDoTuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuongNguoiTheoTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoLuongTheoDoTuoi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoLuongNguoiTheoTinh;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}