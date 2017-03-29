using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        //private Ticket ticket;
        private List<Ticket> tickets;

        public ActiveTickets(List<Ticket> tickets)
        {
            this.tickets = tickets; //Links the Ticket list in CarPark to this class
        }

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
