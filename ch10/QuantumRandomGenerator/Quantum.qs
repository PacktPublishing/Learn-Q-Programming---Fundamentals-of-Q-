namespace QuantumRandomGenerator
   {
       open Microsoft.Quantum.Primitive;
       open Microsoft.Quantum.Canon;

    /// Set Operation
    /// # Summary
    /// sets the Qubit with desired value.
    /// # Parameters
    /// ## desired
    /// desired parameter of Result type
    /// ## q1
    /// qubit
    ///
    /// # Returns
    /// unit

    operation Set (desired: Result, q1: Qubit) : Unit
    {
        let current = M(q1);
        if (desired != current)
        {
            X(q1);
        }
    }

    /// GenerateRandomness Operation
    /// # Summary
    /// returns the count of zeros and ones
    /// # Parameters
    /// ## count
    /// count parameter of Integer type
    /// # Returns
    /// a tuple of Two Integers
    operation GenerateRandomness (count: Int): (Int,Int)
       {
           body {
               mutable countOnes = 0;
               mutable countZeros = 0;
               using (MyQubit = Qubit[1]) { for (test in 1..count) {
                Set (Zero, MyQubit[0]); 
                H(MyQubit[0]);
                let state = M(MyQubit[0]); if (state == Zero) {
                set countZeros = countZeros + 1; }
               if (state == One) {
                  set countOnes = countOnes + 1; }
                 }
               ResetAll(MyQubit);
                 }
              return (countZeros, countOnes);
           }      
      }
}