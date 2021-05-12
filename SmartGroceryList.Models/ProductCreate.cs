using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Models
{
    public class ProductCreate
    {
        [Key]
        public Guid ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(30, ErrorMessage = "There are too many characters in this field.")]
        public string StoreName { get; set; }
        public enum ItemType { Refrigerated, Frozen, Produce, DryGoods, Household, PersonalCareItem }

        public DateTimeOffset CreatedUtc { get; set; }

    }
}
