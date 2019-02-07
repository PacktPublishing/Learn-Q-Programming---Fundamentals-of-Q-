/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace IfCondition
{    class Driver
    {
        static void Main(string[] args)
        {
          int x = 30, y = 25;
            if (x >= 30)
            {
                Console.WriteLine("x is Greater than 30");
            }
            if (y <= 25)
            {
                Console.WriteLine("y is less than or equals to 25");
            }
        }
    }
}