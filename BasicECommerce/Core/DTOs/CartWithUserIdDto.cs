using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CartWithUserIdDto
    {
        public int Number { get; set; }
        public int UserAccountId { get; set; }
        public int ProductId { get; set; }
    }
}
