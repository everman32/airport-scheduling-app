using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class DiagramPassengersCount : Form
    {
        public Form form;
        public DataGridView dataGridView;
        public DiagramPassengersCount(WorkCondorsetAlternative workCondorsetAlternative, DataGridView ScheduleGridView)
        {
            InitializeComponent();
            form = workCondorsetAlternative;
            dataGridView = ScheduleGridView;
        }
        private void GraphDate_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                Series series=new Series();
                chart1.Series.Add(series);
                chart1.Series[0].ChartType = SeriesChartType.Pie;
                chart1.Series[0].IsValueShownAsLabel = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(dataGridView.Rows[i].Cells[1].Value,dataGridView.Rows[i].Cells[2].Value);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
