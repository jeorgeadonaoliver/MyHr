﻿using myHr.domain.myHrDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Contracts
{
    public interface IAttendanceRepository : IGenericRepository<Attendance>
    {
    }
}
