

namespace myHr.application.Features.LeaveCredits.query.get_leavecredit.by_id;

public class GetLeaveCreditByIdQueryHandler : IRequestHandler<GetLeaveCreditByIdQuery, GetLeaveCreditByIdQueryDto>
{
    private readonly ILeaveCreditRepository _repository;
    public GetLeaveCreditByIdQueryHandler(ILeaveCreditRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetLeaveCreditByIdQueryDto> Handle(GetLeaveCreditByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAsync(x => x.CreditId == request.id, cancellationToken);
        if (result.IsFailed)
        {
            return new GetLeaveCreditByIdQueryDto();
        }
        
        return result.Value.MapToGetLeaveCreditByIdQueryDto();
    }
}
