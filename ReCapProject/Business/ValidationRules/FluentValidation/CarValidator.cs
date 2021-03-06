using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description_).NotEmpty();
            RuleFor(c => c.Description_).MinimumLength(2);
           RuleFor(c => c.ModelYear).NotEmpty();
         RuleFor(c => c.ModelYear).GreaterThan(1900);


        }
    }
}
