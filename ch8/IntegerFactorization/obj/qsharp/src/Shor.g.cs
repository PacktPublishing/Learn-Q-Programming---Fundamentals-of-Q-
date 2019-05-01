#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"Shor\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"number\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"useRobustPhaseEstimation\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" This sample contains Q# code implementing Shor's quantum algorithm for\",\" factoring integers. The underlying modular arithmetic is implemented\",\" in phase encoding, based on a paper by Stephane Beauregard who gave a\",\" quantum circuit for factoring n-bit numbers that needs 2n+3 qubits and\",\" O(n³log(n)) elementary quantum gates.\",\"\",\"\",\"\",\" # Summary\",\" Uses Shor's algorithm to factor the parameter `number`\",\"\",\" # Input\",\" ## number\",\" An integer to be factored\",\" ## useRobustPhaseEstimation\",\" If set to true, we use Microsoft.Quantum.Canon.RobustPhaseEstimation and\",\" Microsoft.Quantum.Canon.QuantumPhaseEstimation otherwise\",\"\",\" # Output\",\" Pair of numbers p > 1 and q > 1 such that p⋅q = `number`\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"Shor\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"OrderFindingOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulus\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Interprets `target` as encoding unsigned little-endian integer k\",\" and performs transformation |k⟩ ↦ |gᵖ⋅k mod N ⟩ where\",\" p is `power`, g is `generator` and N is `modulus`.\",\"\",\" # Input\",\" ## generator\",\" The unsigned integer multiplicative order ( period )\",\" of which is being estimated. Must be co-prime to `modulus`.\",\" ## modulus\",\" The modulus which defines the residue ring Z mod `modulus`\",\" in which the multiplicative order of `generator` is being estimated.\",\" ## power\",\" Power of `generator` by which `target` is multiplied.\",\" ## target\",\" Register interpreted as LittleEndian which is multiplied by\",\" given power of the generator. The multiplication is performed modulo\",\" `modulus`.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"OrderFindingOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":131,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"OrderFindingOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":146,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"OrderFindingOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":150,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"OrderFindingOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":151,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"EstimatePeriod\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":172,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulus\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"useRobustPhaseEstimation\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":83}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Finds a multiplicative order of the generator\",\" in the residue ring Z mod `modulus`.\",\"\",\" # Input\",\" ## generator\",\" The unsigned integer multiplicative order ( period )\",\" of which is being estimated. Must be co-prime to `modulus`.\",\" ## modulus\",\" The modulus which defines the residue ring Z mod `modulus`\",\" in which the multiplicative order of `generator` is being estimated.\",\" ## useRobustPhaseEstimation\",\" If set to true, we use Microsoft.Quantum.Canon.RobustPhaseEstimation and\",\" Microsoft.Quantum.Canon.QuantumPhaseEstimation\",\"\",\" # Output\",\" The period ( multiplicative order ) of the generator mod `modulus`\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.IntegerFactorization\",\"Name\":\"EstimatePeriod\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/IntegerFactorization/Shor.qs\",\"Position\":{\"Item1\":172,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Samples.IntegerFactorization
{
    public class Shor : Operation<(Int64,Boolean), (Int64,Int64)>, ICallable
    {
        public Shor(IOperationFactory m) : base(m)
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

        String ICallable.Name => "Shor";
        String ICallable.FullName => "Microsoft.Quantum.Samples.IntegerFactorization.Shor";
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

        protected ICallable<(Int64,Int64,Boolean), Int64> EstimatePeriod
        {
            get;
            set;
        }

        public override Func<(Int64,Boolean), (Int64,Int64)> Body => (__in) =>
        {
            var (number,useRobustPhaseEstimation) = __in;
#line 40 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            if (((number % 2L) == 0L))
            {
#line 41 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                Message.Apply("An even number has been passed; 2 is the factor.");
#line 42 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                return ((number / 2L), 2L);
            }

#line 47 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            var coprimeCandidate = (MicrosoftQuantumCanonRandomInt.Apply((number - 2L)) + 1L);
#line 52 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            if (MicrosoftQuantumCanonIsCoprime.Apply((coprimeCandidate, number)))
            {
#line 56 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                Message.Apply(String.Format("Estimating period of {0}", coprimeCandidate));
#line 61 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                var period = EstimatePeriod.Apply((coprimeCandidate, number, useRobustPhaseEstimation));
#line 64 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                if (((period % 2L) == 0L))
                {
#line 68 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    var halfPower = MicrosoftQuantumCanonExpMod.Apply((coprimeCandidate, (period / 2L), number));
#line 72 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    if ((halfPower != (number - 1L)))
                    {
#line 77 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                        var factor = MicrosoftQuantumExtensionsMathMaxI.Apply((MicrosoftQuantumCanonGCD.Apply(((halfPower - 1L), number)), MicrosoftQuantumCanonGCD.Apply(((halfPower + 1L), number))));
#line 80 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                        return (factor, (number / factor));
                    }
                    else
                    {
#line 86 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                        throw new ExecutionFailException("Residue xᵃ = -1 (mod N) where a is a period.");
                    }
                }
                else
                {
#line 93 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    throw new ExecutionFailException("Period is odd.");
                }
            }
            else
            {
#line 100 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                var gcd = MicrosoftQuantumCanonGCD.Apply((number, coprimeCandidate));
#line 104 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                Message.Apply(String.Format("We have guessed a divisor of {0} to be {1} by accident.", number, gcd));
#line 107 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                return (gcd, (number / gcd));
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonGCD = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.GCD));
            this.MicrosoftQuantumCanonIsCoprime = this.Factory.Get<ICallable<(Int64,Int64), Boolean>>(typeof(Microsoft.Quantum.Canon.IsCoprime));
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
            this.MicrosoftQuantumExtensionsMathMaxI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Extensions.Math.MaxI));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.EstimatePeriod = this.Factory.Get<ICallable<(Int64,Int64,Boolean), Int64>>(typeof(EstimatePeriod));
        }

        public override IApplyData __dataIn((Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 number, Boolean useRobustPhaseEstimation)
        {
            return __m__.Run<Shor, (Int64,Boolean), (Int64,Int64)>((number, useRobustPhaseEstimation));
        }
    }

    public class OrderFindingOracle : Unitary<(Int64,Int64,Int64,QArray<Qubit>)>, ICallable
    {
        public OrderFindingOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item4)?.Qubits;
        }

        String ICallable.Name => "OrderFindingOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.IntegerFactorization.OrderFindingOracle";
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
#line 134 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line 144 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
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
            return __m__.Run<OrderFindingOracle, (Int64,Int64,Int64,QArray<Qubit>), QVoid>((generator, modulus, power, target));
        }
    }

    public class EstimatePeriod : Operation<(Int64,Int64,Boolean), Int64>, ICallable
    {
        public EstimatePeriod(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Boolean)>, IApplyData
        {
            public In((Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "EstimatePeriod";
        String ICallable.FullName => "Microsoft.Quantum.Samples.IntegerFactorization.EstimatePeriod";
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

        protected IUnitary<(Int64,Int64,Int64,QArray<Qubit>)> OrderFindingOracle
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Boolean), Int64> Body => (__in) =>
        {
            var (generator,modulus,useRobustPhaseEstimation) = __in;
#line 176 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply((MicrosoftQuantumCanonIsCoprime.Apply((generator, modulus)), true, "`generator` and `modulus` must be co-prime"));
#line 179 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            var result = 1L;
#line 182 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            var bitsize = MicrosoftQuantumCanonBitSize.Apply(modulus);
#line 192 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            var bitsPrecision = ((2L * bitsize) + 1L);
#line 194 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            while (true)
            {
#line 198 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                var dyadicFractionNum = 0L;
#line hidden
                {
#line 202 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    var eignestateRegister = Allocate.Apply(bitsize);
#line 208 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    var eignestateRegisterLE = new Microsoft.Quantum.Canon.LittleEndian(eignestateRegister?.Copy());
#line 209 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    MicrosoftQuantumCanonInPlaceXorLE.Apply((1L, eignestateRegisterLE));
#line 213 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    var oracle = new Microsoft.Quantum.Canon.DiscreteOracle(OrderFindingOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,Int64,Int64,QArray<Qubit>)>((_arg1) => (generator, modulus, _arg1.Item1, _arg1.Item2))));
#line 217 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    if (useRobustPhaseEstimation)
                    {
#line 222 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                        var phase = MicrosoftQuantumCanonRobustPhaseEstimation.Apply((bitsPrecision, oracle, eignestateRegisterLE.Data));
#line 227 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                        dyadicFractionNum = MicrosoftQuantumExtensionsMathRound.Apply((((phase * MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(bitsPrecision))) / 2D) / MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)));
                    }
                    else
                    {
#line hidden
                        {
#line 234 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                            var dyadicFractionNumerator = Allocate.Apply(bitsPrecision);
#line 240 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                            var dyadicFractionNumeratorBE = new Microsoft.Quantum.Canon.BigEndian(dyadicFractionNumerator?.Copy());
#line 241 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                            MicrosoftQuantumCanonQuantumPhaseEstimation.Apply((oracle, eignestateRegisterLE.Data, dyadicFractionNumeratorBE));
#line 246 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                            dyadicFractionNum = MicrosoftQuantumCanonMeasureIntegerBE.Apply(dyadicFractionNumeratorBE);
#line hidden
                            Release.Apply(dyadicFractionNumerator);
                        }
                    }

#line 252 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    ResetAll.Apply(eignestateRegister?.Copy());
#line hidden
                    Release.Apply(eignestateRegister);
                }

#line 257 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                if ((dyadicFractionNum == 0L))
                {
#line 258 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    throw new ExecutionFailException("We measured 0 for the numerator");
                }

#line 263 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                Message.Apply(String.Format("Estimated eigenvalue is {0}/2^{1}.", dyadicFractionNum, bitsPrecision));
#line 267 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                var (numerator,period) = MicrosoftQuantumCanonContinuedFractionConvergent.Apply((new Microsoft.Quantum.Canon.Fraction((dyadicFractionNum, 2L.Pow(bitsPrecision))), modulus)).Data;
#line 272 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                var (numeratorAbs,periodAbs) = (MicrosoftQuantumExtensionsMathAbsI.Apply(numerator), MicrosoftQuantumExtensionsMathAbsI.Apply(period));
#line 276 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                Message.Apply((String.Format("Estimated divisor of period is {0}, ", periodAbs) + String.Format(" we have projected on eigenstate marked by {0}.", numeratorAbs)));
#line 280 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                result = ((periodAbs * result) / MicrosoftQuantumCanonGCD.Apply((result, periodAbs)));
                if ((MicrosoftQuantumCanonExpMod.Apply((generator, result, modulus)) == 1L))
                {
                    break;
                }
                else
                {
#line 290 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
                    Message.Apply(("It looks like the period has divisors and we have " + "found only a divisor of the period. Trying again ..."));
                }
            }

#line 294 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/IntegerFactorization/Shor.qs"
            return result;
        }

        ;
        public override void Init()
        {
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
            this.OrderFindingOracle = this.Factory.Get<IUnitary<(Int64,Int64,Int64,QArray<Qubit>)>>(typeof(OrderFindingOracle));
        }

        public override IApplyData __dataIn((Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 generator, Int64 modulus, Boolean useRobustPhaseEstimation)
        {
            return __m__.Run<EstimatePeriod, (Int64,Int64,Boolean), Int64>((generator, modulus, useRobustPhaseEstimation));
        }
    }
}