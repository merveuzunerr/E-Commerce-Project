using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int ProductId { get; set; }
        public ICollection<Product>? Products { get; set; }

        public int? UserAccountId { get; set; }
        public UserAccount? UserAccount { get; set; }

        public bool? IsActive { get; set; }

        //public int? GuestAccountId { get; set; }
        //public GuestAccount? GuestAccount { get; set; }
    }
}
