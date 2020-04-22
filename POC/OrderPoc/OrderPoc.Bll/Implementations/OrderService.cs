using System.Linq;
using OrderPoc.Bll.Interfaces;
using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Implementations
{
    public class OrderService : IOrderService
    {
        public decimal GetTotalCost(Order order)
        {
            return order.Items.Sum(item => item.Product.Price * item.Quantity);
        }
    }
}
