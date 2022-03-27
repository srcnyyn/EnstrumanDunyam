using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Castle.DynamicProxy;




namespace Business.Utilities.DependencyResolver.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<ProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>();
            
            builder.RegisterType<ChildCategoryManager>().As<IChildCategoryService>();
            builder.RegisterType<ChildCategoryDal>().As<IChildCategoryDal>();
            
            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<ColorDal>().As<IColorDal>();
            
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<BrandDal>().As<IBrandDal>();
            
            builder.RegisterType<ImageManager>().As<IImageService>();
            builder.RegisterType<ImageDal>().As<IImageDal>();
            
            
        }
    }
}