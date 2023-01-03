using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle)
                .NotEmpty()
                .WithMessage("Başlık alanı boş geçilemez.")
                .MaximumLength(150)
                .WithMessage("Başlık alanı en fazla 150 karakter olmalıdır.")
            .MinimumLength(3)
                .WithMessage("Başlık alanı en az 3 karakter olmalıdır.");
            RuleFor(x => x.BlogContent)
                .NotEmpty()
                .WithMessage("İçerik alanı boş geçilemez.");
            RuleFor(x => x.BlogImage)
                .NotEmpty()
                .WithMessage("Blog görsel alanı boş geçilemez.");

        }
    }
}
