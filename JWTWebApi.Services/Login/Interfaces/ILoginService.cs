using JWTWebApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Services.Login.Interfaces
{
    public interface ILoginService
    {
        Task<string> Authenticate(User user);
    }
}
