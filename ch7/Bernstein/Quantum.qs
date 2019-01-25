namespace Bernstein
{
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    
        
    
    
    // GetFourierSamplingParity Operation
    /// # Summary
    /// ParityViaFourierSampling implements the Bernstein-Vazirani quantum algorithm.
    /// # Parameters
    /// ## Uf
    /// A quantum operation that implements |𝑥〉|𝑦〉 ↦ |𝑥〉|𝑦 ⊕ 𝑓(𝑥)〉,
    /// where 𝑓 is a Boolean function that implements a parity Σᵢ 𝑟ᵢ 𝑥ᵢ.
    /// ## n
    /// The number of bits of the input register |𝑥〉.
    ///
    /// # Returns
    /// An array of type `Bool[]` that contains the parity 𝑟⃗ = (𝑟₀, …, 𝑟ₙ₋₁).
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
    ///  an operation implementing a unitary 𝑈 
    /// # Parameters
    /// ## pattern
    /// The bitstring 𝑟⃗ used to define the function 𝑓.
    ///
    /// # Returns
    /// An operation implementing 𝑈.
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

