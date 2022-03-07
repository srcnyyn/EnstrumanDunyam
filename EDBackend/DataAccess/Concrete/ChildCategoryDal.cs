using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class ChildCategoryDal:EntityRepositoryDal<ChildCategory,EdDBContext>,IChildCategoryDal{}
}