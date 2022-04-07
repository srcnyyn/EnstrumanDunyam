using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ImageManager:IImageService
    {
        IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal=imageDal;  
        }

        public async Task<Result> DeleteAsync(Image image)
        {
            FileHelper.Delete("wwwroot/"+image.ImagePath);
            await _imageDal.DeleteAsync(image);
            return new SuccessResult();
            
        }

        public async Task<DataResult<Image>> GetAsync(int id)
        {
            return new SuccessDataResult<Image>(await _imageDal.GetAsync(i=>i.Id == id));
        }

        public async Task<DataResult<List<Image>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Image>>(await _imageDal.GetAllAsync());
        }

        public async Task<DataResult<List<Image>>> GetByProductIdAsync(int productId)
        {
            return new SuccessDataResult<List<Image>>(await _imageDal.GetAllAsync(i=>i.ProductId==productId));
        }

        public async Task<Result> UpdateAsync(IFormFile file, Image image)
        {
            FileHelper.Update(file , "wwwroot/" +image.ImagePath,"wwwroot/");
            await _imageDal.UpdateAsync(image);
            return new SuccessResult();
        }

        public async Task<Result> UploadAsync(IFormFile file, Image image)
        {
           image.ImagePath = FileHelper.Upload(file,"wwwroot/");
            await _imageDal.AddAsync(image);
           return new SuccessResult();
        }
    }
}
