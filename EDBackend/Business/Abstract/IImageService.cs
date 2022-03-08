using System.Collections.Generic;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImageService
    {
        void Upload(IFormFile file, Image image);
        void Update(IFormFile file, Image image);
        void Delete(Image image);
        List<Image> GetAll();
        Image Get(int id);
        List<Image> GetByProductId(int productId);
    }
}