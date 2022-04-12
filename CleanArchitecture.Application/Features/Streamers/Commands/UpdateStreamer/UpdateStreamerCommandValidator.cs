using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public class UpdateStreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
    {
        public UpdateStreamerCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("{Name} no permite valores nulos");

            RuleFor(P => P.Url)
                .NotNull().WithMessage("{Url} no permite valores nulos");
        }
    }
}
