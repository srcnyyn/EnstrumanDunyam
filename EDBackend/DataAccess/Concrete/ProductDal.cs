using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepositoryDal<Product, EdDBContext>, IProductDal
    {
        
    }
}