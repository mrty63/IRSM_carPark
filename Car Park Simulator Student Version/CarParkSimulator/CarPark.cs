using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        //attributes
        int currentSpcaces;
        int maxSpace;
        EntrySensor entrySensor;
        ExitSensor exitSensor;
        TicketMachine ticketMachine;
        TicketValidator ticketValidator;
        FullSign fullsign;
        Barrier entryBarrier;
        Barrier exitBarrier;
        //constructor
        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullsign, Barrier entryBarrier, Barrier exitBarrier)
        {
            maxSpace = 10;
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullsign = fullsign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
        }

        //functions
        public void CarArrivedAtEntrance()
        {
            entrySensor.CarDetected();
            ticketMachine.GetMessage();
        }
        public void CarArrivedAtExit()
        {

        }
        public void CarEnteredCarPark()
        {

        }
        public void CarExitedCarPark()
        {

        }
        public int GetCurrentSpaces()
        {
            return currentSpcaces;
        }
        public bool HasSpace()
        {
            if (currentSpcaces < maxSpace)
            return true;
            else 
            return false;
        }
        public bool IsFull()
        {
            if (HasSpace() == false)
                return true;
            else
                return false;

        }
        public void TicketDispensed()
        {

        }
        public void TicketValidated()
        {

        }
    }
}
