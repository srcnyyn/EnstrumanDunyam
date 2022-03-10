using System;
using System.Collections.Generic;
using System.IO;
using Business.Abstract;
using Business.Utilities;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
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

        public Result Delete(Image image)
        {
            FileHelper.Delete("wwwroot/"+image.ImagePath);
            _imageDal.Delete(image);
            return new SuccessResult();
            
        }

        public DataResult<Image> Get(int id)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i=>i.ImageId == id));
        }

        public DataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public DataResult<List<Image>> GetByProductId(int productId)
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(i=>i.ProductId==productId));
        }

        public Result Update(IFormFile file, Image image)
        {
            FileHelper.Update(file , "wwwroot/" +image.ImagePath,"wwwroot/");
            _imageDal.Update(image);
            return new SuccessResult();
        }

        public Result Upload(IFormFile file, Image image)
        {
           image.ImagePath = FileHelper.Upload(file,"wwwroot/");
           _imageDal.Add(image);
           return new SuccessResult();
        }
    }
}
