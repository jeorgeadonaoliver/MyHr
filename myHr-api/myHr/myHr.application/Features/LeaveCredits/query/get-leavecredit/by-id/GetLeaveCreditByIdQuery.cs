namespace myHr.application.Features.LeaveCredits.query.get_leavecredit.by_id;

public record GetLeaveCreditByIdQuery(Guid id) : IRequest<GetLeaveCreditByIdQueryDto>;
