namespace DeutschJozsaAlgorithm
{


    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;






    /// IsConstantBooleanFunction Operation
    /// # Summary
    /// checks if the function is a constant boolean type
    ///
    /// # Parameters
    /// ## Uf
    /// An unitary operation
    /// ## n
    /// The count of bits
    ///
    /// # Return
    /// A boolean value
   operation CheckConstantBooleanFunction (Uf : (Qubit[] => Unit), n : Int) : Bool {


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


        return ForAll(IsResultZero, resultArray);
    }




    // ExecuteDeutschJozsaAlgorithm Operation
    operation ExecuteDeutschJozsaAlgorithm (nQubits : Int, markedElements : Int[]) : Bool {

        return CheckConstantBooleanFunction(GetBooleanFunctionFromMarkedElements(nQubits, markedElements), nQubits);
    }

    // GetBooleanFunctionFromMarkedElementsImpl Operation
    operation GetBooleanFunctionFromMarkedElementsImpl (n : Int, markedElements : Int[], qs : Qubit[]) : Unit {

       let target = qs[Length(qs) - 1];
       let inputs = qs[0 .. Length(qs) - 2];


       let nMarked = Length(markedElements);

       for (idxMarked in 0 .. nMarked - 1) {


           (ControlledOnInt(markedElements[idxMarked], ApplyToEachCA(X, _)))(inputs, [target]);
       }
   }



   /// GetBooleanFunctionFromMarkedElements Function
   /// # Summary
   ///  creates a  boolean function
   /// # Parameters
   /// ## nQubits
   /// The count of qubits
   /// ## markedElements
   /// marked Elements array
   /// # Return
   /// An unitary operation
   function GetBooleanFunctionFromMarkedElements (nQubits : Int, markedElements : Int[]) : (Qubit[] => Unit) {

       return GetBooleanFunctionFromMarkedElementsImpl(nQubits, markedElements, _);
   }








}
