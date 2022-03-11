using System.Collections.Generic;
using Business.Utilities.Results;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImageService
    {
        Result Upload(IFormFile file, Image image);
        Result Update(IFormFile file, Image image);
        Result Delete(Image image);
        DataResult<List<Image>> GetAll();
        DataResult<Image> Get(int id);
        DataResult<List<Image>> GetByProductId(int productId);
    }
}