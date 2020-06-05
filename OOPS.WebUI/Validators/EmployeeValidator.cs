using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Validators;
using OOPS.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeModel>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Employee.Name).NotNull().WithMessage("İsim Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Employee.Surname).NotNull().WithMessage("Soyisim Alanı Boş Olamaz").MinimumLength(3).MaximumLength(50);
      
        }
    }
}
