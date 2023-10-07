using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public ParentCategory ParentCategory { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
