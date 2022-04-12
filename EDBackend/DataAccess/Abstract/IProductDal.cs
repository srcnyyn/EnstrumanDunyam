using System;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;
using System.Collections.Generic;
using DataAccess.Entities.Dtos;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        Task<List<ProductDto>> GetProductDetailsAsync(Expression<Func<ProductDto,bool>> filter=null);

    }
}