using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;

namespace DataAccess.Concrete
{
    public class BrandDal:EntityRepositoryDal<Brand,EdDBContext>,IBrandDal
    {
        
    }
}