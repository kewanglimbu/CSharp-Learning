using CustomerManagement.Common;

namespace CustomerManagement.BL
{
    public class Customer:EntityBase,ILoggable
    {

        public Customer():this(0)
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList= new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //public string HomeAddress { get; set; }
        //public string WorkAddress { get; set; }


        //public string FullName()
        //{
        //    return FirstName +","+ LastName;
        //}

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }


        public override string ToString() => FullName;


        public string Log() => $"{CustomerId}  {FullName}  Email: {Email}  Status: {EntityState.ToString()} ";


        /// <summary>
        /// Validate the Customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }
    }
}