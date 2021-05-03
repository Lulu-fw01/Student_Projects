using System;
using System.Drawing;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Форма предназначенная для редактирования продуктов.
    /// </summary>
    public partial class EditItemForm : Form
    {
        public EditItemForm()
        {
            InitializeComponent();
        }
        Item currentItem;

        /// <summary>
        /// Событие, показывающее, что продукт был изменен.
        /// </summary>
        public Action ItemWasEdited;

        /// <summary>
        /// Нажатие на кнопку сохранения изменений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Изменение параметров продукта.
            try
            {
                currentItem.Description = descriptionTextBox.Text;
                currentItem.Price = priceNumericUpDown.Value;
                currentItem.NumInStock = (int)numNumericUpDown.Value;
                setItemImage(currentItem);
                ItemWasEdited?.Invoke();
            }
            catch { };
            this.Close();
        }

        /// <summary>
        /// Отображает форму как модальное диалоговое окно.
        /// </summary>
        /// <param name="item">
        /// Продукт, над которым будут проводиться изменения.
        /// </param>
        public void ShowDialog(Item item)
        {
            currentItem = item;
            imagePicBox.Image = currentItem.Image;
            skuTextBox.Text = currentItem.SKU;
            nameTextBox.Text = currentItem.Name;
            priceNumericUpDown.Value = currentItem.Price;
            numNumericUpDown.Value = currentItem.NumInStock;
            descriptionTextBox.Text = currentItem.Description;

            setItemImage = delegate { };
            this.ShowDialog();
        }
        SetItemImageDelegate setItemImage;
        
        /// <summary>
        /// Изменение изображения продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openImageFileDialog.ShowDialog() == DialogResult.Cancel) return;
                var filePath = openImageFileDialog.FileName;
                var bm = new Bitmap(filePath);
                imagePicBox.Image = Image.FromFile(filePath);
                setItemImage = SetItemImage;
            }
            catch { }
        }

        /// <summary>
        /// Метод для установки изображения товара.
        /// </summary>
        /// <param name="item"></param>
        private void SetItemImage(Item item)
        {
            item.Image = imagePicBox.Image;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            setItemImage = delegate { };
        }
    }
}
