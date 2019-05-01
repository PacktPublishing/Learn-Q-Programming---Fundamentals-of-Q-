namespace PhaseEstimation {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;
    
    
    
    
    
    operation GetIterativePhaseEstimationStep (time : Double, inversionAngle : Double, oracle : ((Double, Qubit[]) => Unit : Controlled), eigenstate : Qubit[]) : Result {
        
    
        mutable result = Zero;
        
    
        using (controlRegister = Qubit[1]) {
            
    
            H(controlRegister[0]);
            Rz(-time * inversionAngle, controlRegister[0]);
            
            Controlled oracle(controlRegister, (time, eigenstate));
            
            set result = Measure([PauliX], controlRegister);
            
            Reset(controlRegister[0]);
        }
        
        return result;
    }
    
    
    operation GetExpOracle (eigenphase : Double, time : Double, register : Qubit[]) : Unit {
        
        body (...) {
            Rz((2.0 * eigenphase) * time, register[0]);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    operation GetPhaseEstimationIteration () : Unit {
        
        let dt = 0.1;
        let nTimes = 101;
        let nSamples = 100;
        let eigenphase = PI();
        let inversionAngle = 0.5 * PI();
        

        using (eigenstate = Qubit[1]) {
            
            X(eigenstate[0]);
            
            for (idxTime in 0 .. nTimes - 1) {
                let time = dt * ToDouble(idxTime);
                mutable nOnesObserved = 0;
                
                for (idxSample in 0 .. nSamples - 1) {
                    let sample = GetIterativePhaseEstimationStep(time, inversionAngle, GetExpOracle(eigenphase, _, _), eigenstate);
                    
                    if (sample == One) {
                        set nOnesObserved = nOnesObserved + 1;
                    }
                }
                
                let obs = ToDouble(nOnesObserved) / ToDouble(nSamples);
                let mean = PowD(Sin(((eigenphase - inversionAngle) * time) / 2.0), 2.0);
                Message($"Observation: value {obs} at time {time}, expected value {mean}.");
            }
            
            X(eigenstate[0]);
        }
    }
    
    
    
    function Integrate (xs : Double[], ys : Double[]) : Double {
        
        mutable sum = 0.0;
        
        for (idxPoint in 0 .. Length(xs) - 2) {
            let trapezoidalHeight = (ys[idxPoint + 1] + ys[idxPoint]) * 0.5;
            let trapezoidalBase = xs[idxPoint + 1] - xs[idxPoint];
            set sum = sum + trapezoidalBase * trapezoidalHeight;
        }
        
        return sum;
    }
    
    
    function MultiplyPointwise (left : Double[], right : Double[]) : Double[] {
        
        mutable product = new Double[Length(left)];
        
        for (idxElement in 0 .. Length(left) - 1) {
            set product[idxElement] = left[idxElement] * right[idxElement];
        }
        
        return product;
    }
    
    

    operation EstimateBayesianPhase (nGridPoints : Int, nMeasurements : Int, oracle : ((Double, Qubit[]) => Unit : Controlled), eigenstate : Qubit[]) : Double {
        
 
        let dPhase = 1.0 / ToDouble(nGridPoints - 1);
        let maxTime = 100.0;
        mutable phases = new Double[nGridPoints];
        mutable prior = new Double[nGridPoints];
        
        for (idxGridPoint in 0 .. nGridPoints - 1) {
            set phases[idxGridPoint] = dPhase * ToDouble(idxGridPoint);
            set prior[idxGridPoint] = 1.0;
        }
        
     
        let priorEst = Integrate(phases, MultiplyPointwise(phases, prior));
        Message($"̂φ from prior estimated value {priorEst}. it is equal to approximately 0.5.");
        
        for (idxMeasurement in 0 .. nMeasurements - 1) {
            
            let time = PowD(9.0 / 8.0, ToDouble(idxMeasurement));
            
            let inversionAngle = RandomReal(16) * 0.02;
            

            let sample = GetIterativePhaseEstimationStep(time, inversionAngle, oracle, eigenstate);
            
 
            mutable likelihood = new Double[nGridPoints];
            
            if (sample == One) {
                
                for (idxGridPoint in 0 .. Length(likelihood) - 1) {
                    let arg = ((phases[idxGridPoint] - inversionAngle) * time) / 2.0;
                    set likelihood[idxGridPoint] = PowD(Sin(arg), 2.0);
                }
            }
            else {
                
                for (idxGridPoint in 0 .. Length(likelihood) - 1) {
                    let arg = ((phases[idxGridPoint] - inversionAngle) * time) / 2.0;
                    set likelihood[idxGridPoint] = PowD(Cos(arg), 2.0);
                }
            }
            
            let unnormalizedPosterior = MultiplyPointwise(prior, likelihood);
            
            let normalization = Integrate(phases, unnormalizedPosterior);
            
            for (idxGridPoint in 0 .. Length(prior) - 1) {
                set prior[idxGridPoint] = unnormalizedPosterior[idxGridPoint] / normalization;
            }
            

            let posteriorEst = Integrate(phases, MultiplyPointwise(phases, prior));
            Message($"̂φ from posterior at #{idxMeasurement}: {posteriorEst}.");
        }
        
        return Integrate(phases, MultiplyPointwise(phases, prior));
    }
    
    

    operation GetBayesianPhaseEstimation (eigenphase : Double) : Double {
        
        let oracle = GetExpOracle(eigenphase, _, _);
        mutable est = 0.0;
        
        using (eigenstate = Qubit[1]) {
            X(eigenstate[0]);
            set est = EstimateBayesianPhase(20001, 60, oracle, eigenstate);
            Reset(eigenstate[0]);
        }
        
        return est;
    }
    
}


