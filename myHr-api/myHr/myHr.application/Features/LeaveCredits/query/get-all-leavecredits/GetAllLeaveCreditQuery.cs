namespace myHr.application.Features.LeaveCredits.query.get_all_leavecredits;

public record GetAllLeaveCreditQuery : IRequest<Result<IEnumerable<GetAllLeaveCreditQueryDto>>>;
