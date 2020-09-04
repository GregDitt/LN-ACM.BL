using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN_ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);


            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbit.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetreieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }



    }
}
