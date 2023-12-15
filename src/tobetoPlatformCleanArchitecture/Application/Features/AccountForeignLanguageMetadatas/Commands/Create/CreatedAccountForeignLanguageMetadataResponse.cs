using Core.Application.Responses;

namespace Application.Features.AccountForeignLanguageMetadatas.Commands.Create;

public class CreatedAccountForeignLanguageMetadataResponse : IResponse
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int ForeignLanguageId { get; set; }
    public int ForeignLanguageLevelId { get; set; }
    public int Priority { get; set; }
}