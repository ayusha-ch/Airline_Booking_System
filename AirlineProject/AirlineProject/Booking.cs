using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Booking
    {
        private int bookingId;
        private string bookingDate;
        private Flight flight;
        private Customer customer;

        public Booking(int bookId, string bookDate, Flight flt, Customer cust)
        {
            bookingId = bookId;
            bookingDate = bookDate;
            flight = flt;
            customer = cust;
        }

        public int getBookingId() { return bookingId; }

        public string getBookingDate() { return bookingDate; }

        public Flight getFlight() { return flight; }

        public Customer getCustomer() { return customer; }

        public string toString()
        {
            string output = "Booking ID: " + bookingId + "\nBooking Date: " + bookingDate + "\nFlight ID: " + flight.getFlightNumber()
                + "Customer ID: " + customer.getCustomerId();
            return output;
        }

    }
}
