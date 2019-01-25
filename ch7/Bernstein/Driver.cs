/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Bernstein
{
    class Driver
    {
     

        static void Main(string[] args)
        {
           
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

           
           

            
            const int nQubits = 4;
            foreach (var parity in Enumerable.Range(0, 1 << nQubits))
            {
                var measuredParity = ExecuteBernsteinVaziraniAlgorithm.Run(sim, nQubits, parity).Result;
                if (measuredParity != parity)
                {
                    throw new Exception($"Measured parity {measuredParity}, but expected {parity}.");
                }
            }

            System.Console.WriteLine("All parities are measured!");

           
           

          

        }
    }
}
