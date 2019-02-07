/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Switch
{
    class Driver
    {
        static void Main(string[] args)
        {
            int x = 11;
            switch (x)
            {
                case 9:
                    Console.WriteLine("x value is 9");
                    break;
                case 15:
                    Console.WriteLine("x value is 15");
                    break;
                case 21:
                    Console.WriteLine("x value is 21");
                    break;
                default:
                    Console.WriteLine("is not handled");
                    break;
            }
        }
    }
}