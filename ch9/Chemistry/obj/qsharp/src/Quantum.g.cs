#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Chemistry\",\"Name\":\"TrotterEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nBitsPrecision\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":87}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"trotterStepSize\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":95},\"Item2\":{\"Line\":1,\"Column\":110}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Method returns the ground state energy\",\" # Parameters\",\" ## qSharpData\",\" Jordan Wigner Encoding Data\",\" ## nBitsPrecision\",\" precision of number of bits\",\" # Returns\",\" estimated Phase and Energy\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Chemistry\",\"Name\":\"TrotterEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Chemistry\",\"Name\":\"OptimizedTrotterEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nBitsPrecision\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":82},\"Item2\":{\"Line\":1,\"Column\":96}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"trotterStepSize\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":104},\"Item2\":{\"Line\":1,\"Column\":119}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Method returns the ground state energy\",\" # Parameters\",\" ## qSharpData\",\" Jordan Wigner Encoding Data\",\" ## nBitsPrecision\",\" precision of number of bits\",\" # Returns\",\" estimated Phase and Energy\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Chemistry\",\"Name\":\"OptimizedTrotterEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Chemistry\",\"Name\":\"QubitizationEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nBitsPrecision\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":92}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Parameters\",\" ## qSharpData\",\" Jordan Wigner Encoding Data\",\" ## nBitsPrecision\",\" precision of number of bits\",\" # Returns\",\" estimated Phase and Energy\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Chemistry\",\"Name\":\"QubitizationEnergyEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/Chemistry/Quantum.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
#line hidden
namespace Chemistry
{
    public class TrotterEnergyEstimator : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)>, ICallable
    {
        public TrotterEnergyEstimator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Double,Double)>, IApplyData
        {
            public Out((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TrotterEnergyEstimator";
        String ICallable.FullName => "Chemistry.TrotterEnergyEstimator";
        protected ICallable<(Int64,ICallable,IUnitary,ICallable), Double> MicrosoftQuantumCanonEstimateEnergy
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))> MicrosoftQuantumChemistryJordanWignerTrotterStepOracle
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)> Body => (__in) =>
        {
            var (qSharpData,nBitsPrecision,trotterStepSize) = __in;
#line 23 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 25 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var trotterOrder = 1L;
#line 26 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nQubits,(rescaleFactor,oracle)) = MicrosoftQuantumChemistryJordanWignerTrotterStepOracle.Apply((qSharpData, trotterStepSize, trotterOrder));
#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var statePrep = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((_arg1) => (statePrepData?.Copy(), _arg1)));
#line 29 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var phaseEstAlgorithm = MicrosoftQuantumCanonRobustPhaseEstimation.Partial(new Func<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), (Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>)>((_arg2) => (nBitsPrecision, _arg2.Item1, _arg2.Item2)));
#line 30 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedPhase = MicrosoftQuantumCanonEstimateEnergy.Apply((nQubits, statePrep, oracle, phaseEstAlgorithm));
#line 31 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedEnergy = ((estimatedPhase * rescaleFactor) + energyShift);
#line 32 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            return (estimatedPhase, estimatedEnergy);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonEstimateEnergy = this.Factory.Get<ICallable<(Int64,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.EstimateEnergy));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumChemistryJordanWignerTrotterStepOracle = this.Factory.Get<ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.TrotterStepOracle));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut((Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Double,Double)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData, Int64 nBitsPrecision, Double trotterStepSize)
        {
            return __m__.Run<TrotterEnergyEstimator, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)>((qSharpData, nBitsPrecision, trotterStepSize));
        }
    }

    public class OptimizedTrotterEnergyEstimator : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)>, ICallable
    {
        public OptimizedTrotterEnergyEstimator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Double,Double)>, IApplyData
        {
            public Out((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "OptimizedTrotterEnergyEstimator";
        String ICallable.FullName => "Chemistry.OptimizedTrotterEnergyEstimator";
        protected ICallable<(Int64,ICallable,IUnitary,ICallable), Double> MicrosoftQuantumCanonEstimateEnergy
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))> MicrosoftQuantumResearchChemistryOptimizedTrotterStepOracle
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)> Body => (__in) =>
        {
            var (qSharpData,nBitsPrecision,trotterStepSize) = __in;
#line 48 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 50 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var trotterOrder = 1L;
#line 51 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nQubits,(rescaleFactor,oracle)) = MicrosoftQuantumResearchChemistryOptimizedTrotterStepOracle.Apply((qSharpData, trotterStepSize, trotterOrder));
#line 53 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var statePrep = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((_arg1) => (statePrepData?.Copy(), _arg1)));
#line 54 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var phaseEstAlgorithm = MicrosoftQuantumCanonRobustPhaseEstimation.Partial(new Func<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), (Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>)>((_arg2) => (nBitsPrecision, _arg2.Item1, _arg2.Item2)));
#line 55 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedPhase = MicrosoftQuantumCanonEstimateEnergy.Apply((nQubits, statePrep, oracle, phaseEstAlgorithm));
#line 56 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedEnergy = ((estimatedPhase * rescaleFactor) + energyShift);
#line 57 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            return (estimatedPhase, estimatedEnergy);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonEstimateEnergy = this.Factory.Get<ICallable<(Int64,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.EstimateEnergy));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumResearchChemistryOptimizedTrotterStepOracle = this.Factory.Get<ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))>>(typeof(Microsoft.Quantum.Research.Chemistry.OptimizedTrotterStepOracle));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut((Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Double,Double)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData, Int64 nBitsPrecision, Double trotterStepSize)
        {
            return __m__.Run<OptimizedTrotterEnergyEstimator, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double), (Double,Double)>((qSharpData, nBitsPrecision, trotterStepSize));
        }
    }

    public class QubitizationEnergyEstimator : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)>, ICallable
    {
        public QubitizationEnergyEstimator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Double,Double)>, IApplyData
        {
            public Out((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QubitizationEnergyEstimator";
        String ICallable.FullName => "Chemistry.QubitizationEnergyEstimator";
        protected ICallable<(Int64,ICallable,IUnitary,ICallable), Double> MicrosoftQuantumCanonEstimateEnergy
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Int64,(Double,IUnitary))> MicrosoftQuantumChemistryJordanWignerQubitizationOracle
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)> Body => (__in) =>
        {
            var (qSharpData,nBitsPrecision) = __in;
#line 74 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 75 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var (nQubits,(l1Norm,oracle)) = MicrosoftQuantumChemistryJordanWignerQubitizationOracle.Apply(qSharpData);
#line 76 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var statePrep = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((_arg1) => (statePrepData?.Copy(), _arg1)));
#line 77 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var phaseEstAlgorithm = MicrosoftQuantumCanonRobustPhaseEstimation.Partial(new Func<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), (Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>)>((_arg2) => (nBitsPrecision, _arg2.Item1, _arg2.Item2)));
#line 78 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedPhase = MicrosoftQuantumCanonEstimateEnergy.Apply((nQubits, statePrep, oracle, phaseEstAlgorithm));
#line 80 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            var estimatedEnergy = ((MicrosoftQuantumExtensionsMathSin.Apply(estimatedPhase) * l1Norm) + energyShift);
#line 82 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/Chemistry/Quantum.qs"
            return (estimatedPhase, estimatedEnergy);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonEstimateEnergy = this.Factory.Get<ICallable<(Int64,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.EstimateEnergy));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumChemistryJordanWignerQubitizationOracle = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Int64,(Double,IUnitary))>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.QubitizationOracle));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64) data) => new In(data);
        public override IApplyData __dataOut((Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Double,Double)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData, Int64 nBitsPrecision)
        {
            return __m__.Run<QubitizationEnergyEstimator, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)>((qSharpData, nBitsPrecision));
        }
    }
}