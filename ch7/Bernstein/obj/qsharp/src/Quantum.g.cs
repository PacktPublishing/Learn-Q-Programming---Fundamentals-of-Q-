#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Bernstein\",\"Name\":\"GetFourierSamplingParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" ParityViaFourierSampling implements the Bernstein-Vazirani quantum algorithm.\",\" # Parameters\",\" ## Uf\",\" A quantum operation that implements |𝑥〉|𝑦〉 ↦ |𝑥〉|𝑦 ⊕ 𝑓(𝑥)〉,\",\" where 𝑓 is a Boolean function that implements a parity Σᵢ 𝑟ᵢ 𝑥ᵢ.\",\" ## n\",\" The number of bits of the input register |𝑥〉.\",\"\",\" # Returns\",\" An array of type `Bool[]` that contains the parity 𝑟⃗ = (𝑟₀, …, 𝑟ₙ₋₁).\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Bernstein\",\"Name\":\"GetFourierSamplingParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteParityImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteParityImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"SupportedFunctors\":[]},\"Documentation\":[\" ExecuteParity function\",\" # Summary\",\"  an operation implementing a unitary 𝑈\",\" # Parameters\",\" ## pattern\",\" The bitstring 𝑟⃗ used to define the function 𝑓.\",\"\",\" # Returns\",\" An operation implementing 𝑈.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteParity\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteBernsteinVaziraniAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"patternInt\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Bernstein\",\"Name\":\"ExecuteBernsteinVaziraniAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
#line hidden
namespace Bernstein
{
    public class GetFourierSamplingParity : Operation<(ICallable,Int64), QArray<Boolean>>, ICallable
    {
        public GetFourierSamplingParity(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64)>, IApplyData
        {
            public In((ICallable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GetFourierSamplingParity";
        String ICallable.FullName => "Bernstein.GetFourierSamplingParity";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, QArray<Boolean>> MicrosoftQuantumCanonBoolArrFromResultArr
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

        public override Func<(ICallable,Int64), QArray<Boolean>> Body => (__in) =>
        {
            var (Uf,n) = __in;
#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            var resultArray = new QArray<Result>(n);
#line hidden
            {
#line 31 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                var qubits = Allocate.Apply((n + 1L));
#line 34 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[n]);
#line 37 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, qubits?.Copy()));
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                Uf.Apply(qubits?.Copy());
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, qubits?.Slice(new Range(0L, (n - 1L)))));
#line 46 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                {
#line 47 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                    resultArray[idx] = MicrosoftQuantumCanonMResetZ.Apply(qubits[idx]);
                }

#line 51 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                Reset.Apply(qubits[n]);
#line hidden
                Release.Apply(qubits);
            }

#line 55 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            Message.Apply(String.Format("measure: {0}", resultArray));
#line 56 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            return MicrosoftQuantumCanonBoolArrFromResultArr.Apply(resultArray);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonBoolArrFromResultArr = this.Factory.Get<ICallable<QArray<Result>, QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromResultArr));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((ICallable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, ICallable Uf, Int64 n)
        {
            return __m__.Run<GetFourierSamplingParity, (ICallable,Int64), QArray<Boolean>>((Uf, n));
        }
    }

    public class ExecuteParityImpl : Operation<(QArray<Boolean>,QArray<Qubit>), QVoid>, ICallable
    {
        public ExecuteParityImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ExecuteParityImpl";
        String ICallable.FullName => "Bernstein.ExecuteParityImpl";
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

        public override Func<(QArray<Boolean>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (pattern,qs) = __in;
#line 64 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            var n = pattern.Length;
#line 66 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            if ((qs.Length != (n + 1L)))
            {
#line 67 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                throw new ExecutionFailException("Length of qs should be equal to pattern length + 1.");
            }

#line 70 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 72 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                if (pattern[idx])
                {
#line 73 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
                    {qs[idx]}, qs[n]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Boolean> pattern, QArray<Qubit> qs)
        {
            return __m__.Run<ExecuteParityImpl, (QArray<Boolean>,QArray<Qubit>), QVoid>((pattern, qs));
        }
    }

    public class ExecuteParity : Function<QArray<Boolean>, ICallable>, ICallable
    {
        public ExecuteParity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ExecuteParity";
        String ICallable.FullName => "Bernstein.ExecuteParity";
        protected ICallable<(QArray<Boolean>,QArray<Qubit>), QVoid> ExecuteParityImpl
        {
            get;
            set;
        }

        public override Func<QArray<Boolean>, ICallable> Body => (__in) =>
        {
            var pattern = __in;
#line 90 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            return ExecuteParityImpl.Partial(new Func<QArray<Qubit>, (QArray<Boolean>,QArray<Qubit>)>((_arg1) => (pattern?.Copy(), _arg1)));
        }

        ;
        public override void Init()
        {
            this.ExecuteParityImpl = this.Factory.Get<ICallable<(QArray<Boolean>,QArray<Qubit>), QVoid>>(typeof(ExecuteParityImpl));
        }

        public override IApplyData __dataIn(QArray<Boolean> data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, QArray<Boolean> pattern)
        {
            return __m__.Run<ExecuteParity, QArray<Boolean>, ICallable>(pattern);
        }
    }

    public class ExecuteBernsteinVaziraniAlgorithm : Operation<(Int64,Int64), Int64>, ICallable
    {
        public ExecuteBernsteinVaziraniAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExecuteBernsteinVaziraniAlgorithm";
        String ICallable.FullName => "Bernstein.ExecuteBernsteinVaziraniAlgorithm";
        protected ICallable<QArray<Boolean>, ICallable> ExecuteParity
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64), QArray<Boolean>> GetFourierSamplingParity
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> MicrosoftQuantumCanonBoolArrFromPositiveInt
        {
            get;
            set;
        }

        protected ICallable<QArray<Boolean>, Int64> MicrosoftQuantumCanonPositiveIntFromBoolArr
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (nQubits,patternInt) = __in;
#line 97 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            var pattern = MicrosoftQuantumCanonBoolArrFromPositiveInt.Apply((patternInt, nQubits));
#line 98 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            var result = GetFourierSamplingParity.Apply((ExecuteParity.Apply(pattern), nQubits));
#line 99 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Bernstein/Bernstein/Quantum.qs"
            return MicrosoftQuantumCanonPositiveIntFromBoolArr.Apply(result);
        }

        ;
        public override void Init()
        {
            this.ExecuteParity = this.Factory.Get<ICallable<QArray<Boolean>, ICallable>>(typeof(ExecuteParity));
            this.GetFourierSamplingParity = this.Factory.Get<ICallable<(ICallable,Int64), QArray<Boolean>>>(typeof(GetFourierSamplingParity));
            this.MicrosoftQuantumCanonBoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
            this.MicrosoftQuantumCanonPositiveIntFromBoolArr = this.Factory.Get<ICallable<QArray<Boolean>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromBoolArr));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 nQubits, Int64 patternInt)
        {
            return __m__.Run<ExecuteBernsteinVaziraniAlgorithm, (Int64,Int64), Int64>((nQubits, patternInt));
        }
    }
}