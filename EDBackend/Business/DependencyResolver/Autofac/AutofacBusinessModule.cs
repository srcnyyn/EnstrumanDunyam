using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Business.Utilities.Interceptors;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete;




namespace Business.DependencyResolver.Autofac
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
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
            
        }
    }
}