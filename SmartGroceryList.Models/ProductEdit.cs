﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Models
{
    public class ProductEdit
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}