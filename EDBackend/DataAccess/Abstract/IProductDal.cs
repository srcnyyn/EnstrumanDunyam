using DataAccess.Entities.Concrete;
using DataAccess.Repositories;
using System.Collections.Generic;
using DataAccess.Entities.Dtos;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        Task<List<ProductDto>> GetProductDetailsAsync();

    }
}