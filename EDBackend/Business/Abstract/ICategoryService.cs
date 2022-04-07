using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService:IServiceRepository<Category>
    {
       
        Task<DataResult<Category>> GetAsync(int id);
    }    
}