namespace Bernstein
{

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;



    // GetFourierSamplingParity Operation
    /// # Summary
    /// Sampling algorithm of  type ParityViaFourier
    /// # Parameters
    /// ## Uf
    /// An operation
    /// ## n
    /// The number of bits
    /// # Returns
    /// A Bool[] typed array
    ///

    operation GetFourierSamplingParity (Uf : (Qubit[] => Unit), n : Int) : Bool[] {


        mutable resultArray = new Result[n];


        using (qubits = Qubit[n + 1]) {


            X(qubits[n]);


            ApplyToEach(H, qubits);


            Uf(qubits);


            ApplyToEach(H, qubits[0 .. n - 1]);


            for (idx in 0 .. n - 1) {
                set resultArray[idx] = MResetZ(qubits[idx]);
            }


            Reset(qubits[n]);
        }


        Message($"measure: {resultArray}");
        return BoolArrFromResultArr(resultArray);
    }


    // ExecuteParityImpl Operation

    operation ExecuteParityImpl (pattern : Bool[], qs : Qubit[]) : Unit {

        let n = Length(pattern);

        if (Length(qs) != n + 1) {
            fail "Length of qs should be equal to pattern length + 1.";
        }

        for (idx in 0 .. n - 1) {

            if (pattern[idx]) {
                Controlled X([qs[idx]], qs[n]);
            }
        }
    }


    /// ExecuteParity function
    /// # Summary
    ///  an unitary operation
    /// # Parameters
    /// ## pattern
    /// The bitstring
    /// # Returns
    /// An unitary operation
    function ExecuteParity (pattern : Bool[]) : (Qubit[] => Unit) {

        return ExecuteParityImpl(pattern, _);
    }


    // ExecuteBernsteinVaziraniAlgorithm Operation
    operation ExecuteBernsteinVaziraniAlgorithm (nQubits : Int, patternInt : Int) : Int {

        let pattern = BoolArrFromPositiveInt(patternInt, nQubits);
        let result = GetFourierSamplingParity(ExecuteParity(pattern), nQubits);
        return PositiveIntFromBoolArr(result);
    }
}
