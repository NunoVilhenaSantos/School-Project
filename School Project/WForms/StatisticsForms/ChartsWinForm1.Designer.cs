namespace School_Project.WForms.StatisticsForms
{
    partial class ChartsWinForm1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartAutoListPayments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartAutoListPayments).BeginInit();
            SuspendLayout();
            // 
            // chartAutoListPayments
            // 
            chartArea1.AxisY.LabelStyle.Format = "{0:0,}m";
            chartArea1.Name = "ChartArea1";
            chartAutoListPayments.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chartAutoListPayments.Legends.Add(legend1);
            chartAutoListPayments.Location = new Point(221, 86);
            chartAutoListPayments.Name = "chartAutoListPayments";
            chartAutoListPayments.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Juros Pagos";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Capital Pago";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = Color.Transparent;
            series3.MarkerColor = Color.Black;
            series3.MarkerStep = 2;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series3.Name = "Saldo do Empréstimo";
            chartAutoListPayments.Series.Add(series1);
            chartAutoListPayments.Series.Add(series2);
            chartAutoListPayments.Series.Add(series3);
            chartAutoListPayments.Size = new Size(1022, 344);
            chartAutoListPayments.TabIndex = 11;
            chartAutoListPayments.Text = "Gráfico";
            // 
            // ChartsWinForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(chartAutoListPayments);
            Name = "ChartsWinForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChartsWinForm1";
            ((System.ComponentModel.ISupportInitialize)chartAutoListPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAutoListPayments;
    }
}