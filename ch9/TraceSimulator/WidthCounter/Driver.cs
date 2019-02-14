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

namespace WidthCounter
{
    class Driver
    {
        static void Main(string[] args)
        {
            var config = new QCTraceSimulatorConfiguration();


            config.throwOnUnconstraintMeasurement = false;
            config.useWidthCounter = true;



            QCTraceSimulator qsim = new QCTraceSimulator(config);
            int totalQubits = 5;



            var res = GetWidthCounter.Run(qsim, totalQubits).Result;

            string csvSummary = qsim.ToCSV()[MetricsCountersNames.widthCounter];

            System.Console.WriteLine(csvSummary);



        }
    }
}
