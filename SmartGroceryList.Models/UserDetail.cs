using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Models
{
    public class UserDetail
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool HasPurchaseHistory { get; set; }

    }
}
