#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":22,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T11_StateFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T11_StateFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T12_BasisChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T12_BasisChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T13_SignFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T13_SignFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T14_AmplitudeChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T14_AmplitudeChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T15_PhaseFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T15_PhaseFlip_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T16_PhaseChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T16_PhaseChange_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":81,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"VerifyBellStateConversion\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startState\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"VerifyBellStateConversion\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T17_BellStateChange1_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T17_BellStateChange1_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T18_BellStateChange2_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":125,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T18_BellStateChange2_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":125,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T19_BellStateChange3_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T19_BellStateChange3_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":138,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":140,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":144,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T21_TwoQubitGate1_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":149,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T21_TwoQubitGate1_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":149,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":178,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":182,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T22_TwoQubitGate2_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":187,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T22_TwoQubitGate2_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":187,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":206,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":208,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":212,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T23_TwoQubitGate3_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":216,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T23_TwoQubitGate3_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":216,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T24_ToffoliGate_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":223,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T24_ToffoliGate_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":223,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T25_FredkinGate_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T25_FredkinGate_Test\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter8/BasicGates/Tests.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.BasicGates
{
    public class ArrayWrapperOperation : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public ArrayWrapperOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ArrayWrapperOperation";
        String ICallable.FullName => "Quantum.Kata.BasicGates.ArrayWrapperOperation";
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,qs) = __in;
#line 24 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,qs) = __in;
#line 28 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            op.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> qs)
        {
            return __m__.Run<ArrayWrapperOperation, (IAdjointable,QArray<Qubit>), QVoid>((op, qs));
        }
    }

    public class T11_StateFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_StateFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_StateFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T11_StateFlip_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> StateFlip
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> StateFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 35 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (StateFlip, _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg2) => (StateFlip_Reference, _arg2))), 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.StateFlip = this.Factory.Get<IAdjointable<Qubit>>(typeof(StateFlip));
            this.StateFlip_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(StateFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_StateFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T12_BasisChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_BasisChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_BasisChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T12_BasisChange_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> BasisChange
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> BasisChange_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 41 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (BasisChange, _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg2) => (BasisChange_Reference, _arg2))), 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.BasisChange = this.Factory.Get<IAdjointable<Qubit>>(typeof(BasisChange));
            this.BasisChange_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(BasisChange_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_BasisChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T13_SignFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_SignFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_SignFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T13_SignFlip_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> SignFlip
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> SignFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 47 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (SignFlip, _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg2) => (SignFlip_Reference, _arg2))), 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.SignFlip = this.Factory.Get<IAdjointable<Qubit>>(typeof(SignFlip));
            this.SignFlip_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(SignFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_SignFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T14_AmplitudeChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_AmplitudeChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_AmplitudeChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T14_AmplitudeChange_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Double)> AmplitudeChange
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Double)> AmplitudeChange_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 53 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            foreach (var i in new Range(0L, 36L))
#line hidden
            {
#line 54 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                var alpha = (((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumExtensionsConvertToDouble.Apply(i)) / 36D);
#line 55 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (AmplitudeChange.Partial(new Func<Qubit, (Qubit,Double)>((_arg2) => (_arg2, alpha))), _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg3) => (AmplitudeChange_Reference.Partial(new Func<Qubit, (Qubit,Double)>((_arg4) => (_arg4, alpha))), _arg3))), 1L));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.AmplitudeChange = this.Factory.Get<IAdjointable<(Qubit,Double)>>(typeof(AmplitudeChange));
            this.AmplitudeChange_Reference = this.Factory.Get<IAdjointable<(Qubit,Double)>>(typeof(AmplitudeChange_Reference));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_AmplitudeChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T15_PhaseFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T15_PhaseFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T15_PhaseFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T15_PhaseFlip_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PhaseFlip
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PhaseFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 62 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (PhaseFlip, _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg2) => (PhaseFlip_Reference, _arg2))), 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.PhaseFlip = this.Factory.Get<IAdjointable<Qubit>>(typeof(PhaseFlip));
            this.PhaseFlip_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PhaseFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T15_PhaseFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T16_PhaseChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T16_PhaseChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T16_PhaseChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T16_PhaseChange_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Double)> PhaseChange
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Double)> PhaseChange_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 68 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            foreach (var i in new Range(0L, 36L))
#line hidden
            {
#line 69 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                var alpha = (((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumExtensionsConvertToDouble.Apply(i)) / 36D);
#line 70 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg1) => (PhaseChange.Partial(new Func<Qubit, (Qubit,Double)>((_arg2) => (_arg2, alpha))), _arg1))), ArrayWrapperOperation.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((_arg3) => (PhaseChange_Reference.Partial(new Func<Qubit, (Qubit,Double)>((_arg4) => (_arg4, alpha))), _arg3))), 1L));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.PhaseChange = this.Factory.Get<IAdjointable<(Qubit,Double)>>(typeof(PhaseChange));
            this.PhaseChange_Reference = this.Factory.Get<IAdjointable<(Qubit,Double)>>(typeof(PhaseChange_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T16_PhaseChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class StatePrep_BellState : Adjointable<(QArray<Qubit>,Int64)>, ICallable
    {
        public StatePrep_BellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_BellState";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_BellState";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qs,state) = __in;
#line 83 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 84 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line 87 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            if (((state % 2L) == 1L))
            {
#line 89 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qs[1L]);
            }

#line 92 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            if (((state / 2L) == 1L))
            {
#line 93 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (qs,state) = __in;
#line hidden
            if (((state / 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[1L]);
            }

#line hidden
            if (((state % 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveZ.Adjoint.Apply(qs[1L]);
            }

#line hidden
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((qs[0L], qs[1L]));
#line hidden
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_BellState, (QArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public class VerifyBellStateConversion : Operation<(ICallable,Int64,Int64), QVoid>, ICallable
    {
        public VerifyBellStateConversion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64,Int64)>, IApplyData
        {
            public In((ICallable,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "VerifyBellStateConversion";
        String ICallable.FullName => "Quantum.Kata.BasicGates.VerifyBellStateConversion";
        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
        {
            get;
            set;
        }

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

        protected IAdjointable<(QArray<Qubit>,Int64)> StatePrep_BellState
        {
            get;
            set;
        }

        public override Func<(ICallable,Int64,Int64), QVoid> Body => (__in) =>
        {
            var (testOp,startState,targetState) = __in;
#line hidden
            {
#line 103 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                var qs = Allocate.Apply(2L);
#line 105 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                StatePrep_BellState.Apply((qs?.Copy(), startState));
#line 108 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                testOp.Apply(qs?.Copy());
#line 111 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                StatePrep_BellState.Adjoint.Apply((qs?.Copy(), targetState));
#line 114 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(qs?.Copy());
#line hidden
                Release.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.StatePrep_BellState = this.Factory.Get<IAdjointable<(QArray<Qubit>,Int64)>>(typeof(StatePrep_BellState));
        }

        public override IApplyData __dataIn((ICallable,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable testOp, Int64 startState, Int64 targetState)
        {
            return __m__.Run<VerifyBellStateConversion, (ICallable,Int64,Int64), QVoid>((testOp, startState, targetState));
        }
    }

    public class T17_BellStateChange1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T17_BellStateChange1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T17_BellStateChange1_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T17_BellStateChange1_Test";
        protected IAdjointable<QArray<Qubit>> BellStateChange1
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 121 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange1, 0L, 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange1 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(BellStateChange1));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(ICallable,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T17_BellStateChange1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T18_BellStateChange2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T18_BellStateChange2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T18_BellStateChange2_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T18_BellStateChange2_Test";
        protected IAdjointable<QArray<Qubit>> BellStateChange2
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 127 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange2, 0L, 2L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange2 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(BellStateChange2));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(ICallable,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T18_BellStateChange2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T19_BellStateChange3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T19_BellStateChange3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T19_BellStateChange3_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T19_BellStateChange3_Test";
        protected IAdjointable<QArray<Qubit>> BellStateChange3
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 133 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange3, 0L, 3L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange3 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(BellStateChange3));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(ICallable,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T19_BellStateChange3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class StatePrep_A : Adjointable<(Double,Qubit)>, ICallable
    {
        public StatePrep_A(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Qubit)>, IApplyData
        {
            public In((Double,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "StatePrep_A";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_A";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Double,Qubit), QVoid> Body => (__in) =>
        {
            var (alpha,q) = __in;
#line 142 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (alpha,q) = __in;
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

        public override IApplyData __dataIn((Double,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double alpha, Qubit q)
        {
            return __m__.Run<StatePrep_A, (Double,Qubit), QVoid>((alpha, q));
        }
    }

    public class T21_TwoQubitGate1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_TwoQubitGate1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_TwoQubitGate1_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T21_TwoQubitGate1_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
        {
            get;
            set;
        }

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

        protected IAdjointable<(Double,Qubit)> StatePrep_A
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate1
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate1_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 154 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                var qs = Allocate.Apply(2L);
#line 155 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                foreach (var i in new Range(0L, 36L))
#line hidden
                {
#line 156 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    var alpha = (((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumExtensionsConvertToDouble.Apply(i)) / 36D);
#line 159 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    StatePrep_A.Apply((alpha, qs[0L]));
#line 162 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    TwoQubitGate1.Apply(qs?.Copy());
#line 165 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    TwoQubitGate1_Reference.Adjoint.Apply(qs?.Copy());
#line 166 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    StatePrep_A.Adjoint.Apply((alpha, qs[0L]));
#line 169 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                    MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(qs?.Copy());
                }

#line hidden
                Release.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.StatePrep_A = this.Factory.Get<IAdjointable<(Double,Qubit)>>(typeof(StatePrep_A));
            this.TwoQubitGate1 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate1));
            this.TwoQubitGate1_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate1_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_TwoQubitGate1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class StatePrep_PlusPlus : Adjointable<QArray<Qubit>>, ICallable
    {
        public StatePrep_PlusPlus(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePrep_PlusPlus";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_PlusPlus";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 180 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, qs?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, qs?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<StatePrep_PlusPlus, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class T22_TwoQubitGate2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_TwoQubitGate2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_TwoQubitGate2_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T22_TwoQubitGate2_Test";
        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
        {
            get;
            set;
        }

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

        protected IAdjointable<QArray<Qubit>> StatePrep_PlusPlus
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate2
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate2_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 189 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                var qs = Allocate.Apply(2L);
#line 191 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                StatePrep_PlusPlus.Apply(qs?.Copy());
#line 194 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                TwoQubitGate2.Apply(qs?.Copy());
#line 197 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                TwoQubitGate2_Reference.Adjoint.Apply(qs?.Copy());
#line 198 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                StatePrep_PlusPlus.Adjoint.Apply(qs?.Copy());
#line 201 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(qs?.Copy());
#line hidden
                Release.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.StatePrep_PlusPlus = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(StatePrep_PlusPlus));
            this.TwoQubitGate2 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate2));
            this.TwoQubitGate2_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate2_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_TwoQubitGate2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SwapWrapper : Adjointable<QArray<Qubit>>, ICallable
    {
        public SwapWrapper(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SwapWrapper";
        String ICallable.FullName => "Quantum.Kata.BasicGates.SwapWrapper";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 210 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumPrimitiveSWAP.Apply((qs[0L], qs[1L]));
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
            return __m__.Run<SwapWrapper, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class T23_TwoQubitGate3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_TwoQubitGate3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_TwoQubitGate3_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T23_TwoQubitGate3_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> SwapWrapper
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate3
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> TwoQubitGate3_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 218 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((SwapWrapper, TwoQubitGate3_Reference, 2L));
#line 219 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((TwoQubitGate3, TwoQubitGate3_Reference, 2L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.SwapWrapper = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(SwapWrapper));
            this.TwoQubitGate3 = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate3));
            this.TwoQubitGate3_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(TwoQubitGate3_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_TwoQubitGate3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T24_ToffoliGate_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T24_ToffoliGate_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T24_ToffoliGate_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T24_ToffoliGate_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> ToffoliGate
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> ToffoliGate_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 225 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((ToffoliGate, ToffoliGate_Reference, 3L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.ToffoliGate = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(ToffoliGate));
            this.ToffoliGate_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(ToffoliGate_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T24_ToffoliGate_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class T25_FredkinGate_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T25_FredkinGate_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T25_FredkinGate_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T25_FredkinGate_Test";
        protected ICallable<(ICallable,IAdjointable,Int64), QVoid> MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> FredkinGate
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> FredkinGate_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 231 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter8/BasicGates/Tests.qs"
            MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced.Apply((FredkinGate, FredkinGate_Reference, 3L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(ICallable,IAdjointable,Int64), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertOperationsEqualReferenced));
            this.FredkinGate = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(FredkinGate));
            this.FredkinGate_Reference = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(FredkinGate_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T25_FredkinGate_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}