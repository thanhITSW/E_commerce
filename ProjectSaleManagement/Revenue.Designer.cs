namespace ProjectSaleManagement
{
    partial class Revenue
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Year = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.bShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 85);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(997, 477);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(111, 30);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(43, 20);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(189, 27);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(271, 26);
            this.txtYear.TabIndex = 2;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(582, 16);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(131, 49);
            this.bShow.TabIndex = 3;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 590);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.chart1);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button bShow;
    }
}