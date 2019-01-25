namespace Grovers
{

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    // GetDataFromInts Operation 
    /// # Summary
    /// Database oracle `D` constructed from classical database.
    /// 
    /// # Parameters
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## markedQubit
    /// Qubit that indicated whether database element is marked.
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    /// 

    operation GetDataFromInts(markedElements : Int[],  markedQubit: Qubit, databaseRegister: Qubit[]) : Unit
    {
        body(...) {
            let nMarked = Length(markedElements);
            for (idxMarked in 0..nMarked - 1) {
                // Note: As X accepts a Qubit, and ControlledOnInt only 
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts 
                // Qubit[] even though the target is only 1 Qubit.
                (ControlledOnInt(markedElements[idxMarked], ApplyToEachCA(X, _)))(databaseRegister, [markedQubit]);
            }

        }	
        adjoint auto;
        controlled auto;
        adjoint controlled auto;
    }

    // SetupGroverStateOracle Operation
    /// # Summary
    /// Preparation of start state from database oracle and oracle `U` that 
    /// creates a uniform superposition over database indices.
    /// 
    /// # Parameters
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## idxMarkedQubit
    /// Index to `MarkedQubit`.
    /// ## startQubits
    /// The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`
    /// initially in the |00…0〉 state.
    /// 
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

    /// # Summary
    /// `StateOracle` type for the preparation of a start state that has a 
    /// marked qubit entangled with some desired state in the database 
    /// register.
    ///
    /// # Parameters
    /// ## markedElements
    /// Indices to marked elements in database.
    ///
    /// # Returns
    /// A `StateOracle` type with signature 
    /// ((Int, Qubit[]) => (): Adjoint, Controlled).
    function SetupGroverStateOracle(markedElements : Int[]) : StateOracle
    {
        return StateOracle(SetupGroverStateOracleImpl(markedElements, _, _));
    }

    // Execute Search function
    /// # Summary
    /// Grover's search algorithm using library functions.
    ///
    /// # Parameters
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## nIterations
    /// Number of iterations of the Grover iteration to apply.
    /// ## idxMarkedQubit
    /// Index to `MarkedQubit`.
    ///
    /// # Returns
    /// Unitary implementing Grover's search algorithm.
    ///
 
    function ExecuteSearch( markedElements: Int[], nIterations: Int, idxMarkedQubit: Int) : (Qubit[] => Unit : Adjoint, Controlled)
    {
        return AmpAmpByOracle(nIterations, SetupGroverStateOracle(markedElements), idxMarkedQubit);
    }
    
    // ExecuteGroversAlgorithm Operation
    /// # Summary
    /// Performs quantum search for the marked elements and returns an index
    /// to the found element in integer format. 
    ///
    /// # Parameters
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## nIterations
    /// Number of applications of the Grover iterate (RS · RM).
    /// ## nDatabaseQubits
    /// Number of qubits in the database register. 
    ///
    /// # Returns
    /// Measurement outcome of marked Qubit and measurement outcomes of 
    /// the database register converted to an integer.
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


