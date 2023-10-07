using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ParentCategory: BaseEntity
    {
        public string ParentCategoryName { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
