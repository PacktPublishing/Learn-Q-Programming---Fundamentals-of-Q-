namespace InvalidQubitsChecker
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Testing;

    
    /// CheckForReleasedQubit Operation
    /// # Summary
    /// checks for Released Qubit
    /// # Parameters
    /// # Returns
    /// unit
   operation CheckForReleasedQubit () : Unit {
    body (...) {
        mutable q = new Qubit[1];
        using(ans = Qubit[1]) {
            set q[0] = ans[0];
        }
        H(q[0]);
    }

}
   

    
}
