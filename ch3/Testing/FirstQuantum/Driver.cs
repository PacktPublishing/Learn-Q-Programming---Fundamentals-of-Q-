using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace FirstQuantum
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator(randomNumberGeneratorSeed: 31))
            {
                
                Result[] initials = new Result[] { Result.Zero, Result.One };
                foreach (Result initial in initials)
                {
                    var res = StateTest.Run(qsim, 1000, initial).Result;
                    var (numZeros, numOnes,agree) = res;
                    System.Console.WriteLine(
                        $"Init:{initial,-4} 0s={numZeros,-4} 1s={numOnes,-4} agree={agree,-4}");
                }
            }
        }
    }
}