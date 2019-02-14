#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DistinctIputsChecker\",\"Name\":\"ExecuteTwoOperations\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs\",\"Position\":{\"Item1\":23,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":83}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" ExecuteTwoOperations operation\",\" # Summary\",\" executes the two operations\",\" # Parameters\",\" ## q1\",\" first qubit\",\" ## q2\",\" second qubit\",\" ## op1\",\" first operation\",\" ## op2\",\" second operation\",\"\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DistinctIputsChecker\",\"Name\":\"ExecuteTwoOperations\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DistinctIputsChecker\",\"Name\":\"CheckDistinctInputs\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs\",\"Position\":{\"Item1\":35,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" CheckDistinctInputs Operation\",\" # Summary\",\" Checks Distinct Inputs\",\" # Parameters\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"DistinctIputsChecker\",\"Name\":\"CheckDistinctInputs\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace DistinctIputsChecker
{
    public class ExecuteTwoOperations : Operation<(Qubit,Qubit,ICallable,ICallable), QVoid>, ICallable
    {
        public ExecuteTwoOperations(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,ICallable,ICallable)>, IApplyData
        {
            public In((Qubit,Qubit,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ExecuteTwoOperations";
        String ICallable.FullName => "DistinctIputsChecker.ExecuteTwoOperations";
        public override Func<(Qubit,Qubit,ICallable,ICallable), QVoid> Body => (__in) =>
        {
            var (q1,q2,op1,op2) = __in;
#line 26 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
            op1.Apply(q1);
#line 27 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
            op2.Apply(q2);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Qubit,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, ICallable op1, ICallable op2)
        {
            return __m__.Run<ExecuteTwoOperations, (Qubit,Qubit,ICallable,ICallable), QVoid>((q1, q2, op1, op2));
        }
    }

    public class CheckDistinctInputs : Operation<QVoid, QVoid>, ICallable
    {
        public CheckDistinctInputs(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CheckDistinctInputs";
        String ICallable.FullName => "DistinctIputsChecker.CheckDistinctInputs";
        protected ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid> ExecuteTwoOperations
        {
            get;
            set;
        }

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

        protected Release Release
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 38 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
                var q = Allocate.Apply(3L);
#line 39 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
                var op1 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, q[1L])));
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
                var op2 = MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg2) => (q[1L], _arg2)));
#line 41 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/DistinctInputsChecker/Quantum.qs"
                ExecuteTwoOperations.Apply((q[0L], q[2L], op1, op2));
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ExecuteTwoOperations = this.Factory.Get<ICallable<(Qubit,Qubit,ICallable,ICallable), QVoid>>(typeof(ExecuteTwoOperations));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<CheckDistinctInputs, QVoid, QVoid>(QVoid.Instance);
        }
    }
}