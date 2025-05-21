﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Domain.Command.Update;

namespace SzkolenieTechniczne2.Cinema.Domain.Command.Create
{
    internal class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nazwa filmu wymagana.")
                .MaximumLength(256)
                .WithMessage("Maxymalna liczba znaków 256. ");

            RuleFor(x => x.Year)
                .InclusiveBetween(1900, 2080)
                .WithMessage("Rok musi być pomiędzy 1900 a 2080.");

            RuleFor(x => x.SeanceTime)
                .InclusiveBetween(30, 300)
                .WithMessage("Seans musi być pomiędzy 30 and 300 minutes.");
        }
    }

}


