using System.Collections.Generic;
using Business.Utilities;
using Business.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        DataResult<Brand> Get(int id);
        DataResult<List<Brand>> GetAll();
    }
}