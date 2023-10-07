using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Task<List<Cart>> GetCartsAsync(int id);
    }
}
