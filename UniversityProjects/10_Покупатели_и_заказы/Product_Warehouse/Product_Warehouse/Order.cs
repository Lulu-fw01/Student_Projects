using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс, описывающий заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Товары в заказе.
        /// </summary>
        Dictionary<string, CartItem> items;
        /// <summary>
        /// Идентификационный номер заказа.
        /// </summary>
        public string Id{ get; }
        
        public DateTime DateOfIssue { get; }

        public string CustomerLogin { get; }

        OrderStatus status;
        public OrderStatus Status { get => status; }
        public Order(string id, Dictionary<string, CartItem> items, string login)
        {
            Id = id;
            this.items = items;
            CustomerLogin = login;
            status = OrderStatus.Created;
            DateOfIssue = DateTime.Now;
        }

        /// <summary>
        /// Поставить отметку, что заказ обработан.
        /// </summary>
        public void ProcessOrder() => status = status | OrderStatus.Processed;

        /// <summary>
        /// Поставить отметку, что заказ оплачен.
        /// </summary>
        public void PayforTheOrder() => status = status | OrderStatus.Paid;

        /// <summary>
        /// Поставить отметку, что заказ отправлен.
        /// </summary>
        public void SendOrder() => status = status | OrderStatus.Sent;

        /// <summary>
        /// Поставить отметку, что заказ доставлен.
        /// </summary>
        public void ReceiveOrder() => status = status | OrderStatus.Received;

    }

    /// <summary>
    /// Перечисление для описания статуса заказа.
    /// </summary>
    [Flags]
    public enum OrderStatus {
        Created = 0b_0000_0000, 
        Processed = 0b_0000_0001,
        Paid = 0b_0000_0010, 
        Sent = 0b_0000_0100, 
        Received = 0b_0000_1000
    }

}
