namespace myHr.application.Features.JobPositions.command.update_jobposition;

public class UpdateJobPositionCommandHandler : IRequestHandler<UpdateJobPositionCommand, Result<Guid>>
{
    private readonly IJobPositionRepository _repository;
    public UpdateJobPositionCommandHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdateJobPositionCommand request, CancellationToken cancellationToken)
    {
        request.ModifiedDate = DateTime.UtcNow;
        request.ModifiedBy = "Admin";
        var result = await _repository.UpdateAsync(request.MapToJobPosition(), cancellationToken);

        if (result.IsFailed) 
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
