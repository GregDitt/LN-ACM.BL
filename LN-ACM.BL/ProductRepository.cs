using System;
using System.Collections.Generic;
using System.Text;

namespace LN_ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;

        }

        public bool Save(Product product)
        {
            return true;
        }
      

    }
}
