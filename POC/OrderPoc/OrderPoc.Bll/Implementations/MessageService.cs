using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Implementations
{
    public class MessageService
    {
        public (string title, string message) PrepareMessage(Order order)
        {
            var title = $"Shipping details for {order.Customer.Name}";
            var message = $"We have shipped {order.Items.Count} items to {order.Customer.Address}";
            return (title, message);
        }
    }
}
