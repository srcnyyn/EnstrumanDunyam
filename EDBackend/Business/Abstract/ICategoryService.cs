using System.Collections.Generic;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService:IServiceRepository<Category>
    {
        DataResult<List<Category>> GetAll();
        DataResult<Category> Get(int id);
    }    
}