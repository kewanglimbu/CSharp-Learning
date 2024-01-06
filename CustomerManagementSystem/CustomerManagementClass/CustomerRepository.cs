using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public  class CustomerRepository
    {
        // this establish collaborative relationship between customerRepository and AddressRepository
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository;

        /// <summary>
        /// Retrieve the customer
        /// </summary>
        /// <param name="customerid"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
          
            // hard-coded data

            if(customerId==1)
            {
                customer.Email = "kewang.h.limbu@gmail.com";
                customer.FirstName = "Kewang";
                customer.LastName = "Limbu";
                customer.AddressList = addressRepository.GetAllAddressByCustomerId(customerId).ToList();
            }
            return customer;

        }


        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var Success = true;

            if (customer.Haschanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //call Insert Stored procedure
                    }
                    else
                    {
                        //call  an Update Stored procedure
                    }
                }
                else
                {
                    Success = false;
                }
            }

            return Success;
        }
    }
}
