using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {
            AddressList = new List<Address>();
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public List<Address> AddressList { get; set; }
        public Address WorkAddress { get; set; }
        public Address HomeAddress { get; set; }
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
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

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public override string ToString() => FullName;

        //public string Log()
        //{
        //    var logString = CustomerId + ": " + FullName + " " + "Email: " + EmailAddress + " " + "Status: " + EntityState.ToString();
        //    return logString;
        //}

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }
        
    }
}
