using DataAccess.Entities.Concrete;
using FluentValidation;
namespace Business.ValidationRules

{
    public class ProductValidation:AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün adı boş olamaz");
            RuleFor(x=>x.ProductName).MinimumLength(5).WithMessage("5 Karakterden büyük olmalı");

            RuleFor(x=>x.Quantity).GreaterThan(0).WithMessage("Ürün miktarı sıfırdan farklı olmalı");

            RuleFor(x=>x.UnitPrice).GreaterThan(0).WithMessage("Ürün fiyatı sıfırdan fazla olmalı");
        }
    }
}