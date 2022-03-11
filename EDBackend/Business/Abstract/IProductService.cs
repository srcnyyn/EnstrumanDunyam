using System.Collections.Generic;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService : IServiceRepository<Product>
    {
        DataResult<Product> GetByProductId(int id);
                
        DataResult<List<Product>> GetByCategoryId(int id);
        DataResult<List<Product>> GetByChildCategoryId(int id);
        DataResult<List<Product>> GetByColorId(int id);
        DataResult<List<Product>> GetByBrandId(int id);

        DataResult<List<Product>> GetAll();
    }
}