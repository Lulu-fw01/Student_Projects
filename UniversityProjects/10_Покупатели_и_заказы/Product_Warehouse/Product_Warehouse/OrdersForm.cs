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
    public partial class OrdersForm : Form
    {
        public OrdersForm(List<Order> orders)
        {
            InitializeComponent();

            foreach(var e in orders )
            {
                Button btn = new Button();
                if (e.Status.HasFlag(OrderStatus.Processed) && !e.Status.HasFlag(OrderStatus.Paid))
                    btn.Enabled = true;
                else
                    btn.Enabled = false;
                btn.Click += (object sender, EventArgs ev) => PayForOrder(e);
                ordersDataGv.Rows.Add(new object[] { e.Id, e.DateOfIssue, e.Status, btn });
            }
        }

        private void PayForOrder(Order order)
        {
            order.PayforTheOrder();
            MessageBox.Show("your order was paid");
        }
    }
}
