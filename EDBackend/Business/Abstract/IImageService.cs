using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImageService
    {
        Task<Result> UploadAsync(IFormFile file, Image image);
        Task<Result> UpdateAsync(IFormFile file, Image image);
        Task<Result> DeleteAsync(Image image);
        Task<DataResult<List<Image>>> GetAllAsync();
        Task<DataResult<Image>> GetAsync(int id);
        Task<DataResult<List<Image>>> GetByProductIdAsync(int productId);
    }
}