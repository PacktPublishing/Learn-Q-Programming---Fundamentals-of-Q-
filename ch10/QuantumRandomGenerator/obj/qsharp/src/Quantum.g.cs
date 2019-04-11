#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumRandomGenerator\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CoinFlip/Quantum.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" Set Operation\",\" # Summary\",\" sets the Qubit with desired value.\",\" # Parameters\",\" ## desired\",\" desired parameter of Result type\",\" ## q1\",\" qubit\",\"\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumRandomGenerator\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CoinFlip/Quantum.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumRandomGenerator\",\"Name\":\"GenerateRandomness\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CoinFlip/Quantum.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" GenerateRandomness Operation\",\" # Summary\",\" returns the count of zeros and ones\",\" # Parameters\",\" ## count\",\" count parameter of Integer type\",\" # Returns\",\" a tuple of Two Integers\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumRandomGenerator\",\"Name\":\"GenerateRandomness\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CoinFlip/Quantum.qs\",\"Position\":{\"Item1\":36,\"Item2\":11},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace QuantumRandomGenerator
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "QuantumRandomGenerator.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (desired,q1) = __in;
#line 20 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
            var current = M.Apply(q1);
#line 21 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
            if ((desired != current))
            {
#line 23 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class GenerateRandomness : Operation<Int64, (Int64,Int64)>, ICallable
    {
        public GenerateRandomness(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GenerateRandomness";
        String ICallable.FullName => "QuantumRandomGenerator.GenerateRandomness";
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

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<Int64, (Int64,Int64)> Body => (__in) =>
        {
            var count = __in;
#line 38 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
            var countOnes = 0L;
#line 39 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
            var countZeros = 0L;
#line hidden
            {
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                var MyQubit = Allocate.Apply(1L);
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                foreach (var test in new Range(1L, count))
#line hidden
                {
#line 41 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                    Set.Apply((Result.Zero, MyQubit[0L]));
#line 42 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                    MicrosoftQuantumPrimitiveH.Apply(MyQubit[0L]);
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                    var state = M.Apply(MyQubit[0L]);
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                    if ((state == Result.Zero))
                    {
#line 44 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                        countZeros = (countZeros + 1L);
                    }

#line 45 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                    if ((state == Result.One))
                    {
#line 46 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                        countOnes = (countOnes + 1L);
                    }
                }

#line 48 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
                ResetAll.Apply(MyQubit?.Copy());
#line hidden
                Release.Apply(MyQubit);
            }

#line 50 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CoinFlip/Quantum.qs"
            return (countZeros, countOnes);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<GenerateRandomness, Int64, (Int64,Int64)>(count);
        }
    }
}