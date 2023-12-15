using Core.Application.Dtos;

namespace Application.Features.Capabilities.Queries.GetList;

public class GetListCapabilityListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }
    public bool Visibility { get; set; }
}