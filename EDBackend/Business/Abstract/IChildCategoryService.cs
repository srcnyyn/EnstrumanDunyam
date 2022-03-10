using System.Collections.Generic;
using Business.Utilities;
using Business.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IChildCategoryService:IServiceRepository<ChildCategory>
    {
        DataResult<ChildCategory> Get(int id);
        DataResult<List<ChildCategory>> GetAll();
    } 

}