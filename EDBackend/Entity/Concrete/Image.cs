using System;

namespace Entity.Concrete
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date{ get; set; }=DateTime.Now;
        public string ImagePath { get; set; }
    }
}