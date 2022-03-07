using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepositoryDal<Product, EdDBContext>, IProductDal
    {
        
    }
}