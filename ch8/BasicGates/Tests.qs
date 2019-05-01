// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//////////////////////////////////////////////////////////////////////
// This file contains testing harness for all tasks.
// You should not modify anything in this file.
// The tasks themselves can be found in Tasks.qs file.
//////////////////////////////////////////////////////////////////////

namespace Quantum.Kata.BasicGates {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    
    
    // ------------------------------------------------------
    // helper wrapper to represent operation on one qubit as an operation on an array of qubits
    operation ArrayWrapperOperation (op : (Qubit => Unit : Adjoint), qs : Qubit[]) : Unit {
        
        body (...) {
            op(qs[0]);
        }
        
        adjoint (...) {
            Adjoint op(qs[0]);
        }
    }
    
    
    // ------------------------------------------------------
    operation T11_StateFlip_Test () : Unit {
        AssertOperationsEqualReferenced(ArrayWrapperOperation(StateFlip, _), ArrayWrapperOperation(StateFlip_Reference, _), 1);
    }
    
    
    // ------------------------------------------------------
    operation T12_BasisChange_Test () : Unit {
        AssertOperationsEqualReferenced(ArrayWrapperOperation(BasisChange, _), ArrayWrapperOperation(BasisChange_Reference, _), 1);
    }
    
    
    // ------------------------------------------------------
    operation T13_SignFlip_Test () : Unit {
        AssertOperationsEqualReferenced(ArrayWrapperOperation(SignFlip, _), ArrayWrapperOperation(SignFlip_Reference, _), 1);
    }
    
    
    // ------------------------------------------------------
    operation T14_AmplitudeChange_Test () : Unit {
        for (i in 0 .. 36) {
            let alpha = ((2.0 * PI()) * ToDouble(i)) / 36.0;
            AssertOperationsEqualReferenced(ArrayWrapperOperation(AmplitudeChange(_, alpha), _), ArrayWrapperOperation(AmplitudeChange_Reference(_, alpha), _), 1);
        }
    }
    
    
    // ------------------------------------------------------
    operation T15_PhaseFlip_Test () : Unit {
        AssertOperationsEqualReferenced(ArrayWrapperOperation(PhaseFlip, _), ArrayWrapperOperation(PhaseFlip_Reference, _), 1);
    }
    
    
    // ------------------------------------------------------
    operation T16_PhaseChange_Test () : Unit {
        for (i in 0 .. 36) {
            let alpha = ((2.0 * PI()) * ToDouble(i)) / 36.0;
            AssertOperationsEqualReferenced(ArrayWrapperOperation(PhaseChange(_, alpha), _), ArrayWrapperOperation(PhaseChange_Reference(_, alpha), _), 1);
        }
    }
    
    
    // ------------------------------------------------------
    // 0 - |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2)
    // 1 - |Φ⁻⟩ = (|00⟩ - |11⟩) / sqrt(2)
    // 2 - |Ψ⁺⟩ = (|01⟩ + |10⟩) / sqrt(2)
    // 3 - |Ψ⁻⟩ = (|01⟩ - |10⟩) / sqrt(2)
    operation StatePrep_BellState (qs : Qubit[], state : Int) : Unit {
        
        body (...) {
            H(qs[0]);
            CNOT(qs[0], qs[1]);
            
            // now we have |00⟩ + |11⟩ - modify it based on state arg
            if (state % 2 == 1) {
                // negative phase
                Z(qs[1]);
            }
            
            if (state / 2 == 1) {
                X(qs[1]);
            }
        }
        
        adjoint invert;
    }
    
    
    // ------------------------------------------------------
    operation VerifyBellStateConversion (testOp : (Qubit[] => Unit), startState : Int, targetState : Int) : Unit {
        using (qs = Qubit[2]) {
            // prepare Bell state startState
            StatePrep_BellState(qs, startState);
            
            // apply operation that needs to be tested
            testOp(qs);
            
            // verify the result by applying adjoint of state prep for target state
            Adjoint StatePrep_BellState(qs, targetState);
            
            // assert that all qubits end up in |0⟩ state
            AssertAllZero(qs);
        }
    }
    
    
    // ------------------------------------------------------
    operation T17_BellStateChange1_Test () : Unit {
        VerifyBellStateConversion(BellStateChange1, 0, 1);
    }
    
    
    // ------------------------------------------------------
    operation T18_BellStateChange2_Test () : Unit {
        VerifyBellStateConversion(BellStateChange2, 0, 2);
    }
    
    
    // ------------------------------------------------------
    operation T19_BellStateChange3_Test () : Unit {
        VerifyBellStateConversion(BellStateChange3, 0, 3);
    }
    
    
    // ------------------------------------------------------
    // prepare state |A⟩ = cos(α) * |0⟩ + sin(α) * |1⟩
    operation StatePrep_A (alpha : Double, q : Qubit) : Unit {
        
        body (...) {
            Ry(2.0 * alpha, q);
        }
        
        adjoint invert;
    }
    
    
    // ------------------------------------------------------
    operation T21_TwoQubitGate1_Test () : Unit {
        
        // Note that the way the problem is formulated, we can't just compare two unitaries,
        // we need to create an input state |A⟩ and check that the output state is correct
        using (qs = Qubit[2]) {
            for (i in 0 .. 36) {
                let alpha = ((2.0 * PI()) * ToDouble(i)) / 36.0;
                
                // prepare A state
                StatePrep_A(alpha, qs[0]);
                
                // apply operation that needs to be tested
                TwoQubitGate1(qs);
                
                // apply adjoint reference operation and adjoint of state prep
                Adjoint TwoQubitGate1_Reference(qs);
                Adjoint StatePrep_A(alpha, qs[0]);
                
                // assert that all qubits end up in |0⟩ state
                AssertAllZero(qs);
            }
        }
    }
    
    
    // ------------------------------------------------------
    // prepare state |+⟩ ⊕ |+⟩ = (|00⟩ + |01⟩ + |10⟩ + |11⟩) / 2.
    operation StatePrep_PlusPlus (qs : Qubit[]) : Unit {
        
        body (...) {
            ApplyToEachA(H, qs);
        }
        
        adjoint invert;
    }
    
    
    // ------------------------------------------------------
    operation T22_TwoQubitGate2_Test () : Unit {
        using (qs = Qubit[2]) {
            // prepare |+⟩ ⊕ |+⟩ state
            StatePrep_PlusPlus(qs);
            
            // apply operation that needs to be tested
            TwoQubitGate2(qs);
            
            // apply adjoint reference operation and adjoint of state prep
            Adjoint TwoQubitGate2_Reference(qs);
            Adjoint StatePrep_PlusPlus(qs);
            
            // assert that all qubits end up in |0⟩ state
            AssertAllZero(qs);
        }
    }
    
    
    // ------------------------------------------------------
    operation SwapWrapper (qs : Qubit[]) : Unit {
        
        body (...) {
            SWAP(qs[0], qs[1]);
        }
        
        adjoint self;
    }
    
    
    operation T23_TwoQubitGate3_Test () : Unit {
        AssertOperationsEqualReferenced(SwapWrapper, TwoQubitGate3_Reference, 2);
        AssertOperationsEqualReferenced(TwoQubitGate3, TwoQubitGate3_Reference, 2);
    }
    
    
    // ------------------------------------------------------
    operation T24_ToffoliGate_Test () : Unit {
        AssertOperationsEqualReferenced(ToffoliGate, ToffoliGate_Reference, 3);
    }
    
    
    // ------------------------------------------------------
    operation T25_FredkinGate_Test () : Unit {
        AssertOperationsEqualReferenced(FredkinGate, FredkinGate_Reference, 3);
    }
    
}
