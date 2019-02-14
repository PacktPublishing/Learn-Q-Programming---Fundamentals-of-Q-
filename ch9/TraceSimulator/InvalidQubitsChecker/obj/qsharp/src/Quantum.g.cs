#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"InvalidQubitsChecker\",\"Name\":\"CheckForReleasedQubit\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs\",\"Position\":{\"Item1\":13,\"Item2\":3},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" CheckForReleasedQubit Operation\",\" # Summary\",\" checks for Released Qubit\",\" # Parameters\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"InvalidQubitsChecker\",\"Name\":\"CheckForReleasedQubit\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace InvalidQubitsChecker
{
    public class CheckForReleasedQubit : Operation<QVoid, QVoid>, ICallable
    {
        public CheckForReleasedQubit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckForReleasedQubit";
        String ICallable.FullName => "InvalidQubitsChecker.CheckForReleasedQubit";
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 16 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs"
            var q = new QArray<Qubit>(1L);
#line hidden
            {
#line 17 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs"
                var ans = Allocate.Apply(1L);
#line 18 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs"
                q[0L] = ans[0L];
#line hidden
                Release.Apply(ans);
            }

#line 20 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/InvalidQubitsChecker/Quantum.qs"
            MicrosoftQuantumPrimitiveH.Apply(q[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CheckForReleasedQubit, QVoid, QVoid>(QVoid.Instance);
        }
    }
}