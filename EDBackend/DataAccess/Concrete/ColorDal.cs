using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class ColorDal : EntityRepositoryDal<Color, EdDBContext>, IColorDal { }
}