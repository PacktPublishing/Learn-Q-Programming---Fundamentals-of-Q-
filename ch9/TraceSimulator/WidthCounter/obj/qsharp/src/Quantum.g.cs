#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"WidthCounter\",\"Name\":\"GetWidthCounter\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/WidthCounter/Quantum.qs\",\"Position\":{\"Item1\":15,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numberOfQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" GetWidthCounter Operation\",\" # Summary\",\" executes X Gate\",\" # Parameters\",\" numberOfQubits\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"WidthCounter\",\"Name\":\"GetWidthCounter\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/WidthCounter/Quantum.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace WidthCounter
{
    public class GetWidthCounter : Operation<Int64, QVoid>, ICallable
    {
        public GetWidthCounter(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetWidthCounter";
        String ICallable.FullName => "WidthCounter.GetWidthCounter";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var numberOfQubits = __in;
#line hidden
            {
#line 18 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/WidthCounter/Quantum.qs"
                var qubits = Allocate.Apply(numberOfQubits);
#line 19 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/WidthCounter/Quantum.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((qubits?.Slice(new Range(1L, (numberOfQubits - 1L))), qubits[0L]));
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numberOfQubits)
        {
            return __m__.Run<GetWidthCounter, Int64, QVoid>(numberOfQubits);
        }
    }
}