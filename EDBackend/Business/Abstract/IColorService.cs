using System.Collections.Generic;
using Business.Utilities;
using Business.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
        DataResult<List<Color>> GetAll();
        DataResult<Color> Get(int id);
    }
}