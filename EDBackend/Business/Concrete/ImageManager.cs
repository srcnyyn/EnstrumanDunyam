using System;
using System.Collections.Generic;
using System.IO;
using Business.Abstract;
using Business.Utilities;
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

        public void Delete(Image image)
        {
            FileHelper.Delete("wwwroot/"+image.ImagePath);
            _imageDal.Delete(image);
            
        }

        public Image Get(int id)
        {
            return _imageDal.Get(i=>i.ImageId == id);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public List<Image> GetByProductId(int productId)
        {
            return _imageDal.GetAll(i=>i.ProductId==productId);
        }

        public void Update(IFormFile file, Image image)
        {
            FileHelper.Update(file , "wwwroot/" +image.ImagePath,"wwwroot/");
            _imageDal.Update(image);
        }

        public void Upload(IFormFile file, Image image)
        {
           image.ImagePath = FileHelper.Upload(file,"wwwroot/");
           _imageDal.Add(image);
            
            
        }
    }
}
