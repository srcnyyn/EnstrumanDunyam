using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        Task<DataResult<Brand>> GetAsync(int id);
       
        
    }
}