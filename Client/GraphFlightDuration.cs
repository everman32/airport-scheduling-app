using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class GraphFlightDuration : Form
    {
        public Form form;
        public DataGridView dataGridView;
        public GraphFlightDuration(WorkDestinationsForm workDestinationsForm,DataGridView DestinationGridView)
        {
            InitializeComponent();
            form = workDestinationsForm;
            dataGridView = DestinationGridView;
        }

        private void DiagramFlightDuration_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                Series series = new Series("Продолжительность полёта");
                series.Font = new System.Drawing.Font("Consolas", 12);
                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Самолёт";
                chart1.ChartAreas[0].AxisX.TitleFont= new Font("Consolas", 8);
                chart1.ChartAreas[0].AxisY.Title = "Время, ч";
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 8);
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].ChartType = SeriesChartType.Line;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(dataGridView.Rows[i].Cells[2].Value, dataGridView.Rows[i].Cells[1].Value);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
