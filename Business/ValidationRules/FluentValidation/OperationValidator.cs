using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OperationValidator:AbstractValidator<Operation>
    {
        public OperationValidator()
        {
            RuleFor(o => o.ExpirationDate).GreaterThanOrEqualTo(o => o.EntryDate);
            RuleFor(o => o.Price).GreaterThanOrEqualTo(2);
        }
    }
}
