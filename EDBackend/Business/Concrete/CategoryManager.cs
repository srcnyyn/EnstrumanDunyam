using System.Collections.Generic;
using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;

namespace Business.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Result Add(Category entity)
        {
            _categoryDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Category entity)
        {
            _categoryDal.Delete(entity);
             return new SuccessResult();
        }

        public DataResult<Category> Get(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x=>x.Id==id));
        }

        public DataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public Result Update(Category entity)
        {
            _categoryDal.Update(entity);
             return new SuccessResult();
        }
    }
}