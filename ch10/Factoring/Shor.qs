namespace Factoring {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Canon;
    
    

    /// # Summary
    /// finding the factors of the number
    ///
    /// # Input
    /// ## number
    /// An integer to be factored
    /// ## useRobustPhaseEstimation
    /// Microsoft.Quantum.Canon.RobustPhaseEstimation if true
    ///
    /// # Output
    /// two factors
    operation Factoring (number : Int, useRobustPhaseEstimation : Bool) : (Int, Int) {
        
        if (number % 2 == 0) {
            Message("The number is even");
            return (number / 2, 2);
        }
        
        let coprimeCandidate = RandomInt(number - 2) + 1;
        
        if (IsCoprime(coprimeCandidate, number)) {
            
            Message($"period for {coprimeCandidate}");
            
 
            let period = PeriodEstimator(coprimeCandidate, number, useRobustPhaseEstimation);
            
            if (period % 2 == 0) {
                
 
                let halfPower = ExpMod(coprimeCandidate, period / 2, number);
                
 
                if (halfPower != number - 1) {
                    
 
                    let factor = MaxI(GCD(halfPower - 1, number), GCD(halfPower + 1, number));
                    
                     return (factor, number / factor);
                }
                else {
                    
 
                    fail "Residue ";
                }
            }
            else {
                
 
                fail "Period is a odd number";
            }
        }
         else {
            
 
            let gcd = GCD(number, coprimeCandidate);
            
 
            Message($"The divisor of {number} is  {gcd} ");
            
 
            return (gcd, number / gcd);
        }
    }
    
    
    /// # Summary
    /// find target given the order
    ///
    /// # Input
    /// ## generator
    /// The unsigned integer multiplicative order
    /// ## modulus
    /// modulus
    /// ## power
    /// Power of generator multiplied by target
    /// ## target
    /// target
    operation GetOrder (generator : Int, modulus : Int, power : Int, target : Qubit[]) : Unit {
        
        body (...) {
             AssertBoolEqual(IsCoprime(generator, modulus), true, "`generator` and `modulus` must be co-prime");
            
 
            ModularMultiplyByConstantLE(ExpMod(generator, power, modulus), modulus, LittleEndian(target));
        }
        
        adjoint invert;
 
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    /// # Summary
    /// generates a multiplicative order of the number
    ///
    /// # Input
    /// ## generator
    /// The unsigned integer multiplicative order
    /// ## modulus
    /// The modulus
    /// ## useRobustPhaseEstimation
    /// Microsoft.Quantum.Canon.RobustPhaseEstimation is used if true
    ///
    /// # Output
    /// The period of the generator
    operation PeriodEstimator (generator : Int, modulus : Int, useRobustPhaseEstimation : Bool) : Int {
        
 
        AssertBoolEqual(IsCoprime(generator, modulus), true, "`generator` and `modulus` must be co-prime");
        
 
        mutable result = 1;
        
 
        let bitsize = BitSize(modulus);
        
 
        let bitsPrecision = 2 * bitsize + 1;
        
        repeat {
            
 
            mutable dyadicFractionNum = 0;
            
 
            using (eignestateRegister = Qubit[bitsize]) {
                
 
                let eignestateRegisterLE = LittleEndian(eignestateRegister);
                InPlaceXorLE(1, eignestateRegisterLE);
                
 
                let oracle = DiscreteOracle(GetOrder(generator, modulus, _, _));
                
 
                if (useRobustPhaseEstimation) {
                    
 
                    let phase = RobustPhaseEstimation(bitsPrecision, oracle, eignestateRegisterLE!);
                    
 
                    set dyadicFractionNum = Round(((phase * ToDouble(2 ^ bitsPrecision)) / 2.0) / PI());
                }
                else {
                    
 
                    using (dyadicFractionNumerator = Qubit[bitsPrecision]) {
                        
 
                        let dyadicFractionNumeratorBE = BigEndian(dyadicFractionNumerator);
                        QuantumPhaseEstimation(oracle, eignestateRegisterLE!, dyadicFractionNumeratorBE);
                        
 
                        set dyadicFractionNum = MeasureIntegerBE(dyadicFractionNumeratorBE);
                    }
                }
                
 
                ResetAll(eignestateRegister);
            }
 
            if (dyadicFractionNum == 0) {
                fail "measured 0 : numerator";
            }
            
 
            Message($"Estimated eigenvalue is {dyadicFractionNum}/2^{bitsPrecision}.");
            
 
            let (numerator, period) = (ContinuedFractionConvergent(Fraction(dyadicFractionNum, 2 ^ bitsPrecision), modulus))!;
            
 
            let (numeratorAbs, periodAbs) = (AbsI(numerator), AbsI(period));
            
 
            Message($"divisor for period : {periodAbs}, " + $" eigenstate project {numeratorAbs}.");
            
 
            set result = (periodAbs * result) / GCD(result, periodAbs);
        }
        until (ExpMod(generator, result, modulus) == 1)
        fixup {
            
 
            Message("period divisors " + "divisor for the period. second try ...");
        }
        
 
        return result;
    }
    
}


