
namespace QuantumGame
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    /// MeasureQbitOfAlice Operation

    /// # Summary

    /// measures Alice Qbit

    /// # Parameters

    /// ## bit

    /// boolean value

    /// ## qubit

    /// Qubit

    /// # Return

    /// Result
  
    operation MeasureQbitOfAlice(bit : Bool, qubit : Qubit) : Result
    {
        if (bit)
        {
            
            return Measure([PauliX], [qubit]);
        }
        else
        {
            
            return Measure([PauliZ], [qubit]);
        }
    }


    /// MeasureQbitOfBob Operation

    /// # Summary

    /// measures Bob Qbit

    /// # Parameters

    /// ## bit

    /// boolean value

    /// ## qubit

    /// Qubit

    /// # Return

    /// Result
    operation MeasureQbitOfBob(bit : Bool, qubit : Qubit) : Result
    {
        if (bit)
        {
            
            let rotation = 2.0 * PI() / 8.0;
            Ry(rotation, qubit);
            return M(qubit);
        }
        else
        {
            
            let rotation = -2.0 * PI() / 8.0;
            Ry(rotation, qubit);
            return M(qubit);
        }
    }


    /// PlayQuantumGame Operation

    /// # Summary

    /// checks if aliceBit equal to Bob bit

    /// # Parameters

    /// ## aliceBit

    /// boolean value

    /// ## bobBit

    /// boolean value
 
    /// ## aliceMeasuresFirst

    /// boolean value   

    /// # Return

    /// boolean value
    operation PlayQuantumGame(
        aliceBit : Bool,
        bobBit : Bool,
        aliceMeasuresFirst : Bool)
        : Bool
    {
        mutable aliceResult = Zero;
        mutable bobResult = Zero;

        using (qubits = Qubit[2])
        {
            
            let aliceQbit = qubits[0];
            let bobQbit = qubits[1];

           
            H(aliceQbit);
            CNOT(aliceQbit, bobQbit);

            
            if (aliceMeasuresFirst)
            {
                set aliceResult = MeasureQbitOfAlice(aliceBit, aliceQbit);
                set bobResult = MeasureQbitOfBob(bobBit, bobQbit);
            }
            else
            {
                set bobResult = MeasureQbitOfBob(bobBit, bobQbit);
                set aliceResult = MeasureQbitOfAlice(aliceBit, aliceQbit);
            }

            ResetAll(qubits);
        }

        return aliceResult == bobResult;
    }
}
