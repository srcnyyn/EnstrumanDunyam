using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryDal _categoryDal;
        IChildCategoryDal _childCategoryDal;

        public ProductManager(IProductDal productDal, ICategoryDal categoryDal, IChildCategoryDal childCategoryDal)
        {
            _productDal = productDal;
            _categoryDal = categoryDal;
            _childCategoryDal = childCategoryDal;
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByBrandId(int id)
        {
            return _productDal.GetAll(x => x.BrandId == id);
        }

        public List<Product> GetByCategoryId(int id)
        {
            var category = _categoryDal.Get(x => x.CategoryId == id);
            var chCat = _childCategoryDal.GetAll(x => x.CategoryId == category.CategoryId);
           
            
        }

        public List<Product> GetByChildCategoryId(int id)
        {
            return _productDal.GetAll(x => x.ChildCategoryId == id);
        }

        public List<Product> GetByColorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetByProductId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}