using Entity.Concrete;
using FluentValidation;
namespace Business.ValidationRules

{
    public class ProductValidation:AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün adı boş olamaz");
            RuleFor(x=>x.ProductName).MinimumLength(5).WithMessage("5 Kelimeden büyük olmalı");
           


        }
           
          
    }
}