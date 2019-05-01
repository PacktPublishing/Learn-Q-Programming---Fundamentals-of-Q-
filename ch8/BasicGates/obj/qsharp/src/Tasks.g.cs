#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StateFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BasisChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":71,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":80,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SignFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":84,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":98,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"AmplitudeChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":102,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":111,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseFlip\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":115,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":127,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":129,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"PhaseChange\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":133,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":142,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":146,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":155,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":159,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":166,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":168,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"BellStateChange3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":172,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":190,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate1\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":194,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":204,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":206,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate2\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":210,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":218,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":220,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"TwoQubitGate3\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":228,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":240,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ToffoliGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":244,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":253,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":255,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"FredkinGate\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tasks.qs\",\"Position\":{\"Item1\":259,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.BasicGates
{
    public class StateFlip : Adjointable<Qubit>, ICallable
    {
        public StateFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StateFlip";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StateFlip";
        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<StateFlip, Qubit, QVoid>(q);
        }
    }

    public class BasisChange : Adjointable<Qubit>, ICallable
    {
        public BasisChange(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BasisChange";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BasisChange";
        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<BasisChange, Qubit, QVoid>(q);
        }
    }

    public class SignFlip : Adjointable<Qubit>, ICallable
    {
        public SignFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SignFlip";
        String ICallable.FullName => "Quantum.Kata.BasicGates.SignFlip";
        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<SignFlip, Qubit, QVoid>(q);
        }
    }

    public class AmplitudeChange : Adjointable<(Qubit,Double)>, ICallable
    {
        public AmplitudeChange(IOperationFactory m) : base(m)
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

        String ICallable.Name => "AmplitudeChange";
        String ICallable.FullName => "Quantum.Kata.BasicGates.AmplitudeChange";
        public override Func<(Qubit,Double), QVoid> Body => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<AmplitudeChange, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class PhaseFlip : Adjointable<Qubit>, ICallable
    {
        public PhaseFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PhaseFlip";
        String ICallable.FullName => "Quantum.Kata.BasicGates.PhaseFlip";
        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var q = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in) =>
        {
            var q = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<PhaseFlip, Qubit, QVoid>(q);
        }
    }

    public class PhaseChange : Adjointable<(Qubit,Double)>, ICallable
    {
        public PhaseChange(IOperationFactory m) : base(m)
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

        String ICallable.Name => "PhaseChange";
        String ICallable.FullName => "Quantum.Kata.BasicGates.PhaseChange";
        public override Func<(Qubit,Double), QVoid> Body => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in) =>
        {
            var (q,alpha) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<PhaseChange, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public class BellStateChange1 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange1";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange1";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange1, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange2 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange2";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange2";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange2, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class BellStateChange3 : Adjointable<QArray<Qubit>>, ICallable
    {
        public BellStateChange3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellStateChange3";
        String ICallable.FullName => "Quantum.Kata.BasicGates.BellStateChange3";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<BellStateChange3, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate1 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate1";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate1";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate1, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate2 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate2";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate2";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate2, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class TwoQubitGate3 : Adjointable<QArray<Qubit>>, ICallable
    {
        public TwoQubitGate3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitGate3";
        String ICallable.FullName => "Quantum.Kata.BasicGates.TwoQubitGate3";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitGate3, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class ToffoliGate : Adjointable<QArray<Qubit>>, ICallable
    {
        public ToffoliGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ToffoliGate";
        String ICallable.FullName => "Quantum.Kata.BasicGates.ToffoliGate";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<ToffoliGate, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class FredkinGate : Adjointable<QArray<Qubit>>, ICallable
    {
        public FredkinGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FredkinGate";
        String ICallable.FullName => "Quantum.Kata.BasicGates.FredkinGate";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<FredkinGate, QArray<Qubit>, QVoid>(qs);
        }
    }
}