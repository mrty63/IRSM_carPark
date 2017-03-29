using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private string message;
        private CarPark carpark;

        private ActiveTickets tickets;

        public TicketMachine(ActiveTickets tickets)
        {
            this.tickets = tickets;
        }

        public void AssignCarPark(CarPark carpark)
        {
            this.carpark = carpark;
        }

        public void CarArrived()
        {
            message = "Please press for ticket.";
        }

        public void PrintTicket()
        {
            message = "Thank you, enjoy your stay.";
            tickets.AddTicket();
            carpark.TicketDispensed();
        }

        public string GetMessage()
        {
            return message;
        }

        public void ClearMessage()
        {
            message = "";
        }

    }
}
