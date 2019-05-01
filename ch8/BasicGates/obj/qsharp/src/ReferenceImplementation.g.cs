#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":58,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":76,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":80,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":89,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":94,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":108,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":112,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":121,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":126,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":135,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":140,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":149,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":153,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":169,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":171,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":175,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":185,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":187,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":191,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":199,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":201,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":209,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":221,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":226,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":236,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":238,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate_Reference\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs\",\"Position\":{\"Item1\":242,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.BasicGates
{
    public class StateFlip_Reference : Adjointable<Qubit>, ICallable
    {
        public StateFlip_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StateFlip_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StateFlip_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line 30 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveX.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<StateFlip_Reference, Qubit, QVoid>(q);
        }
    }

    public class BasisChange_Reference : Adjointable<Qubit>, ICallable
    {
        public BasisChange_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BasisChange_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BasisChange_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line 47 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveH.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<BasisChange_Reference, Qubit, QVoid>(q);
        }
    }

    public class SignFlip_Reference : Adjointable<Qubit>, ICallable
    {
        public SignFlip_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SignFlip_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.SignFlip_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line 60 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveZ.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<SignFlip_Reference, Qubit, QVoid>(q);
        }
    }

    public class AmplitudeChange_Reference : Adjointable<(Qubit,Double)>, ICallable
    {
        public AmplitudeChange_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "AmplitudeChange_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.AmplitudeChange_Reference";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Qubit,Double), QVoid> Body => (__in) =>
        {
            var (q,alpha) = __in;
#line 78 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            MicrosoftQuantumPrimitiveRy.Adjoint.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<AmplitudeChange_Reference, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class PhaseFlip_Reference : Adjointable<Qubit>, ICallable
    {
        public PhaseFlip_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseFlip_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.PhaseFlip_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line 91 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveS.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in) =>
        {
            var q = __in;
#line hidden
            MicrosoftQuantumPrimitiveS.Adjoint.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<PhaseFlip_Reference, Qubit, QVoid>(q);
        }
    }

    public class PhaseChange_Reference : Adjointable<(Qubit,Double)>, ICallable
    {
        public PhaseChange_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "PhaseChange_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.PhaseChange_Reference";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(Qubit,Double), QVoid> Body => (__in) =>
        {
            var (q,alpha) = __in;
#line 110 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveRz.Apply((alpha, q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply((alpha, q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<PhaseChange_Reference, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class BellStateChange1_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange1_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange1_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange1_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 123 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveZ.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            MicrosoftQuantumPrimitiveZ.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange1_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange2_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange2_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange2_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange2_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 137 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange2_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange3_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange3_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange3_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange3_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 151 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveY.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            MicrosoftQuantumPrimitiveY.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange3_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate1_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate1_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate1_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate1_Reference";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 173 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate1_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate2_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate2_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate2_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate2_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 189 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
            {qs[0L]}, qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate2_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate3_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate3_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate3_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate3_Reference";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 205 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line 206 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qs[1L], qs[0L]));
#line 207 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate3_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class ToffoliGate_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public ToffoliGate_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ToffoliGate_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.ToffoliGate_Reference";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 223 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((qs[0L], qs[1L], qs[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<ToffoliGate_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class FredkinGate_Reference : Adjointable<QArray<Qubit>>, ICallable
    {
        public FredkinGate_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FredkinGate_Reference";
        String ICallable.FullName => "Quantum.Kata.BasicGates.FredkinGate_Reference";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 240 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/ReferenceImplementation.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {qs[0L]}, (qs[1L], qs[2L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<FredkinGate_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }
}