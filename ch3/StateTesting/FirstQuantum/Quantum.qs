namespace FirstQuantum
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

operation Set (desired: Result, q1: Qubit) : Unit
    {
        let current = M(q1);
        if (desired != current)
        {
            X(q1);
        }
    }

    operation StateTest (count : Int, initial: Result) : (Int, Int)
    {
        mutable numOnes = 0;
        using (qubit = Qubit())
        {
            for (test in 1..count)
            {
                Set (initial, qubit);

                X (qubit);

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
