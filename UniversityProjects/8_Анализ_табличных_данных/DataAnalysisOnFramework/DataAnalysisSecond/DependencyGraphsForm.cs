using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace DataAnalysisSecond
{
    public partial class DependencyGraphsForm : Form
    {
        DataGridView curDgv;
        public DependencyGraphsForm()
        {
            InitializeComponent();
            curDgv = new DataGridView();
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstColumnCb.SelectedItem == null || firstColumnCb.SelectedItem.ToString() == "" || secondColumnCb.SelectedItem == null || secondColumnCb.SelectedItem.ToString() == "" || firstColumnCb.Text == secondColumnCb.Text)
                    throw new Exception();

                var index1 = firstColumnCb.SelectedIndex;
                var index2 = secondColumnCb.SelectedIndex;

                //List<DataGridViewCell> cellsX = new List<DataGridViewCell>();
                
                var paramsY = new ChartValues<double>();
                var paramsX = new List<string>();
                for (int i = 0; i < curDgv.Rows.Count; i++)
                {
                    paramsX.Add(curDgv[index1, i].Value.ToString());
                    paramsY.Add(double.Parse(curDgv[index2, i].Value.ToString() ));
                }

                UpdateGraph(paramsX, paramsY, curDgv.Columns[index1].Name, curDgv.Columns[index2].Name);

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            };
        }

        public void Show(DataGridView dgv)
        {
            curDgv = dgv;
            UpdateColumns();
            this.Show();
        }

        /// <summary>
        /// Метод обновления комбобоксов.
        /// </summary>
        private void UpdateColumns()
        {

            firstColumnCb.Items.Clear();
            secondColumnCb.Items.Clear();

            for (int i = 0; i < curDgv.Columns.Count; i++)
            {
                firstColumnCb.Items.Add($"{i}-{curDgv.Columns[i].Name}");
                secondColumnCb.Items.Add($"{i}-{curDgv.Columns[i].Name}");
            }

        }

        /// <summary>
        /// Метод для построения графика.
        /// </summary>
        /// <param name="xParametres">
        /// X-параметры.
        /// </param>
        /// <param name="yParametrs">
        /// Y-параметры.
        /// </param>
        /// <param name="xName">
        /// Название оси X.
        /// </param>
        /// <param name="yName">
        /// Название оси Y.
        /// </param>
        private void UpdateGraph(List<string> xParametres, ChartValues<double> yParametrs, string xName, string yName)
        {
            
            mainGraph.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = yName + ':',
                    Values = yParametrs, 
                    
                },
                
            };

            mainGraph.AxisX.Clear();
            mainGraph.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = xName,
                Labels = xParametres,
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 15,
                
            });

            mainGraph.AxisY.Clear();
            mainGraph.AxisY.Add(new Axis
            {
                Title = yName,
               
            });

            mainGraph.LegendLocation = LegendLocation.Top;

            
            





        }
    }
}
