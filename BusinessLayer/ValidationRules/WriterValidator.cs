using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty()
                .WithMessage("Ad - soyad alanı boş geçilemez.")
                .MinimumLength(2)
                .WithMessage("Ad - soyad alanı en az 2 karakter olmalıdır!")
                .MaximumLength(50)
                .WithMessage("Ad - soyad alanı 50 karakterden fazla olmamalıdır!");
            RuleFor(x => x.WriterEmail)
                .NotEmpty()
                .WithMessage("Email alanı boş geçilemez.")
                .EmailAddress()
                .WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(x => x.WriterPassword)
                .NotEmpty()
                .WithMessage("Parola alanı boş geçilemez.");
        }
    }
}
