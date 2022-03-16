using System;
namespace NLayer.Core
{
    public class  Product:BaseEntity
    {
        public String Name{ get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category  category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
