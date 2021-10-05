using JWTWebApi.Entities.Entities;
using JWTWebApi.Services.JWT.Interfaces;
using JWTWebApi.Services.Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly IJWTService _jwtService;

        public LoginService(IJWTService jwtService)
        {
            _jwtService = jwtService;
        }

        public async Task<string> Authenticate(User user)
        {
            return await _jwtService.Authenticate(user);
        }
    }
}
