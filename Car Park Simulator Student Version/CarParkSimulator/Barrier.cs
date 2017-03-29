using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        private bool lifted = false;

        void Lower()
        {
            lifted = false;
        }

        void Raise()
        {
            lifted = true;
        }

        bool isLifted()
        {
            return lifted;
        }
    }
}