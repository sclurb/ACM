﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {

        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }


        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
    }
}
