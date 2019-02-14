namespace Chemistry {

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Research.Chemistry;
    open Microsoft.Quantum.Chemistry.JordanWigner;


    // TrotterEnergyEstimator Operation
    /// # Summary
    /// Method returns the ground state energy
    /// # Parameters
    /// ## qSharpData
    /// Jordan Wigner Encoding Data
    /// ## nBitsPrecision
    /// precision of number of bits
    /// # Returns
    /// estimated Phase and Energy
    operation TrotterEnergyEstimator (qSharpData: JordanWignerEncodingData, nBitsPrecision : Int, trotterStepSize : Double) : (Double, Double) {

        let (nSpinOrbitals, data, statePrepData, energyShift) = qSharpData!;

        let trotterOrder = 1;
        let (nQubits, (rescaleFactor, oracle)) = TrotterStepOracle(qSharpData, trotterStepSize, trotterOrder);

        let statePrep =  PrepareTrialState(statePrepData, _);
        let phaseEstAlgorithm = RobustPhaseEstimation(nBitsPrecision, _, _);
        let estimatedPhase = EstimateEnergy(nQubits, statePrep, oracle, phaseEstAlgorithm);
        let estimatedEnergy = estimatedPhase * rescaleFactor + energyShift;
        return (estimatedPhase, estimatedEnergy);
    }


    // OptimizedTrotterEnergyEstimator Operation
    /// # Summary
    /// Method returns the ground state energy
    /// # Parameters
    /// ## qSharpData
    /// Jordan Wigner Encoding Data
    /// ## nBitsPrecision
    /// precision of number of bits
    /// # Returns
    /// estimated Phase and Energy
    operation OptimizedTrotterEnergyEstimator (qSharpData: JordanWignerEncodingData, nBitsPrecision : Int, trotterStepSize : Double) : (Double, Double) {

        let (nSpinOrbitals, data, statePrepData, energyShift) = qSharpData!;

        let trotterOrder = 1;
        let (nQubits, (rescaleFactor, oracle)) = OptimizedTrotterStepOracle(qSharpData, trotterStepSize, trotterOrder);

        let statePrep =  PrepareTrialState(statePrepData, _);
        let phaseEstAlgorithm = RobustPhaseEstimation(nBitsPrecision, _, _);
        let estimatedPhase = EstimateEnergy(nQubits, statePrep, oracle, phaseEstAlgorithm);
        let estimatedEnergy = estimatedPhase * rescaleFactor + energyShift;
        return (estimatedPhase, estimatedEnergy);
    }


    // QubitizationEnergyEstimator Operation
    // # Summary
    // Returns the energy estimated using the real-time evolution
    /// # Parameters
    /// ## qSharpData
    /// Jordan Wigner Encoding Data
    /// ## nBitsPrecision
    /// precision of number of bits
    /// # Returns
    /// estimated Phase and Energy

    operation QubitizationEnergyEstimator (qSharpData: JordanWignerEncodingData, nBitsPrecision : Int) : (Double, Double) {

        let (nSpinOrbitals, data, statePrepData, energyShift) = qSharpData!;
        let (nQubits, (l1Norm, oracle)) = QubitizationOracle(qSharpData);
        let statePrep =  PrepareTrialState(statePrepData, _);
        let phaseEstAlgorithm = RobustPhaseEstimation(nBitsPrecision, _, _);
        let estimatedPhase = EstimateEnergy(nQubits, statePrep, oracle, phaseEstAlgorithm);

        let estimatedEnergy = Sin(estimatedPhase) * l1Norm + energyShift;

        return (estimatedPhase, estimatedEnergy);
    }

}
