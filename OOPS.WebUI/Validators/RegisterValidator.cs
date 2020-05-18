using FluentValidation;
using FluentValidation.AspNetCore;
using OOPS.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("İsim Alanı Boş Olamaz");
            RuleFor(x => x.Surname).NotNull();
            RuleFor(x => x.PhoneBusiness).NotNull();
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.CompanyName).NotNull();
            RuleFor(x => x.Username).NotNull();
            RuleFor(x => x.Password).NotNull();
        }
    }
}
