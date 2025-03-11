using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    internal class Customer
    {
        private string CustomerID;
        private string CustomerName;
        private string CustomerAddress;
        private string CustomerRequirement;

        public string customerID
        {
            get { return this.CustomerID; }
            set { this.CustomerID = value; }
        }
        public string customerName
        {
            get { return this.CustomerName; }
            set { this.CustomerName = value; }
        }
        public string customerAddress
        {
            get { return this.CustomerAddress; }
            set { this.CustomerAddress = value; }
        }
        public string customerRequirement
        {
            get { return this.CustomerRequirement; }
            set { this.CustomerRequirement = value; }
        }
    }
}
