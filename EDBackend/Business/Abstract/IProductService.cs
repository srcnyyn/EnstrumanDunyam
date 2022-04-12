using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.Dtos;

namespace Business.Abstract
{
    public interface IProductService : IServiceRepository<Product>
    {
        Task<DataResult<Product>> GetByProductIdAsync(int id);
                
        Task<DataResult<List<Product>>> GetByCategoryIdAsync(int id);
        Task<DataResult<List<Product>>> GetByChildCategoryIdAsync(int id);
        Task<DataResult<List<Product>>> GetByColorIdAsync(int id);
        Task<DataResult<List<Product>>> GetByBrandIdAsync(int id);

        Task<DataResult<List<ProductDto>>> GetProductDtoAsync();
        Task<DataResult<List<ProductDto>>> GetProductDtoByIdAsync(int id);

      
    }
}