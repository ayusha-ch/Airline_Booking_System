﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class CustomerManager
    {
        private static int currentCustNo;
        private int maxCustomers;
        private int numCustomers;
        private Customer[] listCustomer;

        public CustomerManager(int seed, int maxCust)
        {
            currentCustNo = seed;
            maxCustomers = maxCust;
            numCustomers = 0;
            listCustomer = new Customer[maxCustomers];
        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            if (numCustomers >= maxCustomers) return false;
            listCustomer[numCustomers] = new Customer(currentCustNo, cfName, lName, phone);
            numCustomers++;
            currentCustNo++;
            return true;
        }

        private int findCustomer(int cId)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (listCustomer[i].getCustomerId() == cId)
                    return i;
            }
            return -1;
        }

        public bool customerExist(int custId)
        {
            if (findCustomer(custId) == -1) return false;
            return true;
        }

        public Customer getCustomer(int custId)
        {
            int loc = findCustomer(custId);
            return listCustomer[loc];
        }

        public bool deleteCustomer(int cId)
        {
            if (!customerExist(cId)) return false;
            int loc = findCustomer(cId);
            listCustomer[loc] = listCustomer[numCustomers-1];
            numCustomers--;
            return true;
        }

        public string getCustomerList()
        {
            string output = "Customer List:\nNumber\tName\t\tPhone\n";
            for(int i = 0; i < numCustomers; i++)
            {
                output += listCustomer[i].getCustomerId() + "\t" + listCustomer[i].getFirstName() + " " +
                    listCustomer[i].getLastName() + "\t" + listCustomer[i].getPhone() +"\n";
            }
            return output;
        }

    }
}
