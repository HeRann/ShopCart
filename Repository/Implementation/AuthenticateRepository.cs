using ApplicationCore;
using DomainModels.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.ViewModel;

namespace Repository.Implementation
{
    class AuthenticateRepository:Repository<User>, IAuthenticateRepository
    {
        public AuthenticateRepository(DatabaseContext _db)
        {
            this.db = _db;
        }

        public UserModel validateUser(string uName, string password)
        {
            User data = db.Users.Include("Roles").Where(m => m.userName == uName && m.password == password).FirstOrDefault();
            UserModel usrModel = new UserModel();
            if (data != null)
            {
                usrModel.userId = data.userId;
                usrModel.password = data.password;
                usrModel.firstName = data.firstName;
                usrModel.lastName = data.lastName;
                usrModel.contactNumber = data.contactNumber;
                usrModel.roles = data.Roles.Select(m => m.name).ToArray();
                usrModel.userName = data.userName;
                return usrModel;
            }
            else
            { 
                return null;
            }
        }
    }
}
