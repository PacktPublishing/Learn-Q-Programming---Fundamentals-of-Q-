/////////////////////////////////////////////////////////////////////
// This file contains the driver class.
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Hello
{
    class Driver
    {

        static void Main(string[] args)
        {

            FunctionTemplates p = new FunctionTemplates();

            p.Show<int>("Integer", 10);
            p.Show<char>("Character", 'E');
            p.Show<double>("Decimal", 231.78);
        }

    }
    public class FunctionTemplates
    {

        public void Show<TypeOfValue>(string message, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", message, value);
        }
    }


}
