/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace NestedSwitch
{
    class Driver
    {
        static void Main(string[] args)
        {
            int x = 11, y = 15;
            switch (x)
            {
                case 9:
                    Console.WriteLine("X Value: 9");
                    switch(y){
                        case 6:
                            Console.WriteLine("Nested Switch Value: 6");
                            switch (y - 2) {
                                case 3:
                                    Console.WriteLine("Another Nested Switch Value: 3");
                                    break;
                            }
                            break;
                    }
                    break;
               case 12:
                    Console.WriteLine("X Value: 12");
                    break;
                case 20:
                    Console.WriteLine("X Value: 20");
                    break;
               default:
                    Console.WriteLine("Not Handled");
                    break;
            }
        }
    }

}