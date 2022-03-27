using DataAccess.Entities.Concrete;
using DataAccess.Repositories;
using System.Collections.Generic;
using DataAccess.Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        List<ProductDto> GetProductDetails();

    }
}