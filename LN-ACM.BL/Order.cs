using System;
using System.Collections.Generic;
using System.Text;

namespace LN_ACM.BL
{
   public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        //public Order Retrive(int orderId)
        //{
        //    return new Order();
        //}

        //public bool Save()
        //{
        //    return true;
        //}

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }



    }
}
