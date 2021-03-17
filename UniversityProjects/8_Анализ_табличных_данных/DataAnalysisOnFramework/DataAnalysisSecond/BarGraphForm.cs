using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

using LiveCharts.Wpf;

using LiveCharts;
using LiveCharts.Defaults;


using Separator = LiveCharts.Wpf.Separator;


namespace DataAnalysisSecond
{
    public partial class BarGraphForm : Form
    {
        DataGridView curDgv;
        Dictionary<object, int> groupedSystem;
        Dictionary<object, int> wholeSystem;
        string curName = "";

        public BarGraphForm()
        {
            InitializeComponent();
            curDgv = new DataGridView();
            groupedSystem = new Dictionary<object, int>();
            wholeSystem = new Dictionary<object, int>();
        }

        private void buildGraphBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (columnComboBox.SelectedItem == null || columnComboBox.SelectedItem.ToString() == "")
                    throw new Exception();

                var index = columnComboBox.SelectedIndex ;


                List<DataGridViewCell> cells = new List<DataGridViewCell>();
                for (int i = 0; i < curDgv.Rows.Count; i++)
                    cells.Add(curDgv[index, i]);

                var groups = from x in cells
                             group x by x.Value into y
                             select y;

                var system = groups.OrderBy(g => -g.Count()).Select(group => group).ToDictionary(group => group.First().Value, group => group.Count());

                groupedSystem = GetSortedDictonary(system);
                wholeSystem = system;
                curName = curDgv.Columns[index].Name;


                UpdateBarGraph(system, curDgv.Columns[index].Name);
                columnNumeric.Value = 0;
                columnNumeric.Maximum = (decimal)GetNumOfDifferentValues(system);

                UpdateLabels(index);


            }
            catch { };
        }

        public void Show(DataGridView dgv)
        {
            curDgv = dgv;
            UpdateColumns();
            this.Show();
        }

        private void UpdateColumns()
        {

            columnComboBox.Items.Clear();

            for (int i = 0; i < curDgv.Columns.Count; i++)
                columnComboBox.Items.Add($"{i}-{curDgv.Columns[i].Name}");

        }

        private void UpdateBarGraph(Dictionary<object, int> columns, string xName)
        {
            // chart стандартная библа.
            /* barGraph.Series[0].Points.Clear();
             barGraph.ChartAreas[0].AxisX.CustomLabels.Clear();
             barGraph.ChartAreas[0].AxisY.CustomLabels.Clear();

             int i = 0;
             foreach(var c in columns)
             {
                 barGraph.Series[0].Points.AddY(c.Value);
                 barGraph.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, c.Key.ToString(), 0, LabelMarkStyle.LineSideMark));
                 barGraph.ChartAreas[0].AxisY.CustomLabels.Add(new CustomLabel(c.Value - 0.5, c.Value + 0.5, c.Value.ToString(), 0, LabelMarkStyle.LineSideMark));
                 i++;
             }*/

            var cv = new ChartValues<ObservableValue>();
            foreach (var e in columns)
                cv.Add(new ObservableValue(e.Value));

            liveBarGraph.Series.Clear();
            liveBarGraph.Series.Add(new ColumnSeries
            {
                Values = cv,
                DataLabels = true,
                LabelPoint = point => point.Y.ToString()
            });

            

            var labels = new List<string>();
            foreach (var e in columns)
                labels.Add(e.Key.ToString());

            liveBarGraph.AxisX.Clear();
            liveBarGraph.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = labels,
                Title = xName,
                Separator = new Separator 
                {
                    Step = 1,
                    IsEnabled = false 
                },
                LabelsRotation = 15
            });

            liveBarGraph.AxisY.Clear();
            liveBarGraph.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Cuerency",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator()
            });

            
        }

        /// <summary>
        /// Метод получения среднего значения.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private double GetAverageValueFromColumn(int index)
        {
            try
            {
                int sum = 0;

                for (int i = 0; i < curDgv.Rows.Count; i++)
                {
                    sum += int.Parse(curDgv[index, i].Value.ToString());
                }

                var av = sum / curDgv.Rows.Count;

                return av;
            }
            catch { return 0; }
        }

        private double GetMedianValueFromColumn(int index)
        {
            var arr = GetDoubleArrayFromColumn(index);
            var sortedArr = arr.OrderBy(x => x).Select(x => x).ToList();


            if (sortedArr.Count() % 2 == 0)
                return sortedArr[sortedArr.Count() / 2] + sortedArr[sortedArr.Count() / 2 + 1];
            else
                return sortedArr[sortedArr.Count() / 2];

        }

        /// <summary>
        /// Изменение лейблов.
        /// </summary>
        /// <param name="columnindex"></param>
        private void UpdateLabels(int columnindex)
        {
            averageLabel.Text = GetAverageValueFromColumn(columnindex).ToString();
            medianLabel.Text = GetMedianValueFromColumn(columnindex).ToString();
            var desp = GetDispersionFromColumn(columnindex);
            dispersionLabel.Text = desp.ToString();
            deviationLabel.Text = Math.Sqrt(desp).ToString();
        }

        /// <summary>
        /// Получение листа double из числового столбца, если столбец другой, то возвраается ноль.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private List<double> GetDoubleArrayFromColumn(int index)
        {
            try 
            {
                var arr = new List<double>();
                for (int i = 0; i < curDgv.Rows.Count; i++)
                {
                    arr.Add(int.Parse(curDgv[index, i].Value.ToString()));
                }
                return arr;
            }
            catch
            {
                return new List<double>() { 0 };
            }
        }

        /// <summary>
        /// Получение дисперсии.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private double GetDispersionFromColumn(int index)
        {
            try
            {
                var list = GetDoubleArrayFromColumn(index);
                var average = GetAverage(list);

                var sumDisp = 0.0;
                foreach (var e in list)
                    sumDisp += (e - average) * (e - average);

                return sumDisp / (list.Count - 1);
            }
            catch {
                return 0;
            }

        }

        /// <summary>
        /// Получение среднего значения.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private double GetAverage(List<double> list)
        {
            try
            {
                var sum = 0.0;
                foreach (var i in list)
                    sum += i;
                return sum / list.Count();
            }
            catch { return 0; }
        }


        private int GetNumOfDifferentValues(Dictionary<object, int> columns)
        {
            try
            {
                var list = new List<int>();
                foreach (var e in columns)
                    list.Add(e.Value);

                var diff = from e in list
                           group e by e into g
                           select g;

                return diff.Count();
            }
            catch {
                return 0;
            }

        }

        private void columnNumeric_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var newSystem = new Dictionary<object, int>();

                var k = wholeSystem.Keys.ToArray();
                var v = wholeSystem.Values.ToArray();

                var n = wholeSystem.Count();
                for (int i = numOfValues.Count() - 1; i > numOfValues.Count() - columnNumeric.Value - 1; i--)
                    n = n - numOfValues[i];

                for (var i = 0; i < n; i++)
                {
                    newSystem.Add(k[i], v[i]);
                }

                k = groupedSystem.Keys.ToArray();
                v = groupedSystem.Values.ToArray();
                for (int i = (int)(groupedSystem.Count() - columnNumeric.Value); i < groupedSystem.Count; i++)
                {
                    newSystem.Add(k[i], v[i]);
                }


                

                UpdateBarGraph(newSystem, curName);
            }
            catch
            {
                UpdateBarGraph(wholeSystem, curName);
            }

            
        }
        int[] numOfValues = new int[1];
        public Dictionary<object, int> GetSortedDictonary(Dictionary<object, int> columns)
        {
            try
            {

                var ll = columns.GroupBy(x => x.Value).OrderBy(x => -x.First().Value).Select(x => x).ToDictionary(g => (object)$"{g.First().Key} - {g.Last().Key}", g => g.First().Value);
                numOfValues = columns.GroupBy(x => x.Value).OrderBy(x => -x.First().Value).Select(x => x.Count()).ToArray();
                return ll;
            }
            catch {
                return new Dictionary<object, int>();
            }

            //groups.Select(group => group).ToDictionary(group => group.First().Value, group => group.Count());
        }
    }

}
