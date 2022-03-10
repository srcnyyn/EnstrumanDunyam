using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Abstract;
using Entity.Concrete;
using FluentValidation.Results;
using FluentValidation;
using Business.Utilities.Results;

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

        public Result Add(Product entity)
        {
            
                _productDal.Add(entity);
                return new SuccessResult();
        }

        public Result Delete(Product entity)
        {
            _productDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public DataResult<List<Product>> GetByBrandId(int id)
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.BrandId == id));
        }

        public DataResult<List<Product>> GetByCategoryId(int id)
        {
            var category = _categoryDal.Get(x => x.CategoryId == id);
            var chCat = _childCategoryDal.GetAll().Where(x => x.CategoryId == category.CategoryId).ToList();
            List<Product> productList = new List<Product>();
            foreach (var item in chCat)
            {
                List<Product> childListProduct = _productDal.GetAll(x => x.ChildCategoryId == item.ChildCategoryId).ToList();
                foreach (var product in childListProduct)
                {

                    productList.Add(product);
                }

            }
            return new SuccessDataResult<List<Product>>(productList);

        }

        public DataResult<List<Product>> GetByChildCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.ChildCategoryId == id));
        }

        public DataResult<List<Product>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.ColorId == id));
        }

        public DataResult<Product> GetByProductId(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductId == id));
        }

        public Result Update(Product entity)
        {
            _productDal.Update(entity);
            return new SuccessResult();
        }
    }
}