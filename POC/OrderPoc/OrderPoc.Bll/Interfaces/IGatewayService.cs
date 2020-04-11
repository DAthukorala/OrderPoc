namespace OrderPoc.Bll.Interfaces
{
    public interface IGatewayService
    {
        bool ChargePayment(string cardNumber, decimal amount);
    }
}
