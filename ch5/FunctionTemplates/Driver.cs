/////////////////////////////////////////////////////////////////////
// This file contains the driver  and ParameterizedTypes class.
//////////////////////////////////////////////////////////////////////
using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Hello
{
    class Driver
    {
        static void Main(string[] args)
        {

            ParameterizedTypes<string> name = new ParameterizedTypes<string>();
            name.value = "Parameterized Types";

            ParameterizedTypes<float> version = new ParameterizedTypes<float>();
            version.value = 7.0F;

            Console.WriteLine(name.value);

            Console.WriteLine(version.value);
        }
    }



    public class ParameterizedTypes<T>
    {

        private T data;

        public T value
        {

            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }

}
