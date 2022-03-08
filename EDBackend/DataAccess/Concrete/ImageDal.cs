using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class ImageDal : EntityRepositoryDal<Image, EdDBContext>, IImageDal { }
}