/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////

using System;
using System.Linq;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;
using Microsoft.Quantum.Chemistry;
using Microsoft.Extensions.Logging;
using System.Diagnostics;


namespace Chemistry
{

    class Driver
    {

        static void Main(string[] args)
        {
            var logger = Logging.LoggerFactory.CreateLogger<Driver>();




            string LiquidFilename = "h2o.dat";

            var numElectrons = 2;


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            logger.LogInformation($"Reading {LiquidFilename}");
            var generalHamiltonian = FermionHamiltonian.LoadFromLiquid($@"{LiquidFilename}").Single();
            generalHamiltonian.NElectrons = numElectrons;
            logger.LogInformation($"The loading of the file took {stopWatch.ElapsedMilliseconds}ms");
            stopWatch.Restart();


            generalHamiltonian.LogSpinOrbitals();


            var jwEncoding = JordanWignerEncoding.Create(generalHamiltonian);


            jwEncoding.LogSpinOrbitals();

            logger.LogInformation(" reading the file is complete");


            using (var qsim = new QuantumSimulator())
            {
                var qSData = jwEncoding.QSharpData();


                var bits = 10;


                var steps = 5;


                var trotterStep = .4;




                    for (int i = 0; i < steps; i++)
                    {
                        var (phaseEstimate, energyEstimate) = TrotterEnergyEstimator.Run(qsim, qSData, bits, trotterStep).Result;
                        logger.LogInformation($"Trotter estimation. phase: {phaseEstimate}; energy {energyEstimate}");
                    }


                    for (int i = 0; i < steps; i++)
                    {
                        var (phaseEstimate, energyEstimate) = OptimizedTrotterEnergyEstimator.Run(qsim, qSData, bits - 1, trotterStep).Result;
                        logger.LogInformation($"Optimized Trotter estimation. phase {phaseEstimate}; energy {energyEstimate}");
                    }

                    for (int i = 0; i < steps; i++)
                    {
                        var (phaseEstimate, energyEstimate) = QubitizationEnergyEstimator.Run(qsim, qSData, bits - 2).Result;
                        logger.LogInformation($"Qubitization estimation. phase: {phaseEstimate}; energy {energyEstimate}");
                    }

                
            }


        

        }
    }
}
