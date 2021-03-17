using System;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace DataAnalysisSecond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытие таблицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (openCSVDialog.ShowDialog() == DialogResult.Cancel) return;
                var filePath = openCSVDialog.FileName;
                using (var csv = new CachedCsvReader(new StreamReader(filePath), true))
                {
                    // Считывание таблицы из файла и форматирование в dataGridView.
                    mainDataGrid.DataSource = csv;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("maybe file ws damaged");
            }
        }

        /// <summary>
        /// Открытие формы с гистаграммами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barGraphBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var bgf = new BarGraphForm();
                bgf.Show(mainDataGrid);
            }
            catch { }
        
        }


        /// <summary>
        /// Открытие формы с графиками.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dependencyGraphsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var dgf = new DependencyGraphsForm();
                dgf.Show(mainDataGrid);
            }
            catch { }
        }
    }
}
