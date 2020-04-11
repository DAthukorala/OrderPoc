using OrderPoc.Bll.Model;
using System.Collections.Generic;

namespace OrderPoc.Dal.Interfaces
{
    public interface IProductsRepository
    {
        bool Save(Product item);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
    }
}
