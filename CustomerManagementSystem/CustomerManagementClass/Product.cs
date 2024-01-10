using CustomerManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class Product:EntityBase
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get;private  set; }
       
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }
        private string _productName;

        public string ProductName
        {
            get
            {
               
                return _productName.InsertSpace();
            }

            set
            {
               _productName = value;
            }
        }
        public override string ToString() => ProductName;
        

        public override bool Validate()
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice==null) isValid = false;

            return isValid;
        }


       
    }
}
