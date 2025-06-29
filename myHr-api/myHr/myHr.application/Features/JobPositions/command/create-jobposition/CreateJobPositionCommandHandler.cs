namespace myHr.application.Features.JobPositions.command.create_jobposition;

public class CreateJobPositionCommandHandler : IRequestHandler<CreateJobPositionCommand, Result<Guid>>
{
    private readonly IJobPositionRepository _repository;
    public CreateJobPositionCommandHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreateJobPositionCommand request, CancellationToken cancellationToken)
    {
        request.Id = Guid.NewGuid();
        request.CreatedDate = DateTime.UtcNow;
        request.CreatedBy = "Admin";
        var result = await _repository.CreateAsync(request.MapToJobPosition(), cancellationToken);

        if (result.IsFailed)
            return Result.Fail(result.Errors);

        return Result.Ok(request.Id);
    }
}
