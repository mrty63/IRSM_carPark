using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        private bool lit;

        public FullSign()
        {
            lit = false;
        }

        private bool isLit()
        {
            return lit;
        }

        private void SetLit()
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
