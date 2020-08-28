using System;
using System.Collections.Generic;
using System.Text;

namespace LN_ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrive(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= null) isValid = false;
            if (ProductId <= null) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }




    }
}
