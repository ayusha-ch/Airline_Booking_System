using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;

        public Customer(int id, string fName, string lName, string ph)
        {
            id = customerId;
            firstName = fName;
            lastName = lName;
            phone = ph;
        }

        public int getCustomerId() { return customerId; }

        public string getFirstName() { return firstName; }

        public string getLastName() { return lastName; }

        public string getPhone() { return phone; }

        public string toString()
        {
            string output = "Customer ID: " + customerId + "\nName: " + firstName + " " + lastName + "\nPhone: " + phone + "\n";
            return output;
        }

    }
}
