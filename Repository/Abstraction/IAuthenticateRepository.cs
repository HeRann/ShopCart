﻿using DomainModels.Entities;
using DomainModels.ViewModel;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IAuthenticateRepository : Repositary<User>
    {
        UserModel validateUser(string uName, string password);
    }
}
 