using CRUD_Marcas.Api.Models.InputModels;
using FluentValidation;

namespace CRUD_Marcas.Api.Validators
{
    public class BrandValidator : AbstractValidator<BrandInputModel>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty()
                    .WithMessage("Nome não pode ficar vazio")
                .MinimumLength(2)
                    .WithMessage("Nome não pode ter menos que 2 caracteres")
                .MaximumLength(50)
                    .WithMessage("Nome não pode ter mais que 50 caracteres");
        }
    }
}
