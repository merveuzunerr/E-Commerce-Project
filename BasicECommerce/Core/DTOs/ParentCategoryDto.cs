using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ParentCategoryDto
    {
        public string ParentCategoryName { get; set; }

        public ICollection<CategoryDto> Categories { get; set; }
    }
}
