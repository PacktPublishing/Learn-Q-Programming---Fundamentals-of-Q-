#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Factoring\",\"Name\":\"Factoring\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"number\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"useRobustPhaseEstimation\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" finding the factors of the number\",\"\",\" # Input\",\" ## number\",\" An integer to be factored\",\" ## useRobustPhaseEstimation\",\" Microsoft.Quantum.Canon.RobustPhaseEstimation if true\",\"\",\" # Output\",\" two factors\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"Factoring\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Factoring\",\"Name\":\"GetOrder\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulus\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" find target given the order\",\"\",\" # Input\",\" ## generator\",\" The unsigned integer multiplicative order\",\" ## modulus\",\" modulus\",\" ## power\",\" Power of generator multiplied by target\",\" ## target\",\" target\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"GetOrder\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":89,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"GetOrder\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"GetOrder\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":98,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"GetOrder\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":99,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Factoring\",\"Name\":\"PeriodEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulus\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"useRobustPhaseEstimation\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":84}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" generates a multiplicative order of the number\",\"\",\" # Input\",\" ## generator\",\" The unsigned integer multiplicative order\",\" ## modulus\",\" The modulus\",\" ## useRobustPhaseEstimation\",\" Microsoft.Quantum.Canon.RobustPhaseEstimation is used if true\",\"\",\" # Output\",\" The period of the generator\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Factoring\",\"Name\":\"PeriodEstimator\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter10/Factoring/Shor.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace Factoring
{
    public class Factoring : Operation<(Int64,Boolean), (Int64,Int64)>, ICallable
    {
        public Factoring(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Boolean)>, IApplyData
        {
            public In((Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Factoring";
        String ICallable.FullName => "Factoring.Factoring";
        protected ICallable<(Int64,Int64,Boolean), Int64> PeriodEstimator
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonGCD
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Boolean> MicrosoftQuantumCanonIsCoprime
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumExtensionsMathMaxI
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<(Int64,Boolean), (Int64,Int64)> Body => (__in) =>
        {
            var (number,useRobustPhaseEstimation) = __in;
#line 23 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            if (((number % 2L) == 0L))
            {
#line 24 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                Message.Apply("The number is even");
#line 25 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                return ((number / 2L), 2L);
            }

#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            var coprimeCandidate = (MicrosoftQuantumCanonRandomInt.Apply((number - 2L)) + 1L);
#line 30 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            if (MicrosoftQuantumCanonIsCoprime.Apply((coprimeCandidate, number)))
            {
#line 32 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                Message.Apply(String.Format("period for {0}", coprimeCandidate));
#line 35 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                var period = PeriodEstimator.Apply((coprimeCandidate, number, useRobustPhaseEstimation));
#line 37 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                if (((period % 2L) == 0L))
                {
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    var halfPower = MicrosoftQuantumCanonExpMod.Apply((coprimeCandidate, (period / 2L), number));
#line 43 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    if ((halfPower != (number - 1L)))
                    {
#line 46 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                        var factor = MicrosoftQuantumExtensionsMathMaxI.Apply((MicrosoftQuantumCanonGCD.Apply(((halfPower - 1L), number)), MicrosoftQuantumCanonGCD.Apply(((halfPower + 1L), number))));
#line 48 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                        return (factor, (number / factor));
                    }
                    else
                    {
#line 53 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                        throw new ExecutionFailException("Residue ");
                    }
                }
                else
                {
#line 59 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    throw new ExecutionFailException("Period is a odd number");
                }
            }
            else
            {
#line 65 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                var gcd = MicrosoftQuantumCanonGCD.Apply((number, coprimeCandidate));
#line 68 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                Message.Apply(String.Format("The divisor of {0} is  {1} ", number, gcd));
#line 71 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                return (gcd, (number / gcd));
            }
        }

        ;
        public override void Init()
        {
            this.PeriodEstimator = this.Factory.Get<ICallable<(Int64,Int64,Boolean), Int64>>(typeof(PeriodEstimator));
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonGCD = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.GCD));
            this.MicrosoftQuantumCanonIsCoprime = this.Factory.Get<ICallable<(Int64,Int64), Boolean>>(typeof(Microsoft.Quantum.Canon.IsCoprime));
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
            this.MicrosoftQuantumExtensionsMathMaxI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Extensions.Math.MaxI));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn((Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 number, Boolean useRobustPhaseEstimation)
        {
            return __m__.Run<Factoring, (Int64,Boolean), (Int64,Int64)>((number, useRobustPhaseEstimation));
        }
    }

    public class GetOrder : Unitary<(Int64,Int64,Int64,QArray<Qubit>)>, ICallable
    {
        public GetOrder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item4)?.Qubits;
        }

        String ICallable.Name => "GetOrder";
        String ICallable.FullName => "Factoring.GetOrder";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Boolean> MicrosoftQuantumCanonIsCoprime
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (generator,modulus,power,target) = __in;
#line 91 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line 94 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((MicrosoftQuantumCanonExpMod.Apply((generator, power, modulus)), modulus, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (generator,modulus,power,target) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Adjoint.Apply((MicrosoftQuantumCanonExpMod.Apply((generator, power, modulus)), modulus, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (__controlQubits__,(generator,modulus,power,target)) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonExpMod.Apply((generator, power, modulus)), modulus, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (__controlQubits__,(generator,modulus,power,target)) = __in;
#line hidden
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonExpMod.Apply((generator, power, modulus)), modulus, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonIsCoprime = this.Factory.Get<ICallable<(Int64,Int64), Boolean>>(typeof(Microsoft.Quantum.Canon.IsCoprime));
            this.MicrosoftQuantumCanonModularMultiplyByConstantLE = this.Factory.Get<IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularMultiplyByConstantLE));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 generator, Int64 modulus, Int64 power, QArray<Qubit> target)
        {
            return __m__.Run<GetOrder, (Int64,Int64,Int64,QArray<Qubit>), QVoid>((generator, modulus, power, target));
        }
    }

    public class PeriodEstimator : Operation<(Int64,Int64,Boolean), Int64>, ICallable
    {
        public PeriodEstimator(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Boolean)>, IApplyData
        {
            public In((Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PeriodEstimator";
        String ICallable.FullName => "Factoring.PeriodEstimator";
        protected IUnitary<(Int64,Int64,Int64,QArray<Qubit>)> GetOrder
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.Fraction,Int64), Microsoft.Quantum.Canon.Fraction> MicrosoftQuantumCanonContinuedFractionConvergent
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonGCD
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonInPlaceXorLE
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Boolean> MicrosoftQuantumCanonIsCoprime
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonQuantumPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathAbsI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathRound
        {
            get;
            set;
        }

        protected Allocate Allocate
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Boolean), Int64> Body => (__in) =>
        {
            var (generator,modulus,useRobustPhaseEstimation) = __in;
#line 120 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line 123 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            var result = 1L;
#line 126 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            var bitsize = MicrosoftQuantumCanonBitSize.Apply(modulus);
#line 129 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            var bitsPrecision = ((2L * bitsize) + 1L);
#line 131 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            while (true)
            {
#line 134 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                var dyadicFractionNum = 0L;
#line hidden
                {
#line 137 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    var eignestateRegister = Allocate.Apply(bitsize);
#line 140 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    var eignestateRegisterLE = new Microsoft.Quantum.Canon.LittleEndian(eignestateRegister?.Copy());
#line 141 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    MicrosoftQuantumCanonInPlaceXorLE.Apply((1L, eignestateRegisterLE));
#line 144 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    var oracle = new Microsoft.Quantum.Canon.DiscreteOracle(GetOrder.Partial(new Func<(Int64,QArray<Qubit>), (Int64,Int64,Int64,QArray<Qubit>)>((_arg1) => (generator, modulus, _arg1.Item1, _arg1.Item2))));
#line 147 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    if (useRobustPhaseEstimation)
                    {
#line 150 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                        var phase = MicrosoftQuantumCanonRobustPhaseEstimation.Apply((bitsPrecision, oracle, eignestateRegisterLE.Data));
#line 153 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                        dyadicFractionNum = MicrosoftQuantumExtensionsMathRound.Apply((((phase * MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(bitsPrecision))) / 2D) / MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)));
                    }
                    else
                    {
#line hidden
                        {
#line 158 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                            var dyadicFractionNumerator = Allocate.Apply(bitsPrecision);
#line 161 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                            var dyadicFractionNumeratorBE = new Microsoft.Quantum.Canon.BigEndian(dyadicFractionNumerator?.Copy());
#line 162 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                            MicrosoftQuantumCanonQuantumPhaseEstimation.Apply((oracle, eignestateRegisterLE.Data, dyadicFractionNumeratorBE));
#line 165 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                            dyadicFractionNum = MicrosoftQuantumCanonMeasureIntegerBE.Apply(dyadicFractionNumeratorBE);
#line hidden
                            Release.Apply(dyadicFractionNumerator);
                        }
                    }

#line 170 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    ResetAll.Apply(eignestateRegister?.Copy());
#line hidden
                    Release.Apply(eignestateRegister);
                }

#line 173 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                if ((dyadicFractionNum == 0L))
                {
#line 174 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    throw new ExecutionFailException("measured 0 : numerator");
                }

#line 178 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                Message.Apply(String.Format("Estimated eigenvalue is {0}/2^{1}.", dyadicFractionNum, bitsPrecision));
#line 181 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                var (numerator,period) = MicrosoftQuantumCanonContinuedFractionConvergent.Apply((new Microsoft.Quantum.Canon.Fraction((dyadicFractionNum, 2L.Pow(bitsPrecision))), modulus)).Data;
#line 184 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                var (numeratorAbs,periodAbs) = (MicrosoftQuantumExtensionsMathAbsI.Apply(numerator), MicrosoftQuantumExtensionsMathAbsI.Apply(period));
#line 187 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                Message.Apply((String.Format("divisor for period : {0}, ", periodAbs) + String.Format(" eigenstate project {0}.", numeratorAbs)));
#line 190 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                result = ((periodAbs * result) / MicrosoftQuantumCanonGCD.Apply((result, periodAbs)));
                if ((MicrosoftQuantumCanonExpMod.Apply((generator, result, modulus)) == 1L))
                {
                    break;
                }
                else
                {
#line 196 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
                    Message.Apply(("period divisors " + "divisor for the period. second try ..."));
                }
            }

#line 200 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter10/Factoring/Shor.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.GetOrder = this.Factory.Get<IUnitary<(Int64,Int64,Int64,QArray<Qubit>)>>(typeof(GetOrder));
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonContinuedFractionConvergent = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.Fraction,Int64), Microsoft.Quantum.Canon.Fraction>>(typeof(Microsoft.Quantum.Canon.ContinuedFractionConvergent));
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonGCD = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.GCD));
            this.MicrosoftQuantumCanonInPlaceXorLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.InPlaceXorLE));
            this.MicrosoftQuantumCanonIsCoprime = this.Factory.Get<ICallable<(Int64,Int64), Boolean>>(typeof(Microsoft.Quantum.Canon.IsCoprime));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumCanonQuantumPhaseEstimation = this.Factory.Get<IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.QuantumPhaseEstimation));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathAbsI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.AbsI));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Round));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 generator, Int64 modulus, Boolean useRobustPhaseEstimation)
        {
            return __m__.Run<PeriodEstimator, (Int64,Int64,Boolean), Int64>((generator, modulus, useRobustPhaseEstimation));
        }
    }
}