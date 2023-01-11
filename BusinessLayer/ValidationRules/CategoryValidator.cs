using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("Kategori adı alanı boş geçilemez.")
                .MaximumLength(50)
                .WithMessage("Kategori adı en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.CategoryDescription)
                .NotEmpty()
                .WithMessage("Açıklama alanı boş geçilemez.");


        }
    }
}
