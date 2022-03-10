using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal=colorDal;  
        }

        public Result Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x=>x.ColorId==id));
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public Result Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult();
        }
    }
}
