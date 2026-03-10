namespace SentenceStatistics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            txtInputSentence = new TextBox();
            CalcPercentage = new Button();
            statChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)statChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Ваше предложение :";
            // 
            // txtInputSentence
            // 
            txtInputSentence.Location = new Point(22, 38);
            txtInputSentence.Name = "txtInputSentence";
            txtInputSentence.Size = new Size(750, 27);
            txtInputSentence.TabIndex = 1;
            // 
            // CalcPercentage
            // 
            CalcPercentage.Location = new Point(23, 72);
            CalcPercentage.Name = "CalcPercentage";
            CalcPercentage.Size = new Size(205, 29);
            CalcPercentage.TabIndex = 2;
            CalcPercentage.Text = "Посчитать проценты букв";
            CalcPercentage.UseVisualStyleBackColor = true;
            CalcPercentage.Click += CalcPercentage_Click;
            // 
            // statChart
            // 
            chartArea2.Name = "ChartArea1";
            statChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            statChart.Legends.Add(legend2);
            statChart.Location = new Point(23, 121);
            statChart.Name = "statChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            statChart.Series.Add(series2);
            statChart.Size = new Size(749, 317);
            statChart.TabIndex = 3;
            statChart.Text = "chart1";
            title2.Name = "Проценты букв";
            statChart.Titles.Add(title2);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statChart);
            Controls.Add(CalcPercentage);
            Controls.Add(txtInputSentence);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)statChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInputSentence;
        private Button CalcPercentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart statChart;
    }
}
