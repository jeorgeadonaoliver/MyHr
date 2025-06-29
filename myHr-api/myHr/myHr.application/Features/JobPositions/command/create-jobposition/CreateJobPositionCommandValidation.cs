using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Features.JobPositions.command.create_jobposition
{
    public class CreateJobPositionCommandValidation : AbstractValidator<CreateJobPositionCommand>
    {
        private readonly IJobPositionRepository _repository;
        public CreateJobPositionCommandValidation(IJobPositionRepository repository)
        {
            _repository = repository;

            RuleFor(x => x.PositionTitle)
                .NotNull()
                .WithMessage("Position Title must not be null!")
                .MustAsync(IsJobPositionExist)
                .WithMessage("Job Position is already exist!");

            RuleFor(x => x.Description)
                .NotNull()
                .WithMessage("Description must not be null!");
        }

        private async Task<bool> IsJobPositionExist(string jobTitle, CancellationToken cancellationToken) 
        {
            var result = await _repository.GetAnyAsync(x => x.PositionTitle == jobTitle, cancellationToken);
            return !result.Value;
        }
    }
}
