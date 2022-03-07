using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class BrandDal:EntityRepositoryDal<Brand,EdDBContext>,IBrandDal
    {
        
    }
}