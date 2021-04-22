using System;
using System.Drawing;
using System.Windows.Forms;


namespace Product_Warehouse
{
    delegate void SetItemImageDelegate(Item newItem);
    
    /// <summary>
    /// Форма для создания нового продукта.
    /// </summary>
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();   
        }
        
        /// <summary>
        /// Флаг для  отметки можно ли закрыть форму.
        /// </summary>
        public bool CanClose { get; set; }

        /// <summary>
        /// Событие создания нового товара.
        /// </summary>
        public Action<Item> NewItemCreated;

        SetItemImageDelegate setItemImage;

        /// <summary>
        /// Нажатие на кнопку добавления изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openImageDialog.ShowDialog() == DialogResult.Cancel) return;
                var filePath = openImageDialog.FileName;
                var bm = new Bitmap(filePath);
                imagePicBox.Image = Image.FromFile(filePath);
                setItemImage = SetItemImage;   
            }
            catch { }
        }

        /// <summary>
        /// Нажатие на кнопку добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка, что артикул и название непустые.
                if (skuTextBox.Text == "")
                    throw new RequiredFieldsAreEmptyException(skuTextBox, "SKU");
                if (nameTextBox.Text == "")
                    throw new RequiredFieldsAreEmptyException(nameTextBox,"Name");

                // Создание ноого товара.
                var newItem = new Item(skuTextBox.Text, nameTextBox.Text);
                // Настройка дополнительной информации товара.
                SetItemInfo(newItem);
                // Установка изображения товара.
                setItemImage.Invoke(newItem);

                CanClose = true;
                // Событие создания нового товара.
                NewItemCreated?.Invoke(newItem);


                this.Close();
            }
            catch (RequiredFieldsAreEmptyException ex)
            {
                errorProvider1.SetError(ex.Control, ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Нажатие на кнопку отмены.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CanClose = true;
        }

        /// <summary>
        /// Сброс параметров при загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewItemForm_Load(object sender, EventArgs e)
        {
            CanClose = true;
            descriptionTextBox.Text = "";
            numNumericUpDown.Value = 0;
            priceNumericUpDown.Value = 0;
            nameTextBox.Text = "";
            skuTextBox.Text = "";
            try
            {
                imagePicBox.Image = Properties.Resources.no_image_icon_6;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            setItemImage = delegate { };
        }

        /// <summary>
        /// Метод для настройки доп. параметров нового товара
        /// </summary>
        /// <param name="newItem">
        /// Новый товар.
        /// </param>
        private void SetItemInfo(Item newItem)
        {
            newItem.Description = descriptionTextBox.Text;
            newItem.Price = priceNumericUpDown.Value;
            newItem.NumInStock = (int)numNumericUpDown.Value;
        }

        /// <summary>
        /// Метод для установки изображения товара.
        /// </summary>
        /// <param name="newItem"></param>
        private void SetItemImage(Item newItem)
        {
            newItem.Image = imagePicBox.Image;
        }

        private void NewItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose)
            {
                e.Cancel = true;
                errorProvider2.SetError(skuTextBox, "Item with current id is already exists");
            }
        }

      
    }
}
