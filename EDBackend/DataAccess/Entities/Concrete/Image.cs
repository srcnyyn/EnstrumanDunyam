using System;
using DataAccess.Entities.BaseEntities;

namespace DataAccess.Entities.Concrete
{
    public class Image:BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime Date{ get; set; }=DateTime.Now;
        public string ImagePath { get; set; }
    }
}