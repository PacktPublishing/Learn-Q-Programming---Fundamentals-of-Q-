#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementOneQubit\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementOneQubit\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementTwoQubits\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementTwoQubits\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementBellBasis\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Measurement\",\"Name\":\"GetMeasurementBellBasis\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/Measurement/Measurement.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
#line hidden
namespace Measurement
{
    public class GetMeasurementOneQubit : Operation<QVoid, Result>, ICallable
    {
        public GetMeasurementOneQubit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetMeasurementOneQubit";
        String ICallable.FullName => "Measurement.GetMeasurementOneQubit";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line 12 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            var result = Result.Zero;
#line hidden
            {
#line 14 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubits = Allocate.Apply(1L);
#line 15 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubit = qubits[0L];
#line 17 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubit);
#line 18 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubit}, Result.Zero, 0.5D, "Error: Outcomes of the measurement must be equally likely", 1E-05D));
#line 20 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                result = M.Apply(qubit);
#line 22 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                if ((result == Result.One))
                {
#line 23 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubit);
                }

#line hidden
                Release.Apply(qubits);
            }

#line 27 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetMeasurementOneQubit, QVoid, Result>(QVoid.Instance);
        }
    }

    public class GetMeasurementTwoQubits : Operation<QVoid, (Result,Result)>, ICallable
    {
        public GetMeasurementTwoQubits(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetMeasurementTwoQubits";
        String ICallable.FullName => "Measurement.GetMeasurementTwoQubits";
        protected ICallable MicrosoftQuantumCanonApplyToEach
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

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
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

        public override Func<QVoid, (Result,Result)> Body => (__in__) =>
        {
#line 33 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            var result = (Result.Zero, Result.Zero);
#line hidden
            {
#line 35 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubits = Allocate.Apply(2L);
#line 37 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, qubits?.Copy()));
#line 39 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[0L]}, Result.Zero, 0.5D, "Error: Outcomes of the measurement must be equally likely", 1E-05D));
#line 41 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[1L]}, Result.Zero, 0.5D, "Error: Outcomes of the measurement must be equally likely", 1E-05D));
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                result = (MicrosoftQuantumCanonMResetZ.Apply(qubits[0L]), MicrosoftQuantumCanonMResetZ.Apply(qubits[1L]));
#line hidden
                Release.Apply(qubits);
            }

#line 46 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetMeasurementTwoQubits, QVoid, (Result,Result)>(QVoid.Instance);
        }
    }

    public class GetMeasurementBellBasis : Operation<QVoid, (Result,Result)>, ICallable
    {
        public GetMeasurementBellBasis(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetMeasurementBellBasis";
        String ICallable.FullName => "Measurement.GetMeasurementBellBasis";
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

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
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

        public override Func<QVoid, (Result,Result)> Body => (__in__) =>
        {
#line 52 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            var result = (Result.Zero, Result.Zero);
#line hidden
            {
#line 54 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubits = Allocate.Apply(2L);
#line 56 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubit0 = qubits[0L];
#line 57 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                var qubit1 = qubits[1L];
#line 58 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubit0);
#line 59 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubit0, qubit1));
#line 61 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                Assert.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qubits?.Copy(), Result.Zero, "Error: EPR state must be eigenstate of ZZ"));
#line 62 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                Assert.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX), qubits?.Copy(), Result.Zero, "Error: EPR state must be eigenstate of XX"));
#line 63 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                AssertProb.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qubits?.Copy(), Result.One, 0D, "Error: 01 or 10 should never occur as an outcome", 1E-05D));
#line 65 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                result = (M.Apply(qubit0), M.Apply(qubit1));
#line 67 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 70 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/Measurement/Measurement.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetMeasurementBellBasis, QVoid, (Result,Result)>(QVoid.Instance);
        }
    }
}