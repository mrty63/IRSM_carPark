using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces;
        private int maxSpaces = 5;

        private TicketMachine ticketmachine;
        private TicketValidator ticketvalidator;


        public CarPark(TicketMachine ticketmachine, TicketValidator ticketvalidator)
        {
            this.ticketmachine = ticketmachine;
            this.ticketvalidator = ticketvalidator;

        }

        public void CarArrivedAtEntrance()
        {

        }

        public void TicketDispensed()
        {

        }

        public void CarEnteredCarPark(){

        }

        public void CarArrivedAtExit()
        {

        }

        public void TicketValidated()
        {

        }

        public void CarEnteredCarPark()
        {

        }

        public bool IsFull()
        {
            if (currentSpaces == maxSpaces)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (currentSpaces == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool HasSpace()
        {
            if (currentSpaces < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetCurrentSpaces()
        {

        }

    }
}
