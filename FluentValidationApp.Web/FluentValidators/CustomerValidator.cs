using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(c=>c.Age).InclusiveBetween(18,60).WithMessage("Age must be between 18 and 60");
            RuleFor(c=>c.Email).EmailAddress().WithMessage("Email is not valid");
            RuleForEach(c=>c.Addresses).SetValidator(new AddressValidator());
        }
    }
}
