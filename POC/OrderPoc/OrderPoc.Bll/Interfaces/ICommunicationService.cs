using OrderPoc.Bll.Model;

namespace OrderPoc.Bll.Interfaces
{
    public interface ICommunicationService
    {
        bool SendInformation(Order information);
    }
}
