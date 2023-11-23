﻿using AKDEM.OBYS.Dto.AppBranchDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKDEM.OBYS.Business.ValidationRules.AppBranch
{
    public class AppBranchCreateDtoValidator:AbstractValidator<AppBranchCreateDto>
    {
        public AppBranchCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("Lütfen Şube İsmini Giriniz");
            RuleFor(x => x.ClassId).NotEmpty().WithMessage("Lütfen Şube İçin Bir Sınıf Seçiniz");


        }
    }
}
