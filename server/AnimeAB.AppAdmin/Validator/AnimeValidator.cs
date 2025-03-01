﻿using AnimeAB.AppAdmin.AnimeEndpoints;
using AnimeAB.AppAdmin.Controllers;
using AnimeAB.Core.Controllers;
using FluentValidation;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAB.AppAdmin.Validator
{
    public class AnimeDetailValidator : AbstractValidator<AnimeDetailRequest>
    {
        public AnimeDetailValidator()
        {
            RuleFor(x => x.Key)
                .NotEmpty()
                .NotNull();
            
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Link)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Episode)
                .NotEmpty()
                .NotNull();
        }
    }

    public class AnimeValidator : AbstractValidator<AnimeRequest>
    {
        public AnimeValidator()
        {
            RuleFor(x => x.Key)
                .NotEmpty()
                .WithMessage("Bạn cần nhập key.")
                .NotNull();

            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Bạn cần nhập tiêu đề.")
                .NotNull();

            RuleFor(x => x.TitleVie)
                .NotEmpty()
                .WithMessage("Bạn cần nhập tiêu đề bổ sung.")
                .NotNull();

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Bạn cần nhập mô tả.")
                .NotNull();

            RuleFor(x => x.Trainer)
                .NotEmpty()
                .WithMessage("Bạn cần nhập trainer.")
                .NotNull();

            RuleFor(x => x.Episode)
               .NotEmpty()
               .WithMessage("Bạn cần nhập số tập.")
               .NotNull();

            RuleFor(x => x.MovieDuration)
               .NotEmpty()
               .WithMessage("Bạn cần nhập thời lượng anime.")
               .NotNull();

            RuleFor(x => x.Categories)
                .NotEmpty()
                .WithMessage("Bạn cần chọn thể loại anime")
                .NotNull();
        }
    }
}
