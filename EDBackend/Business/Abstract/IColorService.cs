using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
        
        Task<DataResult<Color>> GetAsync(int id);
    }
}