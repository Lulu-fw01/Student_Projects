using System;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Форма, прдназначенная для подтверждения, что пользователь хочет или не хочет сохранить класс.
    /// </summary>
    public partial class DuWSaveW : Form
    {
        public DuWSaveW()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие, что нужно сохранить склад.
        /// </summary>
        public Action SaveWarehouse;
        public Action DontSaveWarehouse;

        /// <summary>
        /// Нажатие на кнопку сохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e) {SaveWarehouse?.Invoke(); this.Close(); this.DialogResult = DialogResult.OK; }

        /// <summary>
        /// Нажатие на кнопку "не сохранять"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoBtn_Click(object sender, EventArgs e) { DontSaveWarehouse?.Invoke(); this.Close(); this.DialogResult = DialogResult.OK; }

    }
}
