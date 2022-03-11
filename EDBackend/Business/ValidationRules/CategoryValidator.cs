using DataAccess.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
             RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş olamaz");
        }
    }
}