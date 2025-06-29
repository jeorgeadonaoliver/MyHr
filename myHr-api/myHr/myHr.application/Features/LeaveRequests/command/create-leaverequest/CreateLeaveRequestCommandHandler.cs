
namespace myHr.application.Features.LeaveRequests.command.create_leaverequest;

public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, Result<Guid>>
{
    private readonly ILeaveRequestRepository _repository;
    public CreateLeaveRequestCommandHandler(ILeaveRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        request.CreatedBy = "Admin";
        request.CreatedDate = DateTime.UtcNow;
        var result = await _repository.CreateAsync(request.MapToLeaveRequest(), cancellationToken);

        if (result.IsFailed) 
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
