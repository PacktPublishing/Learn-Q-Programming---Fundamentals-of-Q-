#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGame\",\"Name\":\"MeasureQbitOfAlice\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[\" MeasureQbitOfAlice Operation\",\"\",\" # Summary\",\"\",\" measures Alice Qbit\",\"\",\" # Parameters\",\"\",\" ## bit\",\"\",\" boolean value\",\"\",\" ## qubit\",\"\",\" Qubit\",\"\",\" # Return\",\"\",\" Result\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGame\",\"Name\":\"MeasureQbitOfAlice\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGame\",\"Name\":\"MeasureQbitOfBob\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[\" MeasureQbitOfBob Operation\",\"\",\" # Summary\",\"\",\" measures Bob Qbit\",\"\",\" # Parameters\",\"\",\" ## bit\",\"\",\" boolean value\",\"\",\" ## qubit\",\"\",\" Qubit\",\"\",\" # Return\",\"\",\" Result\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGame\",\"Name\":\"MeasureQbitOfBob\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGame\",\"Name\":\"PlayQuantumGame\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aliceBit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bobBit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":15}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aliceMeasuresFirst\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[\" PlayQuantumGame Operation\",\"\",\" # Summary\",\"\",\" checks if aliceBit equal to Bob bit\",\"\",\" # Parameters\",\"\",\" ## aliceBit\",\"\",\" boolean value\",\"\",\" ## bobBit\",\"\",\" boolean value\",\"\",\" ## aliceMeasuresFirst\",\"\",\" boolean value\",\"\",\" # Return\",\"\",\" boolean value\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGame\",\"Name\":\"PlayQuantumGame\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/CHSHGame/Game.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace QuantumGame
{
    public class MeasureQbitOfAlice : Operation<(Boolean,Qubit), Result>, ICallable
    {
        public MeasureQbitOfAlice(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "MeasureQbitOfAlice";
        String ICallable.FullName => "QuantumGame.MeasureQbitOfAlice";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Result> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 30 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
            if (bit)
            {
#line 33 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliX}, new QArray<Qubit>()
                {qubit}));
            }
            else
            {
#line 38 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubit}));
            }
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<MeasureQbitOfAlice, (Boolean,Qubit), Result>((bit, qubit));
        }
    }

    public class MeasureQbitOfBob : Operation<(Boolean,Qubit), Result>, ICallable
    {
        public MeasureQbitOfBob(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "MeasureQbitOfBob";
        String ICallable.FullName => "QuantumGame.MeasureQbitOfBob";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Result> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 64 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
            if (bit)
            {
#line 67 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                var rotation = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 8D);
#line 68 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                MicrosoftQuantumPrimitiveRy.Apply((rotation, qubit));
#line 69 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                return M.Apply(qubit);
            }
            else
            {
#line 74 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                var rotation = ((-(2D) * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 8D);
#line 75 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                MicrosoftQuantumPrimitiveRy.Apply((rotation, qubit));
#line 76 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                return M.Apply(qubit);
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<MeasureQbitOfBob, (Boolean,Qubit), Result>((bit, qubit));
        }
    }

    public class PlayQuantumGame : Operation<(Boolean,Boolean,Boolean), Boolean>, ICallable
    {
        public PlayQuantumGame(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Boolean)>, IApplyData
        {
            public In((Boolean,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PlayQuantumGame";
        String ICallable.FullName => "QuantumGame.PlayQuantumGame";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Result> MeasureQbitOfAlice
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Result> MeasureQbitOfBob
        {
            get;
            set;
        }

        public override Func<(Boolean,Boolean,Boolean), Boolean> Body => (__in__) =>
        {
            var (aliceBit,bobBit,aliceMeasuresFirst) = __in__;
#line 110 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
            var aliceResult = Result.Zero;
#line 111 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
            var bobResult = Result.Zero;
#line hidden
            {
#line 113 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                var qubits = Allocate.Apply(2L);
#line 116 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                var aliceQbit = qubits[0L];
#line 117 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                var bobQbit = qubits[1L];
#line 120 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                MicrosoftQuantumPrimitiveH.Apply(aliceQbit);
#line 121 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((aliceQbit, bobQbit));
#line 124 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                if (aliceMeasuresFirst)
                {
#line 126 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                    aliceResult = MeasureQbitOfAlice.Apply((aliceBit, aliceQbit));
#line 127 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                    bobResult = MeasureQbitOfBob.Apply((bobBit, bobQbit));
                }
                else
                {
#line 131 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                    bobResult = MeasureQbitOfBob.Apply((bobBit, bobQbit));
#line 132 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                    aliceResult = MeasureQbitOfAlice.Apply((aliceBit, aliceQbit));
                }

#line 135 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 138 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/CHSHGame/Game.qs"
            return (aliceResult == bobResult);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MeasureQbitOfAlice = this.Factory.Get<ICallable<(Boolean,Qubit), Result>>(typeof(MeasureQbitOfAlice));
            this.MeasureQbitOfBob = this.Factory.Get<ICallable<(Boolean,Qubit), Result>>(typeof(MeasureQbitOfBob));
        }

        public override IApplyData __dataIn((Boolean,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean aliceBit, Boolean bobBit, Boolean aliceMeasuresFirst)
        {
            return __m__.Run<PlayQuantumGame, (Boolean,Boolean,Boolean), Boolean>((aliceBit, bobBit, aliceMeasuresFirst));
        }
    }
}