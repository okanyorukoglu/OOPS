using FluentValidation;
using FluentValidation.Validators;
using OOPS.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OOPS.WebUI.Validators
{
    public class UserLoginValidator : AbstractValidator<UserLoginViewModel>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible).NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
        }
    }
}
