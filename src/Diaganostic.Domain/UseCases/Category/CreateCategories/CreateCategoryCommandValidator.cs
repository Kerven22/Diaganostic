using FluentValidation;

namespace Diaganostic.Domain.UseCases.Category.CreateCategories;

public class CreateCategoryCommandValidator:AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(s => s.name).NotEmpty().WithErrorCode("Categry name shoul not empty!"); 
    }
}