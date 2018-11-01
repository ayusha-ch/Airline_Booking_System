using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class AirlineCoordinator
    {
        private FlightManager flightMan;
        private CustomerManager customMan;
        private BookingManager bookingMan;

        public AirlineCoordinator(int custIdSeed, int maxCustomers, int maxFlights, int bookSeed, int maxBook)
        {
            flightMan = new FlightManager(maxFlights);
            customMan = new CustomerManager(custIdSeed, maxCustomers);
            bookingMan = new BookingManager(bookSeed, maxBook);
        }

        public bool addFlight(int flNo, string origin, string dest, int maxSeats)
        {
            return flightMan.addFlight(flNo, origin, dest, maxSeats) ;
        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            return customMan.addCustomer(cfName, lName, phone);
        }

        public string flightList()
        {
            return flightMan.getFlightList();
        }

        public string customerList()
        {
            return customMan.getCustomerList();
        }

        public bool deleteCustomer(int cId)
        {
            return customMan.deleteCustomer(cId);
        }

        public bool deleteFlight(int flightNo)
        {
            return flightMan.deleteFlight(flightNo);
        }

        public bool addBooking(int custId, int flightNum)
        {
            if(!(customMan.customerExist(custId) && flightMan.flightExist(flightNum))) { return false; }
            Customer customer = customMan.getCustomer(custId);
            Flight flight = flightMan.getFlight(flightNum);
            return bookingMan.addBooking(customer, flight);
        }

        public string viewBookings()
        {
            return bookingMan.getBookingList();
        }

    }
}
