/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Empty
{
    class Driver
    {
        public bool printNumber()
        {
            Console.WriteLine("3");
            return true;
        }
        static void Main(string[] args)
        {
            int i = 0;
            Driver program = new Driver();
            while (program.printNumber())
            {
                ;
            }
            Console.WriteLine("The value of i  is {0}", i);
        }
    }
}