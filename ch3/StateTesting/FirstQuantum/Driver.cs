/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace FirstQuantum
{
    class Driver
    {
        static void Main(string[] args)
        {
          using (var qsim = new QuantumSimulator())
                      {
                          Result[] results = new Result[] { Result.Zero, Result.One };
                          foreach (Result result in results)
                          {
                              var res = StateTest.Run(qsim, 1000, result).Result;
                              var (numZeros, numOnes) = res;
                              System.Console.WriteLine(
                              $"Init:{result,-4} 0s={numZeros,-4} 1s={numOnes,-4}");
                          }
                      }
          }
      }
}
