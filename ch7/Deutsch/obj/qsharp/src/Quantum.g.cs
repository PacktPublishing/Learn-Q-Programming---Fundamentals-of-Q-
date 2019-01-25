#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"CheckConstantBooleanFunction\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":28,\"Item2\":3},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[\" IsConstantBooleanFunction Operation\",\" # Summary\",\" This operation returns the Boolean value `true` if the function is constant and `false` if it is not. Note\",\" that the promise that the function is either constant or balanced is assumed.\",\"\",\" # Parameters\",\" ## Uf\",\" A quantum operation that implements |𝑥〉|𝑦〉 ↦ |𝑥〉|𝑦 ⊕ 𝑓(𝑥)〉,\",\" where 𝑓 is a Boolean function, 𝑥 is an 𝑛 bit register and 𝑦 is a single qubit.\",\" ## n\",\" The number of bits of the input register |𝑥〉.\",\"\",\" # Return\",\" A boolean value `true` that indicates that the function is constant and `false`\",\" that indicates that the function is balanced.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"CheckConstantBooleanFunction\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":28,\"Item2\":3},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"ExecuteDeutschJozsaAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"ExecuteDeutschJozsaAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"GetBooleanFunctionFromMarkedElementsImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":51}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"GetBooleanFunctionFromMarkedElementsImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":51}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"GetBooleanFunctionFromMarkedElements\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":98,\"Item2\":3},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"SupportedFunctors\":[]},\"Documentation\":[\" GetBooleanFunctionFromMarkedElements Function\",\" # Summary\",\" Constructs an operation representing a query to a boolean function\",\" # Parameters\",\" ## nQubits\",\" The number of qubits to be used in representing the query operation.\",\" ## markedElements\",\" An array of the elements {𝑘ᵢ} for which 𝑓 should return 1.\",\"\",\" # Return\",\" An operation representing the unitary 𝑈 |𝑧〉 |𝑘〉 = |𝑧 ⊕ 𝑥ₖ〉 |𝑘〉.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DeutschJozsaAlgorithm\",\"Name\":\"GetBooleanFunctionFromMarkedElements\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs\",\"Position\":{\"Item1\":98,\"Item2\":3},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
#line hidden
namespace DeutschJozsaAlgorithm
{
    public class CheckConstantBooleanFunction : Operation<(ICallable,Int64), Boolean>, ICallable
    {
        public CheckConstantBooleanFunction(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64)>, IApplyData
        {
            public In((ICallable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "CheckConstantBooleanFunction";
        String ICallable.FullName => "DeutschJozsaAlgorithm.CheckConstantBooleanFunction";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonForAll
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultZero
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumCanonMResetZ
        {
            get;
            set;
        }

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

        public override Func<(ICallable,Int64), Boolean> Body => (__in) =>
        {
            var (Uf,n) = __in;
#line 32 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            var resultArray = new QArray<Result>(n);
#line hidden
            {
#line 35 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                var qubits = Allocate.Apply((n + 1L));
#line 38 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[n]);
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, qubits?.Copy()));
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                Uf.Apply(qubits?.Copy());
#line 46 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, qubits?.Slice(new Range(0L, (n - 1L)))));
#line 49 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                {
#line 50 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                    resultArray[idx] = MicrosoftQuantumCanonMResetZ.Apply(qubits[idx]);
                }

#line 54 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                Reset.Apply(qubits[n]);
#line hidden
                Release.Apply(qubits);
            }

#line 58 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            return MicrosoftQuantumCanonForAll.Apply<Boolean>((MicrosoftQuantumCanonIsResultZero, resultArray?.Copy()));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonForAll = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ForAll<>));
            this.MicrosoftQuantumCanonIsResultZero = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.IsResultZero));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((ICallable,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, ICallable Uf, Int64 n)
        {
            return __m__.Run<CheckConstantBooleanFunction, (ICallable,Int64), Boolean>((Uf, n));
        }
    }

    public class ExecuteDeutschJozsaAlgorithm : Operation<(Int64,QArray<Int64>), Boolean>, ICallable
    {
        public ExecuteDeutschJozsaAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExecuteDeutschJozsaAlgorithm";
        String ICallable.FullName => "DeutschJozsaAlgorithm.ExecuteDeutschJozsaAlgorithm";
        protected ICallable<(ICallable,Int64), Boolean> CheckConstantBooleanFunction
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Int64>), ICallable> GetBooleanFunctionFromMarkedElements
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>), Boolean> Body => (__in) =>
        {
            var (nQubits,markedElements) = __in;
#line 67 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            return CheckConstantBooleanFunction.Apply((GetBooleanFunctionFromMarkedElements.Apply((nQubits, markedElements?.Copy())), nQubits));
        }

        ;
        public override void Init()
        {
            this.CheckConstantBooleanFunction = this.Factory.Get<ICallable<(ICallable,Int64), Boolean>>(typeof(CheckConstantBooleanFunction));
            this.GetBooleanFunctionFromMarkedElements = this.Factory.Get<ICallable<(Int64,QArray<Int64>), ICallable>>(typeof(GetBooleanFunctionFromMarkedElements));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 nQubits, QArray<Int64> markedElements)
        {
            return __m__.Run<ExecuteDeutschJozsaAlgorithm, (Int64,QArray<Int64>), Boolean>((nQubits, markedElements));
        }
    }

    public class GetBooleanFunctionFromMarkedElementsImpl : Operation<(Int64,QArray<Int64>,QArray<Qubit>), QVoid>, ICallable
    {
        public GetBooleanFunctionFromMarkedElementsImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GetBooleanFunctionFromMarkedElementsImpl";
        String ICallable.FullName => "DeutschJozsaAlgorithm.GetBooleanFunctionFromMarkedElementsImpl";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (n,markedElements,qs) = __in;
#line 73 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            var target = qs[(qs.Length - 1L)];
#line 74 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            var inputs = qs?.Slice(new Range(0L, (qs.Length - 2L)));
#line 77 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            var nMarked = markedElements.Length;
#line 79 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 82 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumPrimitiveX, _arg1))))).Apply((inputs?.Copy(), new QArray<Qubit>()
                {target}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n, QArray<Int64> markedElements, QArray<Qubit> qs)
        {
            return __m__.Run<GetBooleanFunctionFromMarkedElementsImpl, (Int64,QArray<Int64>,QArray<Qubit>), QVoid>((n, markedElements, qs));
        }
    }

    public class GetBooleanFunctionFromMarkedElements : Function<(Int64,QArray<Int64>), ICallable>, ICallable
    {
        public GetBooleanFunctionFromMarkedElements(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetBooleanFunctionFromMarkedElements";
        String ICallable.FullName => "DeutschJozsaAlgorithm.GetBooleanFunctionFromMarkedElements";
        protected ICallable<(Int64,QArray<Int64>,QArray<Qubit>), QVoid> GetBooleanFunctionFromMarkedElementsImpl
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>), ICallable> Body => (__in) =>
        {
            var (nQubits,markedElements) = __in;
#line 101 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Deutsch/Deutsch/Quantum.qs"
            return GetBooleanFunctionFromMarkedElementsImpl.Partial(new Func<QArray<Qubit>, (Int64,QArray<Int64>,QArray<Qubit>)>((_arg1) => (nQubits, markedElements?.Copy(), _arg1)));
        }

        ;
        public override void Init()
        {
            this.GetBooleanFunctionFromMarkedElementsImpl = this.Factory.Get<ICallable<(Int64,QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(GetBooleanFunctionFromMarkedElementsImpl));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, Int64 nQubits, QArray<Int64> markedElements)
        {
            return __m__.Run<GetBooleanFunctionFromMarkedElements, (Int64,QArray<Int64>), ICallable>((nQubits, markedElements));
        }
    }
}