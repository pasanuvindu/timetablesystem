
namespace itpm101
{
    partial class ViewAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_Lecture_Hall_Reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_Lab_Reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_Lecture_Hall_Cancelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_Lecture_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_Lab_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.NO_Lecture_Hall_Reserved,
            this.NO_Lab_Reserved,
            this.NO_Lecture_Hall_Cancelle,
            this.NO_Lecture_Hours,
            this.NO_Lab_Hours});
            this.dataGridView1.Location = new System.Drawing.Point(24, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.Width = 125;
            // 
            // NO_Lecture_Hall_Reserved
            // 
            this.NO_Lecture_Hall_Reserved.HeaderText = "NO_Lecture_Hall_Reserved";
            this.NO_Lecture_Hall_Reserved.MinimumWidth = 6;
            this.NO_Lecture_Hall_Reserved.Name = "NO_Lecture_Hall_Reserved";
            this.NO_Lecture_Hall_Reserved.Width = 125;
            // 
            // NO_Lab_Reserved
            // 
            this.NO_Lab_Reserved.HeaderText = "NO_Lab_Reserved";
            this.NO_Lab_Reserved.MinimumWidth = 6;
            this.NO_Lab_Reserved.Name = "NO_Lab_Reserved";
            this.NO_Lab_Reserved.Width = 125;
            // 
            // NO_Lecture_Hall_Cancelle
            // 
            this.NO_Lecture_Hall_Cancelle.HeaderText = "NO_Lecture_Hall_Cancelle";
            this.NO_Lecture_Hall_Cancelle.MinimumWidth = 6;
            this.NO_Lecture_Hall_Cancelle.Name = "NO_Lecture_Hall_Cancelle";
            this.NO_Lecture_Hall_Cancelle.Width = 125;
            // 
            // NO_Lecture_Hours
            // 
            this.NO_Lecture_Hours.HeaderText = "NO_Lecture_Hours";
            this.NO_Lecture_Hours.MinimumWidth = 6;
            this.NO_Lecture_Hours.Name = "NO_Lecture_Hours";
            this.NO_Lecture_Hours.Width = 125;
            // 
            // NO_Lab_Hours
            // 
            this.NO_Lab_Hours.HeaderText = "NO_Lab_Hours";
            this.NO_Lab_Hours.MinimumWidth = 6;
            this.NO_Lab_Hours.Name = "NO_Lab_Hours";
            this.NO_Lab_Hours.Width = 125;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(793, 135);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Month";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.Legend = "Legend1";
            series12.Name = "NO_Lecture_Hall_Reserved";
            series12.YValuesPerPoint = 6;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series13.Legend = "Legend1";
            series13.Name = "NO_Lab_Reserved";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series14.Legend = "Legend1";
            series14.Name = "NO_Lecture_Hall_Cancelled";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series15.Legend = "Legend1";
            series15.Name = "NO_Lab_Cancelled";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(590, 477);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title11.Name = "Month";
            title11.Text = "Month";
            title12.Name = "NO_Lecture_Hall_Reserved";
            title13.Name = "NO_Lab_Reserved";
            title14.Name = "NO_Lecture_Hall_Cancelled";
            title15.Name = "NO_Lab_Cancelled";
            this.chart1.Titles.Add(title11);
            this.chart1.Titles.Add(title12);
            this.chart1.Titles.Add(title13);
            this.chart1.Titles.Add(title14);
            this.chart1.Titles.Add(title15);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button1.Location = new System.Drawing.Point(942, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1395, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAnalysis";
            this.Text = "ViewAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_Lecture_Hall_Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_Lab_Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_Lecture_Hall_Cancelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_Lecture_Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_Lab_Hours;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}