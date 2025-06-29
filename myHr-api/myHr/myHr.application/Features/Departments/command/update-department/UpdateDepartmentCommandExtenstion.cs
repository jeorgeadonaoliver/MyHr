using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Features.Departments.command.update_department
{
    public static class UpdateDepartmentCommandExtenstion
    {
        public static Department MapToDepartment(this UpdateDepartmentCommand cmd) {

            return new Department()
            {
                DepartmentId = cmd.Id,
                DepartmentName = cmd.DepartmentName,
                Location = cmd.Location,
                ModifiedBy = cmd.ModifiedBy,
                ModifiedDate = cmd.ModifiedDate,
                CreatedBy = cmd.CreatedBy,
                CreatedDate = cmd.CreatedDate
            };
        }
    }
}
