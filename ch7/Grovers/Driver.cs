/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////


using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Grovers
{
    class Driver
    {
        static void Main(string[] args)
        {

            int successfulCnt = ExecuteSearchAlgorithm(100,20);
            successfulCnt = ExecuteSearchAlgorithm(100, 3);
            successfulCnt = ExecuteSearchAlgorithm(100, 2);
            successfulCnt = ExecuteSearchAlgorithm(100, 1);
            successfulCnt = ExecuteSearchAlgorithm(100, 0);

        }

        static int ExecuteSearchAlgorithm(int repeats, int groverIterations)
        {
            int successfulCount = 0;

            using (var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true))
            {

                int nDatabaseQubits = 8;
                var databaseSize = Math.Pow(2.0, nDatabaseQubits);

                QArray<long> markedElements = new QArray<long>() {23};//{ 0, 39, 101, 234 }};


                int nIterations = groverIterations;

                for (int i = 0; i < repeats; ++i)
                {

                    var task = ExecuteGroversAlgorithm.Run(sim, markedElements, nIterations, nDatabaseQubits);

                    var result = task.Result;

                    if (result.Item1 == Result.One)
                    {
                        successfulCount++;
                    }
                }
            }

            Console.WriteLine(
                $"Grover algorithm  iteration {groverIterations}: {successfulCount} of {repeats} consists of the desired result.");
            return successfulCount;
        }
    }
}
