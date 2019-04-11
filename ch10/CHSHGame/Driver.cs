
namespace QuantumGame
{
    using System;
    using Microsoft.Quantum.Simulation.Simulators;

    /// <summary>
    /// Driver class
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Command Line parameters.</param>
        static void Main(string[] args)
        {
            const int trialCount = 10000;
            Random generator = new Random();
            using (QuantumSimulator sim = new QuantumSimulator())
            {
                int classicalWinCount = 0;
                int quantumWinCount = 0;
                for (int i = 0; i < trialCount; i++)
                {
                    bool aliceBit = GetRandomBitGenerator(generator);
                    bool bobBit = GetRandomBitGenerator(generator);
                    bool aliceMeasuresFirst = GetRandomBitGenerator(generator);
                    bool classicalXor =
                        !ExecuteClassicalStrategy(aliceBit, bobBit);
                    bool quantumXor =
                        !PlayQuantumGame.Run(
                            sim,
                            aliceBit,
                            bobBit,
                            aliceMeasuresFirst).Result;

                    if ((aliceBit && bobBit) == classicalXor)
                    {
                        classicalWinCount++;
                    }

                    if ((aliceBit && bobBit) == quantumXor)
                    {
                        quantumWinCount++;
                    }
                }

                Console.WriteLine(
                    "Classical success percentage: "
                    + classicalWinCount / (float)trialCount);
                Console.WriteLine(
                    "Quantum success percentage: "
                    + quantumWinCount / (float)trialCount);

                if (quantumWinCount > classicalWinCount)
                {
                    Console.WriteLine("The quantum success greater : the classical success percentage!");
                }
            }
        }

        /// <summary>
        /// gets a single random bit.
        /// </summary>
        /// <param name="generator"> Random number generator</param>
        /// <returns>A single random bit.</returns>
        private static bool GetRandomBitGenerator(Random generator)
        {
            int next = generator.Next();
            return (next & 1) == 1;
        }

        /// <summary>
        /// Execute Classical Strategy
        /// </summary>
        /// <param name="aliceBit">Alice Bit</param>
        /// <param name="bobBit">Bob Bit</param>
        /// <returns>check if Alice and Bob bits match.</returns>
        private static bool ExecuteClassicalStrategy(bool aliceBit, bool bobBit)
        {
            bool aliceOutput = false;
            bool bobOutput = false;
            return aliceOutput == bobOutput;
        }
    }
}
