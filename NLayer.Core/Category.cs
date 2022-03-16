using System;
using System.Collections.Generic;

namespace NLayer.Core
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }
        
    }
}
