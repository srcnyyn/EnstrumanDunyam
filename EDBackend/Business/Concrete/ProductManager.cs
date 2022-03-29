using Business.Abstract;
using Business.Utilities.Results;
using Business.ValidationRules;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.Dtos;
using System.Collections.Generic;

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
            ProductValidation validations = new();
             var result = validations.Validate(entity);
             if (!result.IsValid)
             {
                 return new ErrorResult(result.ToString(" ~ "));
             }
            _productDal.Add(entity);
            return new SuccessResult(" Ekleme İşlemi Başarılı");

        }

        public Result Delete(Product entity)
        {

            _productDal.Delete(entity);
            return new SuccessResult();

        }

        public DataResult<List<Product>> GetAll()
        {
            var data = _productDal.GetAll();
            if (data==null)
            {
                return new ErrorDataresult<List<Product>>("data boş");
            }
            return new SuccessDataResult<List<Product>>(data,"data dolu");
        }

        public DataResult<List<Product>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.BrandId == id));
        }

        public DataResult<List<Product>> GetByCategoryId(int id)
        {
            
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x=>x.CategoryId==id));

        }

        public DataResult<List<Product>> GetByChildCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.ChildCategoryId == id));
        }

        public DataResult<List<Product>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.ColorId == id));
        }

        public DataResult<List<ProductDto>> GetProductDto()
        { 
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetProductDetails());
        }

        public DataResult<Product> GetByProductId(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == id));
        }

        public Result Update(Product entity)
        {
            _productDal.Update(entity);
            return new SuccessResult();
        }
    }
}