using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Warehouse
{
    public partial class CartForm : Form
    {
        Dictionary<string, CartItem> items;

        public CartForm()
        {
            InitializeComponent();
            items = new Dictionary<string, CartItem>();

        }

        /// <summary>
        /// Добавление товара в корзину.
        /// </summary>
        /// <param name="newItem"></param>
        public void AddItemToCart(CartItem newItem)
        {
            try
            {
                items.Add(newItem.SKU, newItem);
                var btn = new Button();
                btn.BackColor = Color.Red;
                btn.Text = "Remove";
                btn.Click += (object sender, EventArgs e) => RemoveItemFromCart(newItem.SKU);
                itemsDataGV.Rows.Add(new object[] { newItem.SKU, newItem.Name, newItem.Num, newItem.Price, newItem.Price * newItem.Num, btn });
            }
            catch { }
        }

        /// <summary>
        /// Удаление товара из корзины.
        /// </summary>
        /// <param name="sku"></param>
        private void RemoveItemFromCart(string sku)
        {
            try
            {
                foreach (DataGridViewRow e in itemsDataGV.Rows)
                {
                    if (e.Cells[0].Value.ToString() == sku)
                    {
                        itemsDataGV.Rows.Remove(e);
                    }
                }

                ItemRemovedFromCart?.Invoke(sku, items[sku].Num);
                items.Remove(sku);
            }
            catch { }
        }

        public Action<string, int> ItemRemovedFromCart;

        /// <summary>
        /// Нажатие на кнопку создания заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            AddNewOrder?.Invoke(items);
        }
        

        public Action<Dictionary<string, CartItem> > AddNewOrder;
    }

    
}
