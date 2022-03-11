using DataAccess.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class ColorValidation:AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(x=>x.ColorName).NotEmpty().WithMessage("Renk ismi boş olamaz");
        }
    }
}