namespace DepthChecker
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Testing;

    
    /// ExecuteCCNOTGate Operation
    /// # Summary
    /// executes CCNOT Gate
    /// # Parameters
    /// # Returns
    /// unit
   operation ExecuteCCNOTGate() : Unit {
    body (...) {
        using (qubits = Qubit[3]) {
            CCNOT(qubits[0], qubits[1], qubits[2]);
            T(qubits[0]);
        }
    }
  }
   

    
}
