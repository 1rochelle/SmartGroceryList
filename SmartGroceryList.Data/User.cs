using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Data
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public bool HasPurchaseHistory { get; set; }
    }
}
