using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Data
{
    public class Product
    {
        public enum Department { Grocery, Household, PersonalCare, Other }

        [Key]
        public Guid ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        
        public int ItemCount { get; set; }

        public bool PurchasedAtMultipleStores { get; set; }
        public enum ItemType { Refrigerated, Frozen, Produce, DryGoods, Household, PersonalCareItem }

        // Foreign Keys here
        [Required]
        [ForeignKey(nameof(UserName))]
        public Guid UserId { get; set; }
        public virtual User UserName { get; set; }

        [Required]
        [ForeignKey(nameof(StoreName))]
        public int StoreId { get; set; }
        public virtual Store StoreName { get; set; }
    }
}
