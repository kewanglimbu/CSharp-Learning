using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; private set; }
        public string StreetLine { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (PostalCode != null)
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
