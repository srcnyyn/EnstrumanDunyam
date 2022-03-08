using System.Collections.Generic;
using Business.Utilities;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService:IServiceRepository<Category>
    {
        List<Category> GetAll();
        Category Get(int id);
    }    
}