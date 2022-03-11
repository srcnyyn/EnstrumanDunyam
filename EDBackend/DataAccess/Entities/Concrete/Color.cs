using System.Collections.Generic;
using DataAccess.Entities.BaseEntities;

namespace DataAccess.Entities.Concrete
{
    public class Color:BaseEntity
    {
        public string ColorName { get; set; }
    }
}