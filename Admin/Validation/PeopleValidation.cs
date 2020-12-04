using Admin.Models.PeopleViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whereisthelove.Data.Dal;

namespace Admin.Validation
{
    public class PeopleValidation : AbstractValidator<PeopleCEViewModel>
    {
        public PeopleValidation(EntityContext customerContext)
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Ad Boş Olamaz");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyad Boş Olamaz");
            RuleFor(p => p.News).NotEmpty().WithMessage("Haber Boş olamaz");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Açıklama Boş olamaz");
            RuleFor(p => p.Detail).NotEmpty().WithMessage("Detay Boş olamaz");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Başlık Boş olamaz");
        }
    }
}
