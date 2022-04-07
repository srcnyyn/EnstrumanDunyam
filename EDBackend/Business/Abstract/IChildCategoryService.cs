using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface IChildCategoryService:IServiceRepository<ChildCategory>
    {
        Task<DataResult<ChildCategory>> GetAsync(int id);
        Task<DataResult<List<ChildCategory>>> GetByCategoryIdAsync(int categoryId);
        
    } 

}