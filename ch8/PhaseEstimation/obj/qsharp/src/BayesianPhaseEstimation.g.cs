#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetIterativePhaseEstimationStep\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"time\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inversionAngle\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":73}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":90}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenstate\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":135},\"Item2\":{\"Line\":1,\"Column\":145}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetIterativePhaseEstimationStep\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetExpOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"time\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetExpOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":36,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetExpOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":40,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetExpOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":41,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetExpOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetPhaseEstimationIteration\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetPhaseEstimationIteration\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"Integrate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ys\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"Integrate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"MultiplyPointwise\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"left\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"right\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"MultiplyPointwise\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"EstimateBayesianPhase\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nGridPoints\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nMeasurements\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":80}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenstate\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":125},\"Item2\":{\"Line\":1,\"Column\":135}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"EstimateBayesianPhase\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetBayesianPhaseEstimation\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":171,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"eigenphase\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Double\"},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PhaseEstimation\",\"Name\":\"GetBayesianPhaseEstimation\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs\",\"Position\":{\"Item1\":171,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
#line hidden
namespace PhaseEstimation
{
    public class GetIterativePhaseEstimationStep : Operation<(Double,Double,IControllable,QArray<Qubit>), Result>, ICallable
    {
        public GetIterativePhaseEstimationStep(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,IControllable,QArray<Qubit>)>, IApplyData
        {
            public In((Double,Double,IControllable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "GetIterativePhaseEstimationStep";
        String ICallable.FullName => "PhaseEstimation.GetIterativePhaseEstimationStep";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(Double,Double,IControllable,QArray<Qubit>), Result> Body => (__in__) =>
        {
            var (time,inversionAngle,oracle,eigenstate) = __in__;
#line 15 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var result = Result.Zero;
#line hidden
            {
#line 18 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var controlRegister = Allocate.Apply(1L);
#line 21 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                MicrosoftQuantumPrimitiveH.Apply(controlRegister[0L]);
#line 22 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                MicrosoftQuantumPrimitiveRz.Apply(((-(time) * inversionAngle), controlRegister[0L]));
#line 24 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                oracle.Controlled.Apply((controlRegister?.Copy(), (time, eigenstate?.Copy())));
#line 26 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                result = Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliX}, controlRegister?.Copy()));
#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                Reset.Apply(controlRegister[0L]);
#line hidden
                Release.Apply(controlRegister);
            }

#line 31 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((Double,Double,IControllable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Double time, Double inversionAngle, IControllable oracle, QArray<Qubit> eigenstate)
        {
            return __m__.Run<GetIterativePhaseEstimationStep, (Double,Double,IControllable,QArray<Qubit>), Result>((time, inversionAngle, oracle, eigenstate));
        }
    }

    public class GetExpOracle : Unitary<(Double,Double,QArray<Qubit>)>, ICallable
    {
        public GetExpOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GetExpOracle";
        String ICallable.FullName => "PhaseEstimation.GetExpOracle";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(Double,Double,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (eigenphase,time,register) = __in__;
#line 38 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            MicrosoftQuantumPrimitiveRz.Apply((((2D * eigenphase) * time), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Double,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (eigenphase,time,register) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply((((2D * eigenphase) * time), register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Double,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,time,register)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Controlled.Apply((__controlQubits__?.Copy(), (((2D * eigenphase) * time), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(eigenphase,time,register)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (((2D * eigenphase) * time), register[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((Double,Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double eigenphase, Double time, QArray<Qubit> register)
        {
            return __m__.Run<GetExpOracle, (Double,Double,QArray<Qubit>), QVoid>((eigenphase, time, register));
        }
    }

    public class GetPhaseEstimationIteration : Operation<QVoid, QVoid>, ICallable
    {
        public GetPhaseEstimationIteration(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetPhaseEstimationIteration";
        String ICallable.FullName => "PhaseEstimation.GetPhaseEstimationIteration";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(Double,Double,QArray<Qubit>)> GetExpOracle
        {
            get;
            set;
        }

        protected ICallable<(Double,Double,IControllable,QArray<Qubit>), Result> GetIterativePhaseEstimationStep
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 49 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var dt = 0.1D;
#line 50 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var nTimes = 101L;
#line 51 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var nSamples = 100L;
#line 52 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var eigenphase = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 53 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var inversionAngle = (0.5D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance));
#line hidden
            {
#line 56 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var eigenstate = Allocate.Apply(1L);
#line 58 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                MicrosoftQuantumPrimitiveX.Apply(eigenstate[0L]);
#line 60 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                foreach (var idxTime in new Range(0L, (nTimes - 1L)))
#line hidden
                {
#line 61 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    var time = (dt * MicrosoftQuantumExtensionsConvertToDouble.Apply(idxTime));
#line 62 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    var nOnesObserved = 0L;
#line 64 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    foreach (var idxSample in new Range(0L, (nSamples - 1L)))
#line hidden
                    {
#line 65 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        var sample = GetIterativePhaseEstimationStep.Apply((time, inversionAngle, GetExpOracle.Partial(new Func<(Double,QArray<Qubit>), (Double,Double,QArray<Qubit>)>((__arg1__) => (eigenphase, __arg1__.Item1, __arg1__.Item2))), eigenstate?.Copy()));
#line 67 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        if ((sample == Result.One))
                        {
#line 68 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                            nOnesObserved = (nOnesObserved + 1L);
                        }
                    }

#line 72 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    var obs = (MicrosoftQuantumExtensionsConvertToDouble.Apply(nOnesObserved) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nSamples));
#line 73 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    var mean = MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsMathSin.Apply((((eigenphase - inversionAngle) * time) / 2D)), 2D));
#line 74 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    Message.Apply(String.Format("Observation: value {0} at time {1}, expected value {2}.", obs, time, mean));
                }

#line 77 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                MicrosoftQuantumPrimitiveX.Apply(eigenstate[0L]);
#line hidden
                Release.Apply(eigenstate);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.GetExpOracle = this.Factory.Get<IUnitary<(Double,Double,QArray<Qubit>)>>(typeof(GetExpOracle));
            this.GetIterativePhaseEstimationStep = this.Factory.Get<ICallable<(Double,Double,IControllable,QArray<Qubit>), Result>>(typeof(GetIterativePhaseEstimationStep));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetPhaseEstimationIteration, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Integrate : Function<(QArray<Double>,QArray<Double>), Double>, ICallable
    {
        public Integrate(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Double>,QArray<Double>)>, IApplyData
        {
            public In((QArray<Double>,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Integrate";
        String ICallable.FullName => "PhaseEstimation.Integrate";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Double>,QArray<Double>), Double> Body => (__in__) =>
        {
            var (xs,ys) = __in__;
#line 85 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var sum = 0D;
#line 87 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            foreach (var idxPoint in new Range(0L, (xs.Length - 2L)))
#line hidden
            {
#line 88 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var trapezoidalHeight = ((ys[(idxPoint + 1L)] + ys[idxPoint]) * 0.5D);
#line 89 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var trapezoidalBase = (xs[(idxPoint + 1L)] - xs[idxPoint]);
#line 90 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                sum = (sum + (trapezoidalBase * trapezoidalHeight));
            }

#line 93 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Double>,QArray<Double>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, QArray<Double> xs, QArray<Double> ys)
        {
            return __m__.Run<Integrate, (QArray<Double>,QArray<Double>), Double>((xs, ys));
        }
    }

    public class MultiplyPointwise : Function<(QArray<Double>,QArray<Double>), QArray<Double>>, ICallable
    {
        public MultiplyPointwise(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Double>,QArray<Double>)>, IApplyData
        {
            public In((QArray<Double>,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MultiplyPointwise";
        String ICallable.FullName => "PhaseEstimation.MultiplyPointwise";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Double>,QArray<Double>), QArray<Double>> Body => (__in__) =>
        {
            var (left,right) = __in__;
#line 99 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var product = new QArray<Double>(left.Length);
#line 101 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            foreach (var idxElement in new Range(0L, (left.Length - 1L)))
#line hidden
            {
#line 102 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                product[idxElement] = (left[idxElement] * right[idxElement]);
            }

#line 105 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            return product;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Double>,QArray<Double>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Double> data) => data;
        public static System.Threading.Tasks.Task<QArray<Double>> Run(IOperationFactory __m__, QArray<Double> left, QArray<Double> right)
        {
            return __m__.Run<MultiplyPointwise, (QArray<Double>,QArray<Double>), QArray<Double>>((left, right));
        }
    }

    public class EstimateBayesianPhase : Operation<(Int64,Int64,IControllable,QArray<Qubit>), Double>, ICallable
    {
        public EstimateBayesianPhase(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IControllable,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,IControllable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "EstimateBayesianPhase";
        String ICallable.FullName => "PhaseEstimation.EstimateBayesianPhase";
        protected ICallable<Int64, Double> MicrosoftQuantumCanonRandomReal
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathCos
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Double,Double,IControllable,QArray<Qubit>), Result> GetIterativePhaseEstimationStep
        {
            get;
            set;
        }

        protected ICallable<(QArray<Double>,QArray<Double>), Double> Integrate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Double>,QArray<Double>), QArray<Double>> MultiplyPointwise
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IControllable,QArray<Qubit>), Double> Body => (__in__) =>
        {
            var (nGridPoints,nMeasurements,oracle,eigenstate) = __in__;
#line 113 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var dPhase = (1D / MicrosoftQuantumExtensionsConvertToDouble.Apply((nGridPoints - 1L)));
#line 114 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var maxTime = 100D;
#line 115 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var phases = new QArray<Double>(nGridPoints);
#line 116 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var prior = new QArray<Double>(nGridPoints);
#line 118 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            foreach (var idxGridPoint in new Range(0L, (nGridPoints - 1L)))
#line hidden
            {
#line 119 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                phases[idxGridPoint] = (dPhase * MicrosoftQuantumExtensionsConvertToDouble.Apply(idxGridPoint));
#line 120 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                prior[idxGridPoint] = 1D;
            }

#line 124 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var priorEst = Integrate.Apply((phases?.Copy(), MultiplyPointwise.Apply((phases?.Copy(), prior?.Copy()))));
#line 125 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            Message.Apply(String.Format("̂φ from prior estimated value {0}. it is equal to approximately 0.5.", priorEst));
#line 127 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            foreach (var idxMeasurement in new Range(0L, (nMeasurements - 1L)))
#line hidden
            {
#line 129 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var time = MicrosoftQuantumExtensionsMathPowD.Apply(((9D / 8D), MicrosoftQuantumExtensionsConvertToDouble.Apply(idxMeasurement)));
#line 131 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var inversionAngle = (MicrosoftQuantumCanonRandomReal.Apply(16L) * 0.02D);
#line 134 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var sample = GetIterativePhaseEstimationStep.Apply((time, inversionAngle, oracle, eigenstate?.Copy()));
#line 137 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var likelihood = new QArray<Double>(nGridPoints);
#line 139 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                if ((sample == Result.One))
                {
#line 141 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    foreach (var idxGridPoint in new Range(0L, (likelihood.Length - 1L)))
#line hidden
                    {
#line 142 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        var arg = (((phases[idxGridPoint] - inversionAngle) * time) / 2D);
#line 143 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        likelihood[idxGridPoint] = MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsMathSin.Apply(arg), 2D));
                    }
                }
                else
                {
#line 148 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    foreach (var idxGridPoint in new Range(0L, (likelihood.Length - 1L)))
#line hidden
                    {
#line 149 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        var arg = (((phases[idxGridPoint] - inversionAngle) * time) / 2D);
#line 150 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                        likelihood[idxGridPoint] = MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsMathCos.Apply(arg), 2D));
                    }
                }

#line 154 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var unnormalizedPosterior = MultiplyPointwise.Apply((prior?.Copy(), likelihood?.Copy()));
#line 156 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var normalization = Integrate.Apply((phases?.Copy(), unnormalizedPosterior?.Copy()));
#line 158 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                foreach (var idxGridPoint in new Range(0L, (prior.Length - 1L)))
#line hidden
                {
#line 159 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                    prior[idxGridPoint] = (unnormalizedPosterior[idxGridPoint] / normalization);
                }

#line 163 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var posteriorEst = Integrate.Apply((phases?.Copy(), MultiplyPointwise.Apply((phases?.Copy(), prior?.Copy()))));
#line 164 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                Message.Apply(String.Format("̂φ from posterior at #{0}: {1}.", idxMeasurement, posteriorEst));
            }

#line 167 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            return Integrate.Apply((phases?.Copy(), MultiplyPointwise.Apply((phases?.Copy(), prior?.Copy()))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRandomReal = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Canon.RandomReal));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Cos));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.GetIterativePhaseEstimationStep = this.Factory.Get<ICallable<(Double,Double,IControllable,QArray<Qubit>), Result>>(typeof(GetIterativePhaseEstimationStep));
            this.Integrate = this.Factory.Get<ICallable<(QArray<Double>,QArray<Double>), Double>>(typeof(Integrate));
            this.MultiplyPointwise = this.Factory.Get<ICallable<(QArray<Double>,QArray<Double>), QArray<Double>>>(typeof(MultiplyPointwise));
        }

        public override IApplyData __dataIn((Int64,Int64,IControllable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 nGridPoints, Int64 nMeasurements, IControllable oracle, QArray<Qubit> eigenstate)
        {
            return __m__.Run<EstimateBayesianPhase, (Int64,Int64,IControllable,QArray<Qubit>), Double>((nGridPoints, nMeasurements, oracle, eigenstate));
        }
    }

    public class GetBayesianPhaseEstimation : Operation<Double, Double>, ICallable
    {
        public GetBayesianPhaseEstimation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetBayesianPhaseEstimation";
        String ICallable.FullName => "PhaseEstimation.GetBayesianPhaseEstimation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IControllable,QArray<Qubit>), Double> EstimateBayesianPhase
        {
            get;
            set;
        }

        protected IUnitary<(Double,Double,QArray<Qubit>)> GetExpOracle
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in__) =>
        {
            var eigenphase = __in__;
#line 174 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var oracle = GetExpOracle.Partial(new Func<(Double,QArray<Qubit>), (Double,Double,QArray<Qubit>)>((__arg1__) => (eigenphase, __arg1__.Item1, __arg1__.Item2)));
#line 175 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            var est = 0D;
#line hidden
            {
#line 177 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                var eigenstate = Allocate.Apply(1L);
#line 178 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                MicrosoftQuantumPrimitiveX.Apply(eigenstate[0L]);
#line 179 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                est = EstimateBayesianPhase.Apply((20001L, 60L, oracle, eigenstate?.Copy()));
#line 180 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
                Reset.Apply(eigenstate[0L]);
#line hidden
                Release.Apply(eigenstate);
            }

#line 183 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/PhaseEstimation/BayesianPhaseEstimation.qs"
            return est;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.EstimateBayesianPhase = this.Factory.Get<ICallable<(Int64,Int64,IControllable,QArray<Qubit>), Double>>(typeof(EstimateBayesianPhase));
            this.GetExpOracle = this.Factory.Get<IUnitary<(Double,Double,QArray<Qubit>)>>(typeof(GetExpOracle));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double eigenphase)
        {
            return __m__.Run<GetBayesianPhaseEstimation, Double, Double>(eigenphase);
        }
    }
}