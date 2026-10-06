
# Yousef-Ahmed-Henaish-Assignment3
Assignment repo for assignment/1-3 (Assignment3)

 =============================================== top - level statements ===============================================
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!")


 =============================================== File-Scoped namespace ===============================================
namespace Assigment3;



 <!-- ================ Program.cs, the role of: .csproj, Program.cs, obj/, and bin/  ================ -->

A: Program.cs: is the entry point to run code, that compiler start running from it .
    Rule: Compiler need to know the start point and we can write top level statements inside it.

B: .csproj: contain difinitions that detect , 
    1 - output type (.exe, dll, ...)
    2 - target framework: framework I use and the version
    3 - NuGets: implicit libraries that I can use it without calling
    4 - Nullable: make program allow Vullable types, and warning me about Null errors

C: obj: temporary place that compiler use it to build porgram, we need it restore uncompleted data inside it because compiler build the program on phases

D: bin: store the completed program to execute it or debug it after building ( have the final source code)


<!-- =============================================== .csproj Content =============================================== -->


 <!-- <Project Sdk = "Microsoft.NET.Sdk" 
  < PropertyGroup >
    < OutputType > Exe </ OutputType >
    < TargetFramework > net10.0</TargetFramework> 
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup
</Project> -->


=============================================== file-scoped namespace ===============================================
using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using Microsoft.VisualBasic;

 =============================================== namespace Assignment3; =============================================== 
 file-scoped namespace removes level of indentation beacuase before it we was put all namespace content inside {}
 so we was start writing the classed after one level ine level 1 Unlike now that we write class in level 0;


 =============================================== sln, slnx =============================================== 
    I use slnx.
    one of the advantages to slnx over sln is using xml instead of plain-text , git conflicts resolve, readability






# 2:

2. Do #region / #endregion change the compiled output? Why might you still use them?
Answer: No #refion / endregion don't change compile time, output, space. the compiler ignore it.
we can use it to orgnize my code to parts to make the screen clean. but the usage of it not wide.

3. When would you reach for /// XML doc comments instead of a plain //?
Anser: We use XML instead of plain comments to orgnize small documenation Header, Body. open the header to read then close it to make screen clean.