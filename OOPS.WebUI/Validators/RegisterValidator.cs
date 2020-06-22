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
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("İsim Alanı Boş Olamaz").MinimumLength(3);
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad Alanı Boş Olamaz").MinimumLength(3);
            RuleFor(x => x.PhoneBusiness).NotNull().WithMessage("Telefon Alanı Boş Olamaz");
            RuleFor(x => x.Email).NotNull().WithMessage("E-Mail Alanı Boş Olamaz");
            RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("E-Mail Formatı Doğru Değil");
            RuleFor(x => x.Title).NotNull().WithMessage("Ünvan Alanı Boş Olamaz");
            RuleFor(x => x.CompanyName).NotNull().WithMessage("Firma Adı Alanı Boş Olamaz");
            RuleFor(x => x.Username).NotNull().WithMessage("Kullanıcı Adı Alanı Boş Olamaz");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.RePassword).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.RePassword).Matches(x => x.Password).When(x=> !String.IsNullOrEmpty(x.Password)).WithMessage("Şifreniz Eşleşmedi");

        }
    }
}
