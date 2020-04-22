using OrderPoc.Bll.Interfaces;
using OrderPoc.Bll.Model;
using System.Linq;

namespace OrderPoc.Bll.Implementations
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IProductService _productService;
        private readonly ICardService _cardService;
        private readonly IGatewayService _gatewayService;
        private readonly IOrderService _orderService;
        private readonly EmailService _emailService;

        public CheckoutService(IProductService productService, ICardService cardService, IGatewayService gatewayService, IOrderService orderService, EmailService emailService)
        {
            _productService = productService;
            _cardService = cardService;
            _gatewayService = gatewayService;
            _orderService = orderService;
            _emailService = emailService;
        }

        public bool Checkout(Order order)
        {
            var unavailableItems = order.Items.Where(x => !_productService.CheckInventory(x.Product.Id, x.Quantity));
            if (unavailableItems.Count() != 0) return false;
            var cardNumber = order.Customer.CreditCardNumber;
            var isValidCreditCard = _cardService.ValidateNumber(cardNumber);
            if (!isValidCreditCard) return false;
            var cost = _orderService.GetTotalCost(order);
            var isCharged = _gatewayService.ChargePayment(cardNumber, cost);
            if (!isCharged) return false;
            var isEmailSent = _emailService.SendInformation(order);
            return isEmailSent;
        }
    }
}
