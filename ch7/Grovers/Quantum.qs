namespace Grovers
{

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    // GetDataFromInts Operation
    /// # Summary
    /// creates a Database oracle
    ///
    /// # Parameters
    /// ## markedElements
    /// marked Elements array
    /// ## markedQubit
    /// marked Qubit
    /// ## databaseRegister
    /// qubits register having n elements
    /// # Returns
    /// an Unit

    operation GetDataFromInts(markedElements : Int[],  markedQubit: Qubit, databaseRegister: Qubit[]) : Unit
    {
        body(...) {
            let nMarked = Length(markedElements);
            for (idxMarked in 0..nMarked - 1) {
                (ControlledOnInt(markedElements[idxMarked], ApplyToEachCA(X, _)))(databaseRegister, [markedQubit]);
            }

        }
        adjoint auto;
        controlled auto;
        adjoint controlled auto;
    }

    // SetupGroverStateOracle Operation
    /// # Summary
    /// GroverState Oralce is setup by this operation
    ///
    /// # Parameters
    /// ## markedElements
    /// makred Elements array
    /// ## idxMarkedQubit
    /// MarkedQubit index
    /// ## startQubits
    /// start Qubits array
    /// # Returns
    /// an Unit
    operation SetupGroverStateOracleImpl(markedElements : Int[], idxMarkedQubit: Int , startQubits: Qubit[]) : Unit
    {
        body(...) {
            let flagQubit = startQubits[idxMarkedQubit];
            let databaseRegister = Exclude([idxMarkedQubit], startQubits);

            ApplyToEachCA(H, databaseRegister);

            GetDataFromInts(markedElements, flagQubit, databaseRegister);

             }

        adjoint auto;
        controlled auto;
        adjoint controlled auto;
    }

    // setupGroverStateOracle function
    /// # Summary
    /// GroverState Oralce is setup by this operation
    ///
    /// # Parameters
    /// ## markedElements
    /// makred Elements array
    /// ## idxMarkedQubit
    /// MarkedQubit index
    /// ## startQubits
    /// start Qubits array
    /// # Returns
    /// State Oracle
    function SetupGroverStateOracle(markedElements : Int[]) : StateOracle
    {
        return StateOracle(SetupGroverStateOracleImpl(markedElements, _, _));
    }

    // Execute Search function
    /// # Summary
    /// function which has Grover's search technique
    /// # Parameters
    /// ## markedElements
    /// markedElements array
    /// ## nIterations
    /// Count of Grover iterations
    /// ## idxMarkedQubit
    ///  MarkedQubit Index
    /// # Returns
    /// Unitary  Operation

    function ExecuteSearch( markedElements: Int[], nIterations: Int, idxMarkedQubit: Int) : (Qubit[] => Unit : Adjoint, Controlled)
    {
        return AmpAmpByOracle(nIterations, SetupGroverStateOracle(markedElements), idxMarkedQubit);
    }

    // Execute Search function
    /// # Summary
    /// function which has Grover's search technique
    /// # Parameters
    /// ## markedElements
    /// markedElements array
    /// ## nIterations
    /// Count of Grover iterations
    /// ## idxMarkedQubit
    ///  MarkedQubit Index
    /// # Returns
    /// Result and count of elements
    operation ExecuteGroversAlgorithm( markedElements: Int[], nIterations : Int, nDatabaseQubits : Int) : (Result,Int) {
        body(...){

            mutable resultSuccess = Zero;
            mutable numberElement = 0;

            using (qubits = Qubit[nDatabaseQubits+1]) {


                let markedQubit = qubits[0];


                let databaseRegister = qubits[1..nDatabaseQubits];


                (ExecuteSearch( markedElements, nIterations, 0))(qubits);


                set resultSuccess = M(markedQubit);


                let resultElement = MultiM(databaseRegister);

                set numberElement = PositiveIntFromResultArr(resultElement);


                ResetAll(qubits);
            }

            return (resultSuccess, numberElement);
        }
    }
}
