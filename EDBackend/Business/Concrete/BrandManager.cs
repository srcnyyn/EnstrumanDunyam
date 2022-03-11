using System.Collections.Generic;
using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;

namespace Business.Concrete
{
    
    
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Result Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x=>x.Id==id));
        }

        public DataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public Result Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult();
        }

    }
}