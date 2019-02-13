/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Hello
{
    class Driver
    {
        public static void ParameterFunction()
        {
            Console.WriteLine("Invoked by Delegate");
        }
        static void Main(string[] args)
        {

            TestFunctionObject testFunction = new TestFunctionObject(ParameterFunction);
            testFunction();

        }

    }




    public delegate void TestFunctionObject();
}
