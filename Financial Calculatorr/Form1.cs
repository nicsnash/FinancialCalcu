using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;



namespace Financial_Calculatorr
{
    public partial class Form1 : Form
    {
        private List<string> history = new List<string>();


        public Form1()
        {
            InitializeComponent();
            InitializeChart();


        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtPV.Text, out decimal PV);
            double.TryParse(txtT.Text, out double T);
            double.TryParse(txtR.Text, out double R);
            int.TryParse(txtTC.Text, out int TC);
            if (PV >= 0 && T >= 0 && R >= 0 && TC > 0)
            {
                var dValue = PV * (decimal)Math.Pow(1 + (R / 100) / TC, TC * T);
                lblOutput.Text = $"Discrete Value: ${dValue:N2}\n";
                var cValue = PV * (decimal)Math.Pow(Math.E, R / 100 * T);
                lblOutput.Text += $"Continues Value: ${cValue:N2}";
            }
            else
                MessageBox.Show("Check your input.");
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (cartesianchart2.SelectedTab == tabFormulas)
            {

                int.TryParse(TxtLeftMargin.Text, out int left);
                int.TryParse(TxtTopMargin.Text, out int top);
                if (left >= 0 && top >= 0)
                    e.Graphics.DrawImage(pictureBox1.Image, new Point(left, top));
                else
                    e.Graphics.DrawImage(pictureBox1.Image, new Point(10, 10));


            }
            else
            {
                string txtToPrint = $"PV:{txtPV.Text}\n" +
                 $"T:{txtT.Text}\n" +
                 $"R:{txtR.Text}\n" +
                 $"TC:{txtTC.Text}\n" +
                 lblOutput.Text;
                e.Graphics.DrawString(txtToPrint, fontDialog1.Font,
                    new SolidBrush(colorDialog1.Color), e.MarginBounds);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPV.Text = "";
            txtT.Text = "";
            txtR.Text = "";
            txtTC.Text = "";

            // Clear output label
            lblOutput.Text = "";
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtPV.Text, out decimal PV);
            double.TryParse(txtT.Text, out double T);
            double.TryParse(txtR.Text, out double R);
            int.TryParse(txtTC.Text, out int TC);
            if (PV >= 0 && T >= 0 && R >= 0 && TC > 0)
            {
                var dValue = PV * (decimal)Math.Pow(1 + (R / 100) / TC, TC * T);
                var cValue = PV * (decimal)Math.Pow(Math.E, R / 100 * T);

                // Add calculation to history
                string calculation = $"PV:{PV}, T:{T}, R:{R}, TC:{TC} => Discrete Value: ${dValue:N2}, Continuous Value: ${cValue:N2}";
                history.Add(calculation);

                // Update history listbox
                UpdateHistory_SelectedIndexChanged(sender, e);

                // Display result
                lblOutput.Text = $"Discrete Value: ${dValue:N2}\n" +
                                 $"Continuous Value: ${cValue:N2}";
            }
            else
            {
                MessageBox.Show("Check your input.");
            }
        }

        private void UpdateHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewHistory.Items.Clear();
            foreach (var item in history)
            {
                ViewHistory.Items.Add(item);
            }
        }

        private void UpdateHistory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ViewHistory.SelectedIndex != -1)
            {
                // Prompt user to confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Remove selected item from history
                    history.RemoveAt(ViewHistory.SelectedIndex);
                    UpdateHistory_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void InitializeChart()
        {
            // Add X-axis with time labels
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time (years)"
            });

            // Add Y-axis with future value labels
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Future Value"
            });

            // Set legend location
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            // Define the initial amount, interest rate, and time period
            decimal.TryParse(txtPrincipal.Text, out decimal initialAmount);
            double.TryParse(txtInterestRate.Text, out double interestRate);
            double.TryParse(txtTimePeriod.Text, out double timePeriod);

            if (initialAmount > 0 && interestRate > 0 && timePeriod > 0)
            {
                // Series collection for both discrete and continuous compounding
                SeriesCollection seriesCollection = new SeriesCollection();

                // Calculate values for discrete compounding
                ChartValues<double> discreteValues = new ChartValues<double>();
                for (int t = 0; t <= timePeriod; t++)
                {
                    double value = (double)(initialAmount * (decimal)Math.Pow(1 + (interestRate / 100), t));
                    discreteValues.Add(value);
                }

                // Add series for discrete compounding
                seriesCollection.Add(new LineSeries
                {
                    Title = "Discrete Compounding",
                    Values = discreteValues,
                    LineSmoothness = 0.5, // Adjust the smoothness of the line
                    PointGeometry = DefaultGeometries.Circle, // Define the shape of data points
                    Stroke = System.Windows.Media.Brushes.Red, // Color of the line
                    Fill = System.Windows.Media.Brushes.Transparent, // Make sure the line is visible
                    Visibility = System.Windows.Visibility.Visible // Make sure the series is visible
                   
                });

                // Calculate values for continuous compounding
                ChartValues<double> continuousValues = new ChartValues<double>();
                for (int t = 0; t <= timePeriod; t++)
                {
                    double value = (double)(initialAmount * (decimal)Math.Exp((interestRate / 100) * t));
                    continuousValues.Add(value);
                }

                // Add series for continuous compounding
                seriesCollection.Add(new LineSeries
                {
                    Title = "Continuous Compounding",
                    Values = continuousValues,
                    LineSmoothness = 0.5, // Adjust the smoothness of the line
                    PointGeometry = DefaultGeometries.Circle, // Define the shape of data points
                    Stroke = System.Windows.Media.Brushes.Blue, // Color of the line
                    Fill = System.Windows.Media.Brushes.Transparent, // Make sure the line is visible
                    Visibility = System.Windows.Visibility.Visible // Make sure the series is visible
                    
                });

                // Set series collection to the chart
                cartesianChart1.Series = seriesCollection;
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter valid numeric values for initial amount, interest rate, and time period.");
            }
        }
    }
}






    