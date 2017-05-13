using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sample.Core.Repository;
using Sample.Data.Abstractions;
using Sample.Entities;

namespace Sample.Data.Repositories
{
    public class AuthRepository : EntityFrameworkRepository<SampleDbContext>, IAuthRepository
    {
        public AuthRepository(SampleDbContext context) : base(context)
        {
        }

        public async Task<User> RegisterUser(User user)
        {
            context.Users.Add(user);
            await SaveAsync();
            return user;
        }

        public async Task<User> FindUser(string userName, string password)
        {
            return await GetOneAsync<User>(x => x.UserName == userName && x.Password == password);
        }
    }
}