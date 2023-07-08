using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.ValidationRules.FluentValidation
{
    public class AboutValidator :AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmı Boş Geçilemez.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel Seçiniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama En Az 50 Karakter Olmalı.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama En Fazla 1500 Karakter Olmalı.");
        }
    }
}
