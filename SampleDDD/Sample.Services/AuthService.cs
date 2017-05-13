using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Abstractions;
using Sample.Entities;
using Sample.Services.Abstractions;

namespace Sample.Services
{
    public class AuthService: IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<User> RegisterUser(User user)
        {
            return await _authRepository.RegisterUser(user);
        }

        public async Task<User> FindUser(string userName, string password)
        {
            return await _authRepository.FindUser(userName, password);
        }
    }
}
