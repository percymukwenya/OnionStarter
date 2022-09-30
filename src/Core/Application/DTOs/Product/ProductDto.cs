using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Product
{
    public class ProductDto : BaseDto, IProductDto
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
    }
}
