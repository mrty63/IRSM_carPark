using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        //attributes
        private List<Ticket> tickets = new List<Ticket>();

        //constructor
        public ActiveTickets()
        {
            this.tickets = tickets; //Links the Ticket list in CarPark to this class
        }

        //functions
        public void AddTicket()
        {
            tickets.Add(new Ticket());  //Adds a new ticket
        }

        public void RemoveTicket()
        {

            tickets.RemoveAt(1);
        }
    }
}
