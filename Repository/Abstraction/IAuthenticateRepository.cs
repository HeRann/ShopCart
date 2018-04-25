using DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    interface IAuthenticateRepository : IRepository<User>
    {
        User
    }
}
