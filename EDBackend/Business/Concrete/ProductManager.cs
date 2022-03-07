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
            return productList;

        }

        public List<Product> GetByChildCategoryId(int id)
        {
            return _productDal.GetAll(x => x.ChildCategoryId == id);
        }

        public List<Product> GetByColorId(int id)
        {
            return _productDal.GetAll(x=>x.ColorId == id);
        }

        public Product GetByProductId(int id)
        {
            return _productDal.Get(x=>x.ProductId==id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}