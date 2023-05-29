
namespace QLCT.GUI
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoThiTongTien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoThiDanhMucTheoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chartDoThiDanhMucTheoNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiDanhMucTheoThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiDanhMucTheoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoThiTongTien
            // 
            this.chartDoThiTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDoThiTongTien.ChartAreas.Add(chartArea1);
            this.chartDoThiTongTien.Enabled = false;
            legend1.Name = "Legend1";
            this.chartDoThiTongTien.Legends.Add(legend1);
            this.chartDoThiTongTien.Location = new System.Drawing.Point(12, 61);
            this.chartDoThiTongTien.Name = "chartDoThiTongTien";
            this.chartDoThiTongTien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng tiền";
            this.chartDoThiTongTien.Series.Add(series1);
            this.chartDoThiTongTien.Size = new System.Drawing.Size(590, 487);
            this.chartDoThiTongTien.TabIndex = 2;
            this.chartDoThiTongTien.Text = "chart1";
            // 
            // chartDoThiDanhMucTheoThang
            // 
            this.chartDoThiDanhMucTheoThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartDoThiDanhMucTheoThang.ChartAreas.Add(chartArea2);
            this.chartDoThiDanhMucTheoThang.Enabled = false;
            legend2.Name = "Legend1";
            this.chartDoThiDanhMucTheoThang.Legends.Add(legend2);
            this.chartDoThiDanhMucTheoThang.Location = new System.Drawing.Point(566, 4);
            this.chartDoThiDanhMucTheoThang.Name = "chartDoThiDanhMucTheoThang";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series2.Legend = "Legend1";
            series2.Name = "DanhMuc";
            this.chartDoThiDanhMucTheoThang.Series.Add(series2);
            this.chartDoThiDanhMucTheoThang.Size = new System.Drawing.Size(342, 304);
            this.chartDoThiDanhMucTheoThang.TabIndex = 3;
            this.chartDoThiDanhMucTheoThang.Text = "chart1";
            // 
            // cboThang
            // 
            this.cboThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.ForeColor = System.Drawing.Color.Purple;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(237, 16);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(58, 28);
            this.cboThang.TabIndex = 4;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(762, 318);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // chartDoThiDanhMucTheoNgay
            // 
            this.chartDoThiDanhMucTheoNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartDoThiDanhMucTheoNgay.ChartAreas.Add(chartArea3);
            this.chartDoThiDanhMucTheoNgay.Enabled = false;
            legend3.Name = "Legend1";
            this.chartDoThiDanhMucTheoNgay.Legends.Add(legend3);
            this.chartDoThiDanhMucTheoNgay.Location = new System.Drawing.Point(608, 350);
            this.chartDoThiDanhMucTheoNgay.Name = "chartDoThiDanhMucTheoNgay";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "DanhMuc";
            this.chartDoThiDanhMucTheoNgay.Series.Add(series3);
            this.chartDoThiDanhMucTheoNgay.Size = new System.Drawing.Size(300, 238);
            this.chartDoThiDanhMucTheoNgay.TabIndex = 3;
            this.chartDoThiDanhMucTheoNgay.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê chi tiêu của tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày giao dịch";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Biểu đồ thống kê tổng số tiền chi trong 1 tháng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Biểu đồ thống kê số tiền chi theo danh mục trong 1 ngày";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Biểu đồ thống kê số tiền chi theo danh mục trong 1 tháng";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.chartDoThiDanhMucTheoNgay);
            this.Controls.Add(this.chartDoThiDanhMucTheoThang);
            this.Controls.Add(this.chartDoThiTongTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiDanhMucTheoThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoThiDanhMucTheoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoThiTongTien;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoThiDanhMucTheoThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoThiDanhMucTheoNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}