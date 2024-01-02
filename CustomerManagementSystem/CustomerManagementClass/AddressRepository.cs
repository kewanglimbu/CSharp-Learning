using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class AddressRepository
    {
        public Address RetrieveAddress(int addressId)
        {

            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine = "K Street";
                address.City = "Gothagaun";
                address.Province = "province 3";
                address.Country = "Nepal";
                address.PostalCode = "12345";
            }

            return address;
        }

        public IEnumerable<Address> GetAllAddressByCustomerId(int customerId)
        {

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine = "I Street",
                City = "Itahari",
                Province = "province 3",
                Country = "Nepal",
                PostalCode = "234567"
            };
            addressList.Add(address);
           
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine = "B Street",
                City = "Biratchowk",
                Province = "province 3",
                Country = "Nepal",
                PostalCode = "345678"
            };
            addressList.Add(address);

             address = new Address(3)
            {
                AddressType = 3,
                StreetLine = "G Street",
                City = "Y city",
                Province = "province 3",
                Country = "Nepal",
                PostalCode = "345679"
            };
            addressList.Add(address);

            return addressList;
        }
}
}
