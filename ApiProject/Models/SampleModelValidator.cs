using FluentValidation;

namespace ApiProject.Models
{
    public class SampleModelValidator : AbstractValidator<SampleModel>
    {
        public SampleModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        }
    }
}
