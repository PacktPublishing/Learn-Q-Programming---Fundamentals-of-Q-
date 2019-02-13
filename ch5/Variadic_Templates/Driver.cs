/////////////////////////////////////////////////////////////////////
// This file contains the driver and Container class.
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

            Container listContainer = new Container() {
              () => new List<byte>()

          };
            Container memoryContainer = new Container() {
        () => new MemoryStream()
         };
            Container credentialContainer = new Container() {

              () => new CredentialCache()
             };
            Console.WriteLine(listContainer + "Type " + listContainer.GetType());
            Console.WriteLine(memoryContainer + "Type " + memoryContainer.GetType());
            Console.WriteLine(credentialContainer + "Type " + credentialContainer.GetType());
        }

    }
    class Container : System.Collections.IEnumerable
    {
        public void Add<T>(Func<T> func)
        {

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException();
        }
    }


}
