namespace Hello
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation GetSum(x: Int, y: Int): Int {
    body {
        mutable z = 0;
        set z = x + y;
        return (z);
    }
    }
}    
