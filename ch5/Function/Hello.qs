namespace Hello
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation GetProduct(x: Double, y: Double): Double {
    body {
        mutable z = 0.0;
        set z = CalculateProduct(x,y);
        return (z);
    }
    }
    function CalculateProduct(x: Double, y: Double): Double {  
    mutable z = 0.0;  
    set z = x * y;  
    return (z);  
    }
}
