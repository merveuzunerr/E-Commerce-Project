using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public ProductNameDto Product { get; set; }
    }
}
