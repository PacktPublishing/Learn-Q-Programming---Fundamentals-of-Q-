namespace FirstQuantum
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    /// HelloWorld Operation
    /// # Summary
    /// prints the message
    /// # Returns
    /// a Unit
    operation HelloWorld () : Unit {
        Message("Q# - Hello World");
    }

}
