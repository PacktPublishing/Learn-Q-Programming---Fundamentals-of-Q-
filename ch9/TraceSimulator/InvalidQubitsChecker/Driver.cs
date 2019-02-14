/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////

using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.QCTraceSimulatorRuntime;
using Microsoft.Quantum.Extensions.Diagnostics;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;
using System.Diagnostics;

namespace InvalidQubitsChecker
{
    class Driver
    {
        static void Main(string[] args)
        {
            var config = new QCTraceSimulatorConfiguration();
            

            config.throwOnUnconstraintMeasurement = false;
            config.useInvalidatedQubitsUseChecker = true;
    

            
            QCTraceSimulator qsim = new QCTraceSimulator(config);

            var res =  CheckForReleasedQubit.Run(qsim).Result;
        

        }
    }
}
