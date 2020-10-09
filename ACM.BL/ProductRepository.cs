using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(1)
            {
                CurrentPrice = 12.99M,
                ProductDescription = "Thing that is something",
                ProductName = "Widget"
            };
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
