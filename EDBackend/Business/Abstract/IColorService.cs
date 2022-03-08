using System.Collections.Generic;
using Business.Utilities;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
        List<Color> GetAll();
        Color Get(int id);
    }
}