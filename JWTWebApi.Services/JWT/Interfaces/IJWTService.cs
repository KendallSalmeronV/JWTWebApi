using JWTWebApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWebApi.Services.JWT.Interfaces
{
    public interface IJWTService
    {
        Task<string> Authenticate(User user);
    }
}
