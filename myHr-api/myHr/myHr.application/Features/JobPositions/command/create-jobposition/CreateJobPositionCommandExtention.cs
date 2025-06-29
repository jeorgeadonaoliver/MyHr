using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Features.JobPositions.command.create_jobposition
{
    public static class CreateJobPositionCommandExtention
    {
        public static JobPosition MapToJobPosition(this CreateJobPositionCommand cmd) 
        {
            return new JobPosition { 
            
                DepartmentId = cmd.DepartmentId,
                CreatedDate = cmd.CreatedDate,
                CreatedBy = cmd.CreatedBy,
                Description = cmd.Description,
                PositionTitle = cmd.PositionTitle,
                PositionId = cmd.Id,
            };
        }
    }
}
