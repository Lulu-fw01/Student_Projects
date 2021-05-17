using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    [Serializable]
    public class CartItem
    {
        readonly string sku;
        /// <summary>
        /// Название продукта.
        /// </summary>
        readonly string name;
        /// <summary>
        /// Цена продукта.
        /// </summary>
        decimal price;
        /// <summary>
        /// Количество товара в наличии.
        /// </summary>
        int num;

        /// <summary>
        /// Артикул.
        /// </summary>
        public string SKU { get => sku; }
        /// <summary>
        /// Название товара.
        /// </summary>
        public string Name { get => name; }
        public decimal Price
        {
            get => price;
            set => price = value;
        }

        /// <summary>
        /// Количество товаров в заказе.
        /// </summary>
        public int Num
        {
            get => num;
            set => num = value;
        }

        public CartItem(string sku, string name, decimal price, int num)
        {
            this.sku = sku;
            this.name = name;
            this.price = price;
            this.num = num;
        }
    }
}
