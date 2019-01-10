using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Hello
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                System.Console.WriteLine("Sum of 4 and 5 is");

                var result = GetSum.Run(qsim,4,5).Result;
                System.Console.WriteLine(result);
            }
        }
    }
}
