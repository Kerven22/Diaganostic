using AutoMapper;
using Diaganostic.API.Models;
using Diaganostic.Domain.UseCases.Category.CreateCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diaganostic.API.Controllers;

[ApiController]
[Route("categories")]
public class CategoryController:ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    private readonly ILogger<CategoryController> _logger; 
    public CategoryController(IMapper mapper, IMediator mediator, ILogger<CategoryController>logger)
    {
        _mapper = mapper;
        _mediator = mediator;
        _logger = logger; 
    }
    
    [HttpGet]
    public async Task<IActionResult> GetCategories(Guid categoryId, CancellationToken cancellationToken)
    {
        _logger.LogError("categoryId is {categoryId} null", categoryId);
        return Ok("categories"); 
    }

    [HttpPost]
    public async Task<IActionResult> CreatCategory(
        CategoryRequest category, 
        CancellationToken cancellationToken)
    {
        var categoryCommand = _mapper.Map<CreateCategoryCommand>(category);
        var result = await _mediator.Send(categoryCommand, cancellationToken);
            
        return Ok(result); 
    }
}