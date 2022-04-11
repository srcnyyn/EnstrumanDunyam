using Business.Abstract;
using Business.Aspects.Autofac.Validation;
using Business.Utilities.CrossCuttingConcerns.Validation;
using Business.Utilities.Results;
using Business.ValidationRules;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        [ValidationAspect(typeof(ProductValidation))]
        public async Task<Result> AddAsync(Product entity)
        { var result = CheckCategoryCount(entity.CategoryId);
            if (result.Success)
            {
                await _productDal.AddAsync(entity);
                return new SuccessResult(" Ekleme İşlemi Başarılı");

            }
            return new ErrorResult(result.Message);


        }

        public async Task<Result> DeleteAsync(Product entity)
        {

            await _productDal.DeleteAsync(entity);
            return new SuccessResult();

        }

        public async Task<DataResult<List<Product>>> GetAllAsync()
        {
            var data = await _productDal.GetAllAsync();
            if (data == null)
            {
                return new ErrorDataresult<List<Product>>("data boş");
            }
            return new SuccessDataResult<List<Product>>(data, "data dolu");
        }

        public async Task<DataResult<List<Product>>> GetByBrandIdAsync(int id)
        {
            return new SuccessDataResult<List<Product>>(await _productDal.GetAllAsync(x => x.BrandId == id));
        }

        public async Task<DataResult<List<Product>>> GetByCategoryIdAsync(int id)
        {

            return new SuccessDataResult<List<Product>>(await _productDal.GetAllAsync(x => x.CategoryId == id));

        }

        public async Task<DataResult<List<Product>>> GetByChildCategoryIdAsync(int id)
        {
            return new SuccessDataResult<List<Product>>(await _productDal.GetAllAsync(x => x.ChildCategoryId == id));
        }

        public async Task<DataResult<List<Product>>> GetByColorIdAsync(int id)
        {
            return new SuccessDataResult<List<Product>>(await _productDal.GetAllAsync(x => x.ColorId == id));
        }

        public async Task<DataResult<List<ProductDto>>> GetProductDtoAsync()
        {
            return new SuccessDataResult<List<ProductDto>>(await _productDal.GetProductDetailsAsync());
        }

        public async Task<DataResult<Product>> GetByProductIdAsync(int id)
        {
            return new SuccessDataResult<Product>(await _productDal.GetAsync(x => x.Id == id));
        }
        public async Task<Result> UpdateAsync(Product entity)
        {
            var result = CheckCategoryCount(entity.CategoryId);
            if (result.Success)
            {
            await _productDal.UpdateAsync(entity);
            return new SuccessResult();
            }
            return new ErrorResult(result.Message);
            
        }

        #region BusinessRules
            private Result CheckCategoryCount(int categoryId)
        {
            var result = _productDal.GetAllAsync(p => p.CategoryId == categoryId);
            if (result.Result.Count >= 10)
                return new ErrorResult("bir kategoride en fazla 10 ürün olabilir");
            return new SuccessResult();
        }
        #endregion
        
    }
}