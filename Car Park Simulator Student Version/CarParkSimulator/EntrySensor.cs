using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor          // inherits from Sensor
    {
        public EntrySensor() : base()   // constructor also calls parent (base) constructor
        {// this function instantiates the EntrySensor:Sensor class
            carOnSensor = false;
        }

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