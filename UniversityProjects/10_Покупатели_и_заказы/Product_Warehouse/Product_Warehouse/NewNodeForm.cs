using System;
using System.Linq;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Форма для создания новых разделов.
    /// </summary>
    public partial class NewNodeForm : Form
    {
        public NewNodeForm()
        {
            InitializeComponent();
            ReadyToClose = true;
        }

        /// <summary>
        /// Событие, показывающее, что пользователь ввел название и нажал добавить.
        /// </summary>
        public Action<NewNodeForm, string> CategoryNameEntered;

        private void addButton_Click(object sender, EventArgs e)

        {
            try
            {
                // Проверка, что строка не пустая.
                if (categoryNameTb.Text == "")
                    throw new RequiredFieldsAreEmptyException(categoryNameTb, "Category name");

                // Проверка, что строка не содержит специальный символ.
                if (categoryNameTb.Text.Contains('>'))
                    throw new ExtraCharacterInTheFieldException(categoryNameTb, '>');

                if (categoryNameTb.Text.Contains(':'))
                    throw new ExtraCharacterInTheFieldException(categoryNameTb, ':');

                ReadyToClose = true;
                CategoryNameEntered?.Invoke(this, categoryNameTb.Text);
                this.Close();
            }
            catch (FieldException ex)
            {
                errorProvider.SetError(ex.Control, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ReadyToClose { get; set; }

        /// <summary>
        /// Событие закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ReadyToClose)
            {
                e.Cancel = true;
                errorProvider.SetError(categoryNameTb, "Category with this name alredy exists.");
            }
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNodeForm_Load(object sender, EventArgs e)
        {
            ReadyToClose = true;
            errorProvider.Clear();
        }

        /// <summary>
        /// Нажатие на кнопку Cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ReadyToClose = true;
        }

        /// <summary>
        /// Настройка формы, как формы для изменения имени ветки.
        /// </summary>
        public void SetAsChangeNodeNameForm()
        {
            this.Text = "Change Node Name";
            categoryNameGb.Text = "New name:";
            addButton.Text = "Change";
        }
    }
}
