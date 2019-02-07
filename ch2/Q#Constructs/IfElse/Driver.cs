/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace IfElse
{
    class Driver
    {
        static void Main(string[] args)
        {
            int x = 15;
            if (x == 20)
            {
                Console.WriteLine("x value equals to 20");
            }
            else if (x > 11)
            {
                Console.WriteLine("x value greater than 11");
            }
            else
            {
                Console.WriteLine("x value less than 11");
            }
        }
    }
}