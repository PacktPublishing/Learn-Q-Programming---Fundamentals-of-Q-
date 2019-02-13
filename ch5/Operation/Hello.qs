namespace Hello
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    /// Get Sum Operation
    /// # Summary
    /// calculates the sum of two integer elements
    /// # Parameters
    /// ## x
    /// x parameter of Integer type
    /// ## y
    /// y parameter of Integer type
    /// # Returns
    /// sum of two numbers of Integer type
    operation GetSum(x: Int, y: Int): Int {
    body {
        mutable z = 0;
        set z = x + y;
        return (z);
    }
    }
}
