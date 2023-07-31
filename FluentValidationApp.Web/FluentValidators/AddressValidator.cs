using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a=>a.Content).NotEmpty().WithMessage("Adres içeriği boş olamaz");
            RuleFor(a=>a.Content).MinimumLength(10).WithMessage("Adres içeriği en az 10 karakter olmalıdır");
            RuleFor(a=>a.PostCode).NotEmpty().WithMessage("Posta kodu boş olamaz");
            RuleFor(a=>a.PostCode).Length(5).WithMessage("Posta kodu 5 karakter olmalıdır");
            RuleFor(a=>a.Provice).NotEmpty().WithMessage("Şehir boş olamaz");
        }
    }
}
