using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sample.Entities;

namespace Sample.Data.Abstractions
{
    public interface IAuthRepository
    {
        Task<User> RegisterUser(User user);

        Task<User> FindUser(string userName, string password);
    }
}
