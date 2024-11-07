using FluentValidation;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Validators
{
    /// <summary>
    /// Validator for business rules related to Category.
    /// </summary>
    public class CategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Category name is required.")
                .Length(4, 50).WithMessage("Category name must be between 4 and 50 characters.");
        }
    }
}
