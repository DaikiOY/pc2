using FluentValidation;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Validators
{
    /// <summary>
    /// Validator for business rules related to Product.
    /// </summary>
    public class ProductValidator : AbstractValidator<CreateProductCommand>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("Product name is required.")
                .Length(5, 50).WithMessage("Product name must be between 5 and 50 characters.");

            RuleFor(p => p.Sku)
                .NotEmpty().WithMessage("SKU is required.")
                .Length(4, 50).WithMessage("SKU must be between 4 and 50 characters.");

            RuleFor(p => p.CategoryId)
                .NotEmpty().WithMessage("Category ID is required.");

            RuleFor(p => p.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Quantity must be zero or greater.");

            RuleFor(p => p.Status)
                .InclusiveBetween(1, 5).WithMessage("Status must be a valid status code between 1 and 5.");

            When(p => p.Status == 1, () =>
            {
                RuleFor(p => p.CreatedAt)
                    .NotEmpty().WithMessage("Creation date is required when product status is 'Available'.");
            });

            When(p => p.Status == 2 || p.Status == 3 || p.Status == 4 || p.Status == 5, () =>
            {
                RuleFor(p => p.UpdatedAt)
                    .NotEmpty().WithMessage("Updated date is required when product status is OutOfStock, Discontinued, BackOrder, or Returned.");
            });
        }
    }
}
