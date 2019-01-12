#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Hello\",\"Name\":\"GetProduct\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Hello/Hello.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Hello\",\"Name\":\"GetProduct\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Hello/Hello.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Hello\",\"Name\":\"CalculateProduct\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Hello/Hello.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Hello\",\"Name\":\"CalculateProduct\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Hello/Hello.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace Hello
{
    public class GetProduct : Operation<(Double,Double), Double>, ICallable
    {
        public GetProduct(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double)>, IApplyData
        {
            public In((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetProduct";
        String ICallable.FullName => "Hello.GetProduct";
        protected ICallable<(Double,Double), Double> CalculateProduct
        {
            get;
            set;
        }

        public override Func<(Double,Double), Double> Body => (__in) =>
        {
            var (x,y) = __in;
#line 8 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            var z = 0D;
#line 9 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            z = CalculateProduct.Apply((x, y));
#line 10 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            return z;
        }

        ;
        public override void Init()
        {
            this.CalculateProduct = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(CalculateProduct));
        }

        public override IApplyData __dataIn((Double,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double x, Double y)
        {
            return __m__.Run<GetProduct, (Double,Double), Double>((x, y));
        }
    }

    public class CalculateProduct : Function<(Double,Double), Double>, ICallable
    {
        public CalculateProduct(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double)>, IApplyData
        {
            public In((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CalculateProduct";
        String ICallable.FullName => "Hello.CalculateProduct";
        public override Func<(Double,Double), Double> Body => (__in) =>
        {
            var (x,y) = __in;
#line 14 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            var z = 0D;
#line 15 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            z = (x * y);
#line 16 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Hello/Hello.qs"
            return z;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Double,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double x, Double y)
        {
            return __m__.Run<CalculateProduct, (Double,Double), Double>((x, y));
        }
    }
}