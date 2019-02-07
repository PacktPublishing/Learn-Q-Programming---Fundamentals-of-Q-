/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace ForLoops
{    class Driver
    {
        static void Main(string[] args)
        {
          for (int i = 1; i < 10; i++)
            {
                if (i == 3)
                {
                    goto printNumber;
                }
                Console.WriteLine("i value: {0}", i);
            }
            printNumber: Console.WriteLine("The end");
        }
    }
}