using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class CategoryDal:EntityRepositoryDal<Category,EdDBContext>,ICategoryDal{}
}