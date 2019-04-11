/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Core;

namespace Factoring
{
    /// <summary>
    /// This is a Driver program for factoring numbers 
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            
            long numberToFactor = 45;
            long nTrials = 100;
            bool useRobustPhaseEstimation = true;

           
            for (int i = 0; i < nTrials; ++i)
            {
                try
                {
                    using (QuantumSimulator sim = new QuantumSimulator())
                    {
                        Console.WriteLine($"==========================================");
                        Console.WriteLine($"Number to be Factored {numberToFactor}");

                        (long factor1, long factor2) = 
                            Factoring.Run(sim, numberToFactor, useRobustPhaseEstimation).Result;

                        Console.WriteLine($"Factors of {numberToFactor}  are {factor1} and {factor2}");
                    }
                }
                catch (AggregateException e )
                {
                    Console.WriteLine($"Factorization of number has failed:");

                    foreach ( Exception eInner in e.InnerExceptions )
                    {
                        if (eInner is ExecutionFailException failException)
                        {
                            Console.WriteLine($"   {failException.Message}");
                        }
                    }
                }
            }
        }
    }
}