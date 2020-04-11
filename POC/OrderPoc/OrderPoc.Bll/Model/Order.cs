using System.Collections.Generic;

namespace OrderPoc.Bll.Model
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public Customer Customer { get; set; }
    }
}
