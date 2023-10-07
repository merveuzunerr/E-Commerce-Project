using Core.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IUserAccountRepository : IGenericRepository<UserAccount>
    {
       // Task<List<UserAccount>> AddUser(UserAccount user);
        Task<UserAccount> FindByEmail(string email);
    }
}
