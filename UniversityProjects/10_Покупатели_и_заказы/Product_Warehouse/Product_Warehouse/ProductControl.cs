using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Product_Warehouse
{
    /// <summary>
    /// Контроллер для отображения продукта.
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public ProductControl(string sku, string name)
        {
            InitializeComponent();
            skuLabel.Text = sku;
            nameLabel.Text = name;
            _RemoveThisControl = new RemoveThisControlEventHandler((ProductControl) => { });
        }


        public delegate void RemoveThisControlEventHandler(ProductControl pc);
        private event RemoveThisControlEventHandler _RemoveThisControl;

        /// <summary>
        /// Событие, показывающее, что была нажата кнопка удаления.
        /// </summary>
        public event RemoveThisControlEventHandler RemoveThisControl
        {
            remove
            {
                var il = _RemoveThisControl.GetInvocationList();
                if (il.Contains(value))
                    _RemoveThisControl -= value;
            }

            add
            {
                var il = _RemoveThisControl.GetInvocationList();
                if (!il.Contains(value))
                    _RemoveThisControl += value;
            }
        }
        /// <summary>
        /// Нажатие на кнопку удаления данного продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e) => _RemoveThisControl?.Invoke(this);

        /// <summary>
        /// Событие показывающее, что была нажата кнопка редактирования.
        /// </summary>
        public Action EditButtonClicked;

        /// <summary>
        /// Нажатие на кнопку редактирования объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e) => EditButtonClicked?.Invoke();


        /// <summary>
        /// Метод установки цены.
        /// </summary>
        /// <param name="price">
        /// Цена.
        /// </param>
        public void SetPrice(decimal price)
        {
            priceLabel.Text = price.ToString();
            ChangesUnsaved?.Invoke();
        }

        /// <summary>
        /// Метод установки количества .
        /// </summary>
        /// <param name="num">
        /// Количество.
        /// </param>
        public void SetNumInStock(int num)
        {
            numLabel.Text = num.ToString();
            ChangesUnsaved?.Invoke();
        }

        /// <summary>
        /// Метод установки описания продукта.
        /// </summary>
        /// <param name="description">
        /// Строка описания.
        /// </param>
        public void SetDescription(string description)
        {
            descriptionRtb.Text = description;
            ChangesUnsaved?.Invoke();

        }

        /// <summary>
        /// Метод установки изображения продукта.
        /// </summary>
        /// <param name="image">
        /// Изображение.
        /// </param>
        public void SetImage(Image image) 
        { 
            pictureBox.Image = image;
            ChangesUnsaved?.Invoke();
        } 

        /// <summary>
        /// Событие, сигнализирующее, что изменения не были сохранены.
        /// </summary>
        public Action ChangesUnsaved;

        /// <summary>
        /// Нажатие на кнопку добавить в корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToCartBtn_Click(object sender, EventArgs e) => AddItemToCart?.Invoke((int)(toCartNud.Value));

        public Action<int> AddItemToCart;

        /// <summary>
        /// Событие, показывающее, что надо добавить данный продукт в крзину.
        /// </summary>
       /* public delegate void AddThisProductToCartEventHandler(ProductControl pc);
        private event AddThisProductToCartEventHandler _AddThisProductToCart;

        /// <summary>
        /// Событие, показывающее, что была нажата кнопка добавления в корзину.
        /// </summary>
        public event RemoveThisControlEventHandler AddThisProductToCart
        {
            remove
            {
                var il = _AddThisProductToCart.GetInvocationList();
                if (il.Contains(value))
                    _AddThisProductToCart -= value;
            }

            add
            {
                var il = _AddThisProductToCart.GetInvocationList();
                if (!il.Contains(value))
                    _AddThisProductToCart += value;
            }
        }*/

        /// <summary>
        /// Настройка контроллера под режим посетителя.
        /// </summary>
        public void SetVisitorMode()
        {
            addToCartBtn.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;
            toCartNud.Visible = false;
        }

        /// <summary>
        /// Настройка контроллера под режим покупателя.
        /// </summary>
        public void SetCustomerMode()
        {
            addToCartBtn.Visible = true;
            editButton.Visible = false;
            deleteButton.Visible = false;
            if (int.Parse(numLabel.Text) != 0)
            {
                toCartNud.Visible = true;
                toCartNud.Minimum = 1;
                toCartNud.Maximum = int.Parse(numLabel.Text);
                toCartNud.Value = 1;
            }
            else
            {
                toCartNud.Visible = false;
                addToCartBtn.Visible = false;
            }
        }

        /// <summary>
        /// Настройка контроллера под режим продавца.
        /// </summary>
        public void SetSellerMode()
        {
            addToCartBtn.Visible = false;
            editButton.Visible = true;
            deleteButton.Visible = true;
            toCartNud.Visible = false;
        }


    }
}
