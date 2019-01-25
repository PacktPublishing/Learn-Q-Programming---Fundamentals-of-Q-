/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;


namespace DeutschJozsaAlgorithm
{
    class Driver
    {
     

        static void Main(string[] args)
        {
           
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

           
           

            
            var balancedTestCase = new QArray<long> { 1, 2 }; 
            if (ExecuteDeutschJozsaAlgorithm.Run(sim, 2, balancedTestCase).Result)
            {
                throw new Exception("Both the test cases  are constant!");
            }

            var constantTestCase = new QArray<long> { 0, 1, 2, 3, 4, 5, 6, 7 };
            if (!ExecuteDeutschJozsaAlgorithm.Run(sim, 3, constantTestCase).Result)
            {
                throw new Exception("All test cases are balanced!");
            }
            System.Console.WriteLine("constant and balanced functions - success");

           
           

          

        }
    }
}
