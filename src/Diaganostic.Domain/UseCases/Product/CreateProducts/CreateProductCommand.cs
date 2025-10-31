using Diaganostic.Domain.UseCases.Models;
using MediatR;

namespace Diaganostic.Domain.UseCases.Product.CreateProducts;

public record CreateProductCommand(string name, decimal price) : IRequest<ProductDto>;
