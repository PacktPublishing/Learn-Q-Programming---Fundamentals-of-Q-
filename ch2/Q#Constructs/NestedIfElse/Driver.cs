/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace NestedIfElse
{
    class Driver
    {
        static void Main(string[] args)
        {
            int x = 15, y = 25;
            if (x > y)
            {
                if (x >= 11)
                {
                    Console.WriteLine("x value greater than or equal to 11");
                }
                else
                {
                    Console.WriteLine("x value less than 11");
                }
            }
            else
            {
                if (y <= 21)
                {
                    Console.WriteLine("y value less than or equal to 21");
                }
                else
                {
                    Console.WriteLine("y value greater than 21");
                }
            }
        }
    }

}