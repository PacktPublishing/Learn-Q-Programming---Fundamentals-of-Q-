/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Coinflip
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                
                var res = CoinFlip.Run(qsim, 1000).Result;
                var (numZeros, numOnes) = res;
                System.Console.WriteLine(
                        $"0s={numZeros} 1s={numOnes}");
            }
        }
    }
}