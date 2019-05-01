#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"EncodeIntoBitFlipCode\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":68,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"auxiliaryQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Given a qubit representing a state to be protected and two auxiliary\",\" qubits initially in the |0〉 state, encodes the state into the\",\" three-qubit bit-flip code.\",\"\",\" # Input\",\" ## data\",\" A qubit whose state is to be protected.\",\" ## auxiliaryQubits\",\" Two qubits, initially in the |00〉 state, to be used in protecting\",\" the state of `data`.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"EncodeIntoBitFlipCode\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":70,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"EncodeIntoBitFlipCode\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":83,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"EncodeIntoBitFlipCode\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":84,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"EncodeIntoBitFlipCode\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":85,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeStateParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" This operation encodes into a bit-flip code, and confirms that\",\" the parity measurements Z₀Z₁ and Z₁Z₂ both return positive eigenvalues\",\" (that is, the Result value Zero) without disturbing the state that\",\" we are trying to protect.\",\"\",\" # Remarks\",\" This operation will fail when the parity checks are incorrect\",\" if run on a target machine which supports assertions, and thus\",\" can be used as a unit test of error-correction functionality.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeStateParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeCorrectsError\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":180,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"error\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" This operation encodes into a bit-flip code, and confirms that\",\" it can correct a given error applied to the logical state\",\" that results from encoding R_x(π / 3) |0〉.\",\"\",\" # Input\",\" ## error\",\" An operation representing an error to be applied to the code\",\" block.\",\"\",\" # Remarks\",\" This operation will fail when the error correction step fails\",\" if run on a target machine which supports assertions, and thus\",\" can be used as a unit test of error-correction functionality.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeCorrectsError\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":180,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeCorrectsBitFlipErrors\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":266,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" For each single-qubit bit-flip error on three qubits, this operation\",\" encodes R_x(π / 3) |0〉 into the bit-flip code and asserts that the\",\" code protects against that error.\",\"\",\" # Remarks\",\" This operation will fail when error correction fails\",\" if run on a target machine which supports assertions, and thus\",\" can be used as a unit test of error-correction functionality.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckBitFlipCodeCorrectsBitFlipErrors\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":266,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckCodeCorrectsError\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":310,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"code\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"QECC\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nScratch\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"fn\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"RecoveryFn\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"error\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":86}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"QECC\"}]},{\"Case\":\"Int\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"RecoveryFn\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" This operation encodes into an arbitrary code, and confirms that\",\" it can correct a given error applied to the logical state\",\" that results from encoding R_x(π / 3) |0〉.\",\"\",\" # Input\",\" ## error\",\" An operation representing an error to be applied to the code\",\" block.\",\"\",\" # Remarks\",\" This operation will fail when the error correction step fails\",\" if run on a target machine which supports assertions, and thus\",\" can be used as a unit test of error-correction functionality.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckCodeCorrectsError\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":310,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckCanonBitFlipCodeCorrectsBitFlipErrors\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":373,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" For each single-qubit bit-flip error on three qubits, this operation\",\" encodes R_x(π / 3) |0〉 into the bit-flip code and asserts that the\",\" code protects against that error.\",\"\",\" # Remarks\",\" This operation will fail when error correction fails\",\" if run on a target machine which supports assertions, and thus\",\" can be used as a unit test of error-correction functionality.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.BitFlipCode\",\"Name\":\"CheckCanonBitFlipCodeCorrectsBitFlipErrors\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs\",\"Position\":{\"Item1\":373,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Samples.BitFlipCode
{
    public class EncodeIntoBitFlipCode : Unitary<(Qubit,QArray<Qubit>)>, ICallable
    {
        public EncodeIntoBitFlipCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "EncodeIntoBitFlipCode";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.EncodeIntoBitFlipCode";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (data,auxiliaryQubits) = __in__;
#line 76 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (data, __arg1__))), auxiliaryQubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (data,auxiliaryQubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (data, __arg1__))), auxiliaryQubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(data,auxiliaryQubits)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (data, __arg1__))), auxiliaryQubits?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(data,auxiliaryQubits)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((__arg1__) => (data, __arg1__))), auxiliaryQubits?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit data, QArray<Qubit> auxiliaryQubits)
        {
            return __m__.Run<EncodeIntoBitFlipCode, (Qubit,QArray<Qubit>), QVoid>((data, auxiliaryQubits));
        }
    }

    public class CheckBitFlipCodeStateParity : Operation<QVoid, QVoid>, ICallable
    {
        public CheckBitFlipCodeStateParity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckBitFlipCodeStateParity";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.CheckBitFlipCodeStateParity";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,QArray<Qubit>)> EncodeIntoBitFlipCode
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 110 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var register = Allocate.Apply(3L);
#line 111 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var data = register[0L];
#line 112 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var auxiliaryQubits = register?.Slice(new Range(1L, 2L));
#line 113 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 116 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                EncodeIntoBitFlipCode.Apply((data, auxiliaryQubits?.Copy()));
#line 135 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                Assert.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), register?.Copy(), Result.Zero, "Z₀Z₁ was One!"));
#line 136 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                Assert.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), register?.Copy(), Result.Zero, "Z₁Z₂ was One!"));
#line 141 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var parity01 = Measure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), register?.Copy()));
#line 142 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var parity12 = Measure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), register?.Copy()));
#line 146 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                EncodeIntoBitFlipCode.Adjoint.Apply((data, auxiliaryQubits?.Copy()));
#line 147 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Adjoint.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 148 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                Assert.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {data}, Result.Zero, "Didn't return to |0〉!"));
#line hidden
                Release.Apply(register);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
            this.EncodeIntoBitFlipCode = this.Factory.Get<IUnitary<(Qubit,QArray<Qubit>)>>(typeof(EncodeIntoBitFlipCode));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CheckBitFlipCodeStateParity, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class CheckBitFlipCodeCorrectsError : Operation<ICallable, QVoid>, ICallable
    {
        public CheckBitFlipCodeCorrectsError(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckBitFlipCodeCorrectsError";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.CheckBitFlipCodeCorrectsError";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,QArray<Qubit>)> EncodeIntoBitFlipCode
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in__) =>
        {
            var error = __in__;
#line hidden
            {
#line 183 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var register = Allocate.Apply(3L);
#line 187 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var data = register[0L];
#line 188 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var auxiliaryQubits = register?.Slice(new Range(1L, 2L));
#line 189 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 190 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                EncodeIntoBitFlipCode.Apply((data, auxiliaryQubits?.Copy()));
#line 194 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                error.Apply(register?.Copy());
#line 198 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var parity01 = Measure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), register?.Copy()));
#line 199 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var parity12 = Measure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), register?.Copy()));
#line 213 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                if (((parity01 == Result.One) && (parity12 == Result.Zero)))
                {
#line 214 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                    MicrosoftQuantumPrimitiveX.Apply(register[0L]);
                }
                else if (((parity01 == Result.One) && (parity12 == Result.One)))
                {
#line 217 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                    MicrosoftQuantumPrimitiveX.Apply(register[1L]);
                }
                else if (((parity01 == Result.Zero) && (parity12 == Result.One)))
                {
#line 220 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                    MicrosoftQuantumPrimitiveX.Apply(register[2L]);
                }

#line 225 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                EncodeIntoBitFlipCode.Adjoint.Apply((data, auxiliaryQubits?.Copy()));
#line 226 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Adjoint.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 227 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                Assert.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {data}, Result.Zero, "Didn't return to |0〉!"));
#line hidden
                Release.Apply(register);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.EncodeIntoBitFlipCode = this.Factory.Get<IUnitary<(Qubit,QArray<Qubit>)>>(typeof(EncodeIntoBitFlipCode));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable error)
        {
            return __m__.Run<CheckBitFlipCodeCorrectsError, ICallable, QVoid>(error);
        }
    }

    public class CheckBitFlipCodeCorrectsBitFlipErrors : Operation<QVoid, QVoid>, ICallable
    {
        public CheckBitFlipCodeCorrectsBitFlipErrors(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckBitFlipCodeCorrectsBitFlipErrors";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.CheckBitFlipCodeCorrectsBitFlipErrors";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> CheckBitFlipCodeCorrectsError
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 271 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X0 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliI), __arg1__)));
#line 272 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg2__) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliI), __arg2__)));
#line 273 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg3__) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliX), __arg3__)));
#line 277 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            CheckBitFlipCodeCorrectsError.Apply(X0);
#line 278 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            CheckBitFlipCodeCorrectsError.Apply(X1);
#line 279 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            CheckBitFlipCodeCorrectsError.Apply(X2);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.CheckBitFlipCodeCorrectsError = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(CheckBitFlipCodeCorrectsError));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CheckBitFlipCodeCorrectsBitFlipErrors, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class CheckCodeCorrectsError : Operation<(Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable), QVoid>, ICallable
    {
        public CheckCodeCorrectsError(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Data.Item1?.Data)?.Qubits, ((IApplyData)Data.Item1?.Data.Item2?.Data)?.Qubits, ((IApplyData)Data.Item1?.Data.Item3?.Data)?.Qubits, ((IApplyData)Data.Item3?.Data)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "CheckCodeCorrectsError";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.CheckCodeCorrectsError";
        protected ICallable<(Microsoft.Quantum.Canon.QECC,Microsoft.Quantum.Canon.RecoveryFn,Microsoft.Quantum.Canon.LogicalRegister), QVoid> MicrosoftQuantumCanonRecover
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable), QVoid> Body => (__in__) =>
        {
            var (code,nScratch,fn,error) = __in__;
#line hidden
            {
#line 316 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var register = Allocate.Apply((1L + nScratch));
#line 320 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var data = register[0L];
#line 321 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var auxiliaryQubits = register?.Slice(new Range(1L, nScratch));
#line 322 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 329 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var (encode,decode,syndMeas) = code.Data;
#line 339 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var codeBlock = encode.Data.Apply<Microsoft.Quantum.Canon.LogicalRegister>((new QArray<Qubit>()
                {data}, auxiliaryQubits?.Copy()));
#line 342 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                error.Apply(codeBlock.Data);
#line 347 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumCanonRecover.Apply((code, fn, codeBlock));
#line 351 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                var (decodedData,decodedauxiliary) = decode.Data.Apply<(QArray<Qubit>,QArray<Qubit>)>(codeBlock);
#line 354 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                MicrosoftQuantumPrimitiveRx.Adjoint.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 355 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
                Assert.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {data}, Result.Zero, "Didn't return to |0〉!"));
#line hidden
                Release.Apply(register);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRecover = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.QECC,Microsoft.Quantum.Canon.RecoveryFn,Microsoft.Quantum.Canon.LogicalRegister), QVoid>>(typeof(Microsoft.Quantum.Canon.Recover));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.QECC code, Int64 nScratch, Microsoft.Quantum.Canon.RecoveryFn fn, ICallable error)
        {
            return __m__.Run<CheckCodeCorrectsError, (Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable), QVoid>((code, nScratch, fn, error));
        }
    }

    public class CheckCanonBitFlipCodeCorrectsBitFlipErrors : Operation<QVoid, QVoid>, ICallable
    {
        public CheckCanonBitFlipCodeCorrectsBitFlipErrors(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckCanonBitFlipCodeCorrectsBitFlipErrors";
        String ICallable.FullName => "Microsoft.Quantum.Samples.BitFlipCode.CheckCanonBitFlipCodeCorrectsBitFlipErrors";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable<QVoid, Microsoft.Quantum.Canon.QECC> MicrosoftQuantumCanonBitFlipCode
        {
            get;
            set;
        }

        protected ICallable<QVoid, Microsoft.Quantum.Canon.RecoveryFn> MicrosoftQuantumCanonBitFlipRecoveryFn
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable), QVoid> CheckCodeCorrectsError
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 376 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var code = MicrosoftQuantumCanonBitFlipCode.Apply(QVoid.Instance);
#line 377 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var recoveryFn = MicrosoftQuantumCanonBitFlipRecoveryFn.Apply(QVoid.Instance);
#line 378 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X0 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliI), __arg1__)));
#line 379 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg2__) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliI), __arg2__)));
#line 380 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var X2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg3__) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliX), __arg3__)));
#line 384 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var check = CheckCodeCorrectsError.Partial(new Func<ICallable, (Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable)>((__arg4__) => (code, 2L, recoveryFn, __arg4__)));
#line 385 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            var errors = new QArray<IUnitary>(X0, X1, X2);
#line 386 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            check.Apply(errors[0L]);
#line 387 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            check.Apply(errors[1L]);
#line 388 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BitFlipCode/BitFlipCode.qs"
            check.Apply(errors[2L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.MicrosoftQuantumCanonBitFlipCode = this.Factory.Get<ICallable<QVoid, Microsoft.Quantum.Canon.QECC>>(typeof(Microsoft.Quantum.Canon.BitFlipCode));
            this.MicrosoftQuantumCanonBitFlipRecoveryFn = this.Factory.Get<ICallable<QVoid, Microsoft.Quantum.Canon.RecoveryFn>>(typeof(Microsoft.Quantum.Canon.BitFlipRecoveryFn));
            this.CheckCodeCorrectsError = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.QECC,Int64,Microsoft.Quantum.Canon.RecoveryFn,ICallable), QVoid>>(typeof(CheckCodeCorrectsError));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CheckCanonBitFlipCodeCorrectsBitFlipErrors, QVoid, QVoid>(QVoid.Instance);
        }
    }
}