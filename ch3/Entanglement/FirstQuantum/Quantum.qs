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

    operation StateTest (count : Int, initial: Result) : (Int, Int, Int)
    {
        mutable numOnes = 0;
        mutable agree = 0;
        using (qubits = Qubit[2])
        {
            for (test in 1..count)
            {
                Set (initial, qubits[0]);

                Set (Zero,qubits[1]);

                H(qubits[0]);

                CNOT(qubits[0], qubits[1]);

                let res = M (qubits[0]);

                if (M (qubits[1]) == res )
                {
                    set agree = agree + 1;
                }

                if (res == One)
                {
                    set numOnes = numOnes + 1;
                }
            }
            Set(Zero, qubits[0]);
            Set(Zero, qubits[1]);
        }

        return (count-numOnes, numOnes,agree);
    }
}
