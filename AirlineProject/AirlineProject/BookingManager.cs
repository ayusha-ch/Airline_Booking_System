﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class BookingManager
    {
        private static int currentBookingId;
        private int maxBooking;
        private int numBookings;
        private Booking[] bookingList;

        public BookingManager(int bookSeed, int maxBooking)
        {
            currentBookingId = bookSeed;
            this.maxBooking = maxBooking;
            numBookings = 0;
            bookingList = new Booking[maxBooking];
        }
        
        public bool addBooking(Customer cust, Flight flt)
        {
            if (numBookings >= maxBooking) return false;
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy/MM/dd");
            bookingList[numBookings] = new Booking(currentBookingId, date, flt, cust);
            numBookings++;
            currentBookingId++;
            return true;
        }

        public string getBookingList()
        {
            string output = "[Date] - [Booking No.] - [Name] - [Flight No.]\n";
            for(int i=0; i<numBookings; i++)
            {
                output += bookingList[i].getBookingDate() + " - " + bookingList[i].getBookingId() + " - " +
                    bookingList[i].getCustomer().getFirstName() + " " + bookingList[i].getCustomer().getLastName() + " - " +
                    bookingList[i].getFlight().getFlightNumber() + "\n";
            }
            return output;
        }
    }
}
