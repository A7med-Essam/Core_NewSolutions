using Core_NewSolutions.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_NewSolutions.Services
{
    public interface IAuthService
    {
        Task<Auth_VM> RegisterAsync(Register_VM model);
        Task<Auth_VM> GetTokenAsync(TokenRequest_VM model);
        Task<string> AddRoleAsync(AddRole_VM model);
    }
}
