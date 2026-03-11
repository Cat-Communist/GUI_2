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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            txtInputSentence = new TextBox();
            CalcPercentage = new Button();
            pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pieChart).BeginInit();
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
            txtInputSentence.Size = new Size(755, 27);
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
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            pieChart.ChartAreas.Add(chartArea1);
            legend1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new Point(23, 107);
            pieChart.Name = "pieChart";
            pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "chartSeries";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            pieChart.Series.Add(series1);
            pieChart.Size = new Size(754, 277);
            pieChart.TabIndex = 3;
            pieChart.Text = "chart1";
            title1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.Name = "Title1";
            title1.Text = "Процент букв в предложении";
            pieChart.Titles.Add(title1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pieChart);
            Controls.Add(CalcPercentage);
            Controls.Add(txtInputSentence);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pieChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInputSentence;
        private Button CalcPercentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}
