using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        private bool lit = false;

        bool isLit()
        {
            return lit;
        }

        void SetLit()
        {
            if (lit == true)
            {
                lit = false;
            }
            else
            {
                lit = true;
            }
        }
    }
}
