using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        private bool paid = false;
        private int ticketNo;

        public Ticket()
        {
            Random r = new Random();    // This generates a random number for the ticketNo
            ticketNo = r.Next();
        }

        public bool IsPaid()
        {
            return paid;
        }

        public void SetPaid()
        {
            paid = true;
        }
    }
}
