﻿using myHr.domain.myHrIdentityDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.Contracts
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>
    {

    }
}
