/////////////////////////////////////////////////////////////////////
// This file contains the driver and MyClass class.
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

            MyClass myClass = new MyClass();
            myClass.PrintSquareRoot();

        }
        class MyClass  
        {  
      [Obsolete("Use method PrintSquareRootLatest",true)]  
      public void PrintSquareRoot(){ Console.WriteLine("SquareRoot of 4 is 2");}  
      public void PrintSquareRootLatest(){ Console.WriteLine("SquareRoot of 4 is 2");}  
}
    }
}
