using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement
{
    class Program
    {
        static void Main(string[] args)
        {

            var simulator = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);
                      
            foreach (var idxMeasure in Enumerable.Range(0, 8))
            {
                var res = GetMeasurementTwoQubits.Run(simulator).Result;
                System.Console.WriteLine($"Measured hadmard and pauliZ : observed values {res}.");
            }


            foreach (var idxMeasure in Enumerable.Range(0, 8))
            {
                var res = GetMeasurementBellBasis.Run(simulator).Result;
                System.Console.WriteLine($"Measured CNOT and Hadmard gates : observed values {res}.");
            }

        }
    }
}
