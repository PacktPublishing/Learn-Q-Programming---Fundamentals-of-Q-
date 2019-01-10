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
                System.Console.WriteLine("Product of 6 and 8 is");
                var result = GetProduct.Run(qsim,6,8).Result;
                System.Console.WriteLine(result);
            }
        }
    }
}
