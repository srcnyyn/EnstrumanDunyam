

using DataAccess.Entities.BaseEntities;

namespace DataAccess.Entities.Concrete
{
    public class ChildCategory:BaseEntity
    {
        
        public int CategoryId { get; set; }
        public string ChildCategoryName { get; set; }
    }
}