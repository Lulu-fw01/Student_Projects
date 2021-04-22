using System;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Форма для ввода пользователем значения для составлени csv отчета.
    /// </summary>
    public partial class CSVNumForm : Form
    {
        public CSVNumForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие, обозначающее, что пользователь ввел число и нажал ok.
        /// </summary>
        public Action<int> UserEnteredNum;

        /// <summary>
        /// Событие нажатия на кнопку ок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // Запуск события и передача введенного пользователем значения.
            UserEnteredNum?.Invoke((int)numericUpDown1.Value);
            this.Close();
        }
    }
}
