using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.Dtos;
using DataAccess.Repositories;
using System.Linq;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepositoryDal<Product, EdDBContext>, IProductDal
    {
        public List<ProductDto> GetProductDetails()
        {
            using (EdDBContext context=new EdDBContext())
            {
                var result = from p in context.Products 
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             join i in context.Images
                             on p.Id equals i.ProductId
                             join ch in context.ChildCategories
                             on p.ChildCategoryId equals ch.Id
                             select new ProductDto{
                                 ProductDtoId = p.Id,
                                 ProductName=p.ProductName,
                                 BrandName=b.BrandName,
                                 ColorName=c.ColorName,
                                 ChildCategory=ch.ChildCategoryName,
                                 ImagePath=i.ImagePath,
                                 UnitPrice=p.UnitPrice,
                                 Quantity=p.Quantity

                                };
                                return result.ToList();
            }
        }
    }
}