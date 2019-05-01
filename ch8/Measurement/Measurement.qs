namespace Measurement {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    
    

    
    
    
    operation GetMeasurementTwoQubits () : (Result, Result) {
        
        mutable result = (Zero, Zero);
        
        using (qubits = Qubit[2]) {
            
            ApplyToEach(H, qubits);
            
            AssertProb([PauliZ], [qubits[0]], Zero, 0.5, "Error: Outcomes of the measurement must be equally likely", 1E-05);
            
            AssertProb([PauliZ], [qubits[1]], Zero, 0.5, "Error: Outcomes of the measurement must be equally likely", 1E-05);
            
            set result = (MResetZ(qubits[0]), MResetZ(qubits[1]));
        }
        
        return result;
    }
    
    
    operation GetMeasurementBellBasis () : (Result, Result) {
        
        mutable result = (Zero, Zero);
        
        using (qubits = Qubit[2]) {
            
            let qubit0 = qubits[0];
            let qubit1 = qubits[1];
            H(qubit0);
            CNOT(qubit0, qubit1);
            
            Assert([PauliZ, PauliZ], qubits, Zero, "Error: EPR state must be eigenstate of ZZ");
            Assert([PauliX, PauliX], qubits, Zero, "Error: EPR state must be eigenstate of XX");
            AssertProb([PauliZ, PauliZ], qubits, One, 0.0, "Error: 01 or 10 should never occur as an outcome", 1E-05);
            
            set result = (M(qubit0), M(qubit1));
            
            ResetAll(qubits);
        }
        
        return result;
    }
    
}


