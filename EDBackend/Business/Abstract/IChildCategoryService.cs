using System.Collections.Generic;
using Business.Utilities;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IChildCategoryService:IServiceRepository<ChildCategory>
    {
        ChildCategory Get(int id);
        List<ChildCategory> GetAll();
    } 

}