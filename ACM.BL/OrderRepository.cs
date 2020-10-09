using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            var order = new Order(1)
            {
                OrderDate = new DateTime(2020, 10, 9)
            };
            return order;
        }
        public bool Save()
        {
            return true;
        }
    }
}
