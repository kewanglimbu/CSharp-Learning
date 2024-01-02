using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class OrderRepository
    {
       
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 2)
            {
                //used current year in hard coded data 
                order.OrderDate = new DateTimeOffset(DateAndTime.Now.Year, 1, 2, 12, 35, 12, new TimeSpan(5, 45, 0));

            }
            return order;
        }


        public bool Save(Order order)
        {
            return true;
        }

    }
}
