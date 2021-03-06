using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.UserId).NotEmpty();
            RuleFor(cu=> cu.CustomerName).NotEmpty();
            RuleFor(cu => cu.CustomerName).MinimumLength(2);




        }
    }
}
