namespace Hello
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    /// Get Product Operation
    /// # Summary
    /// calculates the product of two double elements
    /// # Parameters
    /// ## x
    /// x parameter of Double type
    /// ## y
    /// y parameter of Double type
    /// # Returns
    /// product of two number of Double type

    operation GetProduct(x: Double, y: Double): Double {
    body {
        mutable z = 0.0;
        set z = CalculateProduct(x,y);
        return (z);
    }
    }

    /// CalculateProduct function
    /// # Summary
    /// finds the product of two double elements
    /// # Parameters
    /// ## x
    /// x parameter of Double type
    /// ## y
    /// y parameter of Double type
    /// # Returns
    /// product of two number of Double type
    function CalculateProduct(x: Double, y: Double): Double {  
    mutable z = 0.0;  
    set z = x * y;  
    return (z);  
    }
}
