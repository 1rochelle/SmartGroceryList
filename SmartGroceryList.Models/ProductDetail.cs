using SmartGroceryList.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Models
{
    public class ProductDetail
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public List<Product> MultiplePurchasesOfItem { get; set; }
    }
}
