
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEstimation
{
    class Program
    {

        static void Main(string[] args)
        {


            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            const Double eigenphaseValue = 0.344;


            System.Console.WriteLine("Phase Estimation checking  Likelihood ");
            GetPhaseEstimationIteration.Run(sim).Wait();


            System.Console.WriteLine("Bayesian Phase Estimation w/ Explicit Grid:");
            var estimate = GetBayesianPhaseEstimation.Run(sim, eigenphaseValue).Result;
            System.Console.WriteLine($"Expected value {eigenphaseValue}, estimated value {estimate}.");


            

        }
    }
}
