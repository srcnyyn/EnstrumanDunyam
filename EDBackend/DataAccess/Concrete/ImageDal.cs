using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;

namespace DataAccess.Concrete
{
    public class ImageDal : EntityRepositoryDal<Image, EdDBContext>, IImageDal { }
}