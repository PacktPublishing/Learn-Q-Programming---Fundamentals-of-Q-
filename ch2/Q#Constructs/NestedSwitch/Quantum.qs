namespace NestedSwitch
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

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
}
