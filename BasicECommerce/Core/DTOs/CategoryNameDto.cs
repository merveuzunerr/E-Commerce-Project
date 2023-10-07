using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CategoryNameDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ParentCategoryNameDto ParentCategory { get; set; }
    }
}
