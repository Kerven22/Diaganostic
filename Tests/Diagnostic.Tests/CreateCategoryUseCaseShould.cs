using Diaganostic.Domain.UseCases.Category.CreateCategories;
using Diaganostic.Domain.UseCases.Models;
using FluentAssertions;
using Moq;
using Moq.Language.Flow;

namespace Diagnostic.Tests;

public class CreateCategoryUseCaseShould
{
    private readonly CreateCategoryUseCase sut;
    private readonly ISetup<ICreateCategoryStorage, Task<CategoryDto>> createCategorySetup;

    public CreateCategoryUseCaseShould()
    {
        var storage = new Mock<ICreateCategoryStorage>();
        createCategorySetup = storage.Setup(s =>
            s.CreateCategory(It.IsAny<string>(), It.IsAny<IEnumerable<ProductDto>>(), It.IsAny<CancellationToken>())); 
        sut = new CreateCategoryUseCase(storage.Object); 
    }
    
    
    [Fact]
    public async Task ReturnNewCategory_WhenCategoryCreated()
    {
        var expected = new CategoryDto() { CategoryName = "Fruct" };
        createCategorySetup.ReturnsAsync(expected);

        var command = new CreateCategoryCommand(name:"Fruct", null);
        var actual = await sut.Handle(command, CancellationToken.None);
        actual.Should().Be(expected); 
    }
}
