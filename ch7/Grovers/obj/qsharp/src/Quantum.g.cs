#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grovers\",\"Name\":\"GetDataFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Database oracle `D` constructed from classical database.\",\"\",\" # Parameters\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"GetDataFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"GetDataFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"GetDataFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"GetDataFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Preparation of start state from database oracle and oracle `U` that\",\" creates a uniform superposition over database indices.\",\"\",\" # Parameters\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\" ## startQubits\",\" The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`\",\" initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":64,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"StateOracle\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" `StateOracle` type for the preparation of a start state that has a\",\" marked qubit entangled with some desired state in the database\",\" register.\",\"\",\" # Parameters\",\" ## markedElements\",\" Indices to marked elements in database.\",\"\",\" # Returns\",\" A `StateOracle` type with signature\",\" ((Int, Qubit[]) => (): Adjoint, Controlled).\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"SetupGroverStateOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Grovers\",\"Name\":\"ExecuteSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":80}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Grover's search algorithm using library functions.\",\"\",\" # Parameters\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of iterations of the Grover iteration to apply.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\"\",\" # Returns\",\" Unitary implementing Grover's search algorithm.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"ExecuteSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grovers\",\"Name\":\"ExecuteGroversAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":121,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked elements and returns an index\",\" to the found element in integer format.\",\"\",\" # Parameters\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Returns\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register converted to an integer.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Grovers\",\"Name\":\"ExecuteGroversAlgorithm\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter7/Grover/Grovers/Quantum.qs\",\"Position\":{\"Item1\":122,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Grovers
{
    public class GetDataFromInts : Unitary<(QArray<Int64>,Qubit,QArray<Qubit>)>, ICallable
    {
        public GetDataFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GetDataFromInts";
        String ICallable.FullName => "Grovers.GetDataFromInts";
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

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in;
#line 23 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            var nMarked = markedElements.Length;
#line 24 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumPrimitiveX, _arg1))))).Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumPrimitiveX, _arg1))))).Adjoint.Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumPrimitiveX, _arg1))))).Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumPrimitiveX, _arg1))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
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
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<GetDataFromInts, (QArray<Int64>,Qubit,QArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class SetupGroverStateOracleImpl : Unitary<(QArray<Int64>,Int64,QArray<Qubit>)>, ICallable
    {
        public SetupGroverStateOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "SetupGroverStateOracleImpl";
        String ICallable.FullName => "Grovers.SetupGroverStateOracleImpl";
        protected IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)> GetDataFromInts
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in;
#line 54 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 55 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line 57 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line 59 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            GetDataFromInts.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            GetDataFromInts.Adjoint.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            GetDataFromInts.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            GetDataFromInts.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GetDataFromInts = this.Factory.Get<IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)>>(typeof(GetDataFromInts));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 idxMarkedQubit, QArray<Qubit> startQubits)
        {
            return __m__.Run<SetupGroverStateOracleImpl, (QArray<Int64>,Int64,QArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public class SetupGroverStateOracle : Function<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>, ICallable
    {
        public SetupGroverStateOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SetupGroverStateOracle";
        String ICallable.FullName => "Grovers.SetupGroverStateOracle";
        protected IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)> SetupGroverStateOracleImpl
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> Body => (__in) =>
        {
            var markedElements = __in;
#line 82 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            return new Microsoft.Quantum.Canon.StateOracle(SetupGroverStateOracleImpl.Partial(new Func<(Int64,QArray<Qubit>), (QArray<Int64>,Int64,QArray<Qubit>)>((_arg1) => (markedElements?.Copy(), _arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.SetupGroverStateOracleImpl = this.Factory.Get<IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)>>(typeof(SetupGroverStateOracleImpl));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.StateOracle data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.StateOracle> Run(IOperationFactory __m__, QArray<Int64> markedElements)
        {
            return __m__.Run<SetupGroverStateOracle, QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>(markedElements);
        }
    }

    public class ExecuteSearch : Function<(QArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public ExecuteSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExecuteSearch";
        String ICallable.FullName => "Grovers.ExecuteSearch";
        protected ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> SetupGroverStateOracle
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), IUnitary> Body => (__in) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in;
#line 103 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            return MicrosoftQuantumCanonAmpAmpByOracle.Apply((nIterations, SetupGroverStateOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.SetupGroverStateOracle = this.Factory.Get<ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>>(typeof(SetupGroverStateOracle));
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<ExecuteSearch, (QArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public class ExecuteGroversAlgorithm : Operation<(QArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ExecuteGroversAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Int64)>, IApplyData
        {
            public Out((Result,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExecuteGroversAlgorithm";
        String ICallable.FullName => "Grovers.ExecuteGroversAlgorithm";
        protected ICallable<(QArray<Int64>,Int64,Int64), IUnitary> ExecuteSearch
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonPositiveIntFromResultArr
        {
            get;
            set;
        }

        protected Allocate Allocate
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

        public override Func<(QArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in;
#line 125 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            var resultSuccess = Result.Zero;
#line 126 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            var numberElement = 0L;
#line hidden
            {
#line 128 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 131 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                var markedQubit = qubits[0L];
#line 134 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 137 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                ExecuteSearch.Apply((markedElements?.Copy(), nIterations, 0L)).Apply(qubits?.Copy());
#line 140 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                resultSuccess = M.Apply(markedQubit);
#line 143 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                var resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 145 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                numberElement = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply(resultElement);
#line 148 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 151 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter7/Grover/Grovers/Quantum.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.ExecuteSearch = this.Factory.Get<ICallable<(QArray<Int64>,Int64,Int64), IUnitary>>(typeof(ExecuteSearch));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonPositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ExecuteGroversAlgorithm, (QArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}