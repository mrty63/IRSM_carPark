using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor : Sensor
    {
        public ExitSensor(CarPark carPark) : base(CarPark carPark)   // constructor also calls parent (base) constructor
        {// this function instantiates the ExitSensor:Sensor class
            carOnSensor = false;
        }
        /*
        public override bool CarDetected()
        {
            if (carOnSensor == true)
                return true;
            else
                return false;
        }
        */

        public override void CarDetected()
        {
            carOnSensor = true;
        }

        public override void CarLeftSensor()
        {
            carOnSensor = false;
        }
    }
}
