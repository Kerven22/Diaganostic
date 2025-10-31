using AutoMapper;
using Diaganostic.API.Models;
using Diaganostic.Domain.UseCases.Category.CreateCategories;
using Diaganostic.Domain.UseCases.Models;

namespace Diaganostic.API.Mapping;

public class ApiProfile:Profile
{
    public ApiProfile()
    {
        CreateMap<CategoryRequest, CreateCategoryCommand>()
            .ForMember(s=>s.name, b=>b.MapFrom(c=>c.Name))
            .ForMember(s=>s.products, b=>b.MapFrom((c=>c.Products)));
        
    }
}