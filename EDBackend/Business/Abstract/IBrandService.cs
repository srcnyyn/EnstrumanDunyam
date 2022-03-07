using System.Collections.Generic;
using Business.Repositories;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        Brand Get(int id);
        List<Brand> GetAll();
    }
}