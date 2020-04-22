using OrderPoc.Bll.Interfaces;
using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Implementations
{
    public abstract class EmailService : ICommunicationService
    {
        private readonly MessageService _messageService;

        protected EmailService(MessageService messageService)
        {
            _messageService = messageService;
        }
        public bool SendInformation(Order information)
        {
            var message = _messageService.PrepareMessage(information);
            var emailSent = true; //add email sending logic here
            return emailSent;
        }
    }
}
