using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IUserAccountService : IService<UserAccount>
    {
        Task<CustomResponseDto<UserAccountDto>> AddUserAccount(UserAccountDto userDto, int id);
        Task<CustomResponseDto<string>> Login(LoginDto loginDto, int id);
        Task<CustomResponseDto<string>> LogOut(int id);
    }

    
}
