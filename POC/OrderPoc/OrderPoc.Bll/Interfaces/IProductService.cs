namespace OrderPoc.Bll.Interfaces
{
    public interface IProductService
    {
        bool CheckInventory(string productId, int quantity);
    }
}
