using OrderPoc.Bll.Interfaces;
using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Implementations
{
    public class OrderService : IOrderService
    {
        public decimal GetTotalCost(Order order)
        {
            decimal cost = 0;
            foreach (var item in order.Items)
            {
                cost += item.Product.Price * item.Quantity;
            }
            return cost;
        }
    }
}
