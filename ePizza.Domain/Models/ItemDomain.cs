using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Domain.Models
{
    public class ItemDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
