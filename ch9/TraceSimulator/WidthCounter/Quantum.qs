namespace WidthCounter
{
    open Microsoft.Quantum.Primitive;
   


    
    /// GetWidthCounter Operation
    /// # Summary
    /// executes X Gate
    /// # Parameters
    /// numberOfQubits 
    /// # Returns
    /// unit

operation GetWidthCounter( numberOfQubits : Int ) : Unit {
    body (...) {
        using(qubits = Qubit[numberOfQubits]) {
            Controlled X (qubits[1 .. numberOfQubits - 1], qubits[0]);
        } 
    }

}
   

    
}
