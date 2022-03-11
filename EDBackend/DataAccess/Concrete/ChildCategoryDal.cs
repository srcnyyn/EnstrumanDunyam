using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;

namespace DataAccess.Concrete
{
    public class ChildCategoryDal:EntityRepositoryDal<ChildCategory,EdDBContext>,IChildCategoryDal{}
}