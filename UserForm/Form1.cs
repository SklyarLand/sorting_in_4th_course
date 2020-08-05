using Algoritmen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            var sizes = GetSizes();
            var sorts = GetSorts();
            if (sizes.Length < 1 && sorts.Length < 1) return;
            var program = new Controllers.MainController(sizes, sorts);
            var dict = program.MakeSort();

            Сhart1Option();

            foreach (var sort in dict)
            {
                var graf = new System.Windows.Forms.DataVisualization.Charting.Series();
                graf.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                graf.LegendText = sort.Key;

                var legend = new System.Windows.Forms.DataVisualization.Charting.Legend(graf.Legend);
                legend.Alignment = StringAlignment.Far;

                foreach (var point in sort.Value) {
                    graf.Points.AddXY(point.Key, point.Value);
                }
                chart1.Series.Add(graf);
                chart1.Legends.Add(legend);
            }
        }

        void Сhart1Option()
        {
            chart1.ChartAreas[0] = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisX.Title = "n, ед.";
            chart1.ChartAreas[0].AxisY.Title = "t, мс.";
        }

        int[] GetSizes()//получаем массив выделенных размеров
        {
            var list = new List<int>();
            foreach (string str in this.checkedListBox1.CheckedItems)
            {
                var arr = str.Split('^');
                int num = Convert.ToInt32(arr[0]);
                int power = 1;
                if (arr.Length > 1)
                {
                    power = Convert.ToInt32(arr[1]);
                }
                num = Convert.ToInt32(Math.Pow(num, power));
                list.Add(num / 2);
                list.Add(num);
            }
            return list.ToArray();
        }

        BaseSort[] GetSorts()
        {
            var sorts = new List<BaseSort>();
            foreach(BaseSort sort in listBox2.SelectedItems)
            {
                sorts.Add(sort);
            }
            return sorts.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = new System.Collections.ArrayList();
            list.Add(new TreeSort());
            list.Add(new ShellSortPratt());
            list.Add(new BubbleSort());
            list.Add(new ShakerSort());
            list.Add(new ShellSort());
            list.Add(new HeapSort());
            listBox2.DataSource = list;
            listBox2.DisplayMember = "Name";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
