
namespace myHr.application.Features.LeaveCredits.query.get_all_leavecredits;

public class GetAllLeaveCreditQueryHandler : IRequestHandler<GetAllLeaveCreditQuery, Result<IEnumerable<GetAllLeaveCreditQueryDto>>>
{
    private readonly ILeaveCreditRepository _repository;
    public GetAllLeaveCreditQueryHandler(ILeaveCreditRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<IEnumerable<GetAllLeaveCreditQueryDto>>> Handle(GetAllLeaveCreditQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync(cancellationToken);

        if (result.IsFailed) 
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.Select(x => x.MapToGetAllLeaveCreditQueryDto()));
    }
}
