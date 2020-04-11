using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Interfaces
{
    public interface IOrderService
    {
        decimal GetTotalCost(Order order);
    }
}
