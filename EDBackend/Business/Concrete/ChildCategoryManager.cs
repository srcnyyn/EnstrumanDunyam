using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<Result> AddAsync(ChildCategory entity)
        {
            await _childCategoryDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<Result> DeleteAsync(ChildCategory entity)
        {
            await _childCategoryDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<DataResult<ChildCategory>> GetAsync(int id)
        {
            return new SuccessDataResult<ChildCategory>(await _childCategoryDal.GetAsync(x=>x.Id == id));
        }

        public async Task<DataResult<List<ChildCategory>>> GetAllAsync()
        {
            return  new SuccessDataResult<List<ChildCategory>>(await _childCategoryDal.GetAllAsync());
        }

        public async Task<DataResult<List<ChildCategory>>> GetByCategoryIdAsync(int categoryId)
        {
            return new SuccessDataResult<List<ChildCategory>>(await _childCategoryDal.GetAllAsync(x=>x.CategoryId==categoryId));
        }

        public async Task<Result> UpdateAsync(ChildCategory entity)
        {
            await _childCategoryDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}