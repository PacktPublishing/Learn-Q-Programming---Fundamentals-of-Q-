#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":68,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a qubit to use to store a mark bit and a register corresponding\",\" to a database, marks the first qubit conditioned on the register\",\" state being the all-ones state |11…1〉.\",\"\",\" # Input\",\" ## markedQubit\",\" A qubit to be targeted by an `X` operation controlled on whether\",\" the state of `databaseRegister` corresponds to a market item.\",\" ## databaseRegister\",\" A register representing the target of a query to the database.\",\"\",\" # Remarks\",\" Implements the operation\",\"\",\"     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,\",\"\",\" where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and\",\" 0 otherwise.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":70,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":77,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" a uniform superposition over all computational basis states.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":108,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"UniformSuperpositionOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":116,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" the start state |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicats whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":149,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparationOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":154,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":173,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection `RM` about the marked state.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectMarked\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":173,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":186,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection about the |00…0〉 state.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectZero\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":186,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Reflection `RS` about the start state DU|0〉|0〉.\",\"\",\" # Input\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectStart\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":244,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Prepares the start state and boosts the amplitude of the marked\",\" subspace by a sequence of reflections about the marked state and the\",\" start state.\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"QuantumSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":244,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":274,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and returns an index\",\" to the found element in binary format. Finds the marked element with\",\" probability sin²((2*nIterations+1) sin⁻¹(1/√N)).\",\"\",\" # Input\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyQuantumSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":274,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparationOracleTest\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":325,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Checks whether state preparation marks the right fraction of elements\",\" against theoretical predictions.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"StatePreparationOracleTest\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":325,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverHardCodedTest\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":359,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked element and checks whether\",\" the success probability matches theoretical predictions. Then checks\",\" whether the correct index is found, post-selected on success.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverHardCodedTest\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":359,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":443,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Database oracle `D` constructed from classical database.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements the oracle D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉 used in the Grover\",\" search algorithm. Given a database with N = 2^n elements, n is the\",\" size of the database qubit register. Let x = x₀x₁...x_{N-1} be a\",\" binary string of N elements. Then xₖ is 1 if k is in \\\"markedElements\\\"\",\" and 0 otherwise.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":445,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":457,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":458,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":459,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":485,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Preparation of start state from database oracle and oracle `U` that\",\" creates a uniform superposition over database indices.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\" ## startQubits\",\" The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`\",\" initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements an oracle `DU` that prepares the start state\",\" DU|0〉|0〉 = √(M/N)|1〉|marked〉 + √(1-(M/N)^2)|0〉|unmarked〉 where\",\" `M` is the length of `markedElements`, and\",\" `N` is 2^n, where `n` is the number of database qubits.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":487,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":498,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":499,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":500,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":516,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"StateOracle\"}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" `StateOracle` type for the preparation of a start state that has a\",\" marked qubit entangled with some desired state in the database\",\" register.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\"\",\" # Output\",\" A `StateOracle` type with signature\",\" ((Int, Qubit[]) => (): Adjoint, Controlled).\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":516,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":542,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Grover's search algorithm using library functions.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of iterations of the Grover iteration to apply.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\"\",\" # Output\",\" Unitary implementing Grover's search algorithm.\",\"\",\" # Remarks\",\" On input |0〉|0〉, this prepares the state |1〉|marked〉 with amplitude\",\" Sin((2*nIterations + 1) ArcSin(Sqrt(M/N))).\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":542,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":565,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked elements and returns an index\",\" to the found element in integer format.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register converted to an integer.\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs\",\"Position\":{\"Item1\":565,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Samples.DatabaseSearch
{
    public class DatabaseOracle : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracle";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line 75 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((databaseRegister?.Copy(), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((databaseRegister?.Copy(), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracle, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class UniformSuperpositionOracle : Adjointable<QArray<Qubit>>, ICallable
    {
        public UniformSuperpositionOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UniformSuperpositionOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.UniformSuperpositionOracle";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var databaseRegister = __in;
#line 110 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var nQubits = databaseRegister.Length;
#line 112 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 113 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveH.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var databaseRegister = __in;
#line hidden
            var nQubits = databaseRegister.Length;
#line hidden
            foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<UniformSuperpositionOracle, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class StatePreparationOracle : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public StatePreparationOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "StatePreparationOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracle";
        protected IAdjointable<(Qubit,QArray<Qubit>)> DatabaseOracle
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> UniformSuperpositionOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line 151 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            UniformSuperpositionOracle.Apply(databaseRegister?.Copy());
#line 152 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            DatabaseOracle.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line hidden
            DatabaseOracle.Adjoint.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            UniformSuperpositionOracle.Adjoint.Apply(databaseRegister?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DatabaseOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(DatabaseOracle));
            this.UniformSuperpositionOracle = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(UniformSuperpositionOracle));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<StatePreparationOracle, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class ReflectMarked : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectMarked";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectMarked";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var markedQubit = __in;
#line 177 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveR1.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectMarked, Qubit, QVoid>(markedQubit);
        }
    }

    public class ReflectZero : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ReflectZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectZero";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectZero";
        protected ICallable Length
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

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var databaseRegister = __in;
#line 189 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var nQubits = databaseRegister.Length;
#line 191 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 192 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxQubit]);
            }

#line 195 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((databaseRegister?.Slice(new Range(1L, (nQubits - 1L))), databaseRegister[0L]));
#line 197 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 198 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectZero, QArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    public class ReflectStart : Operation<(Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public ReflectStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ReflectStart";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectStart";
        protected ICallable<QArray<Qubit>, QVoid> ReflectZero
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedQubit,databaseRegister) = __in;
#line 213 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Adjoint.Apply((markedQubit, databaseRegister?.Copy()));
#line 214 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            ReflectZero.Apply((new QArray<Qubit>()
            {markedQubit} + databaseRegister));
#line 215 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectZero = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(ReflectZero));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<ReflectStart, (Qubit,QArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    public class QuantumSearch : Operation<(Int64,Qubit,QArray<Qubit>), QVoid>, ICallable
    {
        public QuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.QuantumSearch";
        protected ICallable<Qubit, QVoid> ReflectMarked
        {
            get;
            set;
        }

        protected ICallable<(Qubit,QArray<Qubit>), QVoid> ReflectStart
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (nIterations,markedQubit,databaseRegister) = __in;
#line 247 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            StatePreparationOracle.Apply((markedQubit, databaseRegister?.Copy()));
#line 250 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idx in new Range(0L, (nIterations - 1L)))
#line hidden
            {
#line 251 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                ReflectMarked.Apply(markedQubit);
#line 252 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                ReflectStart.Apply((markedQubit, databaseRegister?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ReflectMarked = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(ReflectMarked));
            this.ReflectStart = this.Factory.Get<ICallable<(Qubit,QArray<Qubit>), QVoid>>(typeof(ReflectStart));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn((Int64,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nIterations, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<QuantumSearch, (Int64,Qubit,QArray<Qubit>), QVoid>((nIterations, markedQubit, databaseRegister));
        }
    }

    public class ApplyQuantumSearch : Operation<(Int64,Int64), (Result,QArray<Result>)>, ICallable
    {
        public ApplyQuantumSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,QArray<Result>)>, IApplyData
        {
            public Out((Result,QArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyQuantumSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyQuantumSearch";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(Int64,Qubit,QArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Result,QArray<Result>)> Body => (__in) =>
        {
            var (nIterations,nDatabaseQubits) = __in;
#line 278 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 279 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var resultElement = new QArray<Result>(nDatabaseQubits);
#line hidden
            {
#line 283 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 286 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var markedQubit = qubits[0L];
#line 289 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 292 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                QuantumSearch.Apply((nIterations, markedQubit, databaseRegister?.Copy()));
#line 295 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                resultSuccess = M.Apply(markedQubit);
#line 299 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 303 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                if ((resultSuccess == Result.One))
                {
#line 304 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    MicrosoftQuantumPrimitiveX.Apply(markedQubit);
                }

#line 307 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                {
#line 309 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    if ((resultElement[idxResult] == Result.One))
                    {
#line 310 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        MicrosoftQuantumPrimitiveX.Apply(databaseRegister[idxResult]);
                    }
                }

#line hidden
                Release.Apply(qubits);
            }

#line 316 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            return (resultSuccess, resultElement?.Copy());
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,QArray<Qubit>), QVoid>>(typeof(QuantumSearch));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,QArray<Result>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,QArray<Result>)> Run(IOperationFactory __m__, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyQuantumSearch, (Int64,Int64), (Result,QArray<Result>)>((nIterations, nDatabaseQubits));
        }
    }

    public class StatePreparationOracleTest : Operation<QVoid, QVoid>, ICallable
    {
        public StatePreparationOracleTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePreparationOracleTest";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.StatePreparationOracleTest";
        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
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

        protected IAdjointable<(Qubit,QArray<Qubit>)> StatePreparationOracle
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 328 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var nDatabaseQubits in new Range(0L, 5L))
#line hidden
            {
#line hidden
                {
#line 330 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 331 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    var markedQubit = qubits[0L];
#line 332 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 333 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    StatePreparationOracle.Apply((markedQubit, databaseRegister?.Copy()));
#line 339 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    var successAmplitude = (1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(nDatabaseQubits))));
#line 340 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    var successProbability = (successAmplitude * successAmplitude);
#line 341 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {markedQubit}, Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
#line 345 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                    ResetAll.Apply(qubits?.Copy());
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.StatePreparationOracle = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(StatePreparationOracle));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<StatePreparationOracleTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class GroverHardCodedTest : Operation<QVoid, QVoid>, ICallable
    {
        public GroverHardCodedTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverHardCodedTest";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverHardCodedTest";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
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

        protected ICallable<(Int64,Qubit,QArray<Qubit>), QVoid> QuantumSearch
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 362 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var nDatabaseQubits in new Range(0L, 4L))
#line hidden
            {
#line 364 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                foreach (var nIterations in new Range(0L, 5L))
#line hidden
                {
#line hidden
                    {
#line 366 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 367 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        ResetAll.Apply(qubits?.Copy());
#line 368 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var markedQubit = qubits[0L];
#line 369 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 370 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        QuantumSearch.Apply((nIterations, markedQubit, databaseRegister?.Copy()));
#line 371 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var successAmplitude = MicrosoftQuantumExtensionsMathSin.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(((2L * nIterations) + 1L)) * MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(nDatabaseQubits)))))));
#line 372 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var successProbability = (successAmplitude * successAmplitude);
#line 373 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        AssertProb.Apply((new QArray<Pauli>()
                        {Pauli.PauliZ}, new QArray<Qubit>()
                        {markedQubit}, Result.One, successProbability, "Error: Success probability does not match theory", 1E-10D));
#line 377 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        var result = M.Apply(markedQubit);
#line 379 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        if ((result == Result.One))
                        {
#line 380 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                            var results = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 384 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                            foreach (var idxResult in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                            {
#line 386 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                                if ((results[idxResult] == Result.Zero))
                                {
#line 387 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                                    throw new ExecutionFailException("Found state should be 1..1 string.");
                                }
                            }
                        }

#line 392 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                        ResetAll.Apply(qubits?.Copy());
#line hidden
                        Release.Apply(qubits);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.QuantumSearch = this.Factory.Get<ICallable<(Int64,Qubit,QArray<Qubit>), QVoid>>(typeof(QuantumSearch));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GroverHardCodedTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class DatabaseOracleFromInts : Unitary<(QArray<Int64>,Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracleFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracleFromInts";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.DatabaseOracleFromInts";
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
#line 447 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var nMarked = markedElements.Length;
#line 449 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 454 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
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
            return __m__.Run<DatabaseOracleFromInts, (QArray<Int64>,Qubit,QArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class GroverStatePrepOracleImpl : Unitary<(QArray<Int64>,Int64,QArray<Qubit>)>, ICallable
    {
        public GroverStatePrepOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GroverStatePrepOracleImpl";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracleImpl";
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

        protected IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)> DatabaseOracleFromInts
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in;
#line 489 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 490 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line 493 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line 496 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            DatabaseOracleFromInts.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
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
            DatabaseOracleFromInts.Adjoint.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
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
            DatabaseOracleFromInts.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
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
            DatabaseOracleFromInts.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.DatabaseOracleFromInts = this.Factory.Get<IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)>>(typeof(DatabaseOracleFromInts));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 idxMarkedQubit, QArray<Qubit> startQubits)
        {
            return __m__.Run<GroverStatePrepOracleImpl, (QArray<Int64>,Int64,QArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public class GroverStatePrepOracle : Function<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>, ICallable
    {
        public GroverStatePrepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverStatePrepOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverStatePrepOracle";
        protected IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)> GroverStatePrepOracleImpl
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> Body => (__in) =>
        {
            var markedElements = __in;
#line 519 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            return new Microsoft.Quantum.Canon.StateOracle(GroverStatePrepOracleImpl.Partial(new Func<(Int64,QArray<Qubit>), (QArray<Int64>,Int64,QArray<Qubit>)>((_arg1) => (markedElements?.Copy(), _arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracleImpl = this.Factory.Get<IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)>>(typeof(GroverStatePrepOracleImpl));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.StateOracle data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.StateOracle> Run(IOperationFactory __m__, QArray<Int64> markedElements)
        {
            return __m__.Run<GroverStatePrepOracle, QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>(markedElements);
        }
    }

    public class GroverSearch : Function<(QArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public GroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GroverSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.GroverSearch";
        protected ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> GroverStatePrepOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), IUnitary> Body => (__in) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in;
#line 545 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            return MicrosoftQuantumCanonAmpAmpByOracle.Apply((nIterations, GroverStatePrepOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
            this.GroverStatePrepOracle = this.Factory.Get<ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>>(typeof(GroverStatePrepOracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<GroverSearch, (QArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public class ApplyGroverSearch : Operation<(QArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
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

        String ICallable.Name => "ApplyGroverSearch";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyGroverSearch";
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

        protected ICallable<(QArray<Int64>,Int64,Int64), IUnitary> GroverSearch
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in;
#line 569 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var resultSuccess = Result.Zero;
#line 570 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            var numberElement = 0L;
#line hidden
            {
#line 574 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line 577 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var markedQubit = qubits[0L];
#line 580 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 583 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                GroverSearch.Apply((markedElements?.Copy(), nIterations, 0L)).Apply(qubits?.Copy());
#line 586 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                resultSuccess = M.Apply(markedQubit);
#line 590 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                var resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 591 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                numberElement = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply(resultElement);
#line 595 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 599 "/Users/bhagvan.kommadi/Desktop/packt/Q#/Quantum/Samples/src/DatabaseSearch/DatabaseSearch.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonPositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GroverSearch = this.Factory.Get<ICallable<(QArray<Int64>,Int64,Int64), IUnitary>>(typeof(GroverSearch));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (QArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}