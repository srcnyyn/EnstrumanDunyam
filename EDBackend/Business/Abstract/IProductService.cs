using System.Collections.Generic;
using Business.Utilities;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IProductService : IServiceRepository<Product>
    {
        Product GetByProductId(int id);
        
        List<Product> GetByCategoryId(int id);
        List<Product> GetByChildCategoryId(int id);
        List<Product> GetByColorId(int id);
        List<Product> GetByBrandId(int id);

        List<Product> GetAll();
    }
}