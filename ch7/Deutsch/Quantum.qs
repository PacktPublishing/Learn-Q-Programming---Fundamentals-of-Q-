namespace DeutschJozsaAlgorithm
{

    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    
    
    
    
    
    /// IsConstantBooleanFunction Operation 
    /// # Summary
    /// This operation returns the Boolean value `true` if the function is constant and `false` if it is not. Note
    /// that the promise that the function is either constant or balanced is assumed.
    ///
    /// # Parameters
    /// ## Uf
    /// A quantum operation that implements |𝑥〉|𝑦〉 ↦ |𝑥〉|𝑦 ⊕ 𝑓(𝑥)〉,
    /// where 𝑓 is a Boolean function, 𝑥 is an 𝑛 bit register and 𝑦 is a single qubit.
    /// ## n
    /// The number of bits of the input register |𝑥〉.
    ///
    /// # Return
    /// A boolean value `true` that indicates that the function is constant and `false`
    /// that indicates that the function is balanced.
    ///
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
   /// Constructs an operation representing a query to a boolean function
   /// # Parameters
   /// ## nQubits
   /// The number of qubits to be used in representing the query operation.
   /// ## markedElements
   /// An array of the elements {𝑘ᵢ} for which 𝑓 should return 1.
   ///
   /// # Return
   /// An operation representing the unitary 𝑈 |𝑧〉 |𝑘〉 = |𝑧 ⊕ 𝑥ₖ〉 |𝑘〉.
   function GetBooleanFunctionFromMarkedElements (nQubits : Int, markedElements : Int[]) : (Qubit[] => Unit) {
       
       return GetBooleanFunctionFromMarkedElementsImpl(nQubits, markedElements, _);
   }
   
     
     
     
   
    
    
    
}

