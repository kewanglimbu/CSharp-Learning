﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class ProductRepository
    {
       
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Macbook Pro";
                product.Description = "Latest i9 Macbook with highend processor";
                product.CurrentPrice = 2000;
            }

            return product;
         
        }


        public bool Save(Product product)
        {
            return true;
        }


    }
}
