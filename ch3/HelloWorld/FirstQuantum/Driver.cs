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

                HelloWorld.Run(qsim).Wait();

            }
        }
    }
}