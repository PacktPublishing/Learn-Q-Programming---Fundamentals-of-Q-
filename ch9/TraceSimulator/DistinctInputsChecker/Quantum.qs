namespace DistinctIputsChecker
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Testing;

    
    /// ExecuteTwoOperations operation
    /// # Summary
    /// executes the two operations
    /// # Parameters
    /// ## q1
    /// first qubit
    /// ## q2
    /// second qubit
    /// ## op1
    /// first operation
    /// ## op2
    /// second operation
    ///
    /// # Returns
    /// unit

 operation ExecuteTwoOperations( q1 : Qubit, q2 : Qubit, op1 : (Qubit => Unit), op2 : (Qubit => Unit)) : Unit {
    body (...) {
        op1(q1);
        op2(q2);
    }
}
    /// CheckDistinctInputs Operation
    /// # Summary
    /// Checks Distinct Inputs
    /// # Parameters
    /// # Returns
    /// unit
  operation CheckDistinctInputs () : Unit {
    body (...) {
        using( q = Qubit[3] ) {
            let op1 = CNOT(_, q[1]);
            let op2 = CNOT(q[1], _);
            ExecuteTwoOperations(q[0], q[2], op1, op2);
        }
    }
}
   

    
}
