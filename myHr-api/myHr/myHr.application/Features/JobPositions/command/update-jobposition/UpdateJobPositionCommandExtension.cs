using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Features.JobPositions.command.update_jobposition
{
    public static class UpdateJobPositionCommandExtension
    {
        public static JobPosition MapToJobPosition(this UpdateJobPositionCommand cmd) 
        {
            return new JobPosition() {
            
                PositionId = cmd.Id,
                CreatedBy = cmd.CreatedBy,
                ModifiedBy = cmd.ModifiedBy,
                ModifiedDate = cmd.ModifiedDate,
                CreatedDate = cmd.CreatedDate,
                Description = cmd.Description,
                PositionTitle = cmd.PositionTitle
            };
        }
    }
}
