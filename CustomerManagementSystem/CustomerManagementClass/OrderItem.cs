using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
            
        }
        public int OrderItemId { get;private set; }
     
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? PurchasePrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;
           if(ProductId <= 0) isValid = false;
           if(Quantity <= 0) isValid |= false;
           if (PurchasePrice == null) isValid = false;

           return isValid;
        }


        public bool Save()
        {
            return true;
        }


        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();

        }

    }
}
