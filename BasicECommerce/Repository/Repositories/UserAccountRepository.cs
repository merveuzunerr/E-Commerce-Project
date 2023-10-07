using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserAccountRepository : GenericRepository<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(AppDbContext context) : base(context)
        {

        }
        
             
        public async Task<UserAccount> FindByEmail(string email)
        {
            if (email == null) 
                throw new ArgumentNullException(nameof(email));
            else
                return await _context.UserAccounts.FirstOrDefaultAsync(x => x.Email==email);
        }


    }
}
