using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserOperationClaimValidator : AbstractValidator<UserOperationClaim> 
    {
        public UserOperationClaimValidator()
        {
            RuleFor(uoc => uoc.UserId).NotEmpty();
            RuleFor(uoc => uoc.OperationClaimId).NotEmpty();
         }
    }
    
}
