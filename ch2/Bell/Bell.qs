namespace Bell
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

    /// BellTest Operation
    /// # Summary
    /// Bell Test
    /// # Parameters
    /// ## count
    /// count of tests
    /// ## initial
    /// initial value of qubit
    ///
    /// # Returns
    /// number of ones and zeros (tuple of int and int)
    operation BellTest (count : Int, initial: Result) : (Int, Int)
    {
        mutable numOnes = 0;
        using (qubit = Qubit())
        {
            for (test in 1..count)
            {
                Set (initial, qubit);

                let res = M (qubit);

                if (res == One)
                {
                    set numOnes = numOnes + 1;
                }
            }
            Set(Zero, qubit);
        }

        return (count-numOnes, numOnes);
    }


}
