using FluentValidation;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Service.Validators
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });

            RuleFor(c => c.name)
                 .NotEmpty().WithMessage("Is necessary to inform the name.");
                 
        }
    }
}
