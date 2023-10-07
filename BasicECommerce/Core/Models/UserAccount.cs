using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? City { get; set; }
        public bool? IsActive { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsGuest { get; set; }
        public int? CartId { get; set; }
        public Cart? Cart { get; set; }
    }
}
