using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Repositories;
namespace DataAccess.Concrete
{
    public class ColorDal : EntityRepositoryDal<Color, EdDBContext>, IColorDal { }
}