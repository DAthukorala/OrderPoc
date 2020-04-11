using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Interfaces
{
    public interface ICheckoutService
    {
        bool Checkout(Order order);
    }
}
