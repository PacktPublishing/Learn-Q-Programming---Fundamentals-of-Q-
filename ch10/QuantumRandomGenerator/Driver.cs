/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumRandomGenerator
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {

                var upperLimit = 15;
                var nbits = (long)Math.Floor(Math.Log(999, 2)) + 1;

                for (int j = 0; j < 50; j++)
                {
                    var res = GenerateRandomness.Run(qsim, nbits).Result;
                    var (numZeros, numOnes) = res;
                    double ones = numZeros;
                    double zeros = numOnes;
                    double randomness = ones / (zeros + ones);
                    var randomNumber = (long)Math.Floor(randomness * upperLimit);
                    System.Console.WriteLine(" less than 15 randomNumber " + randomNumber);
                }
            }
        }
    }
}