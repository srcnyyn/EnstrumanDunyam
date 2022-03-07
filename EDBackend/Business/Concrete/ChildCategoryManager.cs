using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ChildCategoryManager : IChildCategoryService
    {
        IChildCategoryDal _childCategoryDal;

        public ChildCategoryManager(IChildCategoryDal childCategoryDal)
        {
            _childCategoryDal = childCategoryDal;
        }

        public void Add(ChildCategory entity)
        {
            _childCategoryDal.Add(entity);
        }

        public void Delete(ChildCategory entity)
        {
            _childCategoryDal.Delete(entity);
        }

        public ChildCategory Get(int id)
        {
            return _childCategoryDal.Get(x=>x.ChildCategoryId == id);
        }

        public List<ChildCategory> GetAll()
        {
            return _childCategoryDal.GetAll();
        }

        public void Update(ChildCategory entity)
        {
            _childCategoryDal.Update(entity);
        }
    }
}