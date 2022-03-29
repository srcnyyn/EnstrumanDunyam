using System.Collections.Generic;
using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;

namespace Business.Concrete
{
    public class ChildCategoryManager : IChildCategoryService
    {
        IChildCategoryDal _childCategoryDal;

        public ChildCategoryManager(IChildCategoryDal childCategoryDal)
        {
            _childCategoryDal = childCategoryDal;
        }

        public Result Add(ChildCategory entity)
        {
            _childCategoryDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(ChildCategory entity)
        {
            _childCategoryDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<ChildCategory> Get(int id)
        {
            return new SuccessDataResult<ChildCategory>(_childCategoryDal.Get(x=>x.Id == id));
        }

        public DataResult<List<ChildCategory>> GetAll()
        {
            return  new SuccessDataResult<List<ChildCategory>>(_childCategoryDal.GetAll());
        }

        public DataResult<List<ChildCategory>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<ChildCategory>>(_childCategoryDal.GetAll(x=>x.CategoryId==categoryId));
        }

        public Result Update(ChildCategory entity)
        {
            _childCategoryDal.Update(entity);
            return new SuccessResult();
        }
    }
}