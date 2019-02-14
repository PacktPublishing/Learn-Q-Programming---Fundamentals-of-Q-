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

namespace DepthChecker
{
    class Driver
    {
        static void Main(string[] args)
        {
            var config = new QCTraceSimulatorConfiguration();
            
                       config.useDepthCounter = true;
    

            
            QCTraceSimulator qsim = new QCTraceSimulator(config);
            

            
            var res =  ExecuteCCNOTGate.Run(qsim).Result;
        
            
            double tDepthAll = qsim.GetMetric<ExecuteCCNOTGate>(DepthCounter.Metrics.Depth);

            System.Console.WriteLine(tDepthAll);
        }
    }
}
