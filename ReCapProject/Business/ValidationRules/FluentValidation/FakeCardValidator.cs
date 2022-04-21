using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public    class FakeCardValidator:AbstractValidator<FakeCard>
    {
        public FakeCardValidator()
        {
            RuleFor(fc => fc.CardNo).NotEmpty();
            RuleFor(fc => fc.CardNo).MaximumLength(16);
            RuleFor(fc => fc.CustomerNameSurname).NotEmpty();
            RuleFor(fc => fc.CVC).NotEmpty();
            RuleFor(fc => fc.Expires).NotEmpty();
        }
    }
}
