using Application.Features.AccountLearningPaths.Commands.Create;
using Application.Features.AccountLearningPaths.Commands.Delete;
using Application.Features.AccountLearningPaths.Commands.Update;
using Application.Features.AccountLearningPaths.Queries.GetById;
using Application.Features.AccountLearningPaths.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;
using Application.Features.AccountLearningPaths.Queries.GetListByAccountId;

namespace Application.Features.AccountLearningPaths.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AccountLearningPath, CreateAccountLearningPathCommand>().ReverseMap();
        CreateMap<AccountLearningPath, CreatedAccountLearningPathResponse>().ReverseMap();
        CreateMap<AccountLearningPath, UpdateAccountLearningPathCommand>().ReverseMap();
        CreateMap<AccountLearningPath, UpdatedAccountLearningPathResponse>().ReverseMap();
        CreateMap<AccountLearningPath, DeleteAccountLearningPathCommand>().ReverseMap();
        CreateMap<AccountLearningPath, DeletedAccountLearningPathResponse>().ReverseMap();
        CreateMap<AccountLearningPath, GetByIdAccountLearningPathResponse>().ReverseMap();
        CreateMap<AccountLearningPath, GetListAccountLearningPathListItemDto>().ReverseMap();
        CreateMap<AccountLearningPath, GetListByAccountIdAccountLearningPathListItemDto>()
            .ForMember(destinationMember: d => d.LearningPathName,
            memberOptions: opt => opt.MapFrom(alp => alp.LearningPath.Name))
            .ForMember(destinationMember: d => d.StartingTime,
            memberOptions: opt => opt.MapFrom(alp => alp.LearningPath.StartingTime))
            .ForMember(destinationMember: d => d.ImageUrl,
            memberOptions: opt => opt.MapFrom(alp => alp.LearningPath.ImageUrl))
            .ReverseMap();
        CreateMap<IPaginate<AccountLearningPath>, GetListResponse<GetListAccountLearningPathListItemDto>>().ReverseMap();
        CreateMap<IPaginate<AccountLearningPath>, GetListResponse<GetListByAccountIdAccountLearningPathListItemDto>>().ReverseMap();
    }
}