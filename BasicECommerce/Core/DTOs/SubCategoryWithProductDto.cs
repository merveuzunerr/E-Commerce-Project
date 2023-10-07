using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class SubCategoryWithProductDto
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public CategoryNameDto Category { get; set; }
    }
}
