using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {       
        //attributes
        int currentSpaces;
        int maxSpaces = 5;
        EntrySensor entrySensor;
        ExitSensor exitSensor;
        TicketMachine ticketMachine;
        TicketValidator ticketValidator;
        FullSign fullsign;
        Barrier entryBarrier;
        Barrier exitBarrier;
        List<Ticket> tickets;
        //constructor
        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullsign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullsign = fullsign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
        }

        public void CarArrivedAtEntrance()
        {
            entrySensor.CarDetected();
            ticketMachine.GetMessage();
        }

        public void TicketDispensed()
        {
            ticketMachine.CarArrived();
            ticketMachine.PrintTicket();
            ticketMachine.GetMessage();
            entryBarrier.Raise();

        }

        public void CarEnteredCarPark()
        {
            entrySensor.CarLeftSensor();
            if (IsFull() == true)
                fullsign.SetLit();
            entryBarrier.Lower();
            currentSpaces++;
        }
        public void CarExitedCarPark()
        {
            exitSensor.CarLeftSensor();
            if (fullsign.isLit() == true)   fullsign.SetLit();
            exitBarrier.Lower();
        }

        public void CarArrivedAtExit()
        {
            exitSensor.CarDetected();
            ticketMachine.GetMessage();
        }

        public void TicketValidated()
        {
            ticketValidator.CarArrived();
            ticketValidator.GetMessage();
            ticketValidator.TicketEntered();
            exitBarrier.Raise();
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
            if (IsFull() == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }

    }
}
